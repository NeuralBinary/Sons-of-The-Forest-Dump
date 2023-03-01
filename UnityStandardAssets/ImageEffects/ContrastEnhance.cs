using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200030E RID: 782
	[Token(Token = "0x200030E")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Enhance (Unsharp Mask)")]
	[ExecuteInEditMode]
	internal class ContrastEnhance : PostEffectsBase
	{
		// Token: 0x06001430 RID: 5168 RVA: 0x000068E8 File Offset: 0x00004AE8
		[Token(Token = "0x6001430")]
		[Address(RVA = "0x2C60BC0", Offset = "0x2C5FBC0", VA = "0x182C60BC0", Slot = "8")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001431")]
		[Address(RVA = "0x2C60C70", Offset = "0x2C5FC70", VA = "0x182C60C70")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001432")]
		[Address(RVA = "0x2C60FE0", Offset = "0x2C5FFE0", VA = "0x182C60FE0")]
		public ContrastEnhance()
		{
		}

		// Token: 0x040013EA RID: 5098
		[Token(Token = "0x40013EA")]
		[FieldOffset(Offset = "0x28")]
		public float intensity;

		// Token: 0x040013EB RID: 5099
		[Token(Token = "0x40013EB")]
		[FieldOffset(Offset = "0x2C")]
		public float threshold;

		// Token: 0x040013EC RID: 5100
		[Token(Token = "0x40013EC")]
		[FieldOffset(Offset = "0x30")]
		private Material separableBlurMaterial;

		// Token: 0x040013ED RID: 5101
		[Token(Token = "0x40013ED")]
		[FieldOffset(Offset = "0x38")]
		private Material contrastCompositeMaterial;

		// Token: 0x040013EE RID: 5102
		[Token(Token = "0x40013EE")]
		[FieldOffset(Offset = "0x40")]
		public float blurSpread;

		// Token: 0x040013EF RID: 5103
		[Token(Token = "0x40013EF")]
		[FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		// Token: 0x040013F0 RID: 5104
		[Token(Token = "0x40013F0")]
		[FieldOffset(Offset = "0x50")]
		public Shader contrastCompositeShader;
	}
}
