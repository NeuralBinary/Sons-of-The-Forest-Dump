using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x0200058B RID: 1419
	[Token(Token = "0x200058B")]
	public class Bloom
	{
		// Token: 0x060025CD RID: 9677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CD")]
		[Address(RVA = "0x339EDE0", Offset = "0x339D3E0", VA = "0x18339EDE0")]
		public Bloom()
		{
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CE")]
		[Address(RVA = "0x339EF10", Offset = "0x339D510", VA = "0x18339EF10")]
		public void ReleaseResources()
		{
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x0000B3D0 File Offset: 0x000095D0
		[Token(Token = "0x60025CF")]
		[Address(RVA = "0x339F040", Offset = "0x339D640", VA = "0x18339F040")]
		public bool PlatformCompatibility()
		{
			return default(bool);
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D0")]
		[Address(RVA = "0x339F0D0", Offset = "0x339D6D0", VA = "0x18339F0D0")]
		public RenderTexture TryGetSmallBloomTexture(int minimumReqPixels)
		{
			return null;
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x0000B3E8 File Offset: 0x000095E8
		[Token(Token = "0x60025D1")]
		[Address(RVA = "0x339F230", Offset = "0x339D830", VA = "0x18339F230")]
		public float GetEnergyNormalizer()
		{
			return 0f;
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D2")]
		[Address(RVA = "0x339F250", Offset = "0x339D850", VA = "0x18339F250")]
		public void EndOfFrameCleanup()
		{
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D3")]
		[Address(RVA = "0x339F380", Offset = "0x339D980", VA = "0x18339F380")]
		public RenderTexture CreateBloomTexture(RenderTexture halfResSource, BloomParameters bloomParams)
		{
			return null;
		}

		// Token: 0x040021C7 RID: 8647
		[Token(Token = "0x40021C7")]
		[FieldOffset(Offset = "0x10")]
		private Material m_bloomMat;

		// Token: 0x040021C8 RID: 8648
		[Token(Token = "0x40021C8")]
		[FieldOffset(Offset = "0x18")]
		private RenderTexture[] m_bloomTextures;

		// Token: 0x040021C9 RID: 8649
		[Token(Token = "0x40021C9")]
		[FieldOffset(Offset = "0x20")]
		private int numDownsamples;

		// Token: 0x040021CA RID: 8650
		[Token(Token = "0x40021CA")]
		[FieldOffset(Offset = "0x24")]
		private int iteratedTextures;
	}
}
