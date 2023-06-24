using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200030C RID: 780
	[Token(Token = "0x200030C")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Rendering/Sun Shafts")]
	public class SunShafts : PostEffectsBase
	{
		// Token: 0x06001489 RID: 5257 RVA: 0x00006BB8 File Offset: 0x00004DB8
		[Token(Token = "0x6001489")]
		[Address(RVA = "0x320D3D0", Offset = "0x320B9D0", VA = "0x18320D3D0", Slot = "8")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600148A")]
		[Address(RVA = "0x320D510", Offset = "0x320BB10", VA = "0x18320D510")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600148B")]
		[Address(RVA = "0x320E250", Offset = "0x320C850", VA = "0x18320E250")]
		public SunShafts()
		{
		}

		// Token: 0x04001440 RID: 5184
		[Token(Token = "0x4001440")]
		[FieldOffset(Offset = "0x28")]
		public SunShafts.SunShaftsResolution resolution;

		// Token: 0x04001441 RID: 5185
		[Token(Token = "0x4001441")]
		[FieldOffset(Offset = "0x2C")]
		public SunShafts.ShaftsScreenBlendMode screenBlendMode;

		// Token: 0x04001442 RID: 5186
		[Token(Token = "0x4001442")]
		[FieldOffset(Offset = "0x30")]
		public Transform sunTransform;

		// Token: 0x04001443 RID: 5187
		[Token(Token = "0x4001443")]
		[FieldOffset(Offset = "0x38")]
		public int radialBlurIterations;

		// Token: 0x04001444 RID: 5188
		[Token(Token = "0x4001444")]
		[FieldOffset(Offset = "0x3C")]
		public Color sunColor;

		// Token: 0x04001445 RID: 5189
		[Token(Token = "0x4001445")]
		[FieldOffset(Offset = "0x4C")]
		public Color sunThreshold;

		// Token: 0x04001446 RID: 5190
		[Token(Token = "0x4001446")]
		[FieldOffset(Offset = "0x5C")]
		public float sunShaftBlurRadius;

		// Token: 0x04001447 RID: 5191
		[Token(Token = "0x4001447")]
		[FieldOffset(Offset = "0x60")]
		public float sunShaftIntensity;

		// Token: 0x04001448 RID: 5192
		[Token(Token = "0x4001448")]
		[FieldOffset(Offset = "0x64")]
		public float maxRadius;

		// Token: 0x04001449 RID: 5193
		[Token(Token = "0x4001449")]
		[FieldOffset(Offset = "0x68")]
		public bool useDepthTexture;

		// Token: 0x0400144A RID: 5194
		[Token(Token = "0x400144A")]
		[FieldOffset(Offset = "0x70")]
		public Shader sunShaftsShader;

		// Token: 0x0400144B RID: 5195
		[Token(Token = "0x400144B")]
		[FieldOffset(Offset = "0x78")]
		private Material sunShaftsMaterial;

		// Token: 0x0400144C RID: 5196
		[Token(Token = "0x400144C")]
		[FieldOffset(Offset = "0x80")]
		public Shader simpleClearShader;

		// Token: 0x0400144D RID: 5197
		[Token(Token = "0x400144D")]
		[FieldOffset(Offset = "0x88")]
		private Material simpleClearMaterial;

		// Token: 0x0200030D RID: 781
		[Token(Token = "0x200030D")]
		public enum SunShaftsResolution
		{
			// Token: 0x0400144F RID: 5199
			[Token(Token = "0x400144F")]
			Low,
			// Token: 0x04001450 RID: 5200
			[Token(Token = "0x4001450")]
			Normal,
			// Token: 0x04001451 RID: 5201
			[Token(Token = "0x4001451")]
			High
		}

		// Token: 0x0200030E RID: 782
		[Token(Token = "0x200030E")]
		public enum ShaftsScreenBlendMode
		{
			// Token: 0x04001453 RID: 5203
			[Token(Token = "0x4001453")]
			Screen,
			// Token: 0x04001454 RID: 5204
			[Token(Token = "0x4001454")]
			Add
		}
	}
}
