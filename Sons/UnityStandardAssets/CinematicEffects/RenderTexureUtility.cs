using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000351 RID: 849
	[Token(Token = "0x2000351")]
	public class RenderTexureUtility
	{
		// Token: 0x06001544 RID: 5444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001544")]
		[Address(RVA = "0x326DF70", Offset = "0x326C570", VA = "0x18326DF70")]
		public RenderTexture GetTemporaryRenderTexture(int width, int height, int depthBuffer = 0, RenderTextureFormat format = RenderTextureFormat.ARGBHalf, FilterMode filterMode = FilterMode.Bilinear)
		{
			return null;
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001545")]
		[Address(RVA = "0x326E120", Offset = "0x326C720", VA = "0x18326E120")]
		public void ReleaseTemporaryRenderTexture(RenderTexture rt)
		{
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001546")]
		[Address(RVA = "0x326E310", Offset = "0x326C910", VA = "0x18326E310")]
		public void ReleaseAllTemporyRenderTexutres()
		{
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001547")]
		[Address(RVA = "0x326E450", Offset = "0x326CA50", VA = "0x18326E450")]
		public RenderTexureUtility()
		{
		}

		// Token: 0x040015CF RID: 5583
		[Token(Token = "0x40015CF")]
		[FieldOffset(Offset = "0x10")]
		private List<RenderTexture> m_TemporaryRTs;
	}
}
