using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	[Serializable]
	public class MaterialVariationSetter
	{
		// Token: 0x060003F2 RID: 1010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x2B0D3E0", Offset = "0x2B0B9E0", VA = "0x182B0D3E0")]
		public static void ApplyMaterial(Renderer renderer, int section, Material material)
		{
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x2B0D810", Offset = "0x2B0BE10", VA = "0x182B0D810")]
		public void ApplyMaterial()
		{
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public MaterialVariationSetter()
		{
		}

		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x10")]
		public Renderer _renderer;

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x18")]
		public int _section;

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x20")]
		public Material _material;
	}
}
