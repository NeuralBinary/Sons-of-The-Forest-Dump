using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000323 RID: 803
	[Token(Token = "0x2000323")]
	public class RenderTextureUtility
	{
		// Token: 0x060014C7 RID: 5319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C7")]
		[Address(RVA = "0x325F390", Offset = "0x325D990", VA = "0x18325F390")]
		public RenderTexture GetTemporaryRenderTexture(int width, int height, int depthBuffer = 0, RenderTextureFormat format = RenderTextureFormat.ARGBHalf, FilterMode filterMode = FilterMode.Bilinear)
		{
			return null;
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C8")]
		[Address(RVA = "0x325F540", Offset = "0x325DB40", VA = "0x18325F540")]
		public void ReleaseTemporaryRenderTexture(RenderTexture rt)
		{
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C9")]
		[Address(RVA = "0x325F730", Offset = "0x325DD30", VA = "0x18325F730")]
		public void ReleaseAllTemporaryRenderTextures()
		{
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014CA")]
		[Address(RVA = "0x325F870", Offset = "0x325DE70", VA = "0x18325F870")]
		public RenderTextureUtility()
		{
		}

		// Token: 0x040014A8 RID: 5288
		[Token(Token = "0x40014A8")]
		[FieldOffset(Offset = "0x10")]
		private List<RenderTexture> m_TemporaryRTs;
	}
}
