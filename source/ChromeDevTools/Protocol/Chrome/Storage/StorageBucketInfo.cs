using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	[SupportedBy("Chrome")]
	public class StorageBucketInfo
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public StorageBucket Bucket { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public double Expiration { get; set; }
		/// <summary>
		/// Gets or setsStorage quota (bytes).

		/// </summary>
		public double Quota { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool Persistent { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public StorageBucketsDurability Durability { get; set; }
	}
}
