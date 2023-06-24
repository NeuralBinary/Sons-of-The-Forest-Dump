using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020001E6 RID: 486
	[Token(Token = "0x20001E6")]
	[Serializable]
	public class ObiStructuralElement
	{
		// Token: 0x060009F0 RID: 2544 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ObiStructuralElement()
		{
		}

		// Token: 0x0400080B RID: 2059
		[Token(Token = "0x400080B")]
		[FieldOffset(Offset = "0x10")]
		public int particle1;

		// Token: 0x0400080C RID: 2060
		[Token(Token = "0x400080C")]
		[FieldOffset(Offset = "0x14")]
		public int particle2;

		// Token: 0x0400080D RID: 2061
		[Token(Token = "0x400080D")]
		[FieldOffset(Offset = "0x18")]
		public float restLength;

		// Token: 0x0400080E RID: 2062
		[Token(Token = "0x400080E")]
		[FieldOffset(Offset = "0x1C")]
		public float constraintForce;

		// Token: 0x0400080F RID: 2063
		[Token(Token = "0x400080F")]
		[FieldOffset(Offset = "0x20")]
		public float tearResistance;
	}
}
