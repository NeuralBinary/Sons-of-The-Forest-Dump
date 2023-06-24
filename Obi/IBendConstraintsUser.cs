using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000129 RID: 297
	[Token(Token = "0x2000129")]
	public interface IBendConstraintsUser
	{
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060005C6 RID: 1478
		// (set) Token: 0x060005C7 RID: 1479
		[Token(Token = "0x170000B5")]
		bool bendConstraintsEnabled { [Token(Token = "0x60005C6")] get; [Token(Token = "0x60005C7")] set; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060005C8 RID: 1480
		// (set) Token: 0x060005C9 RID: 1481
		[Token(Token = "0x170000B6")]
		float bendCompliance { [Token(Token = "0x60005C8")] get; [Token(Token = "0x60005C9")] set; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060005CA RID: 1482
		// (set) Token: 0x060005CB RID: 1483
		[Token(Token = "0x170000B7")]
		float maxBending { [Token(Token = "0x60005CA")] get; [Token(Token = "0x60005CB")] set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060005CC RID: 1484
		// (set) Token: 0x060005CD RID: 1485
		[Token(Token = "0x170000B8")]
		float plasticYield { [Token(Token = "0x60005CC")] get; [Token(Token = "0x60005CD")] set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060005CE RID: 1486
		// (set) Token: 0x060005CF RID: 1487
		[Token(Token = "0x170000B9")]
		float plasticCreep { [Token(Token = "0x60005CE")] get; [Token(Token = "0x60005CF")] set; }
	}
}
