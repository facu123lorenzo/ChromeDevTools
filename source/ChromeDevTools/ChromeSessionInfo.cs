namespace MasterDevs.ChromeDevTools
{
	/*
    public class ChromeSessionInfo
    {
        public string Description { get; set; }

        public string DevtoolsFrontendUrl { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public string WebSocketDebuggerUrl { get; set; }
    }
    */

	public class ChromeSessionInfo
	{
		public string Browser { get; set; }
		public string ProtocolVersion { get; set; }
		public string UserAgent { get; set; }
		public string V8Version { get; set; }
		public string WebKitVersion { get; set; }
		public string WebSocketDebuggerUrl { get; set; }
	}
}