using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Print page as PDF.

	/// </summary>
	[Command(ProtocolName.Page.PrintToPDF)]
	[SupportedBy("Chrome")]
	public class PrintToPDFCommand: ICommand<PrintToPDFCommandResponse>
	{
		/// <summary>
		/// Gets or setsPaper orientation. Defaults to false.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Landscape { get; set; }
		/// <summary>
		/// Gets or setsDisplay header and footer. Defaults to false.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? DisplayHeaderFooter { get; set; }
		/// <summary>
		/// Gets or setsPrint background graphics. Defaults to false.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? PrintBackground { get; set; }
		/// <summary>
		/// Gets or setsScale of the webpage rendering. Defaults to 1.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Scale { get; set; }
		/// <summary>
		/// Gets or setsPaper width in inches. Defaults to 8.5 inches.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double PaperWidth { get; set; }
		/// <summary>
		/// Gets or setsPaper height in inches. Defaults to 11 inches.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double PaperHeight { get; set; }
		/// <summary>
		/// Gets or setsTop margin in inches. Defaults to 1cm (~0.4 inches).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double MarginTop { get; set; }
		/// <summary>
		/// Gets or setsBottom margin in inches. Defaults to 1cm (~0.4 inches).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double MarginBottom { get; set; }
		/// <summary>
		/// Gets or setsLeft margin in inches. Defaults to 1cm (~0.4 inches).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double MarginLeft { get; set; }
		/// <summary>
		/// Gets or setsRight margin in inches. Defaults to 1cm (~0.4 inches).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double MarginRight { get; set; }
		/// <summary>
		/// Gets or setsPaper ranges to print, one based, e.g., '1-5, 8, 11-13'. Pages are
		/// printed in the document order, not in the order specified, and no
		/// more than once.
		/// Defaults to empty string, which implies the entire document is printed.
		/// The page numbers are quietly capped to actual page count of the
		/// document, and ranges beyond the end of the document are ignored.
		/// If this results in no pages to print, an error is reported.
		/// It is an error to specify a range with start greater than end.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PageRanges { get; set; }
		/// <summary>
		/// Gets or setsHTML template for the print header. Should be valid HTML markup with following
		/// classes used to inject printing values into them:
		/// - `date`: formatted print date
		/// - `title`: document title
		/// - `url`: document location
		/// - `pageNumber`: current page number
		/// - `totalPages`: total pages in the document
		/// 
		/// For example, `<span class=title></span>` would generate span containing the title.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string HeaderTemplate { get; set; }
		/// <summary>
		/// Gets or setsHTML template for the print footer. Should use the same format as the `headerTemplate`.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FooterTemplate { get; set; }
		/// <summary>
		/// Gets or setsWhether or not to prefer page size as defined by css. Defaults to false,
		/// in which case the content will be scaled to fit the paper size.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? PreferCSSPageSize { get; set; }
		/// <summary>
		/// Gets or setsreturn as stream

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TransferMode { get; set; }
		/// <summary>
		/// Gets or setsWhether or not to generate tagged (accessible) PDF. Defaults to embedder choice.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? GenerateTaggedPDF { get; set; }
		/// <summary>
		/// Gets or setsWhether or not to embed the document outline into the PDF.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? GenerateDocumentOutline { get; set; }
	}
}
