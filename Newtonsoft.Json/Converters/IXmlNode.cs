using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001C8 RID: 456
	[Token(Token = "0x20001C8")]
	[NullableContext(2)]
	internal interface IXmlNode
	{
		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000F46 RID: 3910
		[Token(Token = "0x17000271")]
		XmlNodeType NodeType { [Token(Token = "0x6000F46")] get; }

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000F47 RID: 3911
		[Token(Token = "0x17000272")]
		string LocalName { [Token(Token = "0x6000F47")] get; }

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000F48 RID: 3912
		[Token(Token = "0x17000273")]
		[Nullable(1)]
		List<IXmlNode> ChildNodes { [Token(Token = "0x6000F48")] [NullableContext(1)] get; }

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000F49 RID: 3913
		[Token(Token = "0x17000274")]
		[Nullable(1)]
		List<IXmlNode> Attributes { [Token(Token = "0x6000F49")] [NullableContext(1)] get; }

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000F4A RID: 3914
		[Token(Token = "0x17000275")]
		IXmlNode ParentNode { [Token(Token = "0x6000F4A")] get; }

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000F4B RID: 3915
		// (set) Token: 0x06000F4C RID: 3916
		[Token(Token = "0x17000276")]
		string Value { [Token(Token = "0x6000F4B")] get; [Token(Token = "0x6000F4C")] set; }

		// Token: 0x06000F4D RID: 3917
		[Token(Token = "0x6000F4D")]
		[NullableContext(1)]
		IXmlNode AppendChild(IXmlNode newChild);

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000F4E RID: 3918
		[Token(Token = "0x17000277")]
		string NamespaceUri { [Token(Token = "0x6000F4E")] get; }

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000F4F RID: 3919
		[Token(Token = "0x17000278")]
		object WrappedNode { [Token(Token = "0x6000F4F")] get; }
	}
}
