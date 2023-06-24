using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002C2 RID: 706
	[Token(Token = "0x20002C2")]
	public class Curve3Curve3RevolveGenerator : MeshGenerator
	{
		// Token: 0x060018DA RID: 6362 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60018DA")]
		[Address(RVA = "0x1EE8F50", Offset = "0x1EE7550", VA = "0x181EE8F50", Slot = "4")]
		public override MeshGenerator Generate()
		{
			return null;
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018DB")]
		[Address(RVA = "0x1EEA830", Offset = "0x1EE8E30", VA = "0x181EEA830")]
		public Curve3Curve3RevolveGenerator()
		{
		}

		// Token: 0x04000C3C RID: 3132
		[Token(Token = "0x4000C3C")]
		[FieldOffset(Offset = "0x40")]
		public Vector3d[] Curve;

		// Token: 0x04000C3D RID: 3133
		[Token(Token = "0x4000C3D")]
		[FieldOffset(Offset = "0x48")]
		public Vector3d[] Axis;

		// Token: 0x04000C3E RID: 3134
		[Token(Token = "0x4000C3E")]
		[FieldOffset(Offset = "0x50")]
		public bool Capped;

		// Token: 0x04000C3F RID: 3135
		[Token(Token = "0x4000C3F")]
		[FieldOffset(Offset = "0x54")]
		public int Slices;

		// Token: 0x04000C40 RID: 3136
		[Token(Token = "0x4000C40")]
		[FieldOffset(Offset = "0x58")]
		public bool NoSharedVertices;

		// Token: 0x04000C41 RID: 3137
		[Token(Token = "0x4000C41")]
		[FieldOffset(Offset = "0x5C")]
		public int startCapCenterIndex;

		// Token: 0x04000C42 RID: 3138
		[Token(Token = "0x4000C42")]
		[FieldOffset(Offset = "0x60")]
		public int endCapCenterIndex;
	}
}
