using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020002FC RID: 764
	[Token(Token = "0x20002FC")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Curves, Saturation)")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		// Token: 0x0600144A RID: 5194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600144A")]
		[Address(RVA = "0x32041D0", Offset = "0x32027D0", VA = "0x1832041D0")]
		private new void Start()
		{
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600144B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void Awake()
		{
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00006AE0 File Offset: 0x00004CE0
		[Token(Token = "0x600144C")]
		[Address(RVA = "0x3204200", Offset = "0x3202800", VA = "0x183204200", Slot = "8")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600144D")]
		[Address(RVA = "0x32049F0", Offset = "0x3202FF0", VA = "0x1832049F0")]
		public void UpdateParameters()
		{
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600144E")]
		[Address(RVA = "0x32054D0", Offset = "0x3203AD0", VA = "0x1832054D0")]
		private void UpdateTextures()
		{
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600144F")]
		[Address(RVA = "0x32054E0", Offset = "0x3203AE0", VA = "0x1832054E0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001450")]
		[Address(RVA = "0x32058E0", Offset = "0x3203EE0", VA = "0x1832058E0")]
		public ColorCorrectionCurves()
		{
		}

		// Token: 0x040013E8 RID: 5096
		[Token(Token = "0x40013E8")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve redChannel;

		// Token: 0x040013E9 RID: 5097
		[Token(Token = "0x40013E9")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve greenChannel;

		// Token: 0x040013EA RID: 5098
		[Token(Token = "0x40013EA")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve blueChannel;

		// Token: 0x040013EB RID: 5099
		[Token(Token = "0x40013EB")]
		[FieldOffset(Offset = "0x40")]
		public bool useDepthCorrection;

		// Token: 0x040013EC RID: 5100
		[Token(Token = "0x40013EC")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve zCurve;

		// Token: 0x040013ED RID: 5101
		[Token(Token = "0x40013ED")]
		[FieldOffset(Offset = "0x50")]
		public AnimationCurve depthRedChannel;

		// Token: 0x040013EE RID: 5102
		[Token(Token = "0x40013EE")]
		[FieldOffset(Offset = "0x58")]
		public AnimationCurve depthGreenChannel;

		// Token: 0x040013EF RID: 5103
		[Token(Token = "0x40013EF")]
		[FieldOffset(Offset = "0x60")]
		public AnimationCurve depthBlueChannel;

		// Token: 0x040013F0 RID: 5104
		[Token(Token = "0x40013F0")]
		[FieldOffset(Offset = "0x68")]
		private Material ccMaterial;

		// Token: 0x040013F1 RID: 5105
		[Token(Token = "0x40013F1")]
		[FieldOffset(Offset = "0x70")]
		private Material ccDepthMaterial;

		// Token: 0x040013F2 RID: 5106
		[Token(Token = "0x40013F2")]
		[FieldOffset(Offset = "0x78")]
		private Material selectiveCcMaterial;

		// Token: 0x040013F3 RID: 5107
		[Token(Token = "0x40013F3")]
		[FieldOffset(Offset = "0x80")]
		private Texture2D rgbChannelTex;

		// Token: 0x040013F4 RID: 5108
		[Token(Token = "0x40013F4")]
		[FieldOffset(Offset = "0x88")]
		private Texture2D rgbDepthChannelTex;

		// Token: 0x040013F5 RID: 5109
		[Token(Token = "0x40013F5")]
		[FieldOffset(Offset = "0x90")]
		private Texture2D zCurveTex;

		// Token: 0x040013F6 RID: 5110
		[Token(Token = "0x40013F6")]
		[FieldOffset(Offset = "0x98")]
		public float saturation;

		// Token: 0x040013F7 RID: 5111
		[Token(Token = "0x40013F7")]
		[FieldOffset(Offset = "0x9C")]
		public bool selectiveCc;

		// Token: 0x040013F8 RID: 5112
		[Token(Token = "0x40013F8")]
		[FieldOffset(Offset = "0xA0")]
		public Color selectiveFromColor;

		// Token: 0x040013F9 RID: 5113
		[Token(Token = "0x40013F9")]
		[FieldOffset(Offset = "0xB0")]
		public Color selectiveToColor;

		// Token: 0x040013FA RID: 5114
		[Token(Token = "0x40013FA")]
		[FieldOffset(Offset = "0xC0")]
		public ColorCorrectionCurves.ColorCorrectionMode mode;

		// Token: 0x040013FB RID: 5115
		[Token(Token = "0x40013FB")]
		[FieldOffset(Offset = "0xC4")]
		public bool updateTextures;

		// Token: 0x040013FC RID: 5116
		[Token(Token = "0x40013FC")]
		[FieldOffset(Offset = "0xC8")]
		public Shader colorCorrectionCurvesShader;

		// Token: 0x040013FD RID: 5117
		[Token(Token = "0x40013FD")]
		[FieldOffset(Offset = "0xD0")]
		public Shader simpleColorCorrectionCurvesShader;

		// Token: 0x040013FE RID: 5118
		[Token(Token = "0x40013FE")]
		[FieldOffset(Offset = "0xD8")]
		public Shader colorCorrectionSelectiveShader;

		// Token: 0x040013FF RID: 5119
		[Token(Token = "0x40013FF")]
		[FieldOffset(Offset = "0xE0")]
		private bool updateTexturesOnStartup;

		// Token: 0x020002FD RID: 765
		[Token(Token = "0x20002FD")]
		public enum ColorCorrectionMode
		{
			// Token: 0x04001401 RID: 5121
			[Token(Token = "0x4001401")]
			Simple,
			// Token: 0x04001402 RID: 5122
			[Token(Token = "0x4001402")]
			Advanced
		}
	}
}
