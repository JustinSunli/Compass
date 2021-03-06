﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class LPZService : IModelService
    {
        public int EditModel(IModel model)
        {
            LPZ objModel = (LPZ)model;
            //编写带参数的SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("Update LPZ set Length=@Length,Width=@Width,ZPanelNo=@ZPanelNo where LPZId=@LPZId");
            //定义参数数组
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Length",objModel.Length),
                new SqlParameter("@Width",objModel.Width),
                new SqlParameter("@ZPanelNo",objModel.ZPanelNo),
                new SqlParameter("@LPZId",objModel.LPZId)
            };
            try
            {
                return SQLHelper.Update(sqlBuilder.ToString(), param);
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

        public DataSet GetModelByDataSet(string projectId)
        {
            string sql = "select LPZId,LPZ.ModuleTreeId,Item,Module,Length,Width,ZPanelNo from LPZ";
            sql += " inner join ModuleTree on LPZ.ModuleTreeId=ModuleTree.ModuleTreeId";
            sql += " inner join DrawingPlan on ModuleTree.DrawingPlanId=DrawingPlan.DrawingPlanId";
            sql += string.Format(" where ProjectId={0}", projectId);
            sql += " order by Item,Module";
            return SQLHelper.GetDataSet(sql);
        }

        public IModel GetModelById(string id)
        {
            return GetModelByWhereSql(string.Format(" where LPZId={0}", id));
        }

        public IModel GetModelByModuleTreeId(string moduleTreeId)
        {
            return GetModelByWhereSql(string.Format(" where ModuleTreeId={0}", moduleTreeId));
        }

        public IModel GetModelByWhereSql(string whereSql)
        {
            string sql =
                "select LPZId,ModuleTreeId,Length,Width,ZPanelNo from LPZ";
            sql += whereSql;
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            LPZ objModel = null;
            if (objReader.Read())
            {
                objModel = new LPZ()
                {
                    LPZId = Convert.ToInt32(objReader["LPZId"]),
                    ModuleTreeId = Convert.ToInt32(objReader["ModuleTreeId"]),
                    //最好不要用=null去判断，提示类型转换错误
                    Length = objReader["Length"].ToString().Length == 0 ? 0 : Convert.ToDecimal(objReader["Length"]),
                    Width = objReader["Width"].ToString().Length == 0 ? 0 : Convert.ToDecimal(objReader["Width"]),
                    ZPanelNo = objReader["ZPanelNo"].ToString().Length == 0 ? 0 : Convert.ToInt32(objReader["ZPanelNo"])

                };
            }
            objReader.Close();
            return objModel;
        }
    }
}
