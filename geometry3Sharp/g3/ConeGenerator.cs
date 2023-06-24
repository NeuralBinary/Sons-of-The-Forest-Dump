using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002AF RID: 687
	[Token(Token = "0x20002AF")]
	public class ConeGenerator : MeshGenerator
	{
		// Token: 0x06001896 RID: 6294 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001896")]
		[Address(RVA = "0x1ED7B10", Offset = "0x1ED6110", VA = "0x181ED7B10", Slot = "4")]
		public override MeshGenerator Generate()
		{
			return null;
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001897")]
		[Address(RVA = "0x1ED9160", Offset = "0x1ED7760", VA = "0x181ED9160")]
		public ConeGenerator()
		{
		}

		// Token: 0x04000BCE RID: 3022
		[Token(Token = "0x4000BCE")]
		[FieldOffset(Offset = "0x40")]
		public float BaseRadius;

		// Token: 0x04000BCF RID: 3023
		[Token(Token = "0x4000BCF")]
		[FieldOffset(Offset = "0x44")]
		public float Height;

		// Token: 0x04000BD0 RID: 3024
		[Token(Token = "0x4000BD0")]
		[FieldOffset(Offset = "0x48")]
		public float StartAngleDeg;

		// Token: 0x04000BD1 RID: 3025
		[Token(Token = "0x4000BD1")]
		[FieldOffset(Offset = "0x4C")]
		public float EndAngleDeg;

		// Token: 0x04000BD2 RID: 3026
		[Token(Token = "0x4000BD2")]
		[FieldOffset(Offset = "0x50")]
		public int Slices;

		// Token: 0x04000BD3 RID: 3027
		[Token(Token = "0x4000BD3")]
		[FieldOffset(Offset = "0x54")]
		public bool NoSharedVertices;
	}
}
