using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\directLight\\nebulae\\NebulaRenderSettings.cs", needAccessors = false)]
	public struct NebulaRenderSettings
	{
		// Token: 0x06000368 RID: 872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000368")]
		[Address(RVA = "0xAE9620", Offset = "0xAE7C20", VA = "0x180AE9620")]
		public static void register(ProceduralNebulaeBlock b)
		{
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000369")]
		[Address(RVA = "0xAE96D0", Offset = "0xAE7CD0", VA = "0x180AE96D0")]
		public static void deregister(ProceduralNebulaeBlock b)
		{
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036A")]
		[Address(RVA = "0xAE9890", Offset = "0xAE7E90", VA = "0x180AE9890")]
		public static void register(TextureNebulaeBlock b)
		{
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036B")]
		[Address(RVA = "0xAE9940", Offset = "0xAE7F40", VA = "0x180AE9940")]
		public static void deregister(TextureNebulaeBlock b)
		{
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00005208 File Offset: 0x00003408
		[Token(Token = "0x600036C")]
		[Address(RVA = "0xAE9B00", Offset = "0xAE8100", VA = "0x180AE9B00")]
		public static int GetNebulaeHashCode()
		{
			return 0;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00005220 File Offset: 0x00003420
		[Token(Token = "0x600036D")]
		[Address(RVA = "0xAEA0D0", Offset = "0xAE86D0", VA = "0x180AEA0D0")]
		public static bool Procedural()
		{
			return default(bool);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00005238 File Offset: 0x00003438
		[Token(Token = "0x600036E")]
		[Address(RVA = "0xAEA1C0", Offset = "0xAE87C0", VA = "0x180AEA1C0")]
		public static Datatypes.Quality GetQuality()
		{
			return Datatypes.Quality.Potato;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036F")]
		[Address(RVA = "0xAEA210", Offset = "0xAE8810", VA = "0x180AEA210")]
		public static void SetShaderGlobals(ExpanseSettings settings, CommandBuffer cmd)
		{
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000370")]
		[Address(RVA = "0xAEA670", Offset = "0xAE8C70", VA = "0x180AEA670")]
		private static void setShaderGlobalsTexture(ExpanseSettings settings, CommandBuffer cmd)
		{
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000371")]
		[Address(RVA = "0xAEAAC0", Offset = "0xAE90C0", VA = "0x180AEAAC0")]
		private static void setShaderGlobalsProcedural(ExpanseSettings settings, CommandBuffer cmd)
		{
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000372")]
		[Address(RVA = "0xAEB870", Offset = "0xAE9E70", VA = "0x180AEB870")]
		public static void build()
		{
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000373")]
		[Address(RVA = "0xAEBC40", Offset = "0xAEA240", VA = "0x180AEBC40")]
		public static void cleanup()
		{
		}

		// Token: 0x04000408 RID: 1032
		[Token(Token = "0x4000408")]
		[FieldOffset(Offset = "0x0")]
		public Matrix4x4 rotation;

		// Token: 0x04000409 RID: 1033
		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0x40")]
		public float definition;

		// Token: 0x0400040A RID: 1034
		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x44")]
		public float intensity;

		// Token: 0x0400040B RID: 1035
		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x48")]
		public Vector4 tint;

		// Token: 0x0400040C RID: 1036
		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0x58")]
		public float coverageScale;

		// Token: 0x0400040D RID: 1037
		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x5C")]
		public Vector3 coverageSeed;

		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x68")]
		public float transmittanceScale;

		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x6C")]
		public Vector2 transmittanceRange;

		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000410")]
		[FieldOffset(Offset = "0x74")]
		public Vector3 transmittanceSeedX;

		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000411")]
		[FieldOffset(Offset = "0x80")]
		public Vector3 transmittanceSeedY;

		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x8C")]
		public Vector3 transmittanceSeedZ;

		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x0")]
		private static TextureNebulaeBlock m_textureNebulae;

		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x8")]
		private static ProceduralNebulaeBlock m_proceduralNebulae;

		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0x10")]
		private static Datatypes.Quality m_quality;

		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x18")]
		private static ComputeBuffer kRenderSettingsComputeBuffer;

		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x20")]
		private static ComputeBuffer kLayersComputeBuffer;

		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x28")]
		private static NebulaRenderSettings[] kRenderSettingsArray;

		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x30")]
		private static NebulaRenderSettings.NebulaGeneratorLayerSettings[] kLayersArray;

		// Token: 0x02000053 RID: 83
		[Token(Token = "0x2000053")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\directLight\\nebulae\\NebulaRenderSettings.cs", needAccessors = false)]
		private struct NebulaGeneratorLayerSettings
		{
			// Token: 0x06000375 RID: 885 RVA: 0x00005250 File Offset: 0x00003450
			[Token(Token = "0x6000375")]
			[Address(RVA = "0xAEBF70", Offset = "0xAEA570", VA = "0x180AEBF70", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x0400041A RID: 1050
			[Token(Token = "0x400041A")]
			[FieldOffset(Offset = "0x0")]
			public float intensity;

			// Token: 0x0400041B RID: 1051
			[Token(Token = "0x400041B")]
			[FieldOffset(Offset = "0x4")]
			public Vector4 color;

			// Token: 0x0400041C RID: 1052
			[Token(Token = "0x400041C")]
			[FieldOffset(Offset = "0x14")]
			public int noise;

			// Token: 0x0400041D RID: 1053
			[Token(Token = "0x400041D")]
			[FieldOffset(Offset = "0x18")]
			public float scale;

			// Token: 0x0400041E RID: 1054
			[Token(Token = "0x400041E")]
			[FieldOffset(Offset = "0x1C")]
			public int octaves;

			// Token: 0x0400041F RID: 1055
			[Token(Token = "0x400041F")]
			[FieldOffset(Offset = "0x20")]
			public float octaveScale;

			// Token: 0x04000420 RID: 1056
			[Token(Token = "0x4000420")]
			[FieldOffset(Offset = "0x24")]
			public float octaveMultiplier;

			// Token: 0x04000421 RID: 1057
			[Token(Token = "0x4000421")]
			[FieldOffset(Offset = "0x28")]
			public float coverage;

			// Token: 0x04000422 RID: 1058
			[Token(Token = "0x4000422")]
			[FieldOffset(Offset = "0x2C")]
			public float spread;

			// Token: 0x04000423 RID: 1059
			[Token(Token = "0x4000423")]
			[FieldOffset(Offset = "0x30")]
			public float bias;

			// Token: 0x04000424 RID: 1060
			[Token(Token = "0x4000424")]
			[FieldOffset(Offset = "0x34")]
			public float definition;

			// Token: 0x04000425 RID: 1061
			[Token(Token = "0x4000425")]
			[FieldOffset(Offset = "0x38")]
			public float strength;

			// Token: 0x04000426 RID: 1062
			[Token(Token = "0x4000426")]
			[FieldOffset(Offset = "0x3C")]
			public float warpScale;

			// Token: 0x04000427 RID: 1063
			[Token(Token = "0x4000427")]
			[FieldOffset(Offset = "0x40")]
			public float warpIntensity;

			// Token: 0x04000428 RID: 1064
			[Token(Token = "0x4000428")]
			[FieldOffset(Offset = "0x44")]
			public Vector3 baseSeedX;

			// Token: 0x04000429 RID: 1065
			[Token(Token = "0x4000429")]
			[FieldOffset(Offset = "0x50")]
			public Vector3 baseSeedY;

			// Token: 0x0400042A RID: 1066
			[Token(Token = "0x400042A")]
			[FieldOffset(Offset = "0x5C")]
			public Vector3 baseSeedZ;

			// Token: 0x0400042B RID: 1067
			[Token(Token = "0x400042B")]
			[FieldOffset(Offset = "0x68")]
			public Vector3 warpSeedX;

			// Token: 0x0400042C RID: 1068
			[Token(Token = "0x400042C")]
			[FieldOffset(Offset = "0x74")]
			public Vector3 warpSeedY;

			// Token: 0x0400042D RID: 1069
			[Token(Token = "0x400042D")]
			[FieldOffset(Offset = "0x80")]
			public Vector3 warpSeedZ;
		}
	}
}
