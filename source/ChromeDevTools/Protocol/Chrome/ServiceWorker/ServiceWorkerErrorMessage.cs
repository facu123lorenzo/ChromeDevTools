using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	/// <summary>
	///ServiceWorker error message.

	/// </summary>
	[SupportedBy("Chrome")]
	public class ServiceWorkerErrorMessage
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string ErrorMessage { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string RegistrationId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string VersionId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string SourceURL { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public long ColumnNumber { get; set; }
	}
}
