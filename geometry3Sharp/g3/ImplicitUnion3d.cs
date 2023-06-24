using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000167 RID: 359
	[Token(Token = "0x2000167")]
	public class ImplicitUnion3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x060009D0 RID: 2512 RVA: 0x000075EC File Offset: 0x000057EC
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x1FF0B60", Offset = "0x1FEF160", VA = "0x181FF0B60", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00007604 File Offset: 0x00005804
		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x1FF0C40", Offset = "0x1FEF240", VA = "0x181FF0C40", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ImplicitUnion3d()
		{
		}

		// Token: 0x04000578 RID: 1400
		[Token(Token = "0x4000578")]
		[FieldOffset(Offset = "0x10")]
		public BoundedImplicitFunction3d A;

		// Token: 0x04000579 RID: 1401
		[Token(Token = "0x4000579")]
		[FieldOffset(Offset = "0x18")]
		public BoundedImplicitFunction3d B;
	}
}
