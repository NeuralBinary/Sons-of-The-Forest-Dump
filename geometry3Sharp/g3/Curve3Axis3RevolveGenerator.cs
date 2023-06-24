using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002C1 RID: 705
	[Token(Token = "0x20002C1")]
	public class Curve3Axis3RevolveGenerator : MeshGenerator
	{
		// Token: 0x060018D8 RID: 6360 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60018D8")]
		[Address(RVA = "0x1EE7970", Offset = "0x1EE5F70", VA = "0x181EE7970", Slot = "4")]
		public override MeshGenerator Generate()
		{
			return null;
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018D9")]
		[Address(RVA = "0x1EE8EC0", Offset = "0x1EE74C0", VA = "0x181EE8EC0")]
		public Curve3Axis3RevolveGenerator()
		{
		}

		// Token: 0x04000C34 RID: 3124
		[Token(Token = "0x4000C34")]
		[FieldOffset(Offset = "0x40")]
		public Vector3d[] Curve;

		// Token: 0x04000C35 RID: 3125
		[Token(Token = "0x4000C35")]
		[FieldOffset(Offset = "0x48")]
		public Frame3f Axis;

		// Token: 0x04000C36 RID: 3126
		[Token(Token = "0x4000C36")]
		[FieldOffset(Offset = "0x64")]
		public int RevolveAxis;

		// Token: 0x04000C37 RID: 3127
		[Token(Token = "0x4000C37")]
		[FieldOffset(Offset = "0x68")]
		public bool Capped;

		// Token: 0x04000C38 RID: 3128
		[Token(Token = "0x4000C38")]
		[FieldOffset(Offset = "0x6C")]
		public int Slices;

		// Token: 0x04000C39 RID: 3129
		[Token(Token = "0x4000C39")]
		[FieldOffset(Offset = "0x70")]
		public bool NoSharedVertices;

		// Token: 0x04000C3A RID: 3130
		[Token(Token = "0x4000C3A")]
		[FieldOffset(Offset = "0x74")]
		public int startCapCenterIndex;

		// Token: 0x04000C3B RID: 3131
		[Token(Token = "0x4000C3B")]
		[FieldOffset(Offset = "0x78")]
		public int endCapCenterIndex;
	}
}
