﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class DrawingService
    {
        /// <summary>
        /// 根据项目Id返回图纸集合
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public List<Drawing> GetDrawingsByProjectId(string projectId)
        {
            return GetDrawingsByWhereSql(string.Format(" where DrawingPlan.ProjectId = {0}", projectId));
        }
        /// <summary>
        /// 根据项目号返回图纸集合
        /// </summary>
        /// <param name="odpNo"></param>
        /// <returns></returns>
        public List<Drawing> GetDrawingsByODPNo(string odpNo)
        {
            return GetDrawingsByWhereSql(string.Format(" where ODPNo = '{0}'", odpNo));
        }
        /// <summary>
        /// 根据条件返回图纸集合
        /// </summary>
        /// <param name="whereSql"></param>
        /// <returns></returns>
        public List<Drawing> GetDrawingsByWhereSql(string whereSql)
        {
            string sql = "select DrawingPlanId,DrawingPlan.ProjectId,ODPNo,Item,LabelImage,ModuleNo,ProjectName,HoodType from DrawingPlan";
            sql += " inner join Projects on Projects.ProjectId=DrawingPlan.ProjectId";
            sql += whereSql;
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Drawing> list = new List<Drawing>();
            while (objReader.Read())
            {
                list.Add(new Drawing()
                {
                    DrawingPlanId = Convert.ToInt32(objReader["DrawingPlanId"]),
                    ProjectId = Convert.ToInt32(objReader["ProjectId"]),
                    ODPNo = objReader["ODPNo"].ToString(),
                    Item = objReader["Item"].ToString(),
                    LabelImage = objReader["LabelImage"].ToString(),
                    ModuleNo = Convert.ToInt32(objReader["ModuleNo"]),
                    ProjectName = objReader["ProjectName"].ToString(),
                    HoodType=objReader["HoodType"].ToString()
                });
            }
            objReader.Close();
            return list;
        }
        /// <summary>
        /// 根据图纸计划id返回单张图纸
        /// </summary>
        /// <param name="drawingPlanId"></param>
        /// <returns></returns>
        public Drawing GetDrawingById(string drawingPlanId)
        {
            return GetDrawingByWhereSql(string.Format(" where DrawingPlanId={0}", drawingPlanId));
        }
        /// <summary>
        /// 根据条件返回单张图纸
        /// </summary>
        /// <param name="whereSql"></param>
        /// <returns></returns>
        public Drawing GetDrawingByWhereSql(string whereSql)
        {
            string sql = "select DrawingPlanId,DrawingPlan.ProjectId,ODPNo,Item,LabelImage,ModuleNo,ProjectName,HoodType from DrawingPlan";
            sql += " inner join Projects on Projects.ProjectId=DrawingPlan.ProjectId";
            sql += whereSql;
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            Drawing objDrawing = null;
            if (objReader.Read())
            {
                objDrawing = new Drawing()
                {
                    DrawingPlanId = Convert.ToInt32(objReader["DrawingPlanId"]),
                    ProjectId = Convert.ToInt32(objReader["ProjectId"]),
                    ODPNo = objReader["ODPNo"].ToString(),
                    Item = objReader["Item"].ToString(),
                    LabelImage = objReader["LabelImage"].ToString(),
                    ModuleNo= Convert.ToInt32(objReader["ModuleNo"]),
                    ProjectName = objReader["ProjectName"].ToString(),
                    HoodType=objReader["HoodType"].ToString()
                };
            }
            objReader.Close();
            return objDrawing;
        }
        /// <summary>
        /// 编辑图纸信息
        /// </summary>
        /// <param name="objDrawing"></param>
        /// <returns></returns>
        public int EditDrawing(Drawing objDrawing)
        {
            string sql = "update DrawingPlan set Item='{0}',LabelImage='{1}' where DrawingPlanId={2}";
            sql = string.Format(sql, objDrawing.Item, objDrawing.LabelImage, objDrawing.DrawingPlanId);
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
    }
}
