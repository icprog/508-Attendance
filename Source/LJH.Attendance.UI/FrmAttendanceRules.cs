﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LJH.Attendance.BLL;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;

namespace LJH.Attendance.UI
{
    public partial class FrmAttendanceRules : Form
    {
        public FrmAttendanceRules()
        {
            InitializeComponent();
        }

        private void ShowItem(AttendanceRules item)
        {
            chkMinLate.Checked = item.MinLate != null;
            if (item.MinLate != null)
            {
                txtMinLate.IntergerValue = item.MinLate.Value;
                txtMinLateAsAbsentMinute.IntergerValue = item.MinLateAsAbsentMinute;
            }
            chkMinLeaveEarly.Checked = item.MinLeaveEarly != null;
            if (item.MinLeaveEarly != null)
            {
                txtMinLeaveEarly.IntergerValue = item.MinLeaveEarly.Value;
                txtMinLeaveEarlyAsAbsentMinute.IntergerValue = item.MinLeaveEarlyAsAbsentMinute;
            }
            chkLateAsAbsent.Checked = item.LateAsAbsent != null;
            if (item.LateAsAbsent != null) txtLateAsAbsent.IntergerValue = item.LateAsAbsent.Value;
            chkLeaveEarlyAsAbsent.Checked = item.LeaveEarlyAsAbsent != null;
            if (item.LeaveEarlyAsAbsent != null) txtLeaveEarlyAsAbsent.IntergerValue = item.LeaveEarlyAsAbsent.Value;
            chkShiftTimeIncludeWaiChu.Checked = item.ShiftTimeIncludeWaiChu;
            chkShiftTimeExclueLateAndLeaveEarly.Checked = !item.ShiftTimeIncludeLateOrLeaveEarly;
            txtMinOTMinute.IntergerValue = item.MinOTMinute;
            txtMinShiftMinute.IntergerValue = item.MinShiftMinute;
            txtOTBeforeStartTime.Value = item.BeforeOTStartTime;
            txtOTAfterEndTime.Value = item.AfterOTEndTime;
            txtMinutesOfWorkDay.Value = item.MinutesOfWorkDay;
            comAttendanceUnit.SelectedUnit = item.AttendanceUnit;
            txtMinAttendanceTime.DecimalValue = item.MinAttendanceTime;

            #region 其它
            txtSNofAbsent.Text  = item.SNofAbsent;
            txtSNofLate.Text  = item.SNofLate;
            txtSNofLateLeaveEarly.Text  = item.SNofLateLeaveEarly;
            txtSNofLeaveEarly.Text  = item.SNofLeaveEarly;
            txtSNofOk.Text = item.SNofOk;
            txtSNofRest.Text = item.SNofRest;
            #endregion
        }

        private AttendanceRules GetFromInput()
        {
            AttendanceRules item = new AttendanceRules();
            if (chkMinLate.Checked)
            {
                item.MinLate = txtMinLate.IntergerValue;
                item.MinLateAsAbsentMinute = txtMinLateAsAbsentMinute.IntergerValue;

            }
            if (chkMinLeaveEarly.Checked)
            {
                item.MinLeaveEarly = txtMinLeaveEarly.IntergerValue;
                item.MinLeaveEarlyAsAbsentMinute = txtMinLeaveEarlyAsAbsentMinute.IntergerValue;
            }
            if (chkLateAsAbsent.Checked) item.LateAsAbsent = txtLateAsAbsent.IntergerValue;
            if (chkLeaveEarlyAsAbsent.Checked) item.LeaveEarlyAsAbsent = txtLeaveEarlyAsAbsent.IntergerValue;
            item.ShiftTimeIncludeWaiChu = chkShiftTimeIncludeWaiChu.Checked;
            item.ShiftTimeIncludeLateOrLeaveEarly = !chkShiftTimeExclueLateAndLeaveEarly.Checked;
            item.MinShiftMinute = txtMinShiftMinute.IntergerValue;
            item.MinOTMinute = txtMinOTMinute.IntergerValue;
            item.BeforeOTStartTime = (int)txtOTBeforeStartTime.Value;
            item.AfterOTEndTime = (int)txtOTAfterEndTime.Value;
            item.MinutesOfWorkDay = (int)txtMinutesOfWorkDay.Value;
            item.AttendanceUnit = comAttendanceUnit.SelectedUnit;
            item.MinAttendanceTime = txtMinAttendanceTime.DecimalValue;

            #region 其它
            item.SNofAbsent = txtSNofAbsent.Text;
            item.SNofLate = txtSNofLate.Text;
            item.SNofLateLeaveEarly = txtSNofLateLeaveEarly.Text;
            item.SNofLeaveEarly = txtSNofLeaveEarly.Text;
            item.SNofOk = txtSNofOk.Text;
            item.SNofRest = txtSNofRest.Text;
            #endregion
            return item;
        }

        private void FrmAttendanceRules_Load(object sender, EventArgs e)
        {
            comAttendanceUnit.Init();
            ShowItem(AttendanceRules.Current);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            AttendanceRules.Current = GetFromInput();
            CommandResult ret = (new ParameterBLL(AppSettings.CurrentSetting.ConnectUri)).Save<AttendanceRules>(AttendanceRules.Current);
            if (ret.Result == ResultCode.Successful)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(ret.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
