using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Media
{
	/// <summary>
	///Corresponds to kMediaError

	/// </summary>
	[SupportedBy("Chrome")]
	public class PlayerError
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string ErrorType { get; set; }
		/// <summary>
		/// Gets or setsCode is the numeric enum entry for a specific set of error codes, such
		/// as PipelineStatusCodes in media/base/pipeline_status.h

		/// </summary>
		public long Code { get; set; }
		/// <summary>
		/// Gets or setsA trace of where this error was caused / where it passed through.

		/// </summary>
		public PlayerErrorSourceLocation[] Stack { get; set; }
		/// <summary>
		/// Gets or setsErrors potentially have a root cause error, ie, a DecoderError might be
		/// caused by an WindowsError

		/// </summary>
		public PlayerError[] Cause { get; set; }
		/// <summary>
		/// Gets or setsExtra data attached to an error, such as an HRESULT, Video Codec, etc.

		/// </summary>
		public object Data { get; set; }
	}
}
