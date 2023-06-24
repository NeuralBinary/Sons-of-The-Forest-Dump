using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000137 RID: 311
	[Token(Token = "0x2000137")]
	public interface ITetherConstraintsUser
	{
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600060C RID: 1548
		// (set) Token: 0x0600060D RID: 1549
		[Token(Token = "0x170000D0")]
		bool tetherConstraintsEnabled { [Token(Token = "0x600060C")] get; [Token(Token = "0x600060D")] set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600060E RID: 1550
		// (set) Token: 0x0600060F RID: 1551
		[Token(Token = "0x170000D1")]
		float tetherCompliance { [Token(Token = "0x600060E")] get; [Token(Token = "0x600060F")] set; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000610 RID: 1552
		// (set) Token: 0x06000611 RID: 1553
		[Token(Token = "0x170000D2")]
		float tetherScale { [Token(Token = "0x6000610")] get; [Token(Token = "0x6000611")] set; }
	}
}
