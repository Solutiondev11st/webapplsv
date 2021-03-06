﻿//-----------------------------------------------------------------------
// <copyright file="Index.cshtml.cs" company="None">
//     Copyright (c) Allow to distribute this code and utilize this code for personal or commercial purpose.
// </copyright>
// <author>Asma Khalid</author>
//-----------------------------------------------------------------------

namespace WebAppLSV.Pages.Home
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authentication.Cookies;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    /// <summary>
    /// Index page model class.
    /// </summary>
    [Authorize]
    public class IndexModel : PageModel
    {
        #region On Get method.

        /// <summary>
        /// On Get method.
        /// </summary>
        public void OnGet()
        {
            try
            {
            }
            catch (Exception ex)
            {
                // Info
                Console.Write(ex);
            }
        }

        #endregion

 
    }
}