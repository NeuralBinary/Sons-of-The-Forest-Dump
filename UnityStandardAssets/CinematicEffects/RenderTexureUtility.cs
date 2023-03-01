using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x0200035F RID: 863
	[Token(Token = "0x200035F")]
	public class RenderTexureUtility
	{
		// Token: 0x06001519 RID: 5401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001519")]
		[Address(RVA = "0x2CB5E80", Offset = "0x2CB4E80", VA = "0x182CB5E80")]
		public RenderTexture GetTemporaryRenderTexture(int width, int height, int depthBuffer = 0, RenderTextureFormat format = 2, FilterMode filterMode = 1)
		{
			return null;
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600151A")]
		[Address(RVA = "0x2CB6070", Offset = "0x2CB5070", VA = "0x182CB6070")]
		public void ReleaseTemporaryRenderTexture(RenderTexture rt)
		{
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600151B")]
		[Address(RVA = "0x2CB5FA0", Offset = "0x2CB4FA0", VA = "0x182CB5FA0")]
		public void ReleaseAllTemporyRenderTexutres()
		{
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600151C")]
		[Address(RVA = "0x2CB61F0", Offset = "0x2CB51F0", VA = "0x182CB61F0")]
		public RenderTexureUtility()
		{
		}

		// Token: 0x040015B1 RID: 5553
		[Token(Token = "0x40015B1")]
		[FieldOffset(Offset = "0x10")]
		private List<RenderTexture> m_TemporaryRTs;
	}
}
