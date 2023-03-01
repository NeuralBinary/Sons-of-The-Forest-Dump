using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000317 RID: 791
	[Token(Token = "0x2000317")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Other/Screen Overlay")]
	public class ScreenOverlay : PostEffectsBase
	{
		// Token: 0x06001459 RID: 5209 RVA: 0x00006960 File Offset: 0x00004B60
		[Token(Token = "0x6001459")]
		[Address(RVA = "0x2C6A5E0", Offset = "0x2C695E0", VA = "0x182C6A5E0", Slot = "8")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600145A")]
		[Address(RVA = "0x2C6A660", Offset = "0x2C69660", VA = "0x182C6A660")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600145B")]
		[Address(RVA = "0x2C6A7D0", Offset = "0x2C697D0", VA = "0x182C6A7D0")]
		public ScreenOverlay()
		{
		}

		// Token: 0x04001417 RID: 5143
		[Token(Token = "0x4001417")]
		[FieldOffset(Offset = "0x28")]
		public ScreenOverlay.OverlayBlendMode blendMode;

		// Token: 0x04001418 RID: 5144
		[Token(Token = "0x4001418")]
		[FieldOffset(Offset = "0x2C")]
		public float intensity;

		// Token: 0x04001419 RID: 5145
		[Token(Token = "0x4001419")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D texture;

		// Token: 0x0400141A RID: 5146
		[Token(Token = "0x400141A")]
		[FieldOffset(Offset = "0x38")]
		public Shader overlayShader;

		// Token: 0x0400141B RID: 5147
		[Token(Token = "0x400141B")]
		[FieldOffset(Offset = "0x40")]
		private Material overlayMaterial;

		// Token: 0x02000318 RID: 792
		[Token(Token = "0x2000318")]
		public enum OverlayBlendMode
		{
			// Token: 0x0400141D RID: 5149
			[Token(Token = "0x400141D")]
			Additive,
			// Token: 0x0400141E RID: 5150
			[Token(Token = "0x400141E")]
			ScreenBlend,
			// Token: 0x0400141F RID: 5151
			[Token(Token = "0x400141F")]
			Multiply,
			// Token: 0x04001420 RID: 5152
			[Token(Token = "0x4001420")]
			Overlay,
			// Token: 0x04001421 RID: 5153
			[Token(Token = "0x4001421")]
			AlphaBlend
		}
	}
}
