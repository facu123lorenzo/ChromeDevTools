using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	/// <summary>
	///ServiceWorker registration.

	/// </summary>
	[SupportedBy("Chrome")]
	public class ServiceWorkerRegistration
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string RegistrationId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string ScopeURL { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool IsDeleted { get; set; }
	}
}
