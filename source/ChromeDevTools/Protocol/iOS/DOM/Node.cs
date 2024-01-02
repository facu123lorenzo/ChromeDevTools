using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	///DOM interaction is implemented in terms of mirror objects that represent the actual DOM nodes. DOMNode is a base node mirror type.

	/// </summary>
	[SupportedBy("iOS")]
	public class Node
	{
		/// <summary>
		/// Gets or setsNode identifier that is passed into the rest of the DOM messages as the <code>nodeId</code>. Backend will only push node with given <code>id</code> once. It is aware of all requested nodes and will only fire DOM events for nodes known to the client.

		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets<code>Node</code>'s nodeType.

		/// </summary>
		public long NodeType { get; set; }
		/// <summary>
		/// Gets or sets<code>Node</code>'s nodeName.

		/// </summary>
		public string NodeName { get; set; }
		/// <summary>
		/// Gets or sets<code>Node</code>'s localName.

		/// </summary>
		public string LocalName { get; set; }
		/// <summary>
		/// Gets or sets<code>Node</code>'s nodeValue.

		/// </summary>
		public string NodeValue { get; set; }
		/// <summary>
		/// Gets or setsChild count for <code>Container</code> nodes.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ChildNodeCount { get; set; }
		/// <summary>
		/// Gets or setsChild nodes of this node when requested with children.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Node[] Children { get; set; }
		/// <summary>
		/// Gets or setsAttributes of the <code>Element</code> node in the form of flat array <code>[name1, value1, name2, value2]</code>.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] Attributes { get; set; }
		/// <summary>
		/// Gets or setsDocument URL that <code>Document</code> or <code>FrameOwner</code> node points to.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string DocumentURL { get; set; }
		/// <summary>
		/// Gets or setsBase URL that <code>Document</code> or <code>FrameOwner</code> node uses for URL completion.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BaseURL { get; set; }
		/// <summary>
		/// Gets or sets<code>DocumentType</code>'s publicId.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PublicId { get; set; }
		/// <summary>
		/// Gets or sets<code>DocumentType</code>'s systemId.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SystemId { get; set; }
		/// <summary>
		/// Gets or sets<code>DocumentType</code>'s internalSubset.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string InternalSubset { get; set; }
		/// <summary>
		/// Gets or sets<code>Document</code>'s XML version in case of XML documents.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string XmlVersion { get; set; }
		/// <summary>
		/// Gets or sets<code>Attr</code>'s name.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets<code>Attr</code>'s value.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Value { get; set; }
		/// <summary>
		/// Gets or setsPseudo element type for this node.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public PseudoType PseudoType { get; set; }
		/// <summary>
		/// Gets or setsFrame ID for frame owner elements.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or setsContent document for frame owner elements.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Node ContentDocument { get; set; }
		/// <summary>
		/// Gets or setsShadow root list for given element host.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Node[] ShadowRoots { get; set; }
		/// <summary>
		/// Gets or setsContent document fragment for template elements

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Node TemplateContent { get; set; }
		/// <summary>
		/// Gets or setsPseudo elements associated with this node.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Node[] PseudoElements { get; set; }
		/// <summary>
		/// Gets or setsComputed value for first recognized role token, default role per element, or overridden role.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Role { get; set; }
	}
}
