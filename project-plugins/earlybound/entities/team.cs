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
	
	
	/// <summary>
	/// Informações sobre tipo de equipe associação da equipe.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum team_membershiptype
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Membroseconvidados = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Membros = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Proprietrios = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Convidados = 3,
	}
	
	/// <summary>
	/// Informações sobre tipo de equipe.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum team_type
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Proprietrio_a = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Acessar = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		GrupodeSegurana = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		GrupodoOffice = 3,
	}
	
	/// <summary>
	/// Grupo de usuários do sistema que colaboram rotineiramente. Equipes podem ser utilizadas para simplificar o compartilhamento de registros e fornecer aos membros da equipe um acesso comum aos dados da organização, quando esses membros de equipe pertencerem a diferentes Divisões.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("team")]
	public partial class Team : Microsoft.Xrm.Sdk.Entity
	{
		
		/// <summary>
		/// Available fields, a the time of codegen, for the team entity
		/// </summary>
		public partial class Fields
		{
			public const string AdministratorId = "administratorid";
			public const string AzureActiveDirectoryObjectId = "azureactivedirectoryobjectid";
			public const string BusinessUnitId = "businessunitid";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string DelegatedAuthorizationId = "delegatedauthorizationid";
			public const string Description = "description";
			public const string EMailAddress = "emailaddress";
			public const string ExchangeRate = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IsDefault = "isdefault";
			public const string IsSasTokenSet = "issastokenset";
			public const string MembershipType = "membershiptype";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string msft_DataState = "msft_datastate";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string ProcessId = "processid";
			public const string QueueId = "queueid";
			public const string RegardingObjectId = "regardingobjectid";
			public const string ShareLinkQualifier = "sharelinkqualifier";
			public const string StageId = "stageid";
			public const string SystemManaged = "systemmanaged";
			public const string TeamId = "teamid";
			public const string Id = "teamid";
			public const string TeamTemplateId = "teamtemplateid";
			public const string TeamType = "teamtype";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string TraversedPath = "traversedpath";
			public const string VersionNumber = "versionnumber";
			public const string YomiName = "yominame";
			public const string team_opportunities = "team_opportunities";
			public const string team_opportunityproduct = "team_opportunityproduct";
			public const string team_orders = "team_orders";
			public const string team_quotes = "team_quotes";
			public const string teammembership_association = "teammembership_association";
			public const string teamroles_association = "teamroles_association";
			public const string business_unit_teams = "business_unit_teams";
			public const string lk_team_createdonbehalfby = "lk_team_createdonbehalfby";
			public const string lk_team_modifiedonbehalfby = "lk_team_modifiedonbehalfby";
			public const string lk_teambase_administratorid = "lk_teambase_administratorid";
			public const string lk_teambase_createdby = "lk_teambase_createdby";
			public const string lk_teambase_modifiedby = "lk_teambase_modifiedby";
			public const string opportunity_Teams = "opportunity_Teams";
			public const string organization_teams = "organization_teams";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Team() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "team";
		
		public const string EntityLogicalCollectionName = "teams";
		
		public const string EntitySetName = "teams";
		
		/// <summary>
		/// Identificador exclusivo do usuário principal responsável pela equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("administratorid")]
		public Microsoft.Xrm.Sdk.EntityReference AdministratorId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("administratorid");
			}
			set
			{
				this.SetAttributeValue("administratorid", value);
			}
		}
		
		/// <summary>
		/// A ID do objeto para um grupo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("azureactivedirectoryobjectid")]
		public System.Nullable<System.Guid> AzureActiveDirectoryObjectId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("azureactivedirectoryobjectid");
			}
			set
			{
				this.SetAttributeValue("azureactivedirectoryobjectid", value);
			}
		}
		
		/// <summary>
		/// Identificador exclusivo da unidade de negócios à qual a equipe está associada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid");
			}
			set
			{
				this.SetAttributeValue("businessunitid", value);
			}
		}
		
		/// <summary>
		/// Identificador exclusivo do usuário que criou a equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Data e hora em que a equipe foi criada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Identificador exclusivo do usuário delegado que criou a equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// The delegated authorization context for the team.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("delegatedauthorizationid")]
		public Microsoft.Xrm.Sdk.EntityReference DelegatedAuthorizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("delegatedauthorizationid");
			}
			set
			{
				this.SetAttributeValue("delegatedauthorizationid", value);
			}
		}
		
		/// <summary>
		/// Descrição da equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.SetAttributeValue("description", value);
			}
		}
		
		/// <summary>
		/// Endereço de email da equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress")]
		public string EMailAddress
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress");
			}
			set
			{
				this.SetAttributeValue("emailaddress", value);
			}
		}
		
		/// <summary>
		/// Taxa de câmbio da moeda associada à equipe com relação à moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Identificador exclusivo da importação de dados ou migração de dados que criou este registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.SetAttributeValue("importsequencenumber", value);
			}
		}
		
		/// <summary>
		/// Informação que especifica se a equipe é uma equipe de unidade empresarial padrão.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdefault")]
		public System.Nullable<bool> IsDefault
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isdefault");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("issastokenset")]
		public System.Nullable<bool> IsSasTokenSet
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("issastokenset");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("membershiptype")]
		public virtual team_membershiptype? MembershipType
		{
			get
			{
				return ((team_membershiptype?)(EntityOptionSetEnum.GetEnum(this, "membershiptype")));
			}
			set
			{
				this.SetAttributeValue("membershiptype", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		/// <summary>
		/// Identificador exclusivo do usuário que modificou a equipe por último.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Data e hora da última modificação da equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Identificador exclusivo do usuário delegado que modificou a equipe pela última vez.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msft_datastate")]
		public virtual msft_datastate? msft_DataState
		{
			get
			{
				return ((msft_datastate?)(EntityOptionSetEnum.GetEnum(this, "msft_datastate")));
			}
		}
		
		/// <summary>
		/// Nome da equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.SetAttributeValue("name", value);
			}
		}
		
		/// <summary>
		/// Identificador exclusivo da organização associada à equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public System.Nullable<System.Guid> OrganizationId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid");
			}
		}
		
		/// <summary>
		/// Data e hora da migração do registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.SetAttributeValue("overriddencreatedon", value);
			}
		}
		
		/// <summary>
		/// Mostra a ID do processo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public System.Nullable<System.Guid> ProcessId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
			}
			set
			{
				this.SetAttributeValue("processid", value);
			}
		}
		
		/// <summary>
		/// Identificador exclusivo da fila padrão da equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
		public Microsoft.Xrm.Sdk.EntityReference QueueId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("queueid");
			}
			set
			{
				this.SetAttributeValue("queueid", value);
			}
		}
		
		/// <summary>
		/// opportunity_Teams
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		public Microsoft.Xrm.Sdk.EntityReference RegardingObjectId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid");
			}
			set
			{
				this.SetAttributeValue("regardingobjectid", value);
			}
		}
		
		/// <summary>
		/// Somente para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharelinkqualifier")]
		public string ShareLinkQualifier
		{
			get
			{
				return this.GetAttributeValue<string>("sharelinkqualifier");
			}
		}
		
		/// <summary>
		/// Mostra a ID do estágio.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		public System.Nullable<System.Guid> StageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			set
			{
				this.SetAttributeValue("stageid", value);
			}
		}
		
		/// <summary>
		/// Escolha se a equipe será gerenciada pelo sistema.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemmanaged")]
		public System.Nullable<bool> SystemManaged
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("systemmanaged");
			}
		}
		
		/// <summary>
		/// Identificador exclusivo da equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamid")]
		public System.Nullable<System.Guid> TeamId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("teamid");
			}
			set
			{
				this.SetAttributeValue("teamid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.TeamId = value;
			}
		}
		
		/// <summary>
		/// Mostra o modelo de equipe associado à equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamtemplateid")]
		public Microsoft.Xrm.Sdk.EntityReference TeamTemplateId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("teamtemplateid");
			}
			set
			{
				this.SetAttributeValue("teamtemplateid", value);
			}
		}
		
		/// <summary>
		/// Selecione o tipo de equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamtype")]
		public virtual team_type? TeamType
		{
			get
			{
				return ((team_type?)(EntityOptionSetEnum.GetEnum(this, "teamtype")));
			}
			set
			{
				this.SetAttributeValue("teamtype", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		/// <summary>
		/// Identificador exclusivo da moeda associada à equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			set
			{
				this.SetAttributeValue("transactioncurrencyid", value);
			}
		}
		
		/// <summary>
		/// Apenas para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			set
			{
				this.SetAttributeValue("traversedpath", value);
			}
		}
		
		/// <summary>
		/// Número da versão da equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// Pronúncia do nome completo da equipe, escrito em caracteres fonéticos hiragana ou katakana.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yominame")]
		public string YomiName
		{
			get
			{
				return this.GetAttributeValue<string>("yominame");
			}
			set
			{
				this.SetAttributeValue("yominame", value);
			}
		}
		
		
		/// <summary>
		/// N:N teammembership_association
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("teammembership_association")]
		public System.Collections.Generic.IEnumerable<project_plugins.earlybound.SystemUser> teammembership_association
		{
			get
			{
				return this.GetRelatedEntities<project_plugins.earlybound.SystemUser>("teammembership_association", null);
			}
			set
			{
				this.SetRelatedEntities<project_plugins.earlybound.SystemUser>("teammembership_association", null, value);
			}
		}
		

		/// <summary>
		/// N:1 business_unit_teams
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_teams")]
		public project_plugins.earlybound.BusinessUnit business_unit_teams
		{
			get
			{
				return this.GetRelatedEntity<project_plugins.earlybound.BusinessUnit>("business_unit_teams", null);
			}
			set
			{
				this.SetRelatedEntity<project_plugins.earlybound.BusinessUnit>("business_unit_teams", null, value);
			}
		}
		
		/// <summary>
		/// N:1 lk_team_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_team_createdonbehalfby")]
		public project_plugins.earlybound.SystemUser lk_team_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<project_plugins.earlybound.SystemUser>("lk_team_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_team_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_team_modifiedonbehalfby")]
		public project_plugins.earlybound.SystemUser lk_team_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<project_plugins.earlybound.SystemUser>("lk_team_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_teambase_administratorid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("administratorid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_administratorid")]
		public project_plugins.earlybound.SystemUser lk_teambase_administratorid
		{
			get
			{
				return this.GetRelatedEntity<project_plugins.earlybound.SystemUser>("lk_teambase_administratorid", null);
			}
			set
			{
				this.SetRelatedEntity<project_plugins.earlybound.SystemUser>("lk_teambase_administratorid", null, value);
			}
		}
		
		/// <summary>
		/// N:1 lk_teambase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_createdby")]
		public project_plugins.earlybound.SystemUser lk_teambase_createdby
		{
			get
			{
				return this.GetRelatedEntity<project_plugins.earlybound.SystemUser>("lk_teambase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_teambase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_modifiedby")]
		public project_plugins.earlybound.SystemUser lk_teambase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<project_plugins.earlybound.SystemUser>("lk_teambase_modifiedby", null);
			}
		}
		

	}
}
#pragma warning restore CS1591
