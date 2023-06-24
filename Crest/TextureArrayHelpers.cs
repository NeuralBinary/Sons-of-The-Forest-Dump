using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	public static class TextureArrayHelpers
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x1700000E")]
		public static Texture2DArray BlackTextureArray
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x9D3820", Offset = "0x9D1E20", VA = "0x1809D3820")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x9D3950", Offset = "0x9D1F50", VA = "0x1809D3950")]
		public static void ClearToBlack(RenderTexture dst)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x9D3BA0", Offset = "0x9D21A0", VA = "0x1809D3BA0")]
		public static Texture2D CreateTexture2D(Color color, TextureFormat format)
		{
			return null;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x9D3D70", Offset = "0x9D2370", VA = "0x1809D3D70")]
		public static Texture2DArray CreateTexture2DArray(Texture2D texture)
		{
			return null;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x9D3EF0", Offset = "0x9D24F0", VA = "0x1809D3EF0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void InitStatics()
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x9D42C0", Offset = "0x9D28C0", VA = "0x1809D42C0")]
		private static void CreateBlackTexArray()
		{
		}

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		private const string CLEAR_TO_BLACK_SHADER_NAME = "ClearToBlack";

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		private const int SMALL_TEXTURE_DIM = 4;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x0")]
		private static int krnl_ClearToBlack;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x8")]
		private static ComputeShader s_clearToBlackShader;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x10")]
		private static int sp_LD_TexArray_Target;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x18")]
		private static Texture2DArray _blackTextureArray;
	}
}
