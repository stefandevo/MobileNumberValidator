using System.Collections.Generic;
using Codygen.Common;

namespace StefanDeVo.MobileNumberCodeGenerator.Generator
{
	public class Configuration
	{
		[Ignore]
		public List<MobileDefinition> Definitions { get; set; }
	}
}