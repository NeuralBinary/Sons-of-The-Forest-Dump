using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000309 RID: 777
	[Token(Token = "0x2000309")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Other/Screen Overlay")]
	public class ScreenOverlay : PostEffectsBase
	{
		// Token: 0x06001484 RID: 5252 RVA: 0x00006BA0 File Offset: 0x00004DA0
		[Token(Token = "0x6001484")]
		[Address(RVA = "0x320D0D0", Offset = "0x320B6D0", VA = "0x18320D0D0", Slot = "8")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001485")]
		[Address(RVA = "0x320D180", Offset = "0x320B780", VA = "0x18320D180")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001486")]
		[Address(RVA = "0x320D2F0", Offset = "0x320B8F0", VA = "0x18320D2F0")]
		public ScreenOverlay()
		{
		}

		// Token: 0x04001435 RID: 5173
		[Token(Token = "0x4001435")]
		[FieldOffset(Offset = "0x28")]
		public ScreenOverlay.OverlayBlendMode blendMode;

		// Token: 0x04001436 RID: 5174
		[Token(Token = "0x4001436")]
		[FieldOffset(Offset = "0x2C")]
		public float intensity;

		// Token: 0x04001437 RID: 5175
		[Token(Token = "0x4001437")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D texture;

		// Token: 0x04001438 RID: 5176
		[Token(Token = "0x4001438")]
		[FieldOffset(Offset = "0x38")]
		public Shader overlayShader;

		// Token: 0x04001439 RID: 5177
		[Token(Token = "0x4001439")]
		[FieldOffset(Offset = "0x40")]
		private Material overlayMaterial;

		// Token: 0x0200030A RID: 778
		[Token(Token = "0x200030A")]
		public enum OverlayBlendMode
		{
			// Token: 0x0400143B RID: 5179
			[Token(Token = "0x400143B")]
			Additive,
			// Token: 0x0400143C RID: 5180
			[Token(Token = "0x400143C")]
			ScreenBlend,
			// Token: 0x0400143D RID: 5181
			[Token(Token = "0x400143D")]
			Multiply,
			// Token: 0x0400143E RID: 5182
			[Token(Token = "0x400143E")]
			Overlay,
			// Token: 0x0400143F RID: 5183
			[Token(Token = "0x400143F")]
			AlphaBlend
		}
	}
}
