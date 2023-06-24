using System;
using Il2CppDummyDll;

namespace SonsLOD
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	public struct SonsDrawRange
	{
		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x0")]
		public SonsRangeKey key;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x4")]
		public int drawCount;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x8")]
		public int drawOffset;
	}
}
