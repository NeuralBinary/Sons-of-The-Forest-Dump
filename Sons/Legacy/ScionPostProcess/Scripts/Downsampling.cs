using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x02000590 RID: 1424
	[Token(Token = "0x2000590")]
	public class Downsampling
	{
		// Token: 0x060025F3 RID: 9715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F3")]
		[Address(RVA = "0x33A2EB0", Offset = "0x33A14B0", VA = "0x1833A2EB0")]
		public Downsampling()
		{
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F4")]
		[Address(RVA = "0x33A2FD0", Offset = "0x33A15D0", VA = "0x1833A2FD0")]
		public RenderTexture DownsampleFireflyRemoving(RenderTexture source)
		{
			return null;
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F5")]
		[Address(RVA = "0x33A3220", Offset = "0x33A1820", VA = "0x1833A3220")]
		public RenderTexture DownsampleFireflyRemovingBilateral(RenderTexture source, RenderTexture halfResDepth)
		{
			return null;
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F6")]
		[Address(RVA = "0x33A3530", Offset = "0x33A1B30", VA = "0x1833A3530")]
		public RenderTexture DownsampleDepthTexture(int width, int height)
		{
			return null;
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F7")]
		[Address(RVA = "0x33A3650", Offset = "0x33A1C50", VA = "0x1833A3650")]
		public RenderTexture Downsample(RenderTexture source)
		{
			return null;
		}

		// Token: 0x040021D0 RID: 8656
		[Token(Token = "0x40021D0")]
		[FieldOffset(Offset = "0x10")]
		private Material m_downsampleMat;

		// Token: 0x040021D1 RID: 8657
		[Token(Token = "0x40021D1")]
		private const int FireflyRemovingPass = 0;

		// Token: 0x040021D2 RID: 8658
		[Token(Token = "0x40021D2")]
		private const int FireflyRemovingBilateralPass = 1;

		// Token: 0x040021D3 RID: 8659
		[Token(Token = "0x40021D3")]
		private const int DepthPass = 2;
	}
}
