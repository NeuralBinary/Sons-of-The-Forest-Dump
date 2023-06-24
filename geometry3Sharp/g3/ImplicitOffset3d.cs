using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000165 RID: 357
	[Token(Token = "0x2000165")]
	public class ImplicitOffset3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x060009CA RID: 2506 RVA: 0x0000758C File Offset: 0x0000578C
		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x1FF0830", Offset = "0x1FEEE30", VA = "0x181FF0830", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x000075A4 File Offset: 0x000057A4
		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x1FF0890", Offset = "0x1FEEE90", VA = "0x181FF0890", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ImplicitOffset3d()
		{
		}

		// Token: 0x04000574 RID: 1396
		[Token(Token = "0x4000574")]
		[FieldOffset(Offset = "0x10")]
		public BoundedImplicitFunction3d A;

		// Token: 0x04000575 RID: 1397
		[Token(Token = "0x4000575")]
		[FieldOffset(Offset = "0x18")]
		public double Offset;
	}
}
