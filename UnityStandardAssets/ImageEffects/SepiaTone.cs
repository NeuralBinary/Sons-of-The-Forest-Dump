using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000319 RID: 793
	[Token(Token = "0x2000319")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Sepia Tone")]
	public class SepiaTone : ImageEffectBase
	{
		// Token: 0x0600145C RID: 5212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600145C")]
		[Address(RVA = "0x2C6AB60", Offset = "0x2C69B60", VA = "0x182C6AB60")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600145D")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public SepiaTone()
		{
		}
	}
}
