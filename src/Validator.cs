using System.Linq;

namespace MobileNumberValidator
{
	public static class MobileNumberValidator
	{
		public static MobileNumberDefinition Validate(string number)
		{
			return MobileNumberDefinitions.Definitions.Where(definition => number.StartsWith(definition.CountryCode)).FirstOrDefault(definition =>
				definition.MobileBeginWith.Select(s => definition.CountryCode + s).Where(number.StartsWith)
					.Any(start => definition.PhoneNumberLengths.Any(length => number.Length == length + definition.CountryCode.Length)));
		}
	}
}