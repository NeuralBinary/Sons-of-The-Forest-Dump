using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000161 RID: 353
	[Token(Token = "0x2000161")]
	public class ImplicitHalfSpace3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x060009BC RID: 2492 RVA: 0x000074B4 File Offset: 0x000056B4
		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x1FF0120", Offset = "0x1FEE720", VA = "0x181FF0120", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x000074CC File Offset: 0x000056CC
		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x1FF01E0", Offset = "0x1FEE7E0", VA = "0x181FF01E0", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ImplicitHalfSpace3d()
		{
		}

		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x10")]
		public Vector3d Origin;

		// Token: 0x0400056D RID: 1389
		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0x28")]
		public Vector3d Normal;
	}
}
