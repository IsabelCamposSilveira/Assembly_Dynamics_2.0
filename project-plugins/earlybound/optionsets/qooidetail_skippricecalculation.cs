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
	/// Com base nas opções em SkipPriceCalculation, o cálculo de preço OOB no nível de item de linha qooi será ignorado
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum qooidetail_skippricecalculation
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		DoPriceCalcAlways = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		SkipPriceCalcOnCreate = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		SkipPriceCalcOnUpdate = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		SkipPriceCalcOnUpSert = 3,
	}
}
#pragma warning restore CS1591
