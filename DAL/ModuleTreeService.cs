﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class ModuleTreeService
    {
        private CategoryService objCategoryService = new CategoryService();
        /// <summary>
        /// 根据项目Id返回烟罩分段合集
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public List<ModuleTree> GetModuleTreesByProjectId(string projectId)
        {
            return GetModuleTreesByWhereSql(string.Format(" where DrawingPlan.ProjectId={0}", projectId));
        }
        /// <summary>
        /// 根据单个条件返回烟罩分段合集
        /// </summary>
        /// <param name="whereSql"></param>
        /// <returns></returns>
        public List<ModuleTree> GetModuleTreesByWhereSql(string whereSql)
        {
            StringBuilder sql = new StringBuilder("select ModuleTreeId,ModuleTree.DrawingPlanId,ModuleTree.CategoryId,Module,DrawingPlan.ProjectId,ODPNo,CategoryName,Item,ModelPath from ModuleTree");
            sql.Append(" inner join DrawingPlan on DrawingPlan.DrawingPlanId=ModuleTree.DrawingPlanId");
            sql.Append(" inner join Categories on Categories.CategoryId=ModuleTree.CategoryId");
            sql.Append(" inner join Projects on DrawingPlan.ProjectId=Projects.ProjectId");
            sql.Append(whereSql);
            sql.Append(" order by Item asc,Module asc");
            SqlDataReader objReader = SQLHelper.GetReader(sql.ToString());
            List<ModuleTree> list = new List<ModuleTree>();
            while (objReader.Read())
            {
                list.Add(new ModuleTree()
                {
                    ModuleTreeId = Convert.ToInt32(objReader["ModuleTreeId"]),
                    DrawingPlanId = Convert.ToInt32(objReader["DrawingPlanId"]),
                    CategoryId = Convert.ToInt32(objReader["CategoryId"]),
                    Module = objReader["Module"].ToString(),
                    ProjectId = Convert.ToInt32(objReader["ProjectId"]),
                    ODPNo = objReader["ODPNo"].ToString(),
                    CategoryName = objReader["CategoryName"].ToString(),
                    Item = objReader["Item"].ToString(),
                    ModelPath = objReader["ModelPath"].ToString()
                });
            }
            objReader.Close();
            return list;
        }
        /// <summary>
        /// 根据Id返回单条moduleTree记录
        /// </summary>
        /// <param name="moduleTreeId"></param>
        /// <returns></returns>
        public ModuleTree GetModuleTreeById(string moduleTreeId)
        {
            string sql = "select ModuleTreeId,Module,ModuleTree.CategoryId,CategoryName,Model from ModuleTree";
            sql += " inner join Categories on Categories.CategoryId=ModuleTree.CategoryId";
            sql += string.Format(" where ModuleTreeId={0}", moduleTreeId);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            ModuleTree objModuleTree = null;
            while (objReader.Read())
            {
                objModuleTree = new ModuleTree()
                {
                    ModuleTreeId = Convert.ToInt32(objReader["ModuleTreeId"]),
                    CategoryId = Convert.ToInt32(objReader["CategoryId"]),
                    CategoryName = objReader["CategoryName"].ToString(),
                    Module = objReader["Module"].ToString(),
                    Model = objReader["Model"].ToString()
                };
            }
            objReader.Close();
            return objModuleTree;
        }
        /// <summary>
        /// 添加分段
        /// </summary>
        /// <param name="objModuleTree"></param>
        /// <returns></returns>
        public int AddModuleTree(ModuleTree objModuleTree)
        {
            string sql = "insert into ModuleTree(DrawingPlanId,CategoryId,Module)";
            sql += " values({0},{1},'{2}'); select @@identity";
            sql = string.Format(sql, objModuleTree.DrawingPlanId, objModuleTree.CategoryId, objModuleTree.Module);
            try
            {
                return Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    throw new Exception("烟罩分段重复，请认真检查");
                }
                else
                {
                    throw new Exception("添加烟罩分段时数据库访问异常");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 修改分段
        /// </summary>
        /// <param name="objModuleTree"></param>
        /// <returns></returns>
        public int EditModuleTree(ModuleTree objModuleTree)
        {
            string sql = "update ModuleTree set Module='{0}' where ModuleTreeId={1}";
            sql = string.Format(sql, objModuleTree.Module, objModuleTree.ModuleTreeId);
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (SqlException ex)
            {
                throw new Exception("数据库操作出现异常：" + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 删除分段
        /// </summary>
        /// <param name="moduleTreeId"></param>
        /// <returns></returns>
        public int DeleteModuleTree(string moduleTreeId)
        {
            string sql = "delete from ModuleTree where ModuleTreeId={0}";
            sql = string.Format(sql, moduleTreeId);
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    throw new Exception("该记录已被其他数据表关联，不能直接删除");
                }
                else
                {
                    throw new Exception("数据库操作异常，不能执行删除：" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 生成多条SQL语句添加分段和作图数据,先添加分段再添加数据
        /// </summary>
        /// <param name="objModuleTree"></param>
        /// <returns></returns>
        public bool AddModuleAndData(ModuleTree objModuleTree)
        {
            //编写SQL语句
            string sql = "insert into ModuleTree(DrawingPlanId,CategoryId,Module)";
            sql += " values({0},{1},'{2}'); select @@identity";
            sql = string.Format(sql, objModuleTree.DrawingPlanId, objModuleTree.CategoryId, objModuleTree.Module);
            List<string> sqlList = new List<string>();
            sqlList.Add(sql);
            Category objCategory = objCategoryService.GetCategoryByCategoryId(objModuleTree.CategoryId.ToString());
            string sqldata = "insert into " + objCategory.CategoryName + " (ModuleTreeId) values(@@IDENTITY)";
            sqlList.Add(sqldata);
            //将sql语句提交到数据库
            return SQLHelper.UpdateByTransaction(sqlList);
        }
        /// <summary>
        /// 生成多条SQL语句删除分段和作图数据,先删除数据后删除分段
        /// </summary>
        /// <param name="objModuleTree"></param>
        /// <returns></returns>
        public bool DeleteModuleAndData(ModuleTree objModuleTree)
        {
            //编写SQL语句
            List<string> sqlList = new List<string>();
            Category objCategory = objCategoryService.GetCategoryByCategoryId(objModuleTree.CategoryId.ToString());
            string sqldata = string.Format("delete from " + objCategory.CategoryName + " where ModuleTreeId={0}", objModuleTree.ModuleTreeId);
            sqlList.Add(sqldata);
            string sql = string.Format("delete from ModuleTree where ModuleTreeId={0}", objModuleTree.ModuleTreeId);
            sqlList.Add(sql);
            return SQLHelper.UpdateByTransaction(sqlList);
        }
    }
}
