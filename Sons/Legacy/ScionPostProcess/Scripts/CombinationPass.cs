using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x0200058E RID: 1422
	[Token(Token = "0x200058E")]
	public class CombinationPass
	{
		// Token: 0x060025DA RID: 9690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DA")]
		[Address(RVA = "0x339FAF0", Offset = "0x339E0F0", VA = "0x18339FAF0")]
		public CombinationPass()
		{
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DB")]
		[Address(RVA = "0x339FC10", Offset = "0x339E210", VA = "0x18339FC10")]
		public void ReleaseResources()
		{
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x0000B400 File Offset: 0x00009600
		[Token(Token = "0x60025DC")]
		[Address(RVA = "0x339FD40", Offset = "0x339E340", VA = "0x18339FD40")]
		public bool PlatformCompatibility()
		{
			return default(bool);
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DD")]
		[Address(RVA = "0x339FDD0", Offset = "0x339E3D0", VA = "0x18339FDD0")]
		private void PrepareBloomSampling(RenderTexture bloomTexture, BloomParameters bloomParams)
		{
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DE")]
		[Address(RVA = "0x339FEC0", Offset = "0x339E4C0", VA = "0x18339FEC0")]
		private void PrepareLensDirtSampling(Texture lensDirtTexture, LensDirtParameters lensDirtParams)
		{
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DF")]
		[Address(RVA = "0x339FFA0", Offset = "0x339E5A0", VA = "0x18339FFA0")]
		private void PrepareExposure(CameraParameters cameraParams, VirtualCamera virtualCamera)
		{
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E0")]
		[Address(RVA = "0x33A0110", Offset = "0x339E710", VA = "0x1833A0110")]
		private void UploadVariables(CommonPostProcess commonPostProcess)
		{
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E1")]
		[Address(RVA = "0x33A02E0", Offset = "0x339E8E0", VA = "0x1833A02E0")]
		private void PrepareColorGrading(ColorGradingParameters colorGradingParams)
		{
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E2")]
		[Address(RVA = "0x33A03D0", Offset = "0x339E9D0", VA = "0x1833A03D0")]
		public void Combine(RenderTexture source, RenderTexture dest, PostProcessParameters postProcessParams, VirtualCamera virtualCamera)
		{
		}

		// Token: 0x040021CB RID: 8651
		[Token(Token = "0x40021CB")]
		[FieldOffset(Offset = "0x10")]
		private Material m_combinationMat;

		// Token: 0x040021CC RID: 8652
		[Token(Token = "0x40021CC")]
		private const float MinValue = 0.0001f;
	}
}
