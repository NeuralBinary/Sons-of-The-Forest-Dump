using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200012F RID: 303
	[Token(Token = "0x200012F")]
	public interface IDistanceConstraintsUser
	{
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060005E6 RID: 1510
		// (set) Token: 0x060005E7 RID: 1511
		[Token(Token = "0x170000C2")]
		bool distanceConstraintsEnabled { [Token(Token = "0x60005E6")] get; [Token(Token = "0x60005E7")] set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060005E8 RID: 1512
		// (set) Token: 0x060005E9 RID: 1513
		[Token(Token = "0x170000C3")]
		float stretchingScale { [Token(Token = "0x60005E8")] get; [Token(Token = "0x60005E9")] set; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060005EA RID: 1514
		// (set) Token: 0x060005EB RID: 1515
		[Token(Token = "0x170000C4")]
		float stretchCompliance { [Token(Token = "0x60005EA")] get; [Token(Token = "0x60005EB")] set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060005EC RID: 1516
		// (set) Token: 0x060005ED RID: 1517
		[Token(Token = "0x170000C5")]
		float maxCompression { [Token(Token = "0x60005EC")] get; [Token(Token = "0x60005ED")] set; }
	}
}
