﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance.BLL;

namespace LJH.Attendance.UI
{
    public partial class FrmOperators:FrmMasterBase
    {
        private List<Operator> operators;
        private OperatorBll bll = new OperatorBll(AppSettings.CurrentSetting.ConnectUri); 

        public FrmOperators()
        {
            InitializeComponent();
        }

        #region 重写基类方法和处理事件
        protected override FrmDetailBase GetDetailForm()
        {
            return new FrmOperatorDetail();
        }

        protected override List<object> GetDataSource()
        {
            operators = bll.GetAllOperators().QueryObjects.ToList();
            List<object> source = new List<object>();
            foreach (object o in operators)
            {
                source.Add(o);
            }
            return source;
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            Operator info = item as Operator;
            row.Tag = info;
            row.Cells["colOperatorID"].Value = info.ID;
            row.Cells["colOperatorName"].Value = info.Name;
            row.Cells["colRoleID"].Value = info.Role.Name;
        }

        protected override bool DeletingItem(object item)
        {
            Operator info = (Operator)item;
            CommandResult ret = bll.Delete(info);
            if (ret.Result != ResultCode.Successful)
            {
                MessageBox.Show(ret.Message,LJH.Attendance.UI.Properties.Resources.Form_Alert, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ret.Result == ResultCode.Successful;
        }

        protected override void Init()
        {
            base.Init();
            this.ContextMenu.Items["mnu_Add"].Enabled = Operator.CurrentOperator.Permit(Permission.EditOperator);
            this.ContextMenu.Items["mnu_Delete"].Enabled = Operator.CurrentOperator.Permit(Permission.EditOperator);
            btn_Add.Enabled = Operator.CurrentOperator.Permit(Permission.EditOperator);
            btn_Delete.Enabled = Operator.CurrentOperator.Permit(Permission.EditOperator);
        }
        #endregion
    }
}
