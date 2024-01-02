using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Autofill
{
	[SupportedBy("Chrome")]
	public class FilledField
	{
		/// <summary>
		/// Gets or setsThe type of the field, e.g text, password etc.

		/// </summary>
		public string HtmlType { get; set; }
		/// <summary>
		/// Gets or setsthe html id

		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or setsthe html name

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsthe field value

		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Gets or setsThe actual field type, e.g FAMILY_NAME

		/// </summary>
		public string AutofillType { get; set; }
		/// <summary>
		/// Gets or setsThe filling strategy

		/// </summary>
		public FillingStrategy FillingStrategy { get; set; }
		/// <summary>
		/// Gets or setsThe form field's DOM node

		/// </summary>
		public long FieldId { get; set; }
	}
}
