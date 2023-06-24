using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000314 RID: 788
	[Token(Token = "0x2000314")]
	public struct LinearIntersection
	{
		// Token: 0x04000DF7 RID: 3575
		[Token(Token = "0x4000DF7")]
		[FieldOffset(Offset = "0x0")]
		public bool intersects;

		// Token: 0x04000DF8 RID: 3576
		[Token(Token = "0x4000DF8")]
		[FieldOffset(Offset = "0x4")]
		public int numIntersections;

		// Token: 0x04000DF9 RID: 3577
		[Token(Token = "0x4000DF9")]
		[FieldOffset(Offset = "0x8")]
		public Interval1d parameter;
	}
}
