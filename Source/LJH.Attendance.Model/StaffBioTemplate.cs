﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
{
    /// <summary>
    /// 表示人员的生物识别模板(指纹，人脸,静脉，虹膜)
    /// </summary>
    public class StaffBioTemplate
    {
        #region 构造函数
        public StaffBioTemplate()
        {
        }
        #endregion

        #region 私有变量

        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// 获取或设置人员ID
        /// </summary>
        public int StaffID { get; set; }
        /// <summary>
        /// 获取或设置生物识别源
        /// </summary>
        public BioSource BioSource { get; set; }
        /// <summary>
        /// 获取或设置生物识别算法的版本号
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// 获取或设置生物识别模板
        /// </summary>
        public string Template { get; set; }
        /// <summary>
        /// 获取或设置备注
        /// </summary>
        public string Memo { get; set; }
        #endregion

        #region 只读属性

        #endregion
    }

    public enum BioSource
    {
        /// <summary>
        /// 左手拇指
        /// </summary>
        Left1=0,
        /// <summary>
        /// 左手食指
        /// </summary>
        Left2=1,
        /// <summary>
        /// 左手中指
        /// </summary>
        Left3=2,
        /// <summary>
        /// 左手无名指
        /// </summary>
        Left4=3,
        /// <summary>
        /// 左手小指
        /// </summary>
        Left5=4,
         /// <summary>
        /// 右手拇指
        /// </summary>
        Right1=5,
        /// <summary>
        /// 右手食指
        /// </summary>
        Right2=6,
        /// <summary>
        /// 右手中指
        /// </summary>
        Right3=7,
        /// <summary>
        /// 右手无名指
        /// </summary>
        Right4=8,
        /// <summary>
        /// 右手小指
        /// </summary>
        Right5=9,
        /// <summary>
        /// 人脸
        /// </summary>
        Face=10,
    }
}
