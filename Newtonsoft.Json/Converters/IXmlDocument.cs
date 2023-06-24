using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001C4 RID: 452
	[Token(Token = "0x20001C4")]
	[NullableContext(1)]
	internal interface IXmlDocument : IXmlNode
	{
		// Token: 0x06000F2D RID: 3885
		[Token(Token = "0x6000F2D")]
		IXmlNode CreateComment([Nullable(2)] string text);

		// Token: 0x06000F2E RID: 3886
		[Token(Token = "0x6000F2E")]
		IXmlNode CreateTextNode([Nullable(2)] string text);

		// Token: 0x06000F2F RID: 3887
		[Token(Token = "0x6000F2F")]
		IXmlNode CreateCDataSection([Nullable(2)] string data);

		// Token: 0x06000F30 RID: 3888
		[Token(Token = "0x6000F30")]
		IXmlNode CreateWhitespace([Nullable(2)] string text);

		// Token: 0x06000F31 RID: 3889
		[Token(Token = "0x6000F31")]
		IXmlNode CreateSignificantWhitespace([Nullable(2)] string text);

		// Token: 0x06000F32 RID: 3890
		[Token(Token = "0x6000F32")]
		IXmlNode CreateXmlDeclaration(string version, [Nullable(2)] string encoding, [Nullable(2)] string standalone);

		// Token: 0x06000F33 RID: 3891
		[Token(Token = "0x6000F33")]
		[NullableContext(2)]
		IXmlNode CreateXmlDocumentType([Nullable(1)] string name, string publicId, string systemId, string internalSubset);

		// Token: 0x06000F34 RID: 3892
		[Token(Token = "0x6000F34")]
		IXmlNode CreateProcessingInstruction(string target, string data);

		// Token: 0x06000F35 RID: 3893
		[Token(Token = "0x6000F35")]
		IXmlElement CreateElement(string elementName);

		// Token: 0x06000F36 RID: 3894
		[Token(Token = "0x6000F36")]
		IXmlElement CreateElement(string qualifiedName, string namespaceUri);

		// Token: 0x06000F37 RID: 3895
		[Token(Token = "0x6000F37")]
		IXmlNode CreateAttribute(string name, string value);

		// Token: 0x06000F38 RID: 3896
		[Token(Token = "0x6000F38")]
		IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000F39 RID: 3897
		[Token(Token = "0x17000268")]
		[Nullable(2)]
		IXmlElement DocumentElement { [Token(Token = "0x6000F39")] [NullableContext(2)] get; }
	}
}
