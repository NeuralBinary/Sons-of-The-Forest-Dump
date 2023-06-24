using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000168 RID: 360
	[Token(Token = "0x2000168")]
	public class ImplicitIntersection3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x060009D3 RID: 2515 RVA: 0x0000761C File Offset: 0x0000581C
		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x1FF0D00", Offset = "0x1FEF300", VA = "0x181FF0D00", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00007634 File Offset: 0x00005834
		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x1FF0DE0", Offset = "0x1FEF3E0", VA = "0x181FF0DE0", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ImplicitIntersection3d()
		{
		}

		// Token: 0x0400057A RID: 1402
		[Token(Token = "0x400057A")]
		[FieldOffset(Offset = "0x10")]
		public BoundedImplicitFunction3d A;

		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0x18")]
		public BoundedImplicitFunction3d B;
	}
}
