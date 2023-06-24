using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public interface IJsonLineInfo
	{
		// Token: 0x06000017 RID: 23
		[Token(Token = "0x6000017")]
		bool HasLineInfo();

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000018 RID: 24
		[Token(Token = "0x17000003")]
		int LineNumber { [Token(Token = "0x6000018")] get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000019 RID: 25
		[Token(Token = "0x17000004")]
		int LinePosition { [Token(Token = "0x6000019")] get; }
	}
}
