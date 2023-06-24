using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000132 RID: 306
	[Token(Token = "0x2000132")]
	public interface IShapeMatchingConstraintsUser
	{
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060005F2 RID: 1522
		// (set) Token: 0x060005F3 RID: 1523
		[Token(Token = "0x170000C6")]
		bool shapeMatchingConstraintsEnabled { [Token(Token = "0x60005F2")] get; [Token(Token = "0x60005F3")] set; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060005F4 RID: 1524
		// (set) Token: 0x060005F5 RID: 1525
		[Token(Token = "0x170000C7")]
		float deformationResistance { [Token(Token = "0x60005F4")] get; [Token(Token = "0x60005F5")] set; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060005F6 RID: 1526
		// (set) Token: 0x060005F7 RID: 1527
		[Token(Token = "0x170000C8")]
		float maxDeformation { [Token(Token = "0x60005F6")] get; [Token(Token = "0x60005F7")] set; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060005F8 RID: 1528
		// (set) Token: 0x060005F9 RID: 1529
		[Token(Token = "0x170000C9")]
		float plasticYield { [Token(Token = "0x60005F8")] get; [Token(Token = "0x60005F9")] set; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060005FA RID: 1530
		// (set) Token: 0x060005FB RID: 1531
		[Token(Token = "0x170000CA")]
		float plasticCreep { [Token(Token = "0x60005FA")] get; [Token(Token = "0x60005FB")] set; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060005FC RID: 1532
		// (set) Token: 0x060005FD RID: 1533
		[Token(Token = "0x170000CB")]
		float plasticRecovery { [Token(Token = "0x60005FC")] get; [Token(Token = "0x60005FD")] set; }
	}
}
