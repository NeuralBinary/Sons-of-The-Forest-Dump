using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000310 RID: 784
	[Token(Token = "0x2000310")]
	[AddComponentMenu("Image Effects/Edge Detection/Crease Shading")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	internal class CreaseShading : PostEffectsBase
	{
		// Token: 0x0600143D RID: 5181 RVA: 0x00006900 File Offset: 0x00004B00
		[Token(Token = "0x600143D")]
		[Address(RVA = "0x2C61CA0", Offset = "0x2C60CA0", VA = "0x182C61CA0", Slot = "8")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600143E")]
		[Address(RVA = "0x2C61D80", Offset = "0x2C60D80", VA = "0x182C61D80")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600143F")]
		[Address(RVA = "0x2C62120", Offset = "0x2C61120", VA = "0x182C62120")]
		public CreaseShading()
		{
		}

		// Token: 0x040013FE RID: 5118
		[Token(Token = "0x40013FE")]
		[FieldOffset(Offset = "0x28")]
		public float intensity;

		// Token: 0x040013FF RID: 5119
		[Token(Token = "0x40013FF")]
		[FieldOffset(Offset = "0x2C")]
		public int softness;

		// Token: 0x04001400 RID: 5120
		[Token(Token = "0x4001400")]
		[FieldOffset(Offset = "0x30")]
		public float spread;

		// Token: 0x04001401 RID: 5121
		[Token(Token = "0x4001401")]
		[FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		// Token: 0x04001402 RID: 5122
		[Token(Token = "0x4001402")]
		[FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		// Token: 0x04001403 RID: 5123
		[Token(Token = "0x4001403")]
		[FieldOffset(Offset = "0x48")]
		public Shader depthFetchShader;

		// Token: 0x04001404 RID: 5124
		[Token(Token = "0x4001404")]
		[FieldOffset(Offset = "0x50")]
		private Material depthFetchMaterial;

		// Token: 0x04001405 RID: 5125
		[Token(Token = "0x4001405")]
		[FieldOffset(Offset = "0x58")]
		public Shader creaseApplyShader;

		// Token: 0x04001406 RID: 5126
		[Token(Token = "0x4001406")]
		[FieldOffset(Offset = "0x60")]
		private Material creaseApplyMaterial;
	}
}
