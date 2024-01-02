using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Autofill
{
	[SupportedBy("Chrome")]
	public class CreditCard
	{
		/// <summary>
		/// Gets or sets16-digit credit card number.

		/// </summary>
		public string Number { get; set; }
		/// <summary>
		/// Gets or setsName of the credit card owner.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets2-digit expiry month.

		/// </summary>
		public string ExpiryMonth { get; set; }
		/// <summary>
		/// Gets or sets4-digit expiry year.

		/// </summary>
		public string ExpiryYear { get; set; }
		/// <summary>
		/// Gets or sets3-digit card verification code.

		/// </summary>
		public string Cvc { get; set; }
	}
}
