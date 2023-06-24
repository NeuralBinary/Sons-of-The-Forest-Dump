using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001C6 RID: 454
	[Token(Token = "0x20001C6")]
	[NullableContext(2)]
	internal interface IXmlDocumentType : IXmlNode
	{
		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000F3F RID: 3903
		[Token(Token = "0x1700026C")]
		[Nullable(1)]
		string Name { [Token(Token = "0x6000F3F")] [NullableContext(1)] get; }

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000F40 RID: 3904
		[Token(Token = "0x1700026D")]
		string System { [Token(Token = "0x6000F40")] get; }

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000F41 RID: 3905
		[Token(Token = "0x1700026E")]
		string Public { [Token(Token = "0x6000F41")] get; }

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000F42 RID: 3906
		[Token(Token = "0x1700026F")]
		string InternalSubset { [Token(Token = "0x6000F42")] get; }
	}
}
