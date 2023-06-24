using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x02000142 RID: 322
	[Token(Token = "0x2000142")]
	public class TextureUtil
	{
		// Token: 0x06000812 RID: 2066 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x2451830", Offset = "0x244FE30", VA = "0x182451830")]
		public static Texture3D RenderTextureToTexture3D(Texture3D output, RenderTexture rt)
		{
			return null;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x2451F00", Offset = "0x2450500", VA = "0x182451F00")]
		private static Texture3D Tex3DFromTex2DArray(Texture3D output, Texture2D[] slices, Vector3Int dimensions)
		{
			return null;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x2452240", Offset = "0x2450840", VA = "0x182452240")]
		private static Texture2D ConvertFromRenderTexture(RenderTexture rt)
		{
			return null;
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public TextureUtil()
		{
		}

		// Token: 0x040004C1 RID: 1217
		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int ThreadGroupSize;
	}
}
