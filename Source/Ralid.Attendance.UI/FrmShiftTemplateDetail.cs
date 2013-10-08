﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ralid.Attendance.Model;
using Ralid.Attendance.Model.Result;
using Ralid.Attendance.BLL;

namespace Ralid.Attendance.UI
{
    public partial class FrmShiftTemplateDetail : FrmDetailBase
    {
        public FrmShiftTemplateDetail()
        {
            InitializeComponent();
        }

        #region 私有方法
        private string GetShiftString(List<Shift> items)
        {
            if (items == null || items.Count == 0) return string.Empty;
            string ret = string.Empty;
            int count = 0;
            foreach (Shift item in items)
            {
                if (count > 0) ret += ",";
                ret += !string.IsNullOrEmpty(item.ShortName) ? item.ShortName : item.Name;
                count++;
            }
            return ret;
        }
        #endregion

        #region 重写基类方法
        protected override void InitControls()
        {
            base.InitControls();
            btnOk.Enabled = Operator.CurrentOperator.Permit(Permission.EditShiftTemplate);
        }

        protected override bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("模板名称不能为空");
                txtName.Focus();
                return false;
            }
            return true;
        }

        protected override void ItemShowing()
        {
            ShiftArrangeTemplate item = UpdatingItem as ShiftArrangeTemplate;
            if (item == null) return;
            txtName.Text = item.Name;
            chkHolidayShifted.Checked = (item.Options & TemplateOptions.HolidayShifted) == TemplateOptions.HolidayShifted;
            chkWeekendShifted.Checked = (item.Options & TemplateOptions.WeekendShifted) == TemplateOptions.WeekendShifted;
            if (item.Items != null && item.Items.Count > 0)
            {
                int i = 0;
                foreach (TemplateItem it in item.Items)
                {
                    i++;
                    if (i > 6) break;
                    (this.Controls["chkShift" + i.ToString()] as CheckBox).Checked = true;
                    (this.Controls["txtShifts" + i.ToString()] as TextBox).Text = GetShiftString(it.Shifts);
                    (this.Controls["txtShifts" + i.ToString()] as TextBox).Tag = it.Shifts;
                    (this.Controls["txtDuration" + i.ToString()] as NumericUpDown).Value = it.Duration;
                    (this.Controls["txtRest" + i.ToString()] as NumericUpDown).Value = it.RestDays;
                }
            }
            txtMemo.Text = item.Memo;
        }

        protected override object GetItemFromInput()
        {
            ShiftArrangeTemplate item = UpdatingItem as ShiftArrangeTemplate;
            if (item == null)
            {
                item = new ShiftArrangeTemplate();
            }
            item.Name = txtName.Text;
            item.Options = TemplateOptions.None;
            if (chkHolidayShifted.Checked) item.Options |= TemplateOptions.HolidayShifted;
            if (chkWeekendShifted.Checked) item.Options |= TemplateOptions.WeekendShifted;
            if (item.Items == null) item.Items = new List<TemplateItem>();
            item.Items.Clear();
            for (int i = 1; i <= 6; i++)
            {
                if ((this.Controls["chkShift" + i.ToString()] as CheckBox).Checked)
                {
                    TemplateItem it = new TemplateItem();
                    it.Shifts = (this.Controls["txtShifts" + i.ToString()] as TextBox).Tag as List<Shift>;
                    it.Duration = (int)(this.Controls["txtDuration" + i.ToString()] as NumericUpDown).Value;
                    it.RestDays = (int)(this.Controls["txtRest" + i.ToString()] as NumericUpDown).Value;
                    item.Items.Add(it);
                }
            }
            item.Memo = txtMemo.Text;
            return item;
        }

        protected override CommandResult AddItem(object addingItem)
        {
            return (new ShiftArrangeTemplateBLL(AppSettings.CurrentSetting.ConnectString)).Add(addingItem as ShiftArrangeTemplate);
        }

        protected override CommandResult UpdateItem(object updatingItem)
        {
            return (new ShiftArrangeTemplateBLL(AppSettings.CurrentSetting.ConnectString)).Update(updatingItem as ShiftArrangeTemplate);
        }
        #endregion

        private void lnkShift_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i <= 6; i++)
            {
                if (object.ReferenceEquals(this.Controls["lnkShift" + i.ToString()], sender))
                {
                    FrmShiftSelection frm = new FrmShiftSelection();
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.SelectedShifts = this.Controls["txtShifts" + i.ToString()].Tag as List<Shift>;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        List<Shift> shifts = frm.SelectedShifts;
                        this.Controls["txtShifts" + i.ToString()].Tag = shifts;
                        (this.Controls["txtShifts" + i.ToString()] as TextBox).Text = GetShiftString(shifts);
                    }
                }
            }
        }

        private void chkShift_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 6; i++)
            {
                if (object.ReferenceEquals(this.Controls["chkShift" + i.ToString()], sender))
                {
                    this.Controls["lnkShift" + i.ToString()].Enabled = (this.Controls["chkShift" + i.ToString()] as CheckBox).Checked;
                }
            }
        }
    }
}