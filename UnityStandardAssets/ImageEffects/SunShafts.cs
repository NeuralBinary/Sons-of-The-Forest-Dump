using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200031A RID: 794
	[Token(Token = "0x200031A")]
	[AddComponentMenu("Image Effects/Rendering/Sun Shafts")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class SunShafts : PostEffectsBase
	{
		// Token: 0x0600145E RID: 5214 RVA: 0x00006978 File Offset: 0x00004B78
		[Token(Token = "0x600145E")]
		[Address(RVA = "0x2C76C40", Offset = "0x2C75C40", VA = "0x182C76C40", Slot = "8")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600145F")]
		[Address(RVA = "0x2C76D00", Offset = "0x2C75D00", VA = "0x182C76D00")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001460")]
		[Address(RVA = "0x2C77540", Offset = "0x2C76540", VA = "0x182C77540")]
		public SunShafts()
		{
		}

		// Token: 0x04001422 RID: 5154
		[Token(Token = "0x4001422")]
		[FieldOffset(Offset = "0x28")]
		public SunShafts.SunShaftsResolution resolution;

		// Token: 0x04001423 RID: 5155
		[Token(Token = "0x4001423")]
		[FieldOffset(Offset = "0x2C")]
		public SunShafts.ShaftsScreenBlendMode screenBlendMode;

		// Token: 0x04001424 RID: 5156
		[Token(Token = "0x4001424")]
		[FieldOffset(Offset = "0x30")]
		public Transform sunTransform;

		// Token: 0x04001425 RID: 5157
		[Token(Token = "0x4001425")]
		[FieldOffset(Offset = "0x38")]
		public int radialBlurIterations;

		// Token: 0x04001426 RID: 5158
		[Token(Token = "0x4001426")]
		[FieldOffset(Offset = "0x3C")]
		public Color sunColor;

		// Token: 0x04001427 RID: 5159
		[Token(Token = "0x4001427")]
		[FieldOffset(Offset = "0x4C")]
		public Color sunThreshold;

		// Token: 0x04001428 RID: 5160
		[Token(Token = "0x4001428")]
		[FieldOffset(Offset = "0x5C")]
		public float sunShaftBlurRadius;

		// Token: 0x04001429 RID: 5161
		[Token(Token = "0x4001429")]
		[FieldOffset(Offset = "0x60")]
		public float sunShaftIntensity;

		// Token: 0x0400142A RID: 5162
		[Token(Token = "0x400142A")]
		[FieldOffset(Offset = "0x64")]
		public float maxRadius;

		// Token: 0x0400142B RID: 5163
		[Token(Token = "0x400142B")]
		[FieldOffset(Offset = "0x68")]
		public bool useDepthTexture;

		// Token: 0x0400142C RID: 5164
		[Token(Token = "0x400142C")]
		[FieldOffset(Offset = "0x70")]
		public Shader sunShaftsShader;

		// Token: 0x0400142D RID: 5165
		[Token(Token = "0x400142D")]
		[FieldOffset(Offset = "0x78")]
		private Material sunShaftsMaterial;

		// Token: 0x0400142E RID: 5166
		[Token(Token = "0x400142E")]
		[FieldOffset(Offset = "0x80")]
		public Shader simpleClearShader;

		// Token: 0x0400142F RID: 5167
		[Token(Token = "0x400142F")]
		[FieldOffset(Offset = "0x88")]
		private Material simpleClearMaterial;

		// Token: 0x0200031B RID: 795
		[Token(Token = "0x200031B")]
		public enum SunShaftsResolution
		{
			// Token: 0x04001431 RID: 5169
			[Token(Token = "0x4001431")]
			Low,
			// Token: 0x04001432 RID: 5170
			[Token(Token = "0x4001432")]
			Normal,
			// Token: 0x04001433 RID: 5171
			[Token(Token = "0x4001433")]
			High
		}

		// Token: 0x0200031C RID: 796
		[Token(Token = "0x200031C")]
		public enum ShaftsScreenBlendMode
		{
			// Token: 0x04001435 RID: 5173
			[Token(Token = "0x4001435")]
			Screen,
			// Token: 0x04001436 RID: 5174
			[Token(Token = "0x4001436")]
			Add
		}
	}
}
