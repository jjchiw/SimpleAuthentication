﻿using System;
using SimpleAuthentication.Core;

namespace Nancy.SimpleAuthentication
{
    [Obsolete]
    public class AuthenticateCallbackResultX
    {
        /// <summary>
        /// The authenticated client information, if we have successfully authenticated.
        /// </summary>
        public IAuthenticatedClient AuthenticatedClient { get; set; }

        /// <summary>
        /// Possible Url or partial route to redirect to.
        /// </summary>
        public string ReturnUrl { get; set; }
    }
}