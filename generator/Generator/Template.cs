using Codygen.Common;

namespace StefanDeVo.MobileNumberCodeGenerator.Generator
{
    [GeneratorTemplate(Name = "Generator", Module = typeof(Generator), Description = "Generator configuration file", FileName = "Generator.codygen", IsDefault = true)]
	public class Template : Configuration
	{
		public Template()
		{

		}
	}
}