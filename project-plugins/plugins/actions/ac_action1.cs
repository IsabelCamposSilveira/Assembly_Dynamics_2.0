using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using project_plugins.MultiLanguage;
using System;
using System.Collections.Generic;
using System.IdentityModel.Metadata;
using System.Linq;
using System.Text;
using project_plugins.business;

namespace project_plugins.plugins.ac_action1
{
    public class ac_action1 : PluginBase
    {
        public ac_action1(string unsecureConfiguration, string secureConfiguration) : base(typeof(ac_action1))
        {
        }

        protected override void ExecuteCrmPlugin(LocalPluginContext localContext)
        {

            var context = localContext.PluginExecutionContext;
            var entityBO = new entityBO(localContext.OrganizationService, localContext.OrganizationServiceAdmin, localContext.TracingService);

            if (!(context.InputParameters.Contains("Target") && context.InputParameters["Target"] is EntityReference target))
            {
                throw new InvalidPluginExecutionException("A ação personalizada não recebeu o registro esperado (Target).");
            }

            var consultaLogicalName = target.LogicalName;
            Guid entityID = target.Id;

            entityBO.RealizaAcao(entityID);

        }
    }
}
