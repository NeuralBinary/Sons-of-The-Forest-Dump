using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x0200057E RID: 1406
	[Token(Token = "0x200057E")]
	public class CombinationPass
	{
		// Token: 0x060024DB RID: 9435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DB")]
		[Address(RVA = "0x2D7CDA0", Offset = "0x2D7BDA0", VA = "0x182D7CDA0")]
		public CombinationPass()
		{
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DC")]
		[Address(RVA = "0x2D7CB60", Offset = "0x2D7BB60", VA = "0x182D7CB60")]
		public void ReleaseResources()
		{
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x0000AD40 File Offset: 0x00008F40
		[Token(Token = "0x60024DD")]
		[Address(RVA = "0x2D7C6E0", Offset = "0x2D7B6E0", VA = "0x182D7C6E0")]
		public bool PlatformCompatibility()
		{
			return default(bool);
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DE")]
		[Address(RVA = "0x2D7C730", Offset = "0x2D7B730", VA = "0x182D7C730")]
		private void PrepareBloomSampling(RenderTexture bloomTexture, BloomParameters bloomParams)
		{
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DF")]
		[Address(RVA = "0x2D7CA80", Offset = "0x2D7BA80", VA = "0x182D7CA80")]
		private void PrepareLensDirtSampling(Texture lensDirtTexture, LensDirtParameters lensDirtParams)
		{
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E0")]
		[Address(RVA = "0x2D7C910", Offset = "0x2D7B910", VA = "0x182D7C910")]
		private void PrepareExposure(CameraParameters cameraParams, VirtualCamera virtualCamera)
		{
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E1")]
		[Address(RVA = "0x2D7CC00", Offset = "0x2D7BC00", VA = "0x182D7CC00")]
		private void UploadVariables(CommonPostProcess commonPostProcess)
		{
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E2")]
		[Address(RVA = "0x2D7C820", Offset = "0x2D7B820", VA = "0x182D7C820")]
		private void PrepareColorGrading(ColorGradingParameters colorGradingParams)
		{
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E3")]
		[Address(RVA = "0x2D7C0E0", Offset = "0x2D7B0E0", VA = "0x182D7C0E0")]
		public void Combine(RenderTexture source, RenderTexture dest, PostProcessParameters postProcessParams, VirtualCamera virtualCamera)
		{
		}

		// Token: 0x040020F7 RID: 8439
		[Token(Token = "0x40020F7")]
		[FieldOffset(Offset = "0x10")]
		private Material m_combinationMat;

		// Token: 0x040020F8 RID: 8440
		[Token(Token = "0x40020F8")]
		private const float MinValue = 0.0001f;
	}
}
