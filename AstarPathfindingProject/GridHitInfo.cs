using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	public struct GridHitInfo
	{
		// Token: 0x040003BF RID: 959
		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0x0")]
		public GridNodeBase node;

		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x8")]
		public int direction;
	}
}
