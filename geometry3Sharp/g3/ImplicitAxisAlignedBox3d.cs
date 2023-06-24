using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000162 RID: 354
	[Token(Token = "0x2000162")]
	public class ImplicitAxisAlignedBox3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x060009BF RID: 2495 RVA: 0x000074E4 File Offset: 0x000056E4
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x1FF0250", Offset = "0x1FEE850", VA = "0x181FF0250", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x000074FC File Offset: 0x000056FC
		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x1B19AA0", Offset = "0x1B180A0", VA = "0x181B19AA0", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ImplicitAxisAlignedBox3d()
		{
		}

		// Token: 0x0400056E RID: 1390
		[Token(Token = "0x400056E")]
		[FieldOffset(Offset = "0x10")]
		public AxisAlignedBox3d AABox;
	}
}
