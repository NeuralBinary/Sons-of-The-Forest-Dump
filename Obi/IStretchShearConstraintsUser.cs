using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000135 RID: 309
	[Token(Token = "0x2000135")]
	public interface IStretchShearConstraintsUser
	{
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000602 RID: 1538
		// (set) Token: 0x06000603 RID: 1539
		[Token(Token = "0x170000CC")]
		bool stretchShearConstraintsEnabled { [Token(Token = "0x6000602")] get; [Token(Token = "0x6000603")] set; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000604 RID: 1540
		// (set) Token: 0x06000605 RID: 1541
		[Token(Token = "0x170000CD")]
		float stretchCompliance { [Token(Token = "0x6000604")] get; [Token(Token = "0x6000605")] set; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000606 RID: 1542
		// (set) Token: 0x06000607 RID: 1543
		[Token(Token = "0x170000CE")]
		float shear1Compliance { [Token(Token = "0x6000606")] get; [Token(Token = "0x6000607")] set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000608 RID: 1544
		// (set) Token: 0x06000609 RID: 1545
		[Token(Token = "0x170000CF")]
		float shear2Compliance { [Token(Token = "0x6000608")] get; [Token(Token = "0x6000609")] set; }
	}
}
