using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000164 RID: 356
	[Token(Token = "0x2000164")]
	public class ImplicitLine3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x060009C7 RID: 2503 RVA: 0x0000755C File Offset: 0x0000575C
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x1FF0580", Offset = "0x1FEEB80", VA = "0x181FF0580", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00007574 File Offset: 0x00005774
		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x1FF0620", Offset = "0x1FEEC20", VA = "0x181FF0620", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ImplicitLine3d()
		{
		}

		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		[FieldOffset(Offset = "0x10")]
		public Segment3d Segment;

		// Token: 0x04000573 RID: 1395
		[Token(Token = "0x4000573")]
		[FieldOffset(Offset = "0x48")]
		public double Radius;
	}
}
