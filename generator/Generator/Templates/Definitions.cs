using System.Collections.Generic;

namespace MobileNumberValidator
{
	internal static class MobileNumberDefinitions
	{
		public static List<MobileNumberDefinition> Definitions { get; } = new List<MobileNumberDefinition>();

		static MobileNumberDefinitions()
		{
			{{#each Definitions}}
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "{{ alpha2 }}",
					Alpha3 = "{{ alpha3 }}",
					CountryCode = "{{ country_code }}",
					CountryName = "{{ country_name }}",
					MobileBeginWith = {{{ MobileBeginWithString}}}, 
					PhoneNumberLengths =  {{{ PhoneNumberLengthsString }}}
				});
			{{/each}}
		}
	}
			
	public class MobileNumberDefinition
	{
		public string Alpha2 { get; set; }
		public string Alpha3 { get; set; }
		public string CountryCode { get; set; }
		public string CountryName { get; set; }
		public string[] MobileBeginWith { get; set; }
		public int[] PhoneNumberLengths { get; set; }
	}
}