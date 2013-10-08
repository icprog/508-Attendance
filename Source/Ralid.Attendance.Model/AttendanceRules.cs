﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model
{
    /// <summary>
    /// 表示考勤规则
    /// </summary>
    public class AttendanceRules
    {
        #region 静态属性
        public static AttendanceRules Current { get; set; }
        #endregion

        #region 构造函数
        public AttendanceRules()
        {
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置迟到多少分钟后计为缺勤
        /// </summary>
        public int? LateAsAbsent { get; set; }
        /// <summary>
        /// 获取或设置早退多少分钟后计为缺勤
        /// </summary>
        public int? LeaveEarlyAsAbsent { get; set; }
        /// <summary>
        /// 获取或设置迟到早退是否扣除出勤时间
        /// </summary>
        public bool ShiftTimeIncludeLateOrLeaveEarly { get; set; }
        /// <summary>
        /// 获取或设置外出是否同时计为出勤
        /// </summary>
        public bool ShiftTimeIncludeWaiChu { get; set; }
        /// <summary>
        /// 获取或设置出差是否同时计为出勤
        /// </summary>
        public bool ShiftTimeIncludeChuChai { get; set; }
        /// <summary>
        /// 获取或设置上班期间外出或请假离开时是否需要打卡
        /// </summary>
        public bool LogWhenLeave { get; set; }
        /// <summary>
        /// 获取或设置上班期间外出或请假回来后是否需要打卡
        /// </summary>
        public bool LogWhenArrive { get; set; }
        /// <summary>
        /// 获取或设置上班期间外出或请假未按时离开或归来的应计迟到早退
        /// </summary>
        public bool ForLateAndLeaveEarly { get; set; }
        /// <summary>
        /// 获取或设置最小的加班分钟数
        /// </summary>
        public int MinOTMinute { get; set; }
        /// <summary>
        /// 获取或设置一个工作日的分钟数
        /// </summary>
        public int MinutesOfWorkDay { get; set; }
        /// <summary>
        /// 获取或设置出勤的时间单位
        /// </summary>
        public AttendanceUnit ShiftUnit { get; set; }
        /// <summary>
        /// 获取或设置出勤时间的最小值
        /// </summary>
        public decimal MinShiftTime { get; set; }
        /// <summary>
        /// 获取或设置请假的时间单位
        /// </summary>
        public AttendanceUnit VacationUnit { get; set; }
        /// <summary>
        /// 获取或设置请假时间的最小值
        /// </summary>
        public decimal MinVacationTime { get; set; }
        /// <summary>
        /// 获取或设置加班的时间单位
        /// </summary>
        public AttendanceUnit OTUnit { get; set; }
        /// <summary>
        /// 获取或设置加班时间的最小值
        /// </summary>
        public decimal MinOTTime { get; set; }
        /// <summary>
        ///  获取或设置外出的时间单位
        /// </summary>
        public AttendanceUnit WaichuUnit { get; set; }
        /// <summary>
        ///  获取或设置外出时间的最小值
        /// </summary>
        public decimal MinWaichuTime { get; set; }
        /// <summary>
        ///  获取或设置出差的时间单位
        /// </summary>
        public AttendanceUnit ChuchaiUnit { get; set; }
        /// <summary>
        ///  获取或设置出差时间的最小值
        /// </summary>
        public decimal MinChuChaiTime { get; set; }
        /// <summary>
        ///  获取或设置迟到早退的时间单位
        /// </summary>
        public AttendanceUnit LateLeaveEarlyUnit { get; set; }
        /// <summary>
        ///  获取或设置迟到早退的最小值
        /// </summary>
        public decimal MinLateLeaveEarlyTime { get; set; }
        #endregion
    }
}