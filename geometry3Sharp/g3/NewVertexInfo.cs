using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200024A RID: 586
	[Token(Token = "0x200024A")]
	public struct NewVertexInfo
	{
		// Token: 0x060014E7 RID: 5351 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014E7")]
		[Address(RVA = "0x1E8B930", Offset = "0x1E89F30", VA = "0x181E8B930")]
		public NewVertexInfo(Vector3d v)
		{
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014E8")]
		[Address(RVA = "0x1E8BA10", Offset = "0x1E8A010", VA = "0x181E8BA10")]
		public NewVertexInfo(Vector3d v, Vector3f n)
		{
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014E9")]
		[Address(RVA = "0x1E8BB00", Offset = "0x1E8A100", VA = "0x181E8BB00")]
		public NewVertexInfo(Vector3d v, Vector3f n, Vector3f c)
		{
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014EA")]
		[Address(RVA = "0x1E8BBD0", Offset = "0x1E8A1D0", VA = "0x181E8BBD0")]
		public NewVertexInfo(Vector3d v, Vector3f n, Vector3f c, Vector2f uv)
		{
		}

		// Token: 0x040009B4 RID: 2484
		[Token(Token = "0x40009B4")]
		[FieldOffset(Offset = "0x0")]
		public Vector3d v;

		// Token: 0x040009B5 RID: 2485
		[Token(Token = "0x40009B5")]
		[FieldOffset(Offset = "0x18")]
		public Vector3f n;

		// Token: 0x040009B6 RID: 2486
		[Token(Token = "0x40009B6")]
		[FieldOffset(Offset = "0x24")]
		public Vector3f c;

		// Token: 0x040009B7 RID: 2487
		[Token(Token = "0x40009B7")]
		[FieldOffset(Offset = "0x30")]
		public Vector2f uv;

		// Token: 0x040009B8 RID: 2488
		[Token(Token = "0x40009B8")]
		[FieldOffset(Offset = "0x38")]
		public bool bHaveN;

		// Token: 0x040009B9 RID: 2489
		[Token(Token = "0x40009B9")]
		[FieldOffset(Offset = "0x39")]
		public bool bHaveUV;

		// Token: 0x040009BA RID: 2490
		[Token(Token = "0x40009BA")]
		[FieldOffset(Offset = "0x3A")]
		public bool bHaveC;
	}
}
