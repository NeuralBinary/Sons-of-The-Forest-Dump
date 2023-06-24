using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[ExecuteInEditMode]
	[Serializable]
	public class CloudLayerInterpolator : MonoBehaviour
	{
		// Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xAB6620", Offset = "0xAB4C20", VA = "0x180AB6620")]
		public void LoadPreset(string filepath)
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000200")]
		[Address(RVA = "0xAB6930", Offset = "0xAB4F30", VA = "0x180AB6930")]
		private void Start()
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000201")]
		[Address(RVA = "0xAB69F0", Offset = "0xAB4FF0", VA = "0x180AB69F0")]
		private void Update()
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00004D84 File Offset: 0x00002F84
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x992180", Offset = "0x990780", VA = "0x180992180")]
		public bool IsInterpolating()
		{
			return default(bool);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000203")]
		[Address(RVA = "0xAB7A40", Offset = "0xAB6040", VA = "0x180AB7A40")]
		private void populateTextureArrays()
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000204")]
		[Address(RVA = "0xAB8040", Offset = "0xAB6640", VA = "0x180AB8040")]
		public CloudLayerInterpolator()
		{
		}

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x20")]
		[Min(0.1f)]
		[Tooltip("Amount of time it takes to transition to the target preset, in seconds.")]
		public float m_transitionTime;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("If enabled, ignores noise offsets in presets when interpolating. Generally, you'll want this to be the case, that way your noises can keep scrolling as the interpolation occurs.")]
		public bool m_bypassOffset;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x28")]
		public float m_interpolationAmount;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x30")]
		public string m_currentPresetName;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x38")]
		public string m_targetPresetName;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x40")]
		private UniversalCloudLayer m_currentPreset;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x48")]
		private UniversalCloudLayer m_targetPreset;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x50")]
		private int m_presetsLoaded;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x54")]
		private int m_prevPresetsLoaded;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x58")]
		private bool m_interpolating;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x60")]
		public BaseCloudLayerBlock m_cloudLayer;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x68")]
		public TextureInterpolationBlock m_coverageInterpolated;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x70")]
		public ProceduralNoiseBlock m_coverageCurrent;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x78")]
		public ProceduralNoiseBlock m_coverageTarget;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x80")]
		public TextureInterpolationBlock m_baseInterpolated;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x88")]
		public ProceduralNoiseBlock m_baseCurrent;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x90")]
		public ProceduralNoiseBlock m_baseTarget;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x98")]
		public TextureInterpolationBlock m_structureInterpolated;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0xA0")]
		public ProceduralNoiseBlock m_structureCurrent;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0xA8")]
		public ProceduralNoiseBlock m_structureTarget;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0xB0")]
		public TextureInterpolationBlock m_detailInterpolated;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0xB8")]
		public ProceduralNoiseBlock m_detailCurrent;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0xC0")]
		public ProceduralNoiseBlock m_detailTarget;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0xC8")]
		public TextureInterpolationBlock m_baseWarpInterpolated;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0xD0")]
		public ProceduralNoiseBlock m_baseWarpCurrent;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0xD8")]
		public ProceduralNoiseBlock m_baseWarpTarget;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0xE0")]
		public TextureInterpolationBlock m_detailWarpInterpolated;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0xE8")]
		public ProceduralNoiseBlock m_detailWarpCurrent;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0xF0")]
		public ProceduralNoiseBlock m_detailWarpTarget;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0xF8")]
		private TextureInterpolationBlock[] m_interpolatedTextures;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x100")]
		private ProceduralNoiseBlock[] m_currentTextures;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x108")]
		private ProceduralNoiseBlock[] m_targetTextures;
	}
}
