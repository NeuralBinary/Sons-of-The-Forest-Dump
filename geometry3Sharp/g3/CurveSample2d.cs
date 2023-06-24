using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000DD RID: 221
	[Token(Token = "0x20000DD")]
	public struct CurveSample2d
	{
		// Token: 0x0600051C RID: 1308 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x15C8940", Offset = "0x15C6F40", VA = "0x1815C8940")]
		public CurveSample2d(Vector2d p, Vector2d t)
		{
		}

		// Token: 0x04000352 RID: 850
		[Token(Token = "0x4000352")]
		[FieldOffset(Offset = "0x0")]
		public Vector2d position;

		// Token: 0x04000353 RID: 851
		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0x10")]
		public Vector2d tangent;
	}
}
