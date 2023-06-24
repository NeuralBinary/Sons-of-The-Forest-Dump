using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200016C RID: 364
	[Token(Token = "0x200016C")]
	public class ImplicitNaryDifference3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x060009DF RID: 2527 RVA: 0x000076DC File Offset: 0x000058DC
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x1FF18E0", Offset = "0x1FEFEE0", VA = "0x181FF18E0", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x000076F4 File Offset: 0x000058F4
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x1FF1B90", Offset = "0x1FF0190", VA = "0x181FF1B90", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ImplicitNaryDifference3d()
		{
		}

		// Token: 0x04000580 RID: 1408
		[Token(Token = "0x4000580")]
		[FieldOffset(Offset = "0x10")]
		public BoundedImplicitFunction3d A;

		// Token: 0x04000581 RID: 1409
		[Token(Token = "0x4000581")]
		[FieldOffset(Offset = "0x18")]
		public List<BoundedImplicitFunction3d> BSet;
	}
}
