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
    public partial class FrmOTTypeMaster : FrmMasterBase
    {
        public FrmOTTypeMaster()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            this.ContextMenu.Items["mnu_Add"].Enabled = Operator.CurrentOperator.Permit(Permission.EditOTType);
            this.ContextMenu.Items["mnu_Delete"].Enabled = Operator.CurrentOperator.Permit(Permission.EditOTType);
            btn_Add.Enabled = Operator.CurrentOperator.Permit(Permission.EditOTType);
            btn_Delete.Enabled = Operator.CurrentOperator.Permit(Permission.EditOTType);
        }

        protected override FrmDetailBase GetDetailForm()
        {
            return new FrmOTTypeDetail();
        }

        protected override List<object> GetDataSource()
        {
            List<OTType> items = (new OTTypeBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(null).QueryObjects;
            return (from item in items
                    select (object)item).ToList();
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            OTType OTType = item as OTType;
            row.Tag = OTType;
            row.Cells["colName"].Value = OTType.Name;
            row.Cells["colMultiple"].Value = OTType.Multiple;
            row.Cells["colMemo"].Value = OTType.Memo;
        }

        protected override bool DeletingItem(object item)
        {
            CommandResult ret = (new OTTypeBLL(AppSettings.CurrentSetting.ConnectUri)).Delete(item as OTType);
            return ret.Result == ResultCode.Successful;
        }
        #endregion
    }
}