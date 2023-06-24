using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	public class ImplicitNaryIntersection3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x060009DC RID: 2524 RVA: 0x000076AC File Offset: 0x000058AC
		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x1FF1460", Offset = "0x1FEFA60", VA = "0x181FF1460", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x000076C4 File Offset: 0x000058C4
		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x1FF16A0", Offset = "0x1FEFCA0", VA = "0x181FF16A0", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ImplicitNaryIntersection3d()
		{
		}

		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		[FieldOffset(Offset = "0x10")]
		public List<BoundedImplicitFunction3d> Children;
	}
}
