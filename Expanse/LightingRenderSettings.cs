using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	public struct LightingRenderSettings
	{
		// Token: 0x060003A4 RID: 932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xAF19C0", Offset = "0xAEFFC0", VA = "0x180AF19C0")]
		public static void register(LightControl b)
		{
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xAF1BF0", Offset = "0xAF01F0", VA = "0x180AF1BF0")]
		public static void deregister(LightControl b)
		{
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xAF1DA0", Offset = "0xAF03A0", VA = "0x180AF1DA0")]
		public static void assignShadowIndices()
		{
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000052E0 File Offset: 0x000034E0
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xAF20D0", Offset = "0xAF06D0", VA = "0x180AF20D0")]
		public static int GetCloudShadowLights()
		{
			return 0;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000052F8 File Offset: 0x000034F8
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xAF2130", Offset = "0xAF0730", VA = "0x180AF2130")]
		public static int CloudShadowIndexToAtmosphereIndex(int shadowIndex)
		{
			return 0;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xAF21B0", Offset = "0xAF07B0", VA = "0x180AF21B0")]
		public static void SetShaderGlobals(ExpanseSettings settings, CommandBuffer cmd)
		{
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xAF2220", Offset = "0xAF0820", VA = "0x180AF2220")]
		public static void SetShaderGlobalsDirectionalLights(ExpanseSettings settings, CommandBuffer cmd)
		{
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xAF3960", Offset = "0xAF1F60", VA = "0x180AF3960")]
		public static void SetShaderGlobalsPointLights(ExpanseSettings settings, CommandBuffer cmd)
		{
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xAF4ED0", Offset = "0xAF34D0", VA = "0x180AF4ED0")]
		public static void build()
		{
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xAF4F30", Offset = "0xAF3530", VA = "0x180AF4F30")]
		public static void cleanup()
		{
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xAF4F90", Offset = "0xAF3590", VA = "0x180AF4F90")]
		public static void buildAtmoDirectionalLights()
		{
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xAF51B0", Offset = "0xAF37B0", VA = "0x180AF51B0")]
		public static void buildCloudDirectionalLights()
		{
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xAF53D0", Offset = "0xAF39D0", VA = "0x180AF53D0")]
		public static void buildCloudShadowDirectionalLights()
		{
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xAF55F0", Offset = "0xAF3BF0", VA = "0x180AF55F0")]
		public static void buildFogPointLights()
		{
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xAF5810", Offset = "0xAF3E10", VA = "0x180AF5810")]
		public static void buildCloudPointLights()
		{
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xAF5A30", Offset = "0xAF4030", VA = "0x180AF5A30")]
		public static void cleanupAtmoDirectionalLights()
		{
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xAF5B40", Offset = "0xAF4140", VA = "0x180AF5B40")]
		public static void cleanupCloudDirectionalLights()
		{
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xAF5C50", Offset = "0xAF4250", VA = "0x180AF5C50")]
		public static void cleanupCloudShadowDirectionalLights()
		{
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xAF5D60", Offset = "0xAF4360", VA = "0x180AF5D60")]
		public static void cleanupFogPointLights()
		{
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xAF5E70", Offset = "0xAF4470", VA = "0x180AF5E70")]
		public static void cleanupCloudPointLights()
		{
		}

		// Token: 0x04000474 RID: 1140
		[Token(Token = "0x4000474")]
		[FieldOffset(Offset = "0x0")]
		private static List<LightControl> kDirectionalLightControls;

		// Token: 0x04000475 RID: 1141
		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0x8")]
		private static List<LightControl> kPointLightControls;

		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4000476")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<Light, int> m_lightToShadowIndex;

		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4000477")]
		[FieldOffset(Offset = "0x18")]
		private static LightingRenderSettings.PointLightRenderSettings lightSettings;

		// Token: 0x04000478 RID: 1144
		[Token(Token = "0x4000478")]
		[FieldOffset(Offset = "0xE0")]
		private static ComputeBuffer kAtmosphereDirectionalComputeBuffer;

		// Token: 0x04000479 RID: 1145
		[Token(Token = "0x4000479")]
		[FieldOffset(Offset = "0xE8")]
		private static ComputeBuffer kCloudDirectionalComputeBuffer;

		// Token: 0x0400047A RID: 1146
		[Token(Token = "0x400047A")]
		[FieldOffset(Offset = "0xF0")]
		private static ComputeBuffer kCloudShadowDirectionalComputeBuffer;

		// Token: 0x0400047B RID: 1147
		[Token(Token = "0x400047B")]
		[FieldOffset(Offset = "0xF8")]
		private static ComputeBuffer kFogPointComputeBuffer;

		// Token: 0x0400047C RID: 1148
		[Token(Token = "0x400047C")]
		[FieldOffset(Offset = "0x100")]
		private static ComputeBuffer kCloudPointComputeBuffer;

		// Token: 0x0400047D RID: 1149
		[Token(Token = "0x400047D")]
		[FieldOffset(Offset = "0x108")]
		private static LightingRenderSettings.DirectionalLightRenderSettings[] kAtmosphereDirectionalArray;

		// Token: 0x0400047E RID: 1150
		[Token(Token = "0x400047E")]
		[FieldOffset(Offset = "0x110")]
		private static LightingRenderSettings.DirectionalLightRenderSettings[] kCloudDirectionalArray;

		// Token: 0x0400047F RID: 1151
		[Token(Token = "0x400047F")]
		[FieldOffset(Offset = "0x118")]
		private static LightingRenderSettings.DirectionalLightRenderSettings[] kCloudShadowDirectionalArray;

		// Token: 0x04000480 RID: 1152
		[Token(Token = "0x4000480")]
		[FieldOffset(Offset = "0x120")]
		private static LightingRenderSettings.PointLightRenderSettings[] kFogPointArray;

		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0x128")]
		private static LightingRenderSettings.PointLightRenderSettings[] kCloudPointArray;

		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0x130")]
		private static int m_cloudShadowLights;

		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x138")]
		private static Dictionary<int, int> m_shadowIndexToAtmosphereIndex;

		// Token: 0x02000059 RID: 89
		[Token(Token = "0x2000059")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\lighting\\LightingRenderSettings.cs", needAccessors = false)]
		public struct DirectionalLightRenderSettings
		{
			// Token: 0x04000484 RID: 1156
			[Token(Token = "0x4000484")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			// Token: 0x04000485 RID: 1157
			[Token(Token = "0x4000485")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 lightColor;

			// Token: 0x04000486 RID: 1158
			[Token(Token = "0x4000486")]
			[FieldOffset(Offset = "0x18")]
			public float penumbraRadius;

			// Token: 0x04000487 RID: 1159
			[Token(Token = "0x4000487")]
			[FieldOffset(Offset = "0x1C")]
			public int useShadowmap;

			// Token: 0x04000488 RID: 1160
			[Token(Token = "0x4000488")]
			[FieldOffset(Offset = "0x20")]
			public float maxShadowmapDistance;

			// Token: 0x04000489 RID: 1161
			[Token(Token = "0x4000489")]
			[FieldOffset(Offset = "0x24")]
			public int shadowmapNDCSign;

			// Token: 0x0400048A RID: 1162
			[Token(Token = "0x400048A")]
			[FieldOffset(Offset = "0x28")]
			public int volumetricGeometryShadows;

			// Token: 0x0400048B RID: 1163
			[Token(Token = "0x400048B")]
			[FieldOffset(Offset = "0x2C")]
			public int volumetricCloudShadows;
		}

		// Token: 0x0200005A RID: 90
		[Token(Token = "0x200005A")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\lighting\\LightingRenderSettings.cs", needAccessors = false)]
		public enum PointLightGeometryType
		{
			// Token: 0x0400048D RID: 1165
			[Token(Token = "0x400048D")]
			Point,
			// Token: 0x0400048E RID: 1166
			[Token(Token = "0x400048E")]
			Cone,
			// Token: 0x0400048F RID: 1167
			[Token(Token = "0x400048F")]
			Pyramid,
			// Token: 0x04000490 RID: 1168
			[Token(Token = "0x4000490")]
			Box
		}

		// Token: 0x0200005B RID: 91
		[Token(Token = "0x200005B")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\lighting\\LightingRenderSettings.cs", needAccessors = false)]
		public struct PointLightRenderSettings
		{
			// Token: 0x04000491 RID: 1169
			[Token(Token = "0x4000491")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			// Token: 0x04000492 RID: 1170
			[Token(Token = "0x4000492")]
			[FieldOffset(Offset = "0xC")]
			public Matrix4x4 rotation;

			// Token: 0x04000493 RID: 1171
			[Token(Token = "0x4000493")]
			[FieldOffset(Offset = "0x4C")]
			public Matrix4x4 inverseRotation;

			// Token: 0x04000494 RID: 1172
			[Token(Token = "0x4000494")]
			[FieldOffset(Offset = "0x8C")]
			public Vector3 lightColor;

			// Token: 0x04000495 RID: 1173
			[Token(Token = "0x4000495")]
			[FieldOffset(Offset = "0x98")]
			public float range;

			// Token: 0x04000496 RID: 1174
			[Token(Token = "0x4000496")]
			[FieldOffset(Offset = "0x9C")]
			public int raymarch;

			// Token: 0x04000497 RID: 1175
			[Token(Token = "0x4000497")]
			[FieldOffset(Offset = "0xA0")]
			public float multiplier;

			// Token: 0x04000498 RID: 1176
			[Token(Token = "0x4000498")]
			[FieldOffset(Offset = "0xA4")]
			public int volumetricGeometryShadows;

			// Token: 0x04000499 RID: 1177
			[Token(Token = "0x4000499")]
			[FieldOffset(Offset = "0xA8")]
			public int volumetricCloudShadows;

			// Token: 0x0400049A RID: 1178
			[Token(Token = "0x400049A")]
			[FieldOffset(Offset = "0xAC")]
			public int useShadowmap;

			// Token: 0x0400049B RID: 1179
			[Token(Token = "0x400049B")]
			[FieldOffset(Offset = "0xB0")]
			public float maxShadowmapDistance;

			// Token: 0x0400049C RID: 1180
			[Token(Token = "0x400049C")]
			[FieldOffset(Offset = "0xB4")]
			public int shadowIndex;

			// Token: 0x0400049D RID: 1181
			[Token(Token = "0x400049D")]
			[FieldOffset(Offset = "0xB8")]
			public int geometryType;

			// Token: 0x0400049E RID: 1182
			[Token(Token = "0x400049E")]
			[FieldOffset(Offset = "0xBC")]
			public float geometryParam1;

			// Token: 0x0400049F RID: 1183
			[Token(Token = "0x400049F")]
			[FieldOffset(Offset = "0xC0")]
			public float geometryParam2;
		}
	}
}
