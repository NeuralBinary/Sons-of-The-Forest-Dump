using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200030A RID: 778
	[Token(Token = "0x200030A")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Curves, Saturation)")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		// Token: 0x0600141F RID: 5151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600141F")]
		[Address(RVA = "0x2C5F360", Offset = "0x2C5E360", VA = "0x182C5F360")]
		private new void Start()
		{
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001420")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void Awake()
		{
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x000068A0 File Offset: 0x00004AA0
		[Token(Token = "0x6001421")]
		[Address(RVA = "0x2C5ECC0", Offset = "0x2C5DCC0", VA = "0x182C5ECC0", Slot = "8")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001422")]
		[Address(RVA = "0x2C5F390", Offset = "0x2C5E390", VA = "0x182C5F390")]
		public void UpdateParameters()
		{
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001423")]
		[Address(RVA = "0x2C5F860", Offset = "0x2C5E860", VA = "0x182C5F860")]
		private void UpdateTextures()
		{
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001424")]
		[Address(RVA = "0x2C5F000", Offset = "0x2C5E000", VA = "0x182C5F000")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001425")]
		[Address(RVA = "0x2C5F870", Offset = "0x2C5E870", VA = "0x182C5F870")]
		public ColorCorrectionCurves()
		{
		}

		// Token: 0x040013CA RID: 5066
		[Token(Token = "0x40013CA")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve redChannel;

		// Token: 0x040013CB RID: 5067
		[Token(Token = "0x40013CB")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve greenChannel;

		// Token: 0x040013CC RID: 5068
		[Token(Token = "0x40013CC")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve blueChannel;

		// Token: 0x040013CD RID: 5069
		[Token(Token = "0x40013CD")]
		[FieldOffset(Offset = "0x40")]
		public bool useDepthCorrection;

		// Token: 0x040013CE RID: 5070
		[Token(Token = "0x40013CE")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve zCurve;

		// Token: 0x040013CF RID: 5071
		[Token(Token = "0x40013CF")]
		[FieldOffset(Offset = "0x50")]
		public AnimationCurve depthRedChannel;

		// Token: 0x040013D0 RID: 5072
		[Token(Token = "0x40013D0")]
		[FieldOffset(Offset = "0x58")]
		public AnimationCurve depthGreenChannel;

		// Token: 0x040013D1 RID: 5073
		[Token(Token = "0x40013D1")]
		[FieldOffset(Offset = "0x60")]
		public AnimationCurve depthBlueChannel;

		// Token: 0x040013D2 RID: 5074
		[Token(Token = "0x40013D2")]
		[FieldOffset(Offset = "0x68")]
		private Material ccMaterial;

		// Token: 0x040013D3 RID: 5075
		[Token(Token = "0x40013D3")]
		[FieldOffset(Offset = "0x70")]
		private Material ccDepthMaterial;

		// Token: 0x040013D4 RID: 5076
		[Token(Token = "0x40013D4")]
		[FieldOffset(Offset = "0x78")]
		private Material selectiveCcMaterial;

		// Token: 0x040013D5 RID: 5077
		[Token(Token = "0x40013D5")]
		[FieldOffset(Offset = "0x80")]
		private Texture2D rgbChannelTex;

		// Token: 0x040013D6 RID: 5078
		[Token(Token = "0x40013D6")]
		[FieldOffset(Offset = "0x88")]
		private Texture2D rgbDepthChannelTex;

		// Token: 0x040013D7 RID: 5079
		[Token(Token = "0x40013D7")]
		[FieldOffset(Offset = "0x90")]
		private Texture2D zCurveTex;

		// Token: 0x040013D8 RID: 5080
		[Token(Token = "0x40013D8")]
		[FieldOffset(Offset = "0x98")]
		public float saturation;

		// Token: 0x040013D9 RID: 5081
		[Token(Token = "0x40013D9")]
		[FieldOffset(Offset = "0x9C")]
		public bool selectiveCc;

		// Token: 0x040013DA RID: 5082
		[Token(Token = "0x40013DA")]
		[FieldOffset(Offset = "0xA0")]
		public Color selectiveFromColor;

		// Token: 0x040013DB RID: 5083
		[Token(Token = "0x40013DB")]
		[FieldOffset(Offset = "0xB0")]
		public Color selectiveToColor;

		// Token: 0x040013DC RID: 5084
		[Token(Token = "0x40013DC")]
		[FieldOffset(Offset = "0xC0")]
		public ColorCorrectionCurves.ColorCorrectionMode mode;

		// Token: 0x040013DD RID: 5085
		[Token(Token = "0x40013DD")]
		[FieldOffset(Offset = "0xC4")]
		public bool updateTextures;

		// Token: 0x040013DE RID: 5086
		[Token(Token = "0x40013DE")]
		[FieldOffset(Offset = "0xC8")]
		public Shader colorCorrectionCurvesShader;

		// Token: 0x040013DF RID: 5087
		[Token(Token = "0x40013DF")]
		[FieldOffset(Offset = "0xD0")]
		public Shader simpleColorCorrectionCurvesShader;

		// Token: 0x040013E0 RID: 5088
		[Token(Token = "0x40013E0")]
		[FieldOffset(Offset = "0xD8")]
		public Shader colorCorrectionSelectiveShader;

		// Token: 0x040013E1 RID: 5089
		[Token(Token = "0x40013E1")]
		[FieldOffset(Offset = "0xE0")]
		private bool updateTexturesOnStartup;

		// Token: 0x0200030B RID: 779
		[Token(Token = "0x200030B")]
		public enum ColorCorrectionMode
		{
			// Token: 0x040013E3 RID: 5091
			[Token(Token = "0x40013E3")]
			Simple,
			// Token: 0x040013E4 RID: 5092
			[Token(Token = "0x40013E4")]
			Advanced
		}
	}
}
