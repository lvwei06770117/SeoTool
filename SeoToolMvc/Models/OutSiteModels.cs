using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SeoToolMvc.Models
{

    [Table("tbOutSite")]
    public class OutSite
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int SiteId { get; set; }
        
        //[Display(Name = "外站名称")]
        /// <summary>
        /// 外站名称
        /// </summary>
        public string SiteName { get; set; }

        //[Display(Name = "外站域名")]
        /// <summary>
        /// 外站域名
        /// </summary>
        public string SiteDomain { get; set; }
        
        //[Display(Name = "添加时间")]
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        
        //[Display(Name = "注册api路径")]
        /// <summary>
        /// 注册api路径
        /// </summary>
        public string RegApiPath { get; set; }
        /// <summary>
        /// 发帖api
        /// </summary>
        //[Display(Name = "发帖api路径")]
        public string PostApiPath { get; set; }

        public virtual ICollection<OutSiteLogin> LoginUsers { get; set; }
    }

    [Table("tbOutSiteLogin")]
    public class OutSiteLogin
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        
        //[Display(Name = "登录名")]
        /// <summary>
        /// LoginName
        /// </summary>
        public string LoginName { get; set; }
        
        //[Display(Name = "登录密码")]
        /// <summary>
        /// 登录密码
        /// </summary>
        public string LoginPwd { get; set; }
        
        //[Display(Name = "添加时间")]
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        public virtual OutSite Site { get; set; }
    }
}