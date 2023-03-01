using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200030D RID: 781
	[Token(Token = "0x200030D")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Ramp)")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		// Token: 0x0600142E RID: 5166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600142E")]
		[Address(RVA = "0x2C60B10", Offset = "0x2C5FB10", VA = "0x182C60B10")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600142F")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ColorCorrectionRamp()
		{
		}

		// Token: 0x040013E9 RID: 5097
		[Token(Token = "0x40013E9")]
		[FieldOffset(Offset = "0x30")]
		public Texture textureRamp;
	}
}
