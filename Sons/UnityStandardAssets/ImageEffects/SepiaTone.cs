using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200030B RID: 779
	[Token(Token = "0x200030B")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Sepia Tone")]
	public class SepiaTone : ImageEffectBase
	{
		// Token: 0x06001487 RID: 5255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001487")]
		[Address(RVA = "0x320D350", Offset = "0x320B950", VA = "0x18320D350")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001488")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SepiaTone()
		{
		}
	}
}
