using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.PluginTelemetry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_plugins.earlybound;
using project_plugins.Business;
using project_plugins.MultiLanguage;
using Microsoft.Xrm.Sdk.Query;

namespace project_plugins.business
{
    public class entityBO : BaseBusiness
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name='service'>Service InitialUser</param>
        /// <param name='serviceAdmin'>Service Admin</param>
        /// <param name='tracingService'>Trace</param>
        public entityBO(IOrganizationService service, IOrganizationService serviceAdmin, ITracingService tracingService, List<Resx> messages = null) : base(service, serviceAdmin, tracingService, messages) { }


        /// <summary>
        /// Escrever o que o método faz
        /// </summary>
        /// <param name="parName">Escreve o que é o parametro</param>
        /// <returns>Cobrança</returns>
        public void RealizaAcao(Guid parName)
        {
            // Ação aqui
        }
    }
}
