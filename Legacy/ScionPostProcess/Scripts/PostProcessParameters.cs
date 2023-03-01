using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x0200058E RID: 1422
	[Token(Token = "0x200058E")]
	public class PostProcessParameters
	{
		// Token: 0x060024F9 RID: 9465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F9")]
		[Address(RVA = "0x2D8BC20", Offset = "0x2D8AC20", VA = "0x182D8BC20")]
		public PostProcessParameters()
		{
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FA")]
		[Address(RVA = "0x2D8B930", Offset = "0x2D8A930", VA = "0x182D8B930")]
		public void Fill(ScionPostProcess postProcess)
		{
		}

		// Token: 0x0400213B RID: 8507
		[Token(Token = "0x400213B")]
		[FieldOffset(Offset = "0x10")]
		public bool tonemapping;

		// Token: 0x0400213C RID: 8508
		[Token(Token = "0x400213C")]
		[FieldOffset(Offset = "0x11")]
		public bool bloom;

		// Token: 0x0400213D RID: 8509
		[Token(Token = "0x400213D")]
		[FieldOffset(Offset = "0x12")]
		public bool lensDirt;

		// Token: 0x0400213E RID: 8510
		[Token(Token = "0x400213E")]
		[FieldOffset(Offset = "0x13")]
		public bool exposure;

		// Token: 0x0400213F RID: 8511
		[Token(Token = "0x400213F")]
		[FieldOffset(Offset = "0x14")]
		public bool depthOfField;

		// Token: 0x04002140 RID: 8512
		[Token(Token = "0x4002140")]
		[FieldOffset(Offset = "0x15")]
		public bool isFirstRender;

		// Token: 0x04002141 RID: 8513
		[Token(Token = "0x4002141")]
		[FieldOffset(Offset = "0x18")]
		public int width;

		// Token: 0x04002142 RID: 8514
		[Token(Token = "0x4002142")]
		[FieldOffset(Offset = "0x1C")]
		public int height;

		// Token: 0x04002143 RID: 8515
		[Token(Token = "0x4002143")]
		[FieldOffset(Offset = "0x20")]
		public int halfWidth;

		// Token: 0x04002144 RID: 8516
		[Token(Token = "0x4002144")]
		[FieldOffset(Offset = "0x24")]
		public int halfHeight;

		// Token: 0x04002145 RID: 8517
		[Token(Token = "0x4002145")]
		[FieldOffset(Offset = "0x28")]
		public RenderTexture halfResSource;

		// Token: 0x04002146 RID: 8518
		[Token(Token = "0x4002146")]
		[FieldOffset(Offset = "0x30")]
		public RenderTexture halfResDepth;

		// Token: 0x04002147 RID: 8519
		[Token(Token = "0x4002147")]
		[FieldOffset(Offset = "0x38")]
		public RenderTexture bloomTexture;

		// Token: 0x04002148 RID: 8520
		[Token(Token = "0x4002148")]
		[FieldOffset(Offset = "0x40")]
		public RenderTexture dofTexture;

		// Token: 0x04002149 RID: 8521
		[Token(Token = "0x4002149")]
		[FieldOffset(Offset = "0x48")]
		public Texture lensDirtTexture;

		// Token: 0x0400214A RID: 8522
		[Token(Token = "0x400214A")]
		[FieldOffset(Offset = "0x50")]
		public BloomParameters bloomParams;

		// Token: 0x0400214B RID: 8523
		[Token(Token = "0x400214B")]
		[FieldOffset(Offset = "0x5C")]
		public LensDirtParameters lensDirtParams;

		// Token: 0x0400214C RID: 8524
		[Token(Token = "0x400214C")]
		[FieldOffset(Offset = "0x64")]
		public CameraParameters cameraParams;

		// Token: 0x0400214D RID: 8525
		[Token(Token = "0x400214D")]
		[FieldOffset(Offset = "0x9C")]
		public DepthOfFieldParameters DoFParams;

		// Token: 0x0400214E RID: 8526
		[Token(Token = "0x400214E")]
		[FieldOffset(Offset = "0xC8")]
		public ColorGradingParameters colorGradingParams;

		// Token: 0x0400214F RID: 8527
		[Token(Token = "0x400214F")]
		[FieldOffset(Offset = "0xE8")]
		public PreCalcValues preCalcValues;

		// Token: 0x04002150 RID: 8528
		[Token(Token = "0x4002150")]
		[FieldOffset(Offset = "0xEC")]
		public CommonPostProcess commonPostProcess;
	}
}
