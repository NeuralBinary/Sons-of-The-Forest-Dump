using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000173 RID: 371
	[Token(Token = "0x2000173")]
	public class SkeletalRicciBlend3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x060009FA RID: 2554 RVA: 0x00007874 File Offset: 0x00005A74
		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x1FF28B0", Offset = "0x1FF0EB0", VA = "0x181FF28B0", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0000788C File Offset: 0x00005A8C
		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x1FF2A20", Offset = "0x1FF1020", VA = "0x181FF2A20", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x1FF2B30", Offset = "0x1FF1130", VA = "0x181FF2B30")]
		public SkeletalRicciBlend3d()
		{
		}

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0x10")]
		public BoundedImplicitFunction3d A;

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		[FieldOffset(Offset = "0x18")]
		public BoundedImplicitFunction3d B;

		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		[FieldOffset(Offset = "0x20")]
		public double BlendPower;
	}
}
