using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[SupportedBy("Chrome")]
	public class BackForwardCacheNotRestoredExplanationTree
	{
		/// <summary>
		/// Gets or setsURL of each frame

		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsNot restored reasons of each frame

		/// </summary>
		public BackForwardCacheNotRestoredExplanation[] Explanations { get; set; }
		/// <summary>
		/// Gets or setsArray of children frame

		/// </summary>
		public BackForwardCacheNotRestoredExplanationTree[] Children { get; set; }
	}
}
