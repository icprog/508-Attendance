﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Device
{
    /// <summary>
    /// 表示中控彩屏指纹读卡器
    /// </summary>
    public class ZKTFTFingerReader : IReader
    {
        #region 构造函数
        public ZKTFTFingerReader()
        {
        }

        public ZKTFTFingerReader(LJH.Attendance.Model.DeviceInfo para)
        {
            Parameter = para;
        }
        #endregion

        #region 公共属性
        public LJH.Attendance.Model.DeviceInfo Parameter { get; set; }
        #endregion

        #region 实现接口
        public void Connect()
        {
            if (Parameter != null)
            {
                
            }
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public bool IsConnected
        {
            get { throw new NotImplementedException(); }
        }

        public List<Model.AttendanceLog> GetAttendanceLogs()
        {
            throw new NotImplementedException();
        }

        public void SetUserInfo(Model.Staff staff)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}