using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	[SupportedBy("Chrome")]
	public class LowTextContrastIssueDetails
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public long ViolatingNodeId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string ViolatingNodeSelector { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public double ContrastRatio { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public double ThresholdAA { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public double ThresholdAAA { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string FontSize { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string FontWeight { get; set; }
	}
}
