using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000007")]
internal class UIBlurPass : CustomPass
{
	// Token: 0x0600001A RID: 26 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x3126070", Offset = "0x3124670", VA = "0x183126070")]
	private ComputeBuffer GetGaussianWeights(int weightCount)
	{
		return null;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x3126350", Offset = "0x3124950", VA = "0x183126350", Slot = "10")]
	protected override void Setup(ScriptableRenderContext renderContext, CommandBuffer cmd)
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x31269E0", Offset = "0x3124FE0", VA = "0x1831269E0", Slot = "9")]
	protected override void Execute(CustomPassContext ctx)
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x3126B70", Offset = "0x3125170", VA = "0x183126B70")]
	private void GenerateGaussianMips(CustomPassContext ctx)
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x3127F20", Offset = "0x3126520", VA = "0x183127F20", Slot = "11")]
	protected override void Cleanup()
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x3128200", Offset = "0x3126800", VA = "0x183128200")]
	public UIBlurPass()
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x0000209C File Offset: 0x0000029C
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x31289A0", Offset = "0x3126FA0", VA = "0x1831289A0")]
	[CompilerGenerated]
	internal static float <GetGaussianWeights>g__Gaussian|26_0(float x, float sigma = 1f)
	{
		return 0f;
	}

	// Token: 0x0400004F RID: 79
	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x90")]
	[Range(0f, 32f)]
	public float radius;

	// Token: 0x04000050 RID: 80
	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x94")]
	[Range(4f, 16f)]
	public int samples;

	// Token: 0x04000051 RID: 81
	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x98")]
	private RTHandle downSampleBuffer;

	// Token: 0x04000052 RID: 82
	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0xA0")]
	private RTHandle blurBuffer;

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0xA8")]
	private Material sonsBlurUIMaterial;

	// Token: 0x04000054 RID: 84
	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0xB0")]
	private int verticalBlurPassIndex;

	// Token: 0x04000055 RID: 85
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0xB4")]
	private int horizontalBlurPassIndex;

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0xB8")]
	private MaterialPropertyBlock propertyBlock;

	// Token: 0x04000057 RID: 87
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0xC0")]
	private Dictionary<int, ComputeBuffer> gaussianWeightsCache;

	// Token: 0x04000058 RID: 88
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x0")]
	private static Vector4 fullScreenScaleBias;

	// Token: 0x04000059 RID: 89
	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int _BlitTexture;

	// Token: 0x0400005A RID: 90
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int _BlitScaleBias;

	// Token: 0x0400005B RID: 91
	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int _BlitMipLevel;

	// Token: 0x0400005C RID: 92
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly int _BlitTexArraySlice;

	// Token: 0x0400005D RID: 93
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x20")]
	private static readonly int _Source;

	// Token: 0x0400005E RID: 94
	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x24")]
	private static readonly int _SourceSize;

	// Token: 0x0400005F RID: 95
	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x28")]
	private static readonly int _SourceScaleBias;

	// Token: 0x04000060 RID: 96
	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x2C")]
	private static readonly int _SourceScaleFactor;

	// Token: 0x04000061 RID: 97
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x30")]
	private static readonly int _GaussianWeights;

	// Token: 0x04000062 RID: 98
	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x34")]
	private static readonly int _SampleCount;

	// Token: 0x04000063 RID: 99
	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x38")]
	private static readonly int _Radius;

	// Token: 0x04000064 RID: 100
	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x3C")]
	private static readonly int _ViewPortSize;

	// Token: 0x04000065 RID: 101
	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x40")]
	private static readonly int _ViewportScaleBias;

	// Token: 0x04000066 RID: 102
	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x44")]
	private static readonly int _FinalScreenBlurred;

	// Token: 0x04000067 RID: 103
	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x48")]
	private static readonly int _AfterPPRTHandles;

	// Token: 0x04000068 RID: 104
	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x4C")]
	private static readonly int _Sons_PostProcessScreenSize;
}
