using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x0200057B RID: 1403
	[Token(Token = "0x200057B")]
	public class Bloom
	{
		// Token: 0x060024CE RID: 9422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CE")]
		[Address(RVA = "0x2D7BF80", Offset = "0x2D7AF80", VA = "0x182D7BF80")]
		public Bloom()
		{
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CF")]
		[Address(RVA = "0x2D7BD80", Offset = "0x2D7AD80", VA = "0x182D7BD80")]
		public void ReleaseResources()
		{
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x0000AD10 File Offset: 0x00008F10
		[Token(Token = "0x60024D0")]
		[Address(RVA = "0x2D7BD30", Offset = "0x2D7AD30", VA = "0x182D7BD30")]
		public bool PlatformCompatibility()
		{
			return default(bool);
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D1")]
		[Address(RVA = "0x2D7BE20", Offset = "0x2D7AE20", VA = "0x182D7BE20")]
		public RenderTexture TryGetSmallBloomTexture(int minimumReqPixels)
		{
			return null;
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x0000AD28 File Offset: 0x00008F28
		[Token(Token = "0x60024D2")]
		[Address(RVA = "0x2D7BD10", Offset = "0x2D7AD10", VA = "0x182D7BD10")]
		public float GetEnergyNormalizer()
		{
			return default(float);
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D3")]
		[Address(RVA = "0x2D7BC70", Offset = "0x2D7AC70", VA = "0x182D7BC70")]
		public void EndOfFrameCleanup()
		{
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D4")]
		[Address(RVA = "0x2D7B8A0", Offset = "0x2D7A8A0", VA = "0x182D7B8A0")]
		public RenderTexture CreateBloomTexture(RenderTexture halfResSource, BloomParameters bloomParams)
		{
			return null;
		}

		// Token: 0x040020F3 RID: 8435
		[Token(Token = "0x40020F3")]
		[FieldOffset(Offset = "0x10")]
		private Material m_bloomMat;

		// Token: 0x040020F4 RID: 8436
		[Token(Token = "0x40020F4")]
		[FieldOffset(Offset = "0x18")]
		private RenderTexture[] m_bloomTextures;

		// Token: 0x040020F5 RID: 8437
		[Token(Token = "0x40020F5")]
		[FieldOffset(Offset = "0x20")]
		private int numDownsamples;

		// Token: 0x040020F6 RID: 8438
		[Token(Token = "0x40020F6")]
		[FieldOffset(Offset = "0x24")]
		private int iteratedTextures;
	}
}
