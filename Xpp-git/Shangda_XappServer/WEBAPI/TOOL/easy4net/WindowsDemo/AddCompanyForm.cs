﻿using Easy4net.DBUtility;
using Easy4net.Entity;
using Easy4net.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsDemo
{
    public partial class AddCompanyForm : Form
    {
        public AddCompanyForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Session session = SessionFactory.GetSession();
            //session.BeginTransaction();

            //旧的写法，新的写法为Session，但是保持了兼容性
            DBHelper dbHelper = DBHelper.getInstance();
            dbHelper.BeginTransaction();

            try
            {
                Company company = new Company();
                company.CompanyName = txtName.Text.Trim();
                company.Industry = txtIndustry.Text.Trim();
                company.Address = txtAddress.Text.Trim();

                //session.Insert<Company>(company);
                dbHelper.Save<Company>(company);

                if (company.Id > 0)
                {
                    MessageBox.Show("创建公司成功！");
                }

                if (DialogResult.OK == MessageBox.Show("是否回滚事务？", "事务测试", MessageBoxButtons.OKCancel))
                {
                    throw new Exception("测试事务回滚！！！");
                }
                else
                {
                    //session.Commit();
                    dbHelper.CommitTransaction();
                    MessageBox.Show("事务提交成功，请查看数据库是否存在该数据！");
                }
            }
            catch (Exception ex)
            {
                //session.Rollback();
                dbHelper.RollbackTransaction();
                MessageBox.Show("事务回滚成功，请查看数据库是否存在该数据！");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtIndustry_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             //旧的写法，新的写法为Session，但是保持了兼容性
            DBHelper dbHelper = DBHelper.getInstance();
            dbHelper.BeginTransaction();

            try
            {
                Company company = new Company();
                company.Id = 1;
                company.CompanyName = txtName.Text.Trim();
                company.Industry = txtIndustry.Text.Trim();
                company.Address = txtAddress.Text.Trim();

                //session.Insert<Company>(company);
                dbHelper.Update<Company>(company);
                dbHelper.CommitTransaction();
            }catch(Exception eX)
            {
                dbHelper.RollbackTransaction();
                MessageBox.Show("AAAAAAAAAAAAAAAAAAAA");
            }
        }
    }
}
