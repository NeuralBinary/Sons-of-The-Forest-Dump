using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000171 RID: 369
	[Token(Token = "0x2000171")]
	public class DistanceFieldToSkeletalField : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x060009F4 RID: 2548 RVA: 0x00007814 File Offset: 0x00005A14
		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x1FF25B0", Offset = "0x1FF0BB0", VA = "0x181FF25B0", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0000782C File Offset: 0x00005A2C
		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x1FF2660", Offset = "0x1FF0C60", VA = "0x181FF2660", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DistanceFieldToSkeletalField()
		{
		}

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0x10")]
		public BoundedImplicitFunction3d DistanceField;

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x18")]
		public double FalloffDistance;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		public const double ZeroIsocontour = 0.421875;
	}
}
