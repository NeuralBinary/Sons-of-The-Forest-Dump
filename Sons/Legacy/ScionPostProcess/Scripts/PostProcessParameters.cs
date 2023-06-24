using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x0200059E RID: 1438
	[Token(Token = "0x200059E")]
	public class PostProcessParameters
	{
		// Token: 0x060025F8 RID: 9720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F8")]
		[Address(RVA = "0x33A3950", Offset = "0x33A1F50", VA = "0x1833A3950")]
		public PostProcessParameters()
		{
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F9")]
		[Address(RVA = "0x33A3970", Offset = "0x33A1F70", VA = "0x1833A3970")]
		public void Fill(ScionPostProcess postProcess)
		{
		}

		// Token: 0x0400220F RID: 8719
		[Token(Token = "0x400220F")]
		[FieldOffset(Offset = "0x10")]
		public bool tonemapping;

		// Token: 0x04002210 RID: 8720
		[Token(Token = "0x4002210")]
		[FieldOffset(Offset = "0x11")]
		public bool bloom;

		// Token: 0x04002211 RID: 8721
		[Token(Token = "0x4002211")]
		[FieldOffset(Offset = "0x12")]
		public bool lensDirt;

		// Token: 0x04002212 RID: 8722
		[Token(Token = "0x4002212")]
		[FieldOffset(Offset = "0x13")]
		public bool exposure;

		// Token: 0x04002213 RID: 8723
		[Token(Token = "0x4002213")]
		[FieldOffset(Offset = "0x14")]
		public bool depthOfField;

		// Token: 0x04002214 RID: 8724
		[Token(Token = "0x4002214")]
		[FieldOffset(Offset = "0x15")]
		public bool isFirstRender;

		// Token: 0x04002215 RID: 8725
		[Token(Token = "0x4002215")]
		[FieldOffset(Offset = "0x18")]
		public int width;

		// Token: 0x04002216 RID: 8726
		[Token(Token = "0x4002216")]
		[FieldOffset(Offset = "0x1C")]
		public int height;

		// Token: 0x04002217 RID: 8727
		[Token(Token = "0x4002217")]
		[FieldOffset(Offset = "0x20")]
		public int halfWidth;

		// Token: 0x04002218 RID: 8728
		[Token(Token = "0x4002218")]
		[FieldOffset(Offset = "0x24")]
		public int halfHeight;

		// Token: 0x04002219 RID: 8729
		[Token(Token = "0x4002219")]
		[FieldOffset(Offset = "0x28")]
		public RenderTexture halfResSource;

		// Token: 0x0400221A RID: 8730
		[Token(Token = "0x400221A")]
		[FieldOffset(Offset = "0x30")]
		public RenderTexture halfResDepth;

		// Token: 0x0400221B RID: 8731
		[Token(Token = "0x400221B")]
		[FieldOffset(Offset = "0x38")]
		public RenderTexture bloomTexture;

		// Token: 0x0400221C RID: 8732
		[Token(Token = "0x400221C")]
		[FieldOffset(Offset = "0x40")]
		public RenderTexture dofTexture;

		// Token: 0x0400221D RID: 8733
		[Token(Token = "0x400221D")]
		[FieldOffset(Offset = "0x48")]
		public Texture lensDirtTexture;

		// Token: 0x0400221E RID: 8734
		[Token(Token = "0x400221E")]
		[FieldOffset(Offset = "0x50")]
		public BloomParameters bloomParams;

		// Token: 0x0400221F RID: 8735
		[Token(Token = "0x400221F")]
		[FieldOffset(Offset = "0x5C")]
		public LensDirtParameters lensDirtParams;

		// Token: 0x04002220 RID: 8736
		[Token(Token = "0x4002220")]
		[FieldOffset(Offset = "0x64")]
		public CameraParameters cameraParams;

		// Token: 0x04002221 RID: 8737
		[Token(Token = "0x4002221")]
		[FieldOffset(Offset = "0x9C")]
		public DepthOfFieldParameters DoFParams;

		// Token: 0x04002222 RID: 8738
		[Token(Token = "0x4002222")]
		[FieldOffset(Offset = "0xC8")]
		public ColorGradingParameters colorGradingParams;

		// Token: 0x04002223 RID: 8739
		[Token(Token = "0x4002223")]
		[FieldOffset(Offset = "0xE8")]
		public PreCalcValues preCalcValues;

		// Token: 0x04002224 RID: 8740
		[Token(Token = "0x4002224")]
		[FieldOffset(Offset = "0xEC")]
		public CommonPostProcess commonPostProcess;
	}
}
