using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200016A RID: 362
	[Token(Token = "0x200016A")]
	public class ImplicitNaryUnion3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x060009D9 RID: 2521 RVA: 0x0000767C File Offset: 0x0000587C
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x1FF1000", Offset = "0x1FEF600", VA = "0x181FF1000", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00007694 File Offset: 0x00005894
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x1FF1240", Offset = "0x1FEF840", VA = "0x181FF1240", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ImplicitNaryUnion3d()
		{
		}

		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		[FieldOffset(Offset = "0x10")]
		public List<BoundedImplicitFunction3d> Children;
	}
}
