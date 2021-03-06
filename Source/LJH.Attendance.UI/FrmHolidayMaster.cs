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
    public partial class FrmHolidayMaster : FrmMasterBase
    {
        public FrmHolidayMaster()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            this.ContextMenu.Items["mnu_Add"].Enabled = Operator.CurrentOperator.Permit(Permission.EditHoliday);
            this.ContextMenu.Items["mnu_Delete"].Enabled = Operator.CurrentOperator.Permit(Permission.EditHoliday);
            btn_Add.Enabled = Operator.CurrentOperator.Permit(Permission.EditHoliday);
            btn_Delete.Enabled = Operator.CurrentOperator.Permit(Permission.EditHoliday);
        }

        protected override FrmDetailBase GetDetailForm()
        {
            return new FrmHolidayDetail();
        }

        protected override List<object> GetDataSource()
        {
            List<Holiday> items = (new HolidayBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(null).QueryObjects;

            if (HolidaySetting.Current == null) HolidaySetting.Current = new HolidaySetting();
            HolidaySetting.Current.Holidays = items;

            return (from item in items
                    select (object)item).ToList();
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            Holiday holiday = item as Holiday;
            row.Tag = holiday;
            row.Cells["colStartDate"].Value = holiday.StartDate.ToLongDateString();
            row.Cells["colEndDate"].Value = holiday.EndDate.ToLongDateString();
            row.Cells["colWeekendToWorkday"].Value = holiday.GetWeekendToWorkDayString(",");
            row.Cells["colMemo"].Value = holiday.Memo;
        }

        protected override bool DeletingItem(object item)
        {
            CommandResult ret = (new HolidayBLL(AppSettings.CurrentSetting.ConnectUri)).Delete(item as Holiday);
            List<Holiday> holidays = (new HolidayBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(null).QueryObjects;
            HolidaySetting.Current.Holidays = holidays;
            return ret.Result == ResultCode.Successful;
        }
        #endregion
    }
}