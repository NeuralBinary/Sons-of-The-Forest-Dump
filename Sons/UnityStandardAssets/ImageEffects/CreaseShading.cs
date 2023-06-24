using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000302 RID: 770
	[Token(Token = "0x2000302")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Edge Detection/Crease Shading")]
	internal class CreaseShading : PostEffectsBase
	{
		// Token: 0x06001468 RID: 5224 RVA: 0x00006B40 File Offset: 0x00004D40
		[Token(Token = "0x6001468")]
		[Address(RVA = "0x3209190", Offset = "0x3207790", VA = "0x183209190", Slot = "8")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001469")]
		[Address(RVA = "0x3209340", Offset = "0x3207940", VA = "0x183209340")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600146A")]
		[Address(RVA = "0x3209A90", Offset = "0x3208090", VA = "0x183209A90")]
		public CreaseShading()
		{
		}

		// Token: 0x0400141C RID: 5148
		[Token(Token = "0x400141C")]
		[FieldOffset(Offset = "0x28")]
		public float intensity;

		// Token: 0x0400141D RID: 5149
		[Token(Token = "0x400141D")]
		[FieldOffset(Offset = "0x2C")]
		public int softness;

		// Token: 0x0400141E RID: 5150
		[Token(Token = "0x400141E")]
		[FieldOffset(Offset = "0x30")]
		public float spread;

		// Token: 0x0400141F RID: 5151
		[Token(Token = "0x400141F")]
		[FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		// Token: 0x04001420 RID: 5152
		[Token(Token = "0x4001420")]
		[FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		// Token: 0x04001421 RID: 5153
		[Token(Token = "0x4001421")]
		[FieldOffset(Offset = "0x48")]
		public Shader depthFetchShader;

		// Token: 0x04001422 RID: 5154
		[Token(Token = "0x4001422")]
		[FieldOffset(Offset = "0x50")]
		private Material depthFetchMaterial;

		// Token: 0x04001423 RID: 5155
		[Token(Token = "0x4001423")]
		[FieldOffset(Offset = "0x58")]
		public Shader creaseApplyShader;

		// Token: 0x04001424 RID: 5156
		[Token(Token = "0x4001424")]
		[FieldOffset(Offset = "0x60")]
		private Material creaseApplyMaterial;
	}
}
