using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000300 RID: 768
	[Token(Token = "0x2000300")]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Enhance (Unsharp Mask)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	internal class ContrastEnhance : PostEffectsBase
	{
		// Token: 0x0600145B RID: 5211 RVA: 0x00006B28 File Offset: 0x00004D28
		[Token(Token = "0x600145B")]
		[Address(RVA = "0x3207320", Offset = "0x3205920", VA = "0x183207320", Slot = "8")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600145C")]
		[Address(RVA = "0x3207460", Offset = "0x3205A60", VA = "0x183207460")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600145D")]
		[Address(RVA = "0x3207970", Offset = "0x3205F70", VA = "0x183207970")]
		public ContrastEnhance()
		{
		}

		// Token: 0x04001408 RID: 5128
		[Token(Token = "0x4001408")]
		[FieldOffset(Offset = "0x28")]
		public float intensity;

		// Token: 0x04001409 RID: 5129
		[Token(Token = "0x4001409")]
		[FieldOffset(Offset = "0x2C")]
		public float threshold;

		// Token: 0x0400140A RID: 5130
		[Token(Token = "0x400140A")]
		[FieldOffset(Offset = "0x30")]
		private Material separableBlurMaterial;

		// Token: 0x0400140B RID: 5131
		[Token(Token = "0x400140B")]
		[FieldOffset(Offset = "0x38")]
		private Material contrastCompositeMaterial;

		// Token: 0x0400140C RID: 5132
		[Token(Token = "0x400140C")]
		[FieldOffset(Offset = "0x40")]
		public float blurSpread;

		// Token: 0x0400140D RID: 5133
		[Token(Token = "0x400140D")]
		[FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		// Token: 0x0400140E RID: 5134
		[Token(Token = "0x400140E")]
		[FieldOffset(Offset = "0x50")]
		public Shader contrastCompositeShader;
	}
}
