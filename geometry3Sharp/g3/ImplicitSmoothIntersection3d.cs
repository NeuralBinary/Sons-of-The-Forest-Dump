using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200016E RID: 366
	[Token(Token = "0x200016E")]
	public class ImplicitSmoothIntersection3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x060009E5 RID: 2533 RVA: 0x0000773C File Offset: 0x0000593C
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x1FF1DD0", Offset = "0x1FF03D0", VA = "0x181FF1DD0", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00007754 File Offset: 0x00005954
		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x1FF1ED0", Offset = "0x1FF04D0", VA = "0x181FF1ED0", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ImplicitSmoothIntersection3d()
		{
		}

		// Token: 0x04000585 RID: 1413
		[Token(Token = "0x4000585")]
		[FieldOffset(Offset = "0x10")]
		public BoundedImplicitFunction3d A;

		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x4000586")]
		[FieldOffset(Offset = "0x18")]
		public BoundedImplicitFunction3d B;

		// Token: 0x04000587 RID: 1415
		[Token(Token = "0x4000587")]
		private const double mul = 0.6666666666666666;
	}
}
