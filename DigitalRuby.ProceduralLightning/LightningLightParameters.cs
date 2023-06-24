using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[Serializable]
	public class LightningLightParameters
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x17000003")]
		public bool HasLight
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0xA2F370", Offset = "0xA2D970", VA = "0x180A2F370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000050")]
		[Address(RVA = "0xA2F3B0", Offset = "0xA2D9B0", VA = "0x180A2F3B0")]
		public LightningLightParameters()
		{
		}

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("Light render mode - leave as auto unless you have special use cases")]
		[HideInInspector]
		public LightRenderMode RenderMode;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x14")]
		[Tooltip("Color of the light")]
		public Color LightColor;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		[Tooltip("What percent of segments should have a light? For performance you may want to keep this small.")]
		public float LightPercent;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("What percent of lights created should cast shadows?")]
		public float LightShadowPercent;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 8f)]
		[Tooltip("Light intensity")]
		public float LightIntensity;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Bounce intensity")]
		[Range(0f, 8f)]
		public float BounceIntensity;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Shadow strength, 0 means all light, 1 means all shadow")]
		[Range(0f, 1f)]
		public float ShadowStrength;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Shadow bias, 0 - 2")]
		[Range(0f, 2f)]
		public float ShadowBias;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Shadow normal bias, 0 - 3")]
		[Range(0f, 3f)]
		public float ShadowNormalBias;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("The range of each light created")]
		public float LightRange;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Only light objects that match this layer mask")]
		public LayerMask CullingMask;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Offset from camera position when in orthographic mode")]
		[Range(-1000f, 1000f)]
		public float OrthographicOffset;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("Increase the duration of light fade in compared to the lightning fade.")]
		[Range(0f, 20f)]
		public float FadeInMultiplier;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x50")]
		[Range(0f, 20f)]
		[Tooltip("Increase the duration of light fully lit compared to the lightning fade.")]
		public float FadeFullyLitMultiplier;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x54")]
		[Range(0f, 20f)]
		[Tooltip("Increase the duration of light fade out compared to the lightning fade.")]
		public float FadeOutMultiplier;
	}
}
