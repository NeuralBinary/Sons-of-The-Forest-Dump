using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000331 RID: 817
	[Token(Token = "0x2000331")]
	public class RenderTextureUtility
	{
		// Token: 0x0600149C RID: 5276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600149C")]
		[Address(RVA = "0x2CB5A90", Offset = "0x2CB4A90", VA = "0x182CB5A90")]
		public RenderTexture GetTemporaryRenderTexture(int width, int height, int depthBuffer = 0, RenderTextureFormat format = 2, FilterMode filterMode = 1)
		{
			return null;
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600149D")]
		[Address(RVA = "0x2CB5C80", Offset = "0x2CB4C80", VA = "0x182CB5C80")]
		public void ReleaseTemporaryRenderTexture(RenderTexture rt)
		{
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600149E")]
		[Address(RVA = "0x2CB5BB0", Offset = "0x2CB4BB0", VA = "0x182CB5BB0")]
		public void ReleaseAllTemporaryRenderTextures()
		{
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600149F")]
		[Address(RVA = "0x2CB5E00", Offset = "0x2CB4E00", VA = "0x182CB5E00")]
		public RenderTextureUtility()
		{
		}

		// Token: 0x0400148A RID: 5258
		[Token(Token = "0x400148A")]
		[FieldOffset(Offset = "0x10")]
		private List<RenderTexture> m_TemporaryRTs;
	}
}
