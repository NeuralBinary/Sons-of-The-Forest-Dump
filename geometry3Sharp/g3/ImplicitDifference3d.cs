using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000169 RID: 361
	[Token(Token = "0x2000169")]
	public class ImplicitDifference3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x060009D6 RID: 2518 RVA: 0x0000764C File Offset: 0x0000584C
		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x1FF0EA0", Offset = "0x1FEF4A0", VA = "0x181FF0EA0", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00007664 File Offset: 0x00005864
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x1FF0F90", Offset = "0x1FEF590", VA = "0x181FF0F90", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ImplicitDifference3d()
		{
		}

		// Token: 0x0400057C RID: 1404
		[Token(Token = "0x400057C")]
		[FieldOffset(Offset = "0x10")]
		public BoundedImplicitFunction3d A;

		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0x18")]
		public BoundedImplicitFunction3d B;
	}
}
