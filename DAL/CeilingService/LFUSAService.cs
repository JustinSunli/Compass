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
   public class LFUSAService : IModelService
    {
        public int EditModel(IModel model)
        {
            LFUSA objModel = (LFUSA)model;
            //编写带参数的SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("Update LFUSA set Length=@Length,Width=@Width,SuNo=@SuNo,SuDia=@SuDia,SuDis=@SuDis,");
           sqlBuilder.Append("SidePanel=@SidePanel,Japan=@Japan where LFUSAId=@LFUSAId");
            //定义参数数组
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Length",objModel.Length),
                new SqlParameter("@Width",objModel.Width),
                new SqlParameter("@SuNo",objModel.SuNo),
                new SqlParameter("@SuDia",objModel.SuDia),
                new SqlParameter("@SuDis",objModel.SuDis),
                new SqlParameter("@SidePanel",objModel.SidePanel),
                new SqlParameter("@Japan",objModel.Japan),
                new SqlParameter("@LFUSAId",objModel.LFUSAId)
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
            string sql = "select LFUSAId,LFUSA.ModuleTreeId,Item,Module,Length,Width," +
                         "SuNo,SuDia,SuDis,SidePanel,Japan from LFUSA";
            sql += " inner join ModuleTree on LFUSA.ModuleTreeId=ModuleTree.ModuleTreeId";
            sql += " inner join DrawingPlan on ModuleTree.DrawingPlanId=DrawingPlan.DrawingPlanId";
            sql += string.Format(" where ProjectId={0}", projectId);
            sql += " order by Item,Module";
            return SQLHelper.GetDataSet(sql);
        }

        public IModel GetModelById(string id)
        {
            return GetModelByWhereSql(string.Format(" where LFUSAId={0}", id));
        }

        public IModel GetModelByModuleTreeId(string moduleTreeId)
        {
            return GetModelByWhereSql(string.Format(" where ModuleTreeId={0}", moduleTreeId));
        }

        public IModel GetModelByWhereSql(string whereSql)
        {
            string sql =
                "select LFUSAId,ModuleTreeId,Length,Width," +
                "SuNo,SuDia,SuDis,SidePanel,Japan from LFUSA";
            sql += whereSql;
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            LFUSA objModel = null;
            if (objReader.Read())
            {
                objModel = new LFUSA()
                {
                    LFUSAId = Convert.ToInt32(objReader["LFUSAId"]),
                    ModuleTreeId = Convert.ToInt32(objReader["ModuleTreeId"]),
                    //最好不要用=null去判断，提示类型转换错误
                    Length = objReader["Length"].ToString().Length == 0 ? 0 : Convert.ToDecimal(objReader["Length"]),
                    Width = objReader["Width"].ToString().Length == 0 ? 0 : Convert.ToDecimal(objReader["Width"]),
                    SuNo = objReader["SuNo"].ToString().Length == 0 ? 0 : Convert.ToInt32(objReader["SuNo"]),
                    SuDia = objReader["SuDia"].ToString().Length == 0 ? 0 : Convert.ToDecimal(objReader["SuDia"]),
                    SuDis = objReader["SuDis"].ToString().Length == 0 ? 0 : Convert.ToDecimal(objReader["SuDis"]),

                    SidePanel = objReader["SidePanel"].ToString().Length == 0 ? "" : objReader["SidePanel"].ToString(),
                    Japan = objReader["Japan"].ToString().Length == 0 ? "" : objReader["Japan"].ToString()
                };
            }
            objReader.Close();
            return objModel;
        }
    }
}
