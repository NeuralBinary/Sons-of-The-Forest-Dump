using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000174 RID: 372
	[Token(Token = "0x2000174")]
	public class SkeletalRicciNaryBlend3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x060009FD RID: 2557 RVA: 0x000078A4 File Offset: 0x00005AA4
		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x1FF2B40", Offset = "0x1FF1140", VA = "0x181FF2B40", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x000078BC File Offset: 0x00005ABC
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x1FF2F70", Offset = "0x1FF1570", VA = "0x181FF2F70", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x1FF31E0", Offset = "0x1FF17E0", VA = "0x181FF31E0")]
		public SkeletalRicciNaryBlend3d()
		{
		}

		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000599")]
		[FieldOffset(Offset = "0x10")]
		public List<BoundedImplicitFunction3d> Children;

		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		[FieldOffset(Offset = "0x18")]
		public double BlendPower;

		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		[FieldOffset(Offset = "0x20")]
		public double FieldShift;
	}
}
