using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200016D RID: 365
	[Token(Token = "0x200016D")]
	public class ImplicitSmoothUnion3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x060009E2 RID: 2530 RVA: 0x0000770C File Offset: 0x0000590C
		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x1FF1C00", Offset = "0x1FF0200", VA = "0x181FF1C00", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00007724 File Offset: 0x00005924
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x1FF1D10", Offset = "0x1FF0310", VA = "0x181FF1D10", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ImplicitSmoothUnion3d()
		{
		}

		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0x10")]
		public BoundedImplicitFunction3d A;

		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0x18")]
		public BoundedImplicitFunction3d B;

		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		private const double mul = 0.6666666666666666;
	}
}
