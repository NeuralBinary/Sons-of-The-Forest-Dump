using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x02000580 RID: 1408
	[Token(Token = "0x2000580")]
	public class Downsampling
	{
		// Token: 0x060024F4 RID: 9460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F4")]
		[Address(RVA = "0x2D82EB0", Offset = "0x2D81EB0", VA = "0x182D82EB0")]
		public Downsampling()
		{
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F5")]
		[Address(RVA = "0x2D82C20", Offset = "0x2D81C20", VA = "0x182D82C20")]
		public RenderTexture DownsampleFireflyRemoving(RenderTexture source)
		{
			return null;
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F6")]
		[Address(RVA = "0x2D82A80", Offset = "0x2D81A80", VA = "0x182D82A80")]
		public RenderTexture DownsampleFireflyRemovingBilateral(RenderTexture source, RenderTexture halfResDepth)
		{
			return null;
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F7")]
		[Address(RVA = "0x2D829F0", Offset = "0x2D819F0", VA = "0x182D829F0")]
		public RenderTexture DownsampleDepthTexture(int width, int height)
		{
			return null;
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F8")]
		[Address(RVA = "0x2D82D60", Offset = "0x2D81D60", VA = "0x182D82D60")]
		public RenderTexture Downsample(RenderTexture source)
		{
			return null;
		}

		// Token: 0x040020FC RID: 8444
		[Token(Token = "0x40020FC")]
		[FieldOffset(Offset = "0x10")]
		private Material m_downsampleMat;

		// Token: 0x040020FD RID: 8445
		[Token(Token = "0x40020FD")]
		private const int FireflyRemovingPass = 0;

		// Token: 0x040020FE RID: 8446
		[Token(Token = "0x40020FE")]
		private const int FireflyRemovingBilateralPass = 1;

		// Token: 0x040020FF RID: 8447
		[Token(Token = "0x40020FF")]
		private const int DepthPass = 2;
	}
}
