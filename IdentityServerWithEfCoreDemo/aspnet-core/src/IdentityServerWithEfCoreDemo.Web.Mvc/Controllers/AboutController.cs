﻿using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using IdentityServerWithEfCoreDemo.Controllers;

namespace IdentityServerWithEfCoreDemo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : IdentityServerWithEfCoreDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
