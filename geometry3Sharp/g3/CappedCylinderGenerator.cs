using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002AE RID: 686
	[Token(Token = "0x20002AE")]
	public class CappedCylinderGenerator : MeshGenerator
	{
		// Token: 0x06001894 RID: 6292 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001894")]
		[Address(RVA = "0x1ED5FF0", Offset = "0x1ED45F0", VA = "0x181ED5FF0", Slot = "4")]
		public override MeshGenerator Generate()
		{
			return null;
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001895")]
		[Address(RVA = "0x1ED5FC0", Offset = "0x1ED45C0", VA = "0x181ED5FC0")]
		public CappedCylinderGenerator()
		{
		}

		// Token: 0x04000BC7 RID: 3015
		[Token(Token = "0x4000BC7")]
		[FieldOffset(Offset = "0x40")]
		public float BaseRadius;

		// Token: 0x04000BC8 RID: 3016
		[Token(Token = "0x4000BC8")]
		[FieldOffset(Offset = "0x44")]
		public float TopRadius;

		// Token: 0x04000BC9 RID: 3017
		[Token(Token = "0x4000BC9")]
		[FieldOffset(Offset = "0x48")]
		public float Height;

		// Token: 0x04000BCA RID: 3018
		[Token(Token = "0x4000BCA")]
		[FieldOffset(Offset = "0x4C")]
		public float StartAngleDeg;

		// Token: 0x04000BCB RID: 3019
		[Token(Token = "0x4000BCB")]
		[FieldOffset(Offset = "0x50")]
		public float EndAngleDeg;

		// Token: 0x04000BCC RID: 3020
		[Token(Token = "0x4000BCC")]
		[FieldOffset(Offset = "0x54")]
		public int Slices;

		// Token: 0x04000BCD RID: 3021
		[Token(Token = "0x4000BCD")]
		[FieldOffset(Offset = "0x58")]
		public bool NoSharedVertices;
	}
}
