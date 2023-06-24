using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020002FF RID: 767
	[Token(Token = "0x20002FF")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Ramp)")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		// Token: 0x06001459 RID: 5209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001459")]
		[Address(RVA = "0x3207270", Offset = "0x3205870", VA = "0x183207270")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600145A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ColorCorrectionRamp()
		{
		}

		// Token: 0x04001407 RID: 5127
		[Token(Token = "0x4001407")]
		[FieldOffset(Offset = "0x30")]
		public Texture textureRamp;
	}
}
