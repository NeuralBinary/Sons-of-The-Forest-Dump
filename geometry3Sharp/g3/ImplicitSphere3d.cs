using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000160 RID: 352
	[Token(Token = "0x2000160")]
	public class ImplicitSphere3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x060009B9 RID: 2489 RVA: 0x00007484 File Offset: 0x00005684
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x1FF0080", Offset = "0x1FEE680", VA = "0x181FF0080", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0000749C File Offset: 0x0000569C
		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x1FF00B0", Offset = "0x1FEE6B0", VA = "0x181FF00B0", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ImplicitSphere3d()
		{
		}

		// Token: 0x0400056A RID: 1386
		[Token(Token = "0x400056A")]
		[FieldOffset(Offset = "0x10")]
		public Vector3d Origin;

		// Token: 0x0400056B RID: 1387
		[Token(Token = "0x400056B")]
		[FieldOffset(Offset = "0x28")]
		public double Radius;
	}
}
