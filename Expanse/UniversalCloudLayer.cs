using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	[Serializable]
	public class UniversalCloudLayer
	{
		// Token: 0x0600030F RID: 783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030F")]
		[Address(RVA = "0xAE2C40", Offset = "0xAE1240", VA = "0x180AE2C40")]
		public UniversalCloudLayer()
		{
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x6000310")]
		[Address(RVA = "0xAE2CD0", Offset = "0xAE12D0", VA = "0x180AE2CD0")]
		public static UniversalCloudLayer lerp(UniversalCloudLayer a, UniversalCloudLayer b, float x)
		{
			return null;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x6000311")]
		[Address(RVA = "0xAE4300", Offset = "0xAE2900", VA = "0x180AE4300")]
		public static UniversalCloudLayer load(string filepath)
		{
			return null;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000312")]
		[Address(RVA = "0xAE43B0", Offset = "0xAE29B0", VA = "0x180AE43B0")]
		public static void save(UniversalCloudLayer universal, string filepath)
		{
		}

		// Token: 0x06000313 RID: 787 RVA: 0x000050E8 File Offset: 0x000032E8
		[Token(Token = "0x6000313")]
		[Address(RVA = "0xAE43E0", Offset = "0xAE29E0", VA = "0x180AE43E0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x10")]
		public Datatypes.Quality noiseTextureQuality;

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x18")]
		public UniversalCloudLayer.UniversalCloudNoiseLayer[] noiseLayers;

		// Token: 0x0400036D RID: 877
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x20")]
		public UniversalCloudLayer.UniversalCloudLayerRenderSettings renderSettings;

		// Token: 0x02000043 RID: 67
		[Token(Token = "0x2000043")]
		[Serializable]
		public struct UniversalCloudNoiseLayer
		{
			// Token: 0x06000314 RID: 788 RVA: 0x00005100 File Offset: 0x00003300
			[Token(Token = "0x6000314")]
			[Address(RVA = "0xAE43F0", Offset = "0xAE29F0", VA = "0x180AE43F0")]
			public static UniversalCloudLayer.UniversalCloudNoiseLayer lerp(UniversalCloudLayer.UniversalCloudNoiseLayer a, UniversalCloudLayer.UniversalCloudNoiseLayer b, float x)
			{
				return default(UniversalCloudLayer.UniversalCloudNoiseLayer);
			}

			// Token: 0x06000315 RID: 789 RVA: 0x00005118 File Offset: 0x00003318
			[Token(Token = "0x6000315")]
			[Address(RVA = "0xAE4410", Offset = "0xAE2A10", VA = "0x180AE4410", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x0400036E RID: 878
			[Token(Token = "0x400036E")]
			[FieldOffset(Offset = "0x0")]
			public UniversalCloudLayer.UniversalCloudNoiseLayer.UniversalCloudNoiseLayerRenderSettings renderSettings;

			// Token: 0x0400036F RID: 879
			[Token(Token = "0x400036F")]
			[FieldOffset(Offset = "0x1C")]
			public bool procedural;

			// Token: 0x04000370 RID: 880
			[Token(Token = "0x4000370")]
			[FieldOffset(Offset = "0x20")]
			public Texture noiseTexture;

			// Token: 0x02000044 RID: 68
			[Token(Token = "0x2000044")]
			[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\clouds\\UniversalCloudLayer.cs", needAccessors = false)]
			[Serializable]
			public struct UniversalCloudNoiseLayerRenderSettings
			{
				// Token: 0x04000371 RID: 881
				[Token(Token = "0x4000371")]
				[FieldOffset(Offset = "0x0")]
				public Datatypes.NoiseType noiseType;

				// Token: 0x04000372 RID: 882
				[Token(Token = "0x4000372")]
				[FieldOffset(Offset = "0x4")]
				public Vector2 scale;

				// Token: 0x04000373 RID: 883
				[Token(Token = "0x4000373")]
				[FieldOffset(Offset = "0xC")]
				public int octaves;

				// Token: 0x04000374 RID: 884
				[Token(Token = "0x4000374")]
				[FieldOffset(Offset = "0x10")]
				public float octaveScale;

				// Token: 0x04000375 RID: 885
				[Token(Token = "0x4000375")]
				[FieldOffset(Offset = "0x14")]
				public float octaveMultiplier;

				// Token: 0x04000376 RID: 886
				[Token(Token = "0x4000376")]
				[FieldOffset(Offset = "0x18")]
				public int tile;
			}
		}

		// Token: 0x02000045 RID: 69
		[Token(Token = "0x2000045")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\clouds\\UniversalCloudLayer.cs", needAccessors = false)]
		[Serializable]
		public struct UniversalCloudLayerRenderSettings
		{
			// Token: 0x04000377 RID: 887
			[Token(Token = "0x4000377")]
			[FieldOffset(Offset = "0x0")]
			public int geometryType;

			// Token: 0x04000378 RID: 888
			[Token(Token = "0x4000378")]
			[FieldOffset(Offset = "0x4")]
			public Vector2 geometryXExtent;

			// Token: 0x04000379 RID: 889
			[Token(Token = "0x4000379")]
			[FieldOffset(Offset = "0xC")]
			public Vector2 geometryYExtent;

			// Token: 0x0400037A RID: 890
			[Token(Token = "0x400037A")]
			[FieldOffset(Offset = "0x14")]
			public Vector2 geometryZExtent;

			// Token: 0x0400037B RID: 891
			[Token(Token = "0x400037B")]
			[FieldOffset(Offset = "0x1C")]
			public float geometryHeight;

			// Token: 0x0400037C RID: 892
			[Token(Token = "0x400037C")]
			[FieldOffset(Offset = "0x20")]
			public float coverageIntensity;

			// Token: 0x0400037D RID: 893
			[Token(Token = "0x400037D")]
			[FieldOffset(Offset = "0x24")]
			public float structureIntensity;

			// Token: 0x0400037E RID: 894
			[Token(Token = "0x400037E")]
			[FieldOffset(Offset = "0x28")]
			public float structureMultiply;

			// Token: 0x0400037F RID: 895
			[Token(Token = "0x400037F")]
			[FieldOffset(Offset = "0x2C")]
			public float detailIntensity;

			// Token: 0x04000380 RID: 896
			[Token(Token = "0x4000380")]
			[FieldOffset(Offset = "0x30")]
			public float detailMultiply;

			// Token: 0x04000381 RID: 897
			[Token(Token = "0x4000381")]
			[FieldOffset(Offset = "0x34")]
			public float baseWarpIntensity;

			// Token: 0x04000382 RID: 898
			[Token(Token = "0x4000382")]
			[FieldOffset(Offset = "0x38")]
			public float detailWarpIntensity;

			// Token: 0x04000383 RID: 899
			[Token(Token = "0x4000383")]
			[FieldOffset(Offset = "0x3C")]
			public Vector2 heightGradientBottom;

			// Token: 0x04000384 RID: 900
			[Token(Token = "0x4000384")]
			[FieldOffset(Offset = "0x44")]
			public Vector2 heightGradientTop;

			// Token: 0x04000385 RID: 901
			[Token(Token = "0x4000385")]
			[FieldOffset(Offset = "0x4C")]
			public float rounding;

			// Token: 0x04000386 RID: 902
			[Token(Token = "0x4000386")]
			[FieldOffset(Offset = "0x50")]
			public float roundingShape;

			// Token: 0x04000387 RID: 903
			[Token(Token = "0x4000387")]
			[FieldOffset(Offset = "0x54")]
			public Vector2 windSkew;

			// Token: 0x04000388 RID: 904
			[Token(Token = "0x4000388")]
			[FieldOffset(Offset = "0x5C")]
			public int coverageTile;

			// Token: 0x04000389 RID: 905
			[Token(Token = "0x4000389")]
			[FieldOffset(Offset = "0x60")]
			public int baseTile;

			// Token: 0x0400038A RID: 906
			[Token(Token = "0x400038A")]
			[FieldOffset(Offset = "0x64")]
			public int structureTile;

			// Token: 0x0400038B RID: 907
			[Token(Token = "0x400038B")]
			[FieldOffset(Offset = "0x68")]
			public int detailTile;

			// Token: 0x0400038C RID: 908
			[Token(Token = "0x400038C")]
			[FieldOffset(Offset = "0x6C")]
			public int baseWarpTile;

			// Token: 0x0400038D RID: 909
			[Token(Token = "0x400038D")]
			[FieldOffset(Offset = "0x70")]
			public int detailWarpTile;

			// Token: 0x0400038E RID: 910
			[Token(Token = "0x400038E")]
			[FieldOffset(Offset = "0x74")]
			public Vector3 coverageOffset;

			// Token: 0x0400038F RID: 911
			[Token(Token = "0x400038F")]
			[FieldOffset(Offset = "0x80")]
			public Vector3 baseOffset;

			// Token: 0x04000390 RID: 912
			[Token(Token = "0x4000390")]
			[FieldOffset(Offset = "0x8C")]
			public Vector3 structureOffset;

			// Token: 0x04000391 RID: 913
			[Token(Token = "0x4000391")]
			[FieldOffset(Offset = "0x98")]
			public Vector3 detailOffset;

			// Token: 0x04000392 RID: 914
			[Token(Token = "0x4000392")]
			[FieldOffset(Offset = "0xA4")]
			public Vector3 baseWarpOffset;

			// Token: 0x04000393 RID: 915
			[Token(Token = "0x4000393")]
			[FieldOffset(Offset = "0xB0")]
			public Vector3 detailWarpOffset;

			// Token: 0x04000394 RID: 916
			[Token(Token = "0x4000394")]
			[FieldOffset(Offset = "0xBC")]
			public float density;

			// Token: 0x04000395 RID: 917
			[Token(Token = "0x4000395")]
			[FieldOffset(Offset = "0xC0")]
			public float attenuationDistance;

			// Token: 0x04000396 RID: 918
			[Token(Token = "0x4000396")]
			[FieldOffset(Offset = "0xC4")]
			public float attenuationBias;

			// Token: 0x04000397 RID: 919
			[Token(Token = "0x4000397")]
			[FieldOffset(Offset = "0xC8")]
			public Vector2 rampUp;

			// Token: 0x04000398 RID: 920
			[Token(Token = "0x4000398")]
			[FieldOffset(Offset = "0xD0")]
			public Vector3 extinctionCoefficients;

			// Token: 0x04000399 RID: 921
			[Token(Token = "0x4000399")]
			[FieldOffset(Offset = "0xDC")]
			public Vector3 scatteringCoefficients;

			// Token: 0x0400039A RID: 922
			[Token(Token = "0x400039A")]
			[FieldOffset(Offset = "0xE8")]
			public float multipleScatteringAmount;

			// Token: 0x0400039B RID: 923
			[Token(Token = "0x400039B")]
			[FieldOffset(Offset = "0xEC")]
			public float multipleScatteringBias;

			// Token: 0x0400039C RID: 924
			[Token(Token = "0x400039C")]
			[FieldOffset(Offset = "0xF0")]
			public float multipleScatteringRampDown;

			// Token: 0x0400039D RID: 925
			[Token(Token = "0x400039D")]
			[FieldOffset(Offset = "0xF4")]
			public float multipleScatteringRampDownShape;

			// Token: 0x0400039E RID: 926
			[Token(Token = "0x400039E")]
			[FieldOffset(Offset = "0xF8")]
			public float silverSpread;

			// Token: 0x0400039F RID: 927
			[Token(Token = "0x400039F")]
			[FieldOffset(Offset = "0xFC")]
			public float silverIntensity;

			// Token: 0x040003A0 RID: 928
			[Token(Token = "0x40003A0")]
			[FieldOffset(Offset = "0x100")]
			public float anisotropy;

			// Token: 0x040003A1 RID: 929
			[Token(Token = "0x40003A1")]
			[FieldOffset(Offset = "0x104")]
			public float ambient;

			// Token: 0x040003A2 RID: 930
			[Token(Token = "0x40003A2")]
			[FieldOffset(Offset = "0x108")]
			public Vector2 ambientHeightRange;

			// Token: 0x040003A3 RID: 931
			[Token(Token = "0x40003A3")]
			[FieldOffset(Offset = "0x110")]
			public Vector2 ambientStrengthRange;

			// Token: 0x040003A4 RID: 932
			[Token(Token = "0x40003A4")]
			[FieldOffset(Offset = "0x118")]
			public int selfShadowing;

			// Token: 0x040003A5 RID: 933
			[Token(Token = "0x40003A5")]
			[FieldOffset(Offset = "0x11C")]
			public int highQualityShadows;

			// Token: 0x040003A6 RID: 934
			[Token(Token = "0x40003A6")]
			[FieldOffset(Offset = "0x120")]
			public float maxSelfShadowDistance;

			// Token: 0x040003A7 RID: 935
			[Token(Token = "0x40003A7")]
			[FieldOffset(Offset = "0x124")]
			public float lightPollutionDimmer;

			// Token: 0x040003A8 RID: 936
			[Token(Token = "0x40003A8")]
			[FieldOffset(Offset = "0x128")]
			public int celShade;

			// Token: 0x040003A9 RID: 937
			[Token(Token = "0x40003A9")]
			[FieldOffset(Offset = "0x12C")]
			public float celShadeLightingBands;

			// Token: 0x040003AA RID: 938
			[Token(Token = "0x40003AA")]
			[FieldOffset(Offset = "0x130")]
			public float celShadeTransmittanceBands;

			// Token: 0x040003AB RID: 939
			[Token(Token = "0x40003AB")]
			[FieldOffset(Offset = "0x134")]
			public int castShadows;

			// Token: 0x040003AC RID: 940
			[Token(Token = "0x40003AC")]
			[FieldOffset(Offset = "0x138")]
			public float apparentThickness;

			// Token: 0x040003AD RID: 941
			[Token(Token = "0x40003AD")]
			[FieldOffset(Offset = "0x13C")]
			public Vector2 verticalProbabilityHeightRange;

			// Token: 0x040003AE RID: 942
			[Token(Token = "0x40003AE")]
			[FieldOffset(Offset = "0x144")]
			public float verticalProbabilityStrength;

			// Token: 0x040003AF RID: 943
			[Token(Token = "0x40003AF")]
			[FieldOffset(Offset = "0x148")]
			public Vector2 depthProbabilityHeightRange;

			// Token: 0x040003B0 RID: 944
			[Token(Token = "0x40003B0")]
			[FieldOffset(Offset = "0x150")]
			public Vector2 depthProbabilityStrengthRange;

			// Token: 0x040003B1 RID: 945
			[Token(Token = "0x40003B1")]
			[FieldOffset(Offset = "0x158")]
			public float depthProbabilityDensityMultiplier;

			// Token: 0x040003B2 RID: 946
			[Token(Token = "0x40003B2")]
			[FieldOffset(Offset = "0x15C")]
			public float depthProbabilityBias;

			// Token: 0x040003B3 RID: 947
			[Token(Token = "0x40003B3")]
			[FieldOffset(Offset = "0x160")]
			public int depthProbabilityDetailIndex;

			// Token: 0x040003B4 RID: 948
			[Token(Token = "0x40003B4")]
			[FieldOffset(Offset = "0x164")]
			public float maxShadowIntensity;

			// Token: 0x040003B5 RID: 949
			[Token(Token = "0x40003B5")]
			[FieldOffset(Offset = "0x168")]
			public int reprojectionFrames;

			// Token: 0x040003B6 RID: 950
			[Token(Token = "0x40003B6")]
			[FieldOffset(Offset = "0x16C")]
			public int useTemporalDenoising;

			// Token: 0x040003B7 RID: 951
			[Token(Token = "0x40003B7")]
			[FieldOffset(Offset = "0x170")]
			public float temporalDenoisingRatio;

			// Token: 0x040003B8 RID: 952
			[Token(Token = "0x40003B8")]
			[FieldOffset(Offset = "0x174")]
			public float coarseStepSize;

			// Token: 0x040003B9 RID: 953
			[Token(Token = "0x40003B9")]
			[FieldOffset(Offset = "0x178")]
			public float detailStepSize;

			// Token: 0x040003BA RID: 954
			[Token(Token = "0x40003BA")]
			[FieldOffset(Offset = "0x17C")]
			public Vector2 coarseStepRange;

			// Token: 0x040003BB RID: 955
			[Token(Token = "0x40003BB")]
			[FieldOffset(Offset = "0x184")]
			public Vector2 detailStepRange;

			// Token: 0x040003BC RID: 956
			[Token(Token = "0x40003BC")]
			[FieldOffset(Offset = "0x18C")]
			public Vector2 stepDistanceRange;

			// Token: 0x040003BD RID: 957
			[Token(Token = "0x40003BD")]
			[FieldOffset(Offset = "0x194")]
			public Vector2 flythroughStepRange;

			// Token: 0x040003BE RID: 958
			[Token(Token = "0x40003BE")]
			[FieldOffset(Offset = "0x19C")]
			public Vector2 flythroughStepDistanceRange;

			// Token: 0x040003BF RID: 959
			[Token(Token = "0x40003BF")]
			[FieldOffset(Offset = "0x1A4")]
			public float mediaZeroThreshold;

			// Token: 0x040003C0 RID: 960
			[Token(Token = "0x40003C0")]
			[FieldOffset(Offset = "0x1A8")]
			public float transmittanceZeroThreshold;

			// Token: 0x040003C1 RID: 961
			[Token(Token = "0x40003C1")]
			[FieldOffset(Offset = "0x1AC")]
			public int maxConsecutiveZeroSamples;
		}
	}
}
