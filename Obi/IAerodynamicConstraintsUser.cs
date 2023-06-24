using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000127 RID: 295
	[Token(Token = "0x2000127")]
	public interface IAerodynamicConstraintsUser
	{
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060005BE RID: 1470
		// (set) Token: 0x060005BF RID: 1471
		[Token(Token = "0x170000B2")]
		bool aerodynamicsEnabled { [Token(Token = "0x60005BE")] get; [Token(Token = "0x60005BF")] set; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060005C0 RID: 1472
		// (set) Token: 0x060005C1 RID: 1473
		[Token(Token = "0x170000B3")]
		float drag { [Token(Token = "0x60005C0")] get; [Token(Token = "0x60005C1")] set; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060005C2 RID: 1474
		// (set) Token: 0x060005C3 RID: 1475
		[Token(Token = "0x170000B4")]
		float lift { [Token(Token = "0x60005C2")] get; [Token(Token = "0x60005C3")] set; }
	}
}
