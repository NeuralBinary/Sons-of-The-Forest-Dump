using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002A9 RID: 681
	[Token(Token = "0x20002A9")]
	public class Radial3DArrowGenerator : VerticalGeneralizedCylinderGenerator
	{
		// Token: 0x0600188A RID: 6282 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600188A")]
		[Address(RVA = "0x1ED24B0", Offset = "0x1ED0AB0", VA = "0x181ED24B0", Slot = "4")]
		public override MeshGenerator Generate()
		{
			return null;
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600188B")]
		[Address(RVA = "0x1ED2600", Offset = "0x1ED0C00", VA = "0x181ED2600")]
		public Radial3DArrowGenerator()
		{
		}

		// Token: 0x04000BB1 RID: 2993
		[Token(Token = "0x4000BB1")]
		[FieldOffset(Offset = "0x58")]
		public float StickRadius;

		// Token: 0x04000BB2 RID: 2994
		[Token(Token = "0x4000BB2")]
		[FieldOffset(Offset = "0x5C")]
		public float StickLength;

		// Token: 0x04000BB3 RID: 2995
		[Token(Token = "0x4000BB3")]
		[FieldOffset(Offset = "0x60")]
		public float HeadBaseRadius;

		// Token: 0x04000BB4 RID: 2996
		[Token(Token = "0x4000BB4")]
		[FieldOffset(Offset = "0x64")]
		public float TipRadius;

		// Token: 0x04000BB5 RID: 2997
		[Token(Token = "0x4000BB5")]
		[FieldOffset(Offset = "0x68")]
		public float HeadLength;
	}
}
