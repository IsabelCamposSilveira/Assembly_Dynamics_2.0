using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using project_plugins.MultiLanguage;
using System;
using System.Collections.Generic;
using System.IdentityModel.Metadata;
using System.Linq;
using System.Text;
using project_plugins.business;
using project_plugins.earlybound;

namespace project_plugins.plugins.salesorder
{
    public class postOperation_entity : PluginBase
    {
        public postOperation_entity(string unsecureConfiguration, string secureConfiguration) : base(typeof(postOperation_entity))
        {
        }

        protected override void ExecuteCrmPlugin(LocalPluginContext localContext)
        {

            // var Entity = localContext.GetTarget<Entity>();
            var entityBO = new entityBO(localContext.OrganizationService, localContext.OrganizationServiceAdmin, localContext.TracingService);

            if ("create".Equals(localContext.PluginExecutionContext.MessageName, StringComparison.InvariantCultureIgnoreCase))
            {
                // Ação Abaixo
                //if (SalesOrder.QuoteId != null)
                //{
                //    entityBO.RealizaAcao(SalesOrder.Id);
                //}


            }
            else if ("update".Equals(localContext.PluginExecutionContext.MessageName, StringComparison.InvariantCultureIgnoreCase))
            {

            }

        }
    }
}
