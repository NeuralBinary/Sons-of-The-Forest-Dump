using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000166 RID: 358
	[Token(Token = "0x2000166")]
	public class ImplicitShell3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x060009CD RID: 2509 RVA: 0x000075BC File Offset: 0x000057BC
		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x1FF0940", Offset = "0x1FEEF40", VA = "0x181FF0940", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000075D4 File Offset: 0x000057D4
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x1FF0A50", Offset = "0x1FEF050", VA = "0x181FF0A50", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ImplicitShell3d()
		{
		}

		// Token: 0x04000576 RID: 1398
		[Token(Token = "0x4000576")]
		[FieldOffset(Offset = "0x10")]
		public BoundedImplicitFunction3d A;

		// Token: 0x04000577 RID: 1399
		[Token(Token = "0x4000577")]
		[FieldOffset(Offset = "0x18")]
		public Interval1d Inside;
	}
}
