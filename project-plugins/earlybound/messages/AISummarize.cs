#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project_plugins.earlybound
{
	
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/new/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("AISummarize")]
	public partial class AISummarizeRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string Text
		{
			get
			{
				if (this.Parameters.Contains("Text"))
				{
					return ((string)(this.Parameters["Text"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["Text"] = value;
			}
		}
		
		public string source
		{
			get
			{
				if (this.Parameters.Contains("source"))
				{
					return ((string)(this.Parameters["source"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["source"] = value;
			}
		}
		
		public AISummarizeRequest()
		{
			this.RequestName = "AISummarize";
			this.Text = default(string);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/new/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("AISummarize")]
	public partial class AISummarizeResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public AISummarizeResponse()
		{
		}
		
		public string SummarizedText
		{
			get
			{
				if (this.Results.Contains("SummarizedText"))
				{
					return ((string)(this.Results["SummarizedText"]));
				}
				else
				{
					return default(string);
				}
			}
		}
	}
}
#pragma warning restore CS1591
