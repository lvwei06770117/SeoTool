using SeoToolMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SeoToolMvc.DAL
{
    public class OutSiteInitializer : DropCreateDatabaseIfModelChanges<OutSiteContext>
    {
        protected override void Seed(OutSiteContext context) 
        {
            List<OutSite> sites = new List<OutSite>() 
            {
                new OutSite(){ SiteName="百度", SiteDomain="www.baidu.com", CreateTime=DateTime.Now},
                new OutSite(){ SiteName="谷歌", SiteDomain="www.google.com", CreateTime=DateTime.Now}
            };
        }
    }
}