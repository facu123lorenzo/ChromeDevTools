using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	///Capture a snapshot of the page within the specified rectangle and coordinate system.

	/// </summary>
	[Command(ProtocolName.Page.SnapshotRect)]
	[SupportedBy("iOS")]
	public class SnapshotRectCommand: ICommand<SnapshotRectCommandResponse>
	{
		/// <summary>
		/// Gets or setsX coordinate

		/// </summary>
		public long X { get; set; }
		/// <summary>
		/// Gets or setsY coordinate

		/// </summary>
		public long Y { get; set; }
		/// <summary>
		/// Gets or setsRectangle width

		/// </summary>
		public long Width { get; set; }
		/// <summary>
		/// Gets or setsRectangle height

		/// </summary>
		public long Height { get; set; }
		/// <summary>
		/// Gets or setsIndicates the coordinate system of the supplied rectangle.

		/// </summary>
		public string CoordinateSystem { get; set; }
	}
}
