﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Models;

namespace Compass
{
    public partial class FrmUserLogin : MetroFramework.Forms.MetroForm
    {
        //创建数据访问类对象
        private UserService objUserService=new UserService();
        public FrmUserLogin()
        {
            InitializeComponent();
            //从属性中获取保存的用户名和密码
            txtUserAccount.Text = Properties.Settings.Default.UserAccount;
            txtUserPwd.Text = Properties.Settings.Default.UserPwd;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //验证信息
            if (txtUserAccount.Text.Trim().Length == 0)
            {
                lblStatus.Text = "请输入登陆账号";
                txtUserAccount.Focus();
                return;
            }
            if (txtUserPwd.Text.Trim().Length == 0)
            {
                lblStatus.Text = "请输入登陆密码";
                txtUserPwd.Focus();
                return;
            }
            //封装用户实体信息
            User objUser=new User()
            {
                UserAccount = this.txtUserAccount.Text.Trim(),
                UserPwd = this.txtUserPwd.Text.Trim()
            };
            //和后台交互判断信息是否正确
            try
            {
                //执行查询并保存登陆信息
                Program.ObjCurrentUser = objUserService.UserLogin(objUser);
                if (Program.ObjCurrentUser != null)
                {
                    this.DialogResult = DialogResult.OK;
                    //记住密码
                    if (ckbRememberMe.Checked)
                    {
                        Properties.Settings.Default.UserAccount = objUser.UserAccount;
                        Properties.Settings.Default.UserPwd = objUser.UserPwd;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.UserAccount = "";
                        Properties.Settings.Default.UserPwd = "";
                        Properties.Settings.Default.Save();
                    }
                    //以后再封装权限信息

                    
                    this.Close();
                }
                else
                {
                    lblStatus.Text = "账号或者密码错误，请重试";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "数据访问出现异常，登陆失败"+ex.Message;
            }
        }


        //改善用户体验
        private void FrmUserLogin_Load(object sender, EventArgs e)
        {
            txtUserPwd.Focus();//获取焦点，如果已经保存密码可以直接按回车登陆
        }
        private void txtUserAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && this.txtUserAccount.Text.Trim().Length != 0)
            {
                this.txtUserPwd.Focus();
                this.txtUserPwd.SelectAll();
            }
            else
            {
                lblStatus.Text = "输入账号...";
            }
        }
        private void txtUserPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && this.txtUserPwd.Text.Trim().Length != 0)
            {
                btnLogin_Click(null, null);
            }
            else
            {
                lblStatus.Text = "输入密码...";
            }
        }
    }
}
