using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001C7 RID: 455
	[Token(Token = "0x20001C7")]
	[NullableContext(1)]
	internal interface IXmlElement : IXmlNode
	{
		// Token: 0x06000F43 RID: 3907
		[Token(Token = "0x6000F43")]
		void SetAttributeNode(IXmlNode attribute);

		// Token: 0x06000F44 RID: 3908
		[Token(Token = "0x6000F44")]
		string GetPrefixOfNamespace(string namespaceUri);

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000F45 RID: 3909
		[Token(Token = "0x17000270")]
		bool IsEmpty { [Token(Token = "0x6000F45")] get; }
	}
}
