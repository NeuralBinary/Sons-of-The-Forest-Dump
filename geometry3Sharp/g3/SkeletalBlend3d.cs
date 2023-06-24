using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000172 RID: 370
	[Token(Token = "0x2000172")]
	public class SkeletalBlend3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x060009F7 RID: 2551 RVA: 0x00007844 File Offset: 0x00005A44
		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x1FF2720", Offset = "0x1FF0D20", VA = "0x181FF2720", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0000785C File Offset: 0x00005A5C
		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x1FF27A0", Offset = "0x1FF0DA0", VA = "0x181FF27A0", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SkeletalBlend3d()
		{
		}

		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		[FieldOffset(Offset = "0x10")]
		public BoundedImplicitFunction3d A;

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0x18")]
		public BoundedImplicitFunction3d B;
	}
}
