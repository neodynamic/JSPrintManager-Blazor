﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Neodynamic.Blazor;

namespace JSPMBlazorServerApp.Controllers
{
    [AllowAnonymous]
    public class JSPMController : Controller
    {
        public IActionResult Index(string timestamp)
        {
            return File(JSPrintManager.GenerateLicense("YOUR-LICENSE-OWNER-HERE", "YOUR-LICNESE-KEY-HERE", timestamp), "text/plain");
        }
    }
}
