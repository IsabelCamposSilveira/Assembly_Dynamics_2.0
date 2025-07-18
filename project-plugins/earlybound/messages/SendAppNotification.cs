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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("SendAppNotification")]
	public partial class SendAppNotificationRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public Microsoft.Xrm.Sdk.OptionSetValue Priority
		{
			get
			{
				if (this.Parameters.Contains("Priority"))
				{
					return ((Microsoft.Xrm.Sdk.OptionSetValue)(this.Parameters["Priority"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.OptionSetValue);
				}
			}
			set
			{
				this.Parameters["Priority"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.OptionSetValue IconType
		{
			get
			{
				if (this.Parameters.Contains("IconType"))
				{
					return ((Microsoft.Xrm.Sdk.OptionSetValue)(this.Parameters["IconType"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.OptionSetValue);
				}
			}
			set
			{
				this.Parameters["IconType"] = value;
			}
		}
		
		public int Expiry
		{
			get
			{
				if (this.Parameters.Contains("Expiry"))
				{
					return ((int)(this.Parameters["Expiry"]));
				}
				else
				{
					return default(int);
				}
			}
			set
			{
				this.Parameters["Expiry"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.OptionSetValue ToastType
		{
			get
			{
				if (this.Parameters.Contains("ToastType"))
				{
					return ((Microsoft.Xrm.Sdk.OptionSetValue)(this.Parameters["ToastType"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.OptionSetValue);
				}
			}
			set
			{
				this.Parameters["ToastType"] = value;
			}
		}
		
		public string Title
		{
			get
			{
				if (this.Parameters.Contains("Title"))
				{
					return ((string)(this.Parameters["Title"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["Title"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference Recipient
		{
			get
			{
				if (this.Parameters.Contains("Recipient"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["Recipient"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["Recipient"] = value;
			}
		}
		
		public string Body
		{
			get
			{
				if (this.Parameters.Contains("Body"))
				{
					return ((string)(this.Parameters["Body"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["Body"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.Entity OverrideContent
		{
			get
			{
				if (this.Parameters.Contains("OverrideContent"))
				{
					return ((Microsoft.Xrm.Sdk.Entity)(this.Parameters["OverrideContent"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.Entity);
				}
			}
			set
			{
				this.Parameters["OverrideContent"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.Entity Actions
		{
			get
			{
				if (this.Parameters.Contains("Actions"))
				{
					return ((Microsoft.Xrm.Sdk.Entity)(this.Parameters["Actions"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.Entity);
				}
			}
			set
			{
				this.Parameters["Actions"] = value;
			}
		}
		
		public SendAppNotificationRequest()
		{
			this.RequestName = "SendAppNotification";
			this.Title = default(string);
			this.Recipient = default(Microsoft.Xrm.Sdk.EntityReference);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/new/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("SendAppNotification")]
	public partial class SendAppNotificationResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public SendAppNotificationResponse()
		{
		}
		
		public System.Guid NotificationId
		{
			get
			{
				if (this.Results.Contains("NotificationId"))
				{
					return ((System.Guid)(this.Results["NotificationId"]));
				}
				else
				{
					return default(System.Guid);
				}
			}
		}
	}
}
#pragma warning restore CS1591
