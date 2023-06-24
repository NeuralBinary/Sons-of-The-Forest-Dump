using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000163 RID: 355
	[Token(Token = "0x2000163")]
	public class ImplicitBox3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x00007514 File Offset: 0x00005714
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001BE")]
		public Box3d Box
		{
			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x1B28100", Offset = "0x1B26700", VA = "0x181B28100")]
			get
			{
				return default(Box3d);
			}
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x1FF0280", Offset = "0x1FEE880", VA = "0x181FF0280")]
			set
			{
			}
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0000752C File Offset: 0x0000572C
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x1FF0380", Offset = "0x1FEE980", VA = "0x181FF0380", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00007544 File Offset: 0x00005744
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x1FF0550", Offset = "0x1FEEB50", VA = "0x181FF0550", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ImplicitBox3d()
		{
		}

		// Token: 0x0400056F RID: 1391
		[Token(Token = "0x400056F")]
		[FieldOffset(Offset = "0x10")]
		private Box3d box;

		// Token: 0x04000570 RID: 1392
		[Token(Token = "0x4000570")]
		[FieldOffset(Offset = "0x88")]
		private AxisAlignedBox3d local_aabb;

		// Token: 0x04000571 RID: 1393
		[Token(Token = "0x4000571")]
		[FieldOffset(Offset = "0xB8")]
		private AxisAlignedBox3d bounds_aabb;
	}
}
