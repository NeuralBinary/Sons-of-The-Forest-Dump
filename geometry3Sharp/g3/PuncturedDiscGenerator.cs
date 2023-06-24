using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002B2 RID: 690
	[Token(Token = "0x20002B2")]
	public class PuncturedDiscGenerator : MeshGenerator
	{
		// Token: 0x0600189C RID: 6300 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600189C")]
		[Address(RVA = "0x1EDAF60", Offset = "0x1ED9560", VA = "0x181EDAF60", Slot = "4")]
		public override MeshGenerator Generate()
		{
			return null;
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600189D")]
		[Address(RVA = "0x1EDBA20", Offset = "0x1EDA020", VA = "0x181EDBA20")]
		public PuncturedDiscGenerator()
		{
		}

		// Token: 0x04000BDE RID: 3038
		[Token(Token = "0x4000BDE")]
		[FieldOffset(Offset = "0x40")]
		public float OuterRadius;

		// Token: 0x04000BDF RID: 3039
		[Token(Token = "0x4000BDF")]
		[FieldOffset(Offset = "0x44")]
		public float InnerRadius;

		// Token: 0x04000BE0 RID: 3040
		[Token(Token = "0x4000BE0")]
		[FieldOffset(Offset = "0x48")]
		public float StartAngleDeg;

		// Token: 0x04000BE1 RID: 3041
		[Token(Token = "0x4000BE1")]
		[FieldOffset(Offset = "0x4C")]
		public float EndAngleDeg;

		// Token: 0x04000BE2 RID: 3042
		[Token(Token = "0x4000BE2")]
		[FieldOffset(Offset = "0x50")]
		public int Slices;
	}
}
