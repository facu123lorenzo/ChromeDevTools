using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	///Cookie object

	/// </summary>
	[SupportedBy("iOS")]
	public class Cookie
	{
		/// <summary>
		/// Gets or setsCookie name.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsCookie value.

		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Gets or setsCookie domain.

		/// </summary>
		public string Domain { get; set; }
		/// <summary>
		/// Gets or setsCookie path.

		/// </summary>
		public string Path { get; set; }
		/// <summary>
		/// Gets or setsCookie expires.

		/// </summary>
		public double Expires { get; set; }
		/// <summary>
		/// Gets or setsCookie size.

		/// </summary>
		public long Size { get; set; }
		/// <summary>
		/// Gets or setsTrue if cookie is http-only.

		/// </summary>
		public bool HttpOnly { get; set; }
		/// <summary>
		/// Gets or setsTrue if cookie is secure.

		/// </summary>
		public bool Secure { get; set; }
		/// <summary>
		/// Gets or setsTrue in case of session cookie.

		/// </summary>
		public bool Session { get; set; }
	}
}
