using System.Collections.Generic;

namespace MobileNumberValidator
{
	internal static class MobileNumberDefinitions
	{
		public static List<MobileNumberDefinition> Definitions { get; } = new List<MobileNumberDefinition>();

		static MobileNumberDefinitions()
		{
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "US",
					Alpha3 = "USA",
					CountryCode = "1",
					CountryName = "United States",
					MobileBeginWith = new[] {"201", "202", "203", "205", "206", "207", "208", "209", "210", "212", "213", "214", "215", "216", "217", "218", "219", "224", "225", "227", "228", "229", "231", "234", "239", "240", "248", "251", "252", "253", "254", "256", "260", "262", "267", "269", "270", "272", "274", "276", "278", "281", "283", "301", "302", "303", "304", "305", "307", "308", "309", "310", "312", "313", "314", "315", "316", "317", "318", "319", "320", "321", "323", "325", "327", "330", "331", "334", "336", "337", "339", "341", "346", "347", "351", "352", "360", "361", "364", "369", "380", "385", "386", "401", "402", "404", "405", "406", "407", "408", "409", "410", "412", "413", "414", "415", "417", "419", "423", "424", "425", "430", "432", "434", "435", "440", "442", "443", "445", "447", "458", "464", "469", "470", "475", "478", "479", "480", "484", "501", "502", "503", "504", "505", "507", "508", "509", "510", "512", "513", "515", "516", "517", "518", "520", "530", "531", "534", "539", "540", "541", "551", "557", "559", "561", "562", "563", "564", "567", "570", "571", "573", "574", "575", "580", "582", "585", "586", "601", "602", "603", "605", "606", "607", "608", "609", "610", "612", "614", "615", "616", "617", "618", "619", "620", "623", "626", "627", "628", "629", "630", "631", "636", "641", "646", "650", "651", "657", "659", "660", "661", "662", "667", "669", "678", "679", "681", "682", "689", "701", "702", "703", "704", "706", "707", "708", "712", "713", "714", "715", "716", "717", "718", "719", "720", "724", "725", "727", "730", "731", "732", "734", "737", "740", "747", "752", "754", "757", "760", "762", "763", "764", "765", "769", "770", "772", "773", "774", "775", "779", "781", "785", "786", "801", "802", "803", "804", "805", "806", "808", "810", "812", "813", "814", "815", "816", "817", "818", "828", "830", "831", "832", "835", "843", "845", "847", "848", "850", "854", "856", "857", "858", "859", "860", "862", "863", "864", "865", "870", "872", "878", "901", "903", "904", "906", "907", "908", "909", "910", "912", "913", "914", "915", "916", "917", "918", "919", "920", "925", "927", "928", "929", "931", "934", "935", "936", "937", "938", "940", "941", "947", "949", "951", "952", "954", "956", "957", "959", "970", "971", "972", "973", "975", "978", "979", "980", "984", "985", "989"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "AW",
					Alpha3 = "ABW",
					CountryCode = "297",
					CountryName = "Aruba",
					MobileBeginWith = new[] {"5", "6", "7", "9"}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "AF",
					Alpha3 = "AFG",
					CountryCode = "93",
					CountryName = "Afghanistan",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "AO",
					Alpha3 = "AGO",
					CountryCode = "244",
					CountryName = "Angola",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "AI",
					Alpha3 = "AIA",
					CountryCode = "1",
					CountryName = "Anguilla",
					MobileBeginWith = new[] {"2645", "2647"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "AX",
					Alpha3 = "ALA",
					CountryCode = "358",
					CountryName = "&#197;land Islands",
					MobileBeginWith = new[] {"18"}, 
					PhoneNumberLengths =  new[] {6, 7, 8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "AL",
					Alpha3 = "ALB",
					CountryCode = "355",
					CountryName = "Albania",
					MobileBeginWith = new[] {"6"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "AD",
					Alpha3 = "AND",
					CountryCode = "376",
					CountryName = "Andorra",
					MobileBeginWith = new[] {"3", "4", "6"}, 
					PhoneNumberLengths =  new[] {6}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "AE",
					Alpha3 = "ARE",
					CountryCode = "971",
					CountryName = "United Arab Emirates",
					MobileBeginWith = new[] {"5"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "AR",
					Alpha3 = "ARG",
					CountryCode = "54",
					CountryName = "Argentina",
					MobileBeginWith = new[] {""}, 
					PhoneNumberLengths =  new[] {6, 7, 8, 9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "AM",
					Alpha3 = "ARM",
					CountryCode = "374",
					CountryName = "Armenia",
					MobileBeginWith = new[] {"4", "5", "7", "9"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "AS",
					Alpha3 = "ASM",
					CountryCode = "1",
					CountryName = "American Samoa",
					MobileBeginWith = new[] {"684733", "684258"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "AG",
					Alpha3 = "ATG",
					CountryCode = "1",
					CountryName = "Antigua and Barbuda",
					MobileBeginWith = new[] {"2687"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "AU",
					Alpha3 = "AUS",
					CountryCode = "61",
					CountryName = "Australia",
					MobileBeginWith = new[] {"4"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "AT",
					Alpha3 = "AUT",
					CountryCode = "43",
					CountryName = "Austria",
					MobileBeginWith = new[] {"6"}, 
					PhoneNumberLengths =  new[] {10, 11, 12, 13, 14}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "AZ",
					Alpha3 = "AZE",
					CountryCode = "994",
					CountryName = "Azerbaijan",
					MobileBeginWith = new[] {"4", "5", "6", "7"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "BI",
					Alpha3 = "BDI",
					CountryCode = "257",
					CountryName = "Burundi",
					MobileBeginWith = new[] {"7", "29"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "BE",
					Alpha3 = "BEL",
					CountryCode = "32",
					CountryName = "Belgium",
					MobileBeginWith = new[] {"4"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "BJ",
					Alpha3 = "BEN",
					CountryCode = "229",
					CountryName = "Benin",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "BF",
					Alpha3 = "BFA",
					CountryCode = "226",
					CountryName = "Burkina Faso",
					MobileBeginWith = new[] {"6", "7"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "BD",
					Alpha3 = "BGD",
					CountryCode = "880",
					CountryName = "Bangladesh",
					MobileBeginWith = new[] {"1"}, 
					PhoneNumberLengths =  new[] {8, 9, 10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "BG",
					Alpha3 = "BGR",
					CountryCode = "359",
					CountryName = "Bulgaria",
					MobileBeginWith = new[] {"87", "88", "89", "98", "99", "43"}, 
					PhoneNumberLengths =  new[] {8, 9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "BH",
					Alpha3 = "BHR",
					CountryCode = "973",
					CountryName = "Bahrain",
					MobileBeginWith = new[] {"3"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "BS",
					Alpha3 = "BHS",
					CountryCode = "1",
					CountryName = "Bahamas",
					MobileBeginWith = new[] {"242"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "BA",
					Alpha3 = "BIH",
					CountryCode = "387",
					CountryName = "Bosnia and Herzegovina",
					MobileBeginWith = new[] {"6"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "BY",
					Alpha3 = "BLR",
					CountryCode = "375",
					CountryName = "Belarus",
					MobileBeginWith = new[] {"25", "29", "33", "44"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "BZ",
					Alpha3 = "BLZ",
					CountryCode = "501",
					CountryName = "Belize",
					MobileBeginWith = new[] {"6"}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "BM",
					Alpha3 = "BMU",
					CountryCode = "1",
					CountryName = "Bermuda",
					MobileBeginWith = new[] {"4413", "4415", "4417"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "BO",
					Alpha3 = "BOL",
					CountryCode = "591",
					CountryName = "Bolivia",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "BR",
					Alpha3 = "BRA",
					CountryCode = "55",
					CountryName = "Brazil",
					MobileBeginWith = new[] {"119", "129", "139", "149", "159", "169", "179", "189", "199", "219", "229", "249", "279", "289", "31", "32", "34", "38", "41", "43", "44", "45", "47", "48", "51", "53", "54", "55", "61", "62", "65", "67", "68", "69", "71", "73", "74", "75", "77", "79", "81", "82", "83", "84", "85", "86", "91", "92", "95", "96", "98"}, 
					PhoneNumberLengths =  new[] {10, 11}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "BB",
					Alpha3 = "BRB",
					CountryCode = "1",
					CountryName = "Barbados",
					MobileBeginWith = new[] {"246"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "BN",
					Alpha3 = "BRN",
					CountryCode = "673",
					CountryName = "Brunei Darussalam",
					MobileBeginWith = new[] {"7", "8"}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "BT",
					Alpha3 = "BTN",
					CountryCode = "975",
					CountryName = "Bhutan",
					MobileBeginWith = new[] {"17"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "BW",
					Alpha3 = "BWA",
					CountryCode = "267",
					CountryName = "Botswana",
					MobileBeginWith = new[] {"71", "72", "73", "74", "75", "76"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "CF",
					Alpha3 = "CAF",
					CountryCode = "236",
					CountryName = "Central African Republic",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "CA",
					Alpha3 = "CAN",
					CountryCode = "1",
					CountryName = "Canada",
					MobileBeginWith = new[] {"204", "226", "236", "249", "250", "289", "306", "343", "365", "403", "416", "418", "431", "437", "438", "450", "506", "514", "519", "579", "581", "587", "600", "604", "613", "639", "647", "705", "709", "778", "780", "807", "819", "867", "873", "902", "905"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "CH",
					Alpha3 = "CHE",
					CountryCode = "41",
					CountryName = "Switzerland",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "CL",
					Alpha3 = "CHL",
					CountryCode = "56",
					CountryName = "Chile",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "CN",
					Alpha3 = "CHN",
					CountryCode = "86",
					CountryName = "China",
					MobileBeginWith = new[] {"13", "14", "15", "17", "18"}, 
					PhoneNumberLengths =  new[] {11}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "CI",
					Alpha3 = "CIV",
					CountryCode = "225",
					CountryName = "C&#244;te D'Ivoire",
					MobileBeginWith = new[] {"0", "4", "5", "6"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "CM",
					Alpha3 = "CMR",
					CountryCode = "237",
					CountryName = "Cameroon",
					MobileBeginWith = new[] {"7", "9"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "CD",
					Alpha3 = "COD",
					CountryCode = "243",
					CountryName = "Congo, The Democratic Republic Of The",
					MobileBeginWith = new[] {"8", "9"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "CG",
					Alpha3 = "COG",
					CountryCode = "242",
					CountryName = "Congo",
					MobileBeginWith = new[] {"0"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "CK",
					Alpha3 = "COK",
					CountryCode = "682",
					CountryName = "Cook Islands",
					MobileBeginWith = new[] {"5", "7"}, 
					PhoneNumberLengths =  new[] {5}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "CO",
					Alpha3 = "COL",
					CountryCode = "57",
					CountryName = "Colombia",
					MobileBeginWith = new[] {"3"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "KM",
					Alpha3 = "COM",
					CountryCode = "269",
					CountryName = "Comoros",
					MobileBeginWith = new[] {"3", "76"}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "CV",
					Alpha3 = "CPV",
					CountryCode = "238",
					CountryName = "Cape Verde",
					MobileBeginWith = new[] {"5", "9"}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "CR",
					Alpha3 = "CRI",
					CountryCode = "506",
					CountryName = "Costa Rica",
					MobileBeginWith = new[] {"5", "6", "7", "8"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "CU",
					Alpha3 = "CUB",
					CountryCode = "53",
					CountryName = "Cuba",
					MobileBeginWith = new[] {"5"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "KY",
					Alpha3 = "CYM",
					CountryCode = "1",
					CountryName = "Cayman Islands",
					MobileBeginWith = new[] {"345"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "CY",
					Alpha3 = "CYP",
					CountryCode = "357",
					CountryName = "Cyprus",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "CZ",
					Alpha3 = "CZE",
					CountryCode = "420",
					CountryName = "Czech Republic",
					MobileBeginWith = new[] {"6", "7"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "DE",
					Alpha3 = "DEU",
					CountryCode = "49",
					CountryName = "Germany",
					MobileBeginWith = new[] {"15", "16", "17"}, 
					PhoneNumberLengths =  new[] {10, 11}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "DJ",
					Alpha3 = "DJI",
					CountryCode = "253",
					CountryName = "Djibouti",
					MobileBeginWith = new[] {"77"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "DM",
					Alpha3 = "DMA",
					CountryCode = "1",
					CountryName = "Dominica",
					MobileBeginWith = new[] {"767"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "DK",
					Alpha3 = "DNK",
					CountryCode = "45",
					CountryName = "Denmark",
					MobileBeginWith = new[] {"2", "30", "31", "40", "41", "42", "50", "51", "52", "53", "60", "61", "71", "81", "91", "92", "93"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "DO",
					Alpha3 = "DOM",
					CountryCode = "1",
					CountryName = "Dominican Republic",
					MobileBeginWith = new[] {"809", "829", "849"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "DZ",
					Alpha3 = "DZA",
					CountryCode = "213",
					CountryName = "Algeria",
					MobileBeginWith = new[] {"5", "6", "7"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "EC",
					Alpha3 = "ECU",
					CountryCode = "593",
					CountryName = "Ecuador",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "EG",
					Alpha3 = "EGY",
					CountryCode = "20",
					CountryName = "Egypt",
					MobileBeginWith = new[] {"1"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "ER",
					Alpha3 = "ERI",
					CountryCode = "291",
					CountryName = "Eritrea",
					MobileBeginWith = new[] {"1", "7", "8"}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "ES",
					Alpha3 = "ESP",
					CountryCode = "34",
					CountryName = "Spain",
					MobileBeginWith = new[] {"6", "7"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "EE",
					Alpha3 = "EST",
					CountryCode = "372",
					CountryName = "Estonia",
					MobileBeginWith = new[] {"5", "81", "82", "83"}, 
					PhoneNumberLengths =  new[] {7, 8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "ET",
					Alpha3 = "ETH",
					CountryCode = "251",
					CountryName = "Ethiopia",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "FI",
					Alpha3 = "FIN",
					CountryCode = "358",
					CountryName = "Finland",
					MobileBeginWith = new[] {"4", "5"}, 
					PhoneNumberLengths =  new[] {9, 10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "FJ",
					Alpha3 = "FJI",
					CountryCode = "679",
					CountryName = "Fiji",
					MobileBeginWith = new[] {"7", "9"}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "FK",
					Alpha3 = "FLK",
					CountryCode = "500",
					CountryName = "Falkland Islands (Malvinas)",
					MobileBeginWith = new[] {"5", "6"}, 
					PhoneNumberLengths =  new[] {5}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "FR",
					Alpha3 = "FRA",
					CountryCode = "33",
					CountryName = "France",
					MobileBeginWith = new[] {"6", "7"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "FO",
					Alpha3 = "FRO",
					CountryCode = "298",
					CountryName = "Faroe Islands",
					MobileBeginWith = new[] {""}, 
					PhoneNumberLengths =  new[] {6}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "FM",
					Alpha3 = "FSM",
					CountryCode = "691",
					CountryName = "Micronesia, Federated States Of",
					MobileBeginWith = new[] {""}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "GA",
					Alpha3 = "GAB",
					CountryCode = "241",
					CountryName = "Gabon",
					MobileBeginWith = new[] {"05", "06", "07"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "GB",
					Alpha3 = "GBR",
					CountryCode = "44",
					CountryName = "United Kingdom",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "GE",
					Alpha3 = "GEO",
					CountryCode = "995",
					CountryName = "Georgia",
					MobileBeginWith = new[] {"5", "7"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "GH",
					Alpha3 = "GHA",
					CountryCode = "233",
					CountryName = "Ghana",
					MobileBeginWith = new[] {"2", "5"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "GI",
					Alpha3 = "GIB",
					CountryCode = "350",
					CountryName = "Gibraltar",
					MobileBeginWith = new[] {"5"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "GN",
					Alpha3 = "GIN",
					CountryCode = "224",
					CountryName = "Guinea",
					MobileBeginWith = new[] {"6"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "GP",
					Alpha3 = "GLP",
					CountryCode = "590",
					CountryName = "Guadeloupe",
					MobileBeginWith = new[] {"690"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "GM",
					Alpha3 = "GMB",
					CountryCode = "220",
					CountryName = "Gambia",
					MobileBeginWith = new[] {"7", "9"}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "GW",
					Alpha3 = "GNB",
					CountryCode = "245",
					CountryName = "Guinea-Bissau",
					MobileBeginWith = new[] {"5", "6", "7"}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "GQ",
					Alpha3 = "GNQ",
					CountryCode = "240",
					CountryName = "Equatorial Guinea",
					MobileBeginWith = new[] {"222", "551"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "GR",
					Alpha3 = "GRC",
					CountryCode = "30",
					CountryName = "Greece",
					MobileBeginWith = new[] {"6"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "GD",
					Alpha3 = "GRD",
					CountryCode = "1",
					CountryName = "Grenada",
					MobileBeginWith = new[] {"473"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "GL",
					Alpha3 = "GRL",
					CountryCode = "299",
					CountryName = "Greenland",
					MobileBeginWith = new[] {"4", "5"}, 
					PhoneNumberLengths =  new[] {6}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "GT",
					Alpha3 = "GTM",
					CountryCode = "502",
					CountryName = "Guatemala",
					MobileBeginWith = new[] {"3", "4", "5"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "GF",
					Alpha3 = "GUF",
					CountryCode = "594",
					CountryName = "French Guiana",
					MobileBeginWith = new[] {"694"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "GU",
					Alpha3 = "GUM",
					CountryCode = "1",
					CountryName = "Guam",
					MobileBeginWith = new[] {"671"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "GY",
					Alpha3 = "GUY",
					CountryCode = "592",
					CountryName = "Guyana",
					MobileBeginWith = new[] {"6"}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "HK",
					Alpha3 = "HKG",
					CountryCode = "852",
					CountryName = "Hong Kong",
					MobileBeginWith = new[] {"5", "6", "9"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "HN",
					Alpha3 = "HND",
					CountryCode = "504",
					CountryName = "Honduras",
					MobileBeginWith = new[] {"3", "7", "8", "9"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "HR",
					Alpha3 = "HRV",
					CountryCode = "385",
					CountryName = "Croatia",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {8, 9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "HT",
					Alpha3 = "HTI",
					CountryCode = "509",
					CountryName = "Haiti",
					MobileBeginWith = new[] {"3", "4"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "HU",
					Alpha3 = "HUN",
					CountryCode = "36",
					CountryName = "Hungary",
					MobileBeginWith = new[] {"20", "30", "31", "70"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "ID",
					Alpha3 = "IDN",
					CountryCode = "62",
					CountryName = "Indonesia",
					MobileBeginWith = new[] {"8"}, 
					PhoneNumberLengths =  new[] {9, 10, 11, 12}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "IN",
					Alpha3 = "IND",
					CountryCode = "91",
					CountryName = "India",
					MobileBeginWith = new[] {"7", "8", "9"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "IE",
					Alpha3 = "IRL",
					CountryCode = "353",
					CountryName = "Ireland",
					MobileBeginWith = new[] {"82", "83", "84", "85", "86", "87", "88", "89"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "IR",
					Alpha3 = "IRN",
					CountryCode = "98",
					CountryName = "Iran, Islamic Republic Of",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "IQ",
					Alpha3 = "IRQ",
					CountryCode = "964",
					CountryName = "Iraq",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "IS",
					Alpha3 = "ISL",
					CountryCode = "354",
					CountryName = "Iceland",
					MobileBeginWith = new[] {"6", "7", "8"}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "IL",
					Alpha3 = "ISR",
					CountryCode = "972",
					CountryName = "Israel",
					MobileBeginWith = new[] {"5"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "IT",
					Alpha3 = "ITA",
					CountryCode = "39",
					CountryName = "Italy",
					MobileBeginWith = new[] {"3"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "JM",
					Alpha3 = "JAM",
					CountryCode = "1",
					CountryName = "Jamaica",
					MobileBeginWith = new[] {"876"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "JO",
					Alpha3 = "JOR",
					CountryCode = "962",
					CountryName = "Jordan",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "JP",
					Alpha3 = "JPN",
					CountryCode = "81",
					CountryName = "Japan",
					MobileBeginWith = new[] {"70", "80", "90"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "KZ",
					Alpha3 = "KAZ",
					CountryCode = "7",
					CountryName = "Kazakhstan",
					MobileBeginWith = new[] {"70", "74", "77"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "KE",
					Alpha3 = "KEN",
					CountryCode = "254",
					CountryName = "Kenya",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "KG",
					Alpha3 = "KGZ",
					CountryCode = "996",
					CountryName = "Kyrgyzstan",
					MobileBeginWith = new[] {"5", "7"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "KH",
					Alpha3 = "KHM",
					CountryCode = "855",
					CountryName = "Cambodia",
					MobileBeginWith = new[] {"1", "6", "7", "8", "9"}, 
					PhoneNumberLengths =  new[] {8, 9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "KI",
					Alpha3 = "KIR",
					CountryCode = "686",
					CountryName = "Kiribati",
					MobileBeginWith = new[] {"9", "30"}, 
					PhoneNumberLengths =  new[] {5}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "KN",
					Alpha3 = "KNA",
					CountryCode = "1",
					CountryName = "Saint Kitts And Nevis",
					MobileBeginWith = new[] {"869"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "KR",
					Alpha3 = "KOR",
					CountryCode = "82",
					CountryName = "Korea, Republic of",
					MobileBeginWith = new[] {"1"}, 
					PhoneNumberLengths =  new[] {9, 10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "KW",
					Alpha3 = "KWT",
					CountryCode = "965",
					CountryName = "Kuwait",
					MobileBeginWith = new[] {"5", "6", "9"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "LA",
					Alpha3 = "LAO",
					CountryCode = "856",
					CountryName = "Lao People's Democratic Republic",
					MobileBeginWith = new[] {"20"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "LB",
					Alpha3 = "LBN",
					CountryCode = "961",
					CountryName = "Lebanon",
					MobileBeginWith = new[] {"3", "7"}, 
					PhoneNumberLengths =  new[] {7, 8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "LR",
					Alpha3 = "LBR",
					CountryCode = "231",
					CountryName = "Liberia",
					MobileBeginWith = new[] {"4", "5", "6", "7"}, 
					PhoneNumberLengths =  new[] {7, 8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "LY",
					Alpha3 = "LBY",
					CountryCode = "218",
					CountryName = "Libyan Arab Jamahiriya",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "LC",
					Alpha3 = "LCA",
					CountryCode = "1",
					CountryName = "Saint Lucia",
					MobileBeginWith = new[] {"758"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "LI",
					Alpha3 = "LIE",
					CountryCode = "423",
					CountryName = "Liechtenstein",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "LK",
					Alpha3 = "LKA",
					CountryCode = "94",
					CountryName = "Sri Lanka",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "LS",
					Alpha3 = "LSO",
					CountryCode = "266",
					CountryName = "Lesotho",
					MobileBeginWith = new[] {"5", "6"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "LT",
					Alpha3 = "LTU",
					CountryCode = "370",
					CountryName = "Lithuania",
					MobileBeginWith = new[] {"6"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "LU",
					Alpha3 = "LUX",
					CountryCode = "352",
					CountryName = "Luxembourg",
					MobileBeginWith = new[] {"6"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "LV",
					Alpha3 = "LVA",
					CountryCode = "371",
					CountryName = "Latvia",
					MobileBeginWith = new[] {"2"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "MO",
					Alpha3 = "MAC",
					CountryCode = "853",
					CountryName = "Macao",
					MobileBeginWith = new[] {"6"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "MA",
					Alpha3 = "MAR",
					CountryCode = "212",
					CountryName = "Morocco",
					MobileBeginWith = new[] {"6"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "MC",
					Alpha3 = "MCO",
					CountryCode = "377",
					CountryName = "Monaco",
					MobileBeginWith = new[] {"4", "6"}, 
					PhoneNumberLengths =  new[] {8, 9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "MD",
					Alpha3 = "MDA",
					CountryCode = "373",
					CountryName = "Moldova, Republic of",
					MobileBeginWith = new[] {"6", "7"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "MG",
					Alpha3 = "MDG",
					CountryCode = "261",
					CountryName = "Madagascar",
					MobileBeginWith = new[] {"3"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "MV",
					Alpha3 = "MDV",
					CountryCode = "960",
					CountryName = "Maldives",
					MobileBeginWith = new[] {"7", "9"}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "MX",
					Alpha3 = "MEX",
					CountryCode = "52",
					CountryName = "Mexico",
					MobileBeginWith = new[] {""}, 
					PhoneNumberLengths =  new[] {10, 11}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "MH",
					Alpha3 = "MHL",
					CountryCode = "692",
					CountryName = "Marshall Islands",
					MobileBeginWith = new[] {""}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "MK",
					Alpha3 = "MKD",
					CountryCode = "389",
					CountryName = "Macedonia, the Former Yugoslav Republic Of",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "ML",
					Alpha3 = "MLI",
					CountryCode = "223",
					CountryName = "Mali",
					MobileBeginWith = new[] {"6", "7"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "MT",
					Alpha3 = "MLT",
					CountryCode = "356",
					CountryName = "Malta",
					MobileBeginWith = new[] {"79", "99"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "MM",
					Alpha3 = "MMR",
					CountryCode = "95",
					CountryName = "Myanmar",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "ME",
					Alpha3 = "MNE",
					CountryCode = "382",
					CountryName = "Montenegro",
					MobileBeginWith = new[] {"6"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "MN",
					Alpha3 = "MNG",
					CountryCode = "976",
					CountryName = "Mongolia",
					MobileBeginWith = new[] {"5", "8", "9"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "MP",
					Alpha3 = "MNP",
					CountryCode = "1",
					CountryName = "Northern Mariana Islands",
					MobileBeginWith = new[] {"670"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "MZ",
					Alpha3 = "MOZ",
					CountryCode = "258",
					CountryName = "Mozambique",
					MobileBeginWith = new[] {"8"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "MR",
					Alpha3 = "MRT",
					CountryCode = "222",
					CountryName = "Mauritania",
					MobileBeginWith = new[] {""}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "MS",
					Alpha3 = "MSR",
					CountryCode = "1",
					CountryName = "Montserrat",
					MobileBeginWith = new[] {"664"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "MQ",
					Alpha3 = "MTQ",
					CountryCode = "596",
					CountryName = "Martinique",
					MobileBeginWith = new[] {"696"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "MU",
					Alpha3 = "MUS",
					CountryCode = "230",
					CountryName = "Mauritius",
					MobileBeginWith = new[] {""}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "MW",
					Alpha3 = "MWI",
					CountryCode = "265",
					CountryName = "Malawi",
					MobileBeginWith = new[] {"77", "88", "99"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "MY",
					Alpha3 = "MYS",
					CountryCode = "60",
					CountryName = "Malaysia",
					MobileBeginWith = new[] {"1"}, 
					PhoneNumberLengths =  new[] {9, 10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "YT",
					Alpha3 = "MYT",
					CountryCode = "269",
					CountryName = "Mayotte",
					MobileBeginWith = new[] {"639"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "NA",
					Alpha3 = "NAM",
					CountryCode = "264",
					CountryName = "Namibia",
					MobileBeginWith = new[] {"60", "81", "82", "85"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "NC",
					Alpha3 = "NCL",
					CountryCode = "687",
					CountryName = "New Caledonia",
					MobileBeginWith = new[] {""}, 
					PhoneNumberLengths =  new[] {6}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "NE",
					Alpha3 = "NER",
					CountryCode = "227",
					CountryName = "Niger",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "NF",
					Alpha3 = "NFK",
					CountryCode = "672",
					CountryName = "Norfolk Island",
					MobileBeginWith = new[] {"5", "8"}, 
					PhoneNumberLengths =  new[] {5}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "NG",
					Alpha3 = "NGA",
					CountryCode = "234",
					CountryName = "Nigeria",
					MobileBeginWith = new[] {"70", "80", "81"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "NI",
					Alpha3 = "NIC",
					CountryCode = "505",
					CountryName = "Nicaragua",
					MobileBeginWith = new[] {"8"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "NU",
					Alpha3 = "NIU",
					CountryCode = "683",
					CountryName = "Niue",
					MobileBeginWith = new[] {""}, 
					PhoneNumberLengths =  new[] {4}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "NL",
					Alpha3 = "NLD",
					CountryCode = "31",
					CountryName = "Netherlands",
					MobileBeginWith = new[] {"6"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "NO",
					Alpha3 = "NOR",
					CountryCode = "47",
					CountryName = "Norway",
					MobileBeginWith = new[] {"4", "9"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "NP",
					Alpha3 = "NPL",
					CountryCode = "977",
					CountryName = "Nepal",
					MobileBeginWith = new[] {"97", "98"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "NR",
					Alpha3 = "NRU",
					CountryCode = "674",
					CountryName = "Nauru",
					MobileBeginWith = new[] {"555"}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "NZ",
					Alpha3 = "NZL",
					CountryCode = "64",
					CountryName = "New Zealand",
					MobileBeginWith = new[] {"2"}, 
					PhoneNumberLengths =  new[] {8, 9, 10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "OM",
					Alpha3 = "OMN",
					CountryCode = "968",
					CountryName = "Oman",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "PK",
					Alpha3 = "PAK",
					CountryCode = "92",
					CountryName = "Pakistan",
					MobileBeginWith = new[] {"3"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "PA",
					Alpha3 = "PAN",
					CountryCode = "507",
					CountryName = "Panama",
					MobileBeginWith = new[] {"5", "6"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "PE",
					Alpha3 = "PER",
					CountryCode = "51",
					CountryName = "Peru",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "PH",
					Alpha3 = "PHL",
					CountryCode = "63",
					CountryName = "Philippines",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "PW",
					Alpha3 = "PLW",
					CountryCode = "680",
					CountryName = "Palau",
					MobileBeginWith = new[] {""}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "PG",
					Alpha3 = "PNG",
					CountryCode = "675",
					CountryName = "Papua New Guinea",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "PL",
					Alpha3 = "POL",
					CountryCode = "48",
					CountryName = "Poland",
					MobileBeginWith = new[] {"4", "5", "6", "7", "8"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "PR",
					Alpha3 = "PRI",
					CountryCode = "1",
					CountryName = "Puerto Rico",
					MobileBeginWith = new[] {"787", "939"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "PT",
					Alpha3 = "PRT",
					CountryCode = "351",
					CountryName = "Portugal",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "PY",
					Alpha3 = "PRY",
					CountryCode = "595",
					CountryName = "Paraguay",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "PS",
					Alpha3 = "PSE",
					CountryCode = "970",
					CountryName = "Palestinian Territory, Occupied",
					MobileBeginWith = new[] {"5"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "PF",
					Alpha3 = "PYF",
					CountryCode = "689",
					CountryName = "French Polynesia",
					MobileBeginWith = new[] {""}, 
					PhoneNumberLengths =  new[] {6}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "QA",
					Alpha3 = "QAT",
					CountryCode = "974",
					CountryName = "Qatar",
					MobileBeginWith = new[] {"3", "5", "6", "7"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "RE",
					Alpha3 = "REU",
					CountryCode = "262",
					CountryName = "R&#233;union",
					MobileBeginWith = new[] {"692", "693"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "RO",
					Alpha3 = "ROU",
					CountryCode = "40",
					CountryName = "Romania",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "RU",
					Alpha3 = "RUS",
					CountryCode = "7",
					CountryName = "Russian Federation",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "RW",
					Alpha3 = "RWA",
					CountryCode = "250",
					CountryName = "Rwanda",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "SA",
					Alpha3 = "SAU",
					CountryCode = "966",
					CountryName = "Saudi Arabia",
					MobileBeginWith = new[] {"5"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "SD",
					Alpha3 = "SDN",
					CountryCode = "249",
					CountryName = "Sudan",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "SN",
					Alpha3 = "SEN",
					CountryCode = "221",
					CountryName = "Senegal",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "SG",
					Alpha3 = "SGP",
					CountryCode = "65",
					CountryName = "Singapore",
					MobileBeginWith = new[] {"8", "9"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "SH",
					Alpha3 = "SHN",
					CountryCode = "290",
					CountryName = "Saint Helena",
					MobileBeginWith = new[] {""}, 
					PhoneNumberLengths =  new[] {4}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "SJ",
					Alpha3 = "SJM",
					CountryCode = "47",
					CountryName = "Svalbard And Jan Mayen",
					MobileBeginWith = new[] {""}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "SB",
					Alpha3 = "SLB",
					CountryCode = "677",
					CountryName = "Solomon Islands",
					MobileBeginWith = new[] {"7", "8"}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "SL",
					Alpha3 = "SLE",
					CountryCode = "232",
					CountryName = "Sierra Leone",
					MobileBeginWith = new[] {"21", "25", "30", "33", "34", "40", "44", "50", "55", "76", "77", "78", "79", "88"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "SV",
					Alpha3 = "SLV",
					CountryCode = "503",
					CountryName = "El Salvador",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "SM",
					Alpha3 = "SMR",
					CountryCode = "378",
					CountryName = "San Marino",
					MobileBeginWith = new[] {"3", "6"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "SO",
					Alpha3 = "SOM",
					CountryCode = "252",
					CountryName = "Somalia",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "SX",
					Alpha3 = "SXM",
					CountryCode = "1",
					CountryName = "Sint Maarten",
					MobileBeginWith = new[] {"721"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "PM",
					Alpha3 = "SPM",
					CountryCode = "508",
					CountryName = "Saint Pierre And Miquelon",
					MobileBeginWith = new[] {"55"}, 
					PhoneNumberLengths =  new[] {6}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "RS",
					Alpha3 = "SRB",
					CountryCode = "381",
					CountryName = "Serbia",
					MobileBeginWith = new[] {"6"}, 
					PhoneNumberLengths =  new[] {8, 9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "ST",
					Alpha3 = "STP",
					CountryCode = "239",
					CountryName = "Sao Tome and Principe",
					MobileBeginWith = new[] {"98", "99"}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "SR",
					Alpha3 = "SUR",
					CountryCode = "597",
					CountryName = "Suriname",
					MobileBeginWith = new[] {"6", "7", "8"}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "SK",
					Alpha3 = "SVK",
					CountryCode = "421",
					CountryName = "Slovakia",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "SI",
					Alpha3 = "SVN",
					CountryCode = "386",
					CountryName = "Slovenia",
					MobileBeginWith = new[] {"3", "4", "5", "6", "7"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "SE",
					Alpha3 = "SWE",
					CountryCode = "46",
					CountryName = "Sweden",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "SC",
					Alpha3 = "SYC",
					CountryCode = "248",
					CountryName = "Seychelles",
					MobileBeginWith = new[] {"2"}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "SY",
					Alpha3 = "SYR",
					CountryCode = "963",
					CountryName = "Syrian Arab Republic",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "TC",
					Alpha3 = "TCA",
					CountryCode = "1",
					CountryName = "Turks and Caicos Islands",
					MobileBeginWith = new[] {"6492", "6493", "6494"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "TD",
					Alpha3 = "TCD",
					CountryCode = "235",
					CountryName = "Chad",
					MobileBeginWith = new[] {"6", "7", "9"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "TG",
					Alpha3 = "TGO",
					CountryCode = "228",
					CountryName = "Togo",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "TH",
					Alpha3 = "THA",
					CountryCode = "66",
					CountryName = "Thailand",
					MobileBeginWith = new[] {"6", "8", "9"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "TJ",
					Alpha3 = "TJK",
					CountryCode = "992",
					CountryName = "Tajikistan",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "TK",
					Alpha3 = "TKL",
					CountryCode = "690",
					CountryName = "Tokelau",
					MobileBeginWith = new[] {""}, 
					PhoneNumberLengths =  new[] {4}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "TM",
					Alpha3 = "TKM",
					CountryCode = "993",
					CountryName = "Turkmenistan",
					MobileBeginWith = new[] {"6"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "TL",
					Alpha3 = "TLS",
					CountryCode = "670",
					CountryName = "Timor-Leste",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "TO",
					Alpha3 = "TON",
					CountryCode = "676",
					CountryName = "Tonga",
					MobileBeginWith = new[] {""}, 
					PhoneNumberLengths =  new[] {5}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "TT",
					Alpha3 = "TTO",
					CountryCode = "1",
					CountryName = "Trinidad and Tobago",
					MobileBeginWith = new[] {"868"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "TN",
					Alpha3 = "TUN",
					CountryCode = "216",
					CountryName = "Tunisia",
					MobileBeginWith = new[] {"2", "9"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "TR",
					Alpha3 = "TUR",
					CountryCode = "90",
					CountryName = "Turkey",
					MobileBeginWith = new[] {"5"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "TV",
					Alpha3 = "TUV",
					CountryCode = "688",
					CountryName = "Tuvalu",
					MobileBeginWith = new[] {""}, 
					PhoneNumberLengths =  new[] {5}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "TW",
					Alpha3 = "TWN",
					CountryCode = "886",
					CountryName = "Taiwan, Province Of China",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "TZ",
					Alpha3 = "TZA",
					CountryCode = "255",
					CountryName = "Tanzania, United Republic of",
					MobileBeginWith = new[] {"7", "6"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "UG",
					Alpha3 = "UGA",
					CountryCode = "256",
					CountryName = "Uganda",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "UA",
					Alpha3 = "UKR",
					CountryCode = "380",
					CountryName = "Ukraine",
					MobileBeginWith = new[] {"39", "50", "63", "66", "67", "68", "9"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "UY",
					Alpha3 = "URY",
					CountryCode = "598",
					CountryName = "Uruguay",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {8}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "UZ",
					Alpha3 = "UZB",
					CountryCode = "998",
					CountryName = "Uzbekistan",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "VC",
					Alpha3 = "VCT",
					CountryCode = "1",
					CountryName = "Saint Vincent And The Grenedines",
					MobileBeginWith = new[] {"784"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "VE",
					Alpha3 = "VEN",
					CountryCode = "58",
					CountryName = "Venezuela, Bolivarian Republic of",
					MobileBeginWith = new[] {"4"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "VG",
					Alpha3 = "VGB",
					CountryCode = "1",
					CountryName = "Virgin Islands, British",
					MobileBeginWith = new[] {"284"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "VI",
					Alpha3 = "VIR",
					CountryCode = "1",
					CountryName = "Virgin Islands, U.S.",
					MobileBeginWith = new[] {"340"}, 
					PhoneNumberLengths =  new[] {10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "VN",
					Alpha3 = "VNM",
					CountryCode = "84",
					CountryName = "Viet Nam",
					MobileBeginWith = new[] {"8", "9", "1"}, 
					PhoneNumberLengths =  new[] {9, 10}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "VU",
					Alpha3 = "VUT",
					CountryCode = "678",
					CountryName = "Vanuatu",
					MobileBeginWith = new[] {"5", "7"}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "WF",
					Alpha3 = "WLF",
					CountryCode = "681",
					CountryName = "Wallis and Futuna",
					MobileBeginWith = new[] {""}, 
					PhoneNumberLengths =  new[] {6}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "WS",
					Alpha3 = "WSM",
					CountryCode = "685",
					CountryName = "Samoa",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {7}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "YE",
					Alpha3 = "YEM",
					CountryCode = "967",
					CountryName = "Yemen",
					MobileBeginWith = new[] {"7"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "ZA",
					Alpha3 = "ZAF",
					CountryCode = "27",
					CountryName = "South Africa",
					MobileBeginWith = new[] {"6", "7", "8"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "ZM",
					Alpha3 = "ZMB",
					CountryCode = "260",
					CountryName = "Zambia",
					MobileBeginWith = new[] {"9"}, 
					PhoneNumberLengths =  new[] {9}
				});
			Definitions.Add(new MobileNumberDefinition()
				{
					Alpha2 = "ZW",
					Alpha3 = "ZWE",
					CountryCode = "263",
					CountryName = "Zimbabwe",
					MobileBeginWith = new[] {"71", "73", "77"}, 
					PhoneNumberLengths =  new[] {9}
				});
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