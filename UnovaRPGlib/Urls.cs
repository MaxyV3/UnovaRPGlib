﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnovaRPGlib
{
    internal static class Urls
    {
        public const string Domain = "www.unovarpg.com";
        public const string UrlBase = "https://" + Domain;
        public const string UrlLogin = UrlBase + "/login.php";
        public const string UrlLoginAction = UrlLogin + "?doLogin";
    }
}