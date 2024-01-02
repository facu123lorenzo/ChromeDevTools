using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	///Definition of PermissionDescriptor defined in the Permissions API:
	/// https://w3c.github.io/permissions/#dom-permissiondescriptor.

	/// </summary>
	[SupportedBy("Chrome")]
	public class PermissionDescriptor
	{
		/// <summary>
		/// Gets or setsName of permission.
		/// See https://cs.chromium.org/chromium/src/third_party/blink/renderer/modules/permissions/permission_descriptor.idl for valid permission names.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsFor "midi" permission, may also specify sysex control.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Sysex { get; set; }
		/// <summary>
		/// Gets or setsFor "push" permission, may specify userVisibleOnly.
		/// Note that userVisibleOnly = true is the only currently supported type.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? UserVisibleOnly { get; set; }
		/// <summary>
		/// Gets or setsFor "clipboard" permission, may specify allowWithoutSanitization.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? AllowWithoutSanitization { get; set; }
		/// <summary>
		/// Gets or setsFor "camera" permission, may specify panTiltZoom.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? PanTiltZoom { get; set; }
	}
}
