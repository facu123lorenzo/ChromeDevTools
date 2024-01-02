using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Navigates current page to the given URL.

	/// </summary>
	[Command(ProtocolName.Page.Navigate)]
	[SupportedBy("Chrome")]
	public class NavigateCommand: ICommand<NavigateCommandResponse>
	{
		/// <summary>
		/// Gets or setsURL to navigate the page to.

		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsReferrer URL.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Referrer { get; set; }
		/// <summary>
		/// Gets or setsIntended transition type.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TransitionType { get; set; }
		/// <summary>
		/// Gets or setsFrame id to navigate, if not specified navigates the top frame.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or setsReferrer-policy used for the navigation.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ReferrerPolicy { get; set; }
	}
}
