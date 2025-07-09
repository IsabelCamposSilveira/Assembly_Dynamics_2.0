using project_plugins.Business;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.PluginTelemetry;
using project_plugins.MultiLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_plugins.business
{
    public class MetadataBO : BaseBusiness
    {
        public MetadataBO(IOrganizationService service, IOrganizationService serviceAdmin, ITracingService tracingService, List<Resx> messages = null) : base(service, serviceAdmin, tracingService, messages) { }

        public EnumAttributeMetadata GetOptions(string table, string column)
        {
            var request = new RetrieveAttributeRequest
            {
                EntityLogicalName = table,
                LogicalName = column,
                RetrieveAsIfPublished = true
            };

            var response = (RetrieveAttributeResponse)this.ServiceAdmin.Execute(request);
            return (EnumAttributeMetadata)response.AttributeMetadata;
        }
    }
}
