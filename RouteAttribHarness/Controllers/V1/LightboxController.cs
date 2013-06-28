﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using AttributeRouting;
using AttributeRouting.Web.Http;

namespace RouteAttribHarness.Controllers.V1
{
    [RoutePrefix("api")]
    [RoutePrefix("api2")]
    public class LightboxController : ApiController
    {
        [GET("lightbox/{id}")]
        public string Get(int id)
        {
            return "I guess we should return a lightbox.";
        }

        [POST("lightbox")]
        public int AddStuff(Thingy thingy)
        {
            return 99;
        }
    }

    public class Thingy
    {
        public string Whatsit;
        public int Whoa;
    }
}