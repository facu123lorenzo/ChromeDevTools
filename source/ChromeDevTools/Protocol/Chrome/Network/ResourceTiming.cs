using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Timing information for the request.

	/// </summary>
	[SupportedBy("Chrome")]
	public class ResourceTiming
	{
		/// <summary>
		/// Gets or setsTiming's requestTime is a baseline in seconds, while the other numbers are ticks in
		/// milliseconds relatively to this requestTime.

		/// </summary>
		public double RequestTime { get; set; }
		/// <summary>
		/// Gets or setsStarted resolving proxy.

		/// </summary>
		public double ProxyStart { get; set; }
		/// <summary>
		/// Gets or setsFinished resolving proxy.

		/// </summary>
		public double ProxyEnd { get; set; }
		/// <summary>
		/// Gets or setsStarted DNS address resolve.

		/// </summary>
		public double DnsStart { get; set; }
		/// <summary>
		/// Gets or setsFinished DNS address resolve.

		/// </summary>
		public double DnsEnd { get; set; }
		/// <summary>
		/// Gets or setsStarted connecting to the remote host.

		/// </summary>
		public double ConnectStart { get; set; }
		/// <summary>
		/// Gets or setsConnected to the remote host.

		/// </summary>
		public double ConnectEnd { get; set; }
		/// <summary>
		/// Gets or setsStarted SSL handshake.

		/// </summary>
		public double SslStart { get; set; }
		/// <summary>
		/// Gets or setsFinished SSL handshake.

		/// </summary>
		public double SslEnd { get; set; }
		/// <summary>
		/// Gets or setsStarted running ServiceWorker.

		/// </summary>
		public double WorkerStart { get; set; }
		/// <summary>
		/// Gets or setsFinished Starting ServiceWorker.

		/// </summary>
		public double WorkerReady { get; set; }
		/// <summary>
		/// Gets or setsStarted fetch event.

		/// </summary>
		public double WorkerFetchStart { get; set; }
		/// <summary>
		/// Gets or setsSettled fetch event respondWith promise.

		/// </summary>
		public double WorkerRespondWithSettled { get; set; }
		/// <summary>
		/// Gets or setsStarted sending request.

		/// </summary>
		public double SendStart { get; set; }
		/// <summary>
		/// Gets or setsFinished sending request.

		/// </summary>
		public double SendEnd { get; set; }
		/// <summary>
		/// Gets or setsTime the server started pushing request.

		/// </summary>
		public double PushStart { get; set; }
		/// <summary>
		/// Gets or setsTime the server finished pushing request.

		/// </summary>
		public double PushEnd { get; set; }
		/// <summary>
		/// Gets or setsStarted receiving response headers.

		/// </summary>
		public double ReceiveHeadersStart { get; set; }
		/// <summary>
		/// Gets or setsFinished receiving response headers.

		/// </summary>
		public double ReceiveHeadersEnd { get; set; }
	}
}
