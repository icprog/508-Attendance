﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LJH.Attendance.BLL {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LJH.Attendance.BLL.Resource1", typeof(Resource1).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 缴费机编号 &quot;{0}&quot; 已经被使用 的本地化字符串。
        /// </summary>
        internal static string APMBll_NumbeUsed {
            get {
                return ResourceManager.GetString("APMBll_NumbeUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 已发行的,非临时的卡片不能删除! 的本地化字符串。
        /// </summary>
        internal static string CardBll_CannotDelelt {
            get {
                return ResourceManager.GetString("CardBll_CannotDelelt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 已发行的,非临时的卡片不能删除 的本地化字符串。
        /// </summary>
        internal static string CardBll_CannotDelete {
            get {
                return ResourceManager.GetString("CardBll_CannotDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 卡片挂失 的本地化字符串。
        /// </summary>
        internal static string CardBll_CardLost {
            get {
                return ResourceManager.GetString("CardBll_CardLost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 卡片收费记录不唯一 的本地化字符串。
        /// </summary>
        internal static string CardPaymentRecordBll_notSingle {
            get {
                return ResourceManager.GetString("CardPaymentRecordBll_notSingle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 同步时间间隔设置不正确，要设置成大于零的值 的本地化字符串。
        /// </summary>
        internal static string DatetimeSyncService_Invalidtime {
            get {
                return ResourceManager.GetString("DatetimeSyncService_Invalidtime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 操作员 &quot;{0}&quot; 是系统默认的操作员,不能被删除 的本地化字符串。
        /// </summary>
        internal static string OperatorBll_CannotDelete {
            get {
                return ResourceManager.GetString("OperatorBll_CannotDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 操作员ID &quot;{0}&quot; 已经被使用 的本地化字符串。
        /// </summary>
        internal static string OperatorBll_IDbeUsed {
            get {
                return ResourceManager.GetString("OperatorBll_IDbeUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 操作员真实姓名 &quot;{0}&quot; 已经被使用 的本地化字符串。
        /// </summary>
        internal static string OperatorBll_NamebeUsed {
            get {
                return ResourceManager.GetString("OperatorBll_NamebeUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 数据库中不存在操作员 &quot;{0}&quot; ,可能被其它人员删除 的本地化字符串。
        /// </summary>
        internal static string OperatorBll_NotExistsOperator {
            get {
                return ResourceManager.GetString("OperatorBll_NotExistsOperator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 操作员编号 &quot;{0}&quot; 已经被使用 的本地化字符串。
        /// </summary>
        internal static string OperatorBll_NumbeUsed {
            get {
                return ResourceManager.GetString("OperatorBll_NumbeUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 生成汇总结果时没有指定操作员 的本地化字符串。
        /// </summary>
        internal static string OperatorSettleBLL_noOperator {
            get {
                return ResourceManager.GetString("OperatorSettleBLL_noOperator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 角色 &quot;{0}&quot;  是系统默认角色,不能删除 的本地化字符串。
        /// </summary>
        internal static string RoleBll_CannotDelete {
            get {
                return ResourceManager.GetString("RoleBll_CannotDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 有操作员归属到角色 &quot;{0}&quot; ,请先把角色为 &quot;{1}&quot; 的操作员删除或改成别的角色,再来删除此角色! 的本地化字符串。
        /// </summary>
        internal static string RoleBll_RoleBeUsed {
            get {
                return ResourceManager.GetString("RoleBll_RoleBeUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 工作站 &quot;{0} &quot;是系统默认工作站,不能删除 的本地化字符串。
        /// </summary>
        internal static string WorkstationBll_CannotDelete {
            get {
                return ResourceManager.GetString("WorkstationBll_CannotDelete", resourceCulture);
            }
        }
    }
}
