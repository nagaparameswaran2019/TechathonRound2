using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UniversityMgmtUtil
{
    public class Cache: PageModel
    {
        public void AddCache(string key, string value)
        {

        }

        public static void SetSession(string key, string value)
        {

            //HttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            //httpContextAccessor.HttpContext.Session.GetString("Roles");
        }
    }
}
