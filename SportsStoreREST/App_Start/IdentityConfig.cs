using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(SportsStoreREST.App_Start.IdentityConfig))]
namespace SportsStoreREST.App_Start
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}