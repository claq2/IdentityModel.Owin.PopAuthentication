﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel.Owin.PopAuthentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityModelOwinPopAuthentication.Tests.UnitTests
{
    public class StubSignatureValidator
    {
        public bool InvokeWasCalled { get; set; }
        public bool Result { get; set; }

        public Task<bool> Invoke(IDictionary<string, object> env, OwinRequestValidationOptions options, string token)
        {
            InvokeWasCalled = true;
            return Task.FromResult(Result);
        }
    }
}
