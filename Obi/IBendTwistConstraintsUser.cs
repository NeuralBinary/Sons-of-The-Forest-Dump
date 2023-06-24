using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200012B RID: 299
	[Token(Token = "0x200012B")]
	public interface IBendTwistConstraintsUser
	{
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060005D2 RID: 1490
		// (set) Token: 0x060005D3 RID: 1491
		[Token(Token = "0x170000BA")]
		bool bendTwistConstraintsEnabled { [Token(Token = "0x60005D2")] get; [Token(Token = "0x60005D3")] set; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060005D4 RID: 1492
		// (set) Token: 0x060005D5 RID: 1493
		[Token(Token = "0x170000BB")]
		float torsionCompliance { [Token(Token = "0x60005D4")] get; [Token(Token = "0x60005D5")] set; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060005D6 RID: 1494
		// (set) Token: 0x060005D7 RID: 1495
		[Token(Token = "0x170000BC")]
		float bend1Compliance { [Token(Token = "0x60005D6")] get; [Token(Token = "0x60005D7")] set; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060005D8 RID: 1496
		// (set) Token: 0x060005D9 RID: 1497
		[Token(Token = "0x170000BD")]
		float bend2Compliance { [Token(Token = "0x60005D8")] get; [Token(Token = "0x60005D9")] set; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060005DA RID: 1498
		// (set) Token: 0x060005DB RID: 1499
		[Token(Token = "0x170000BE")]
		float plasticYield { [Token(Token = "0x60005DA")] get; [Token(Token = "0x60005DB")] set; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060005DC RID: 1500
		// (set) Token: 0x060005DD RID: 1501
		[Token(Token = "0x170000BF")]
		float plasticCreep { [Token(Token = "0x60005DC")] get; [Token(Token = "0x60005DD")] set; }
	}
}
