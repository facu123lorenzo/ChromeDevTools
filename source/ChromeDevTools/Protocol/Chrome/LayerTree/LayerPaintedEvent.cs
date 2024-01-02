using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	[Event(ProtocolName.LayerTree.LayerPainted)]
	[SupportedBy("Chrome")]
	public class LayerPaintedEvent
	{
		/// <summary>
		/// Gets or setsThe id of the painted layer.

		/// </summary>
		public string LayerId { get; set; }
		/// <summary>
		/// Gets or setsClip rectangle.

		/// </summary>
		public DOM.Rect Clip { get; set; }
	}
}
