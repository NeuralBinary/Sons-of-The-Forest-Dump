using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002AD RID: 685
	[Token(Token = "0x20002AD")]
	public class OpenCylinderGenerator : MeshGenerator
	{
		// Token: 0x06001892 RID: 6290 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001892")]
		[Address(RVA = "0x1ED5460", Offset = "0x1ED3A60", VA = "0x181ED5460", Slot = "4")]
		public override MeshGenerator Generate()
		{
			return null;
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001893")]
		[Address(RVA = "0x1ED5FC0", Offset = "0x1ED45C0", VA = "0x181ED5FC0")]
		public OpenCylinderGenerator()
		{
		}

		// Token: 0x04000BC0 RID: 3008
		[Token(Token = "0x4000BC0")]
		[FieldOffset(Offset = "0x40")]
		public float BaseRadius;

		// Token: 0x04000BC1 RID: 3009
		[Token(Token = "0x4000BC1")]
		[FieldOffset(Offset = "0x44")]
		public float TopRadius;

		// Token: 0x04000BC2 RID: 3010
		[Token(Token = "0x4000BC2")]
		[FieldOffset(Offset = "0x48")]
		public float Height;

		// Token: 0x04000BC3 RID: 3011
		[Token(Token = "0x4000BC3")]
		[FieldOffset(Offset = "0x4C")]
		public float StartAngleDeg;

		// Token: 0x04000BC4 RID: 3012
		[Token(Token = "0x4000BC4")]
		[FieldOffset(Offset = "0x50")]
		public float EndAngleDeg;

		// Token: 0x04000BC5 RID: 3013
		[Token(Token = "0x4000BC5")]
		[FieldOffset(Offset = "0x54")]
		public int Slices;

		// Token: 0x04000BC6 RID: 3014
		[Token(Token = "0x4000BC6")]
		[FieldOffset(Offset = "0x58")]
		public bool NoSharedVertices;
	}
}
