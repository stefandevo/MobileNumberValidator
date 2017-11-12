using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using Codygen.Common;
using Codygen.Common.Diagnostics;
using Codygen.Common.Handlebars;
using Codygen.Common.IO;
using Newtonsoft.Json;

namespace StefanDeVo.MobileNumberCodeGenerator.Generator
{
	[Generator(Name = "Generator", IsDefault = true)]
	public class Generator : Generator<Configuration>
	{
		public override bool Execute()
		{
			var contents = new HttpClient().GetStringAsync("https://raw.githubusercontent.com/AfterShip/phone/master/lib/iso3166_data.js").Result;
			contents = contents.Substring(17, contents.Length - 19);
			var definitions = JsonConvert.DeserializeObject<List<MobileDefinition>>(contents);

			Log.Info($"Found {definitions.Count} definitions");

			Config = new Configuration()
			{
				Definitions = definitions
			};

			FluentHandlebars.Create(this)
				.HavingModel(Config)
				.UsingEmbeddedTemplate("Definitions.cs")
				.OutputFile(Path.Combine(Env.ConfigPath, $"Definitions.cs"), overwrite: true);

			return true;
		}
	}

	public class MobileDefinition
	{
		public string alpha2 { get; set; }
		public string alpha3 { get; set; }
		public string country_code { get; set; }
		public string country_name { get; set; }
		public string[] mobile_begin_with { get; set; }
		public int[] phone_number_lengths { get; set; }

		public string MobileBeginWithString
		{
			get
			{
				var result = "new[] {";

				var mobileBeginWith = new List<string>(mobile_begin_with);
				if(mobileBeginWith.Count == 0)
					mobileBeginWith.Add("");
				
				foreach (var s in mobileBeginWith)
				{
					result += "\"" + s + "\", ";
				}

				result = result.Substring(0, result.Length - 2) + "}";
				return result;
			}
		}

		public string PhoneNumberLengthsString
		{
			get
			{
				var result = "new[] {";
				foreach (var s in phone_number_lengths)
				{
					result += s + ", ";
				}

				result = result.Substring(0, result.Length - 2) + "}";
				return result;
			}
		}
	}
}