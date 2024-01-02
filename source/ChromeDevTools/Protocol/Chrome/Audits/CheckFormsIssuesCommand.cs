using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	///Runs the form issues check for the target page. Found issues are reported
	/// using Audits.issueAdded event.

	/// </summary>
	[Command(ProtocolName.Audits.CheckFormsIssues)]
	[SupportedBy("Chrome")]
	public class CheckFormsIssuesCommand: ICommand<CheckFormsIssuesCommandResponse>
	{
	}
}
