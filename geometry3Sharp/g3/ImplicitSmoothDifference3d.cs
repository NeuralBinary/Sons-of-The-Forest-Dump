using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200016F RID: 367
	[Token(Token = "0x200016F")]
	public class ImplicitSmoothDifference3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x060009E8 RID: 2536 RVA: 0x0000776C File Offset: 0x0000596C
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x1FF1F90", Offset = "0x1FF0590", VA = "0x181FF1F90", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00007784 File Offset: 0x00005984
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x1FF2090", Offset = "0x1FF0690", VA = "0x181FF2090", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ImplicitSmoothDifference3d()
		{
		}

		// Token: 0x04000588 RID: 1416
		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x10")]
		public BoundedImplicitFunction3d A;

		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0x18")]
		public BoundedImplicitFunction3d B;

		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		private const double mul = 0.6666666666666666;
	}
}
