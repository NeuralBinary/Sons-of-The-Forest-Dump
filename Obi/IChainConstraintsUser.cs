using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200012D RID: 301
	[Token(Token = "0x200012D")]
	public interface IChainConstraintsUser
	{
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060005E0 RID: 1504
		// (set) Token: 0x060005E1 RID: 1505
		[Token(Token = "0x170000C0")]
		bool chainConstraintsEnabled { [Token(Token = "0x60005E0")] get; [Token(Token = "0x60005E1")] set; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060005E2 RID: 1506
		// (set) Token: 0x060005E3 RID: 1507
		[Token(Token = "0x170000C1")]
		float tightness { [Token(Token = "0x60005E2")] get; [Token(Token = "0x60005E3")] set; }
	}
}
