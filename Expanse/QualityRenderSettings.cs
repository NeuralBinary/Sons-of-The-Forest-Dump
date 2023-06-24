using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\main\\QualityRenderSettings.cs", needAccessors = false)]
	public struct QualityRenderSettings
	{
		// Token: 0x060003CE RID: 974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xAF9DF0", Offset = "0xAF83F0", VA = "0x180AF9DF0")]
		public static void register(QualitySettingsBlock b)
		{
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xAF9EA0", Offset = "0xAF84A0", VA = "0x180AF9EA0")]
		public static void deregister(QualitySettingsBlock b)
		{
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xAFA060", Offset = "0xAF8660", VA = "0x180AFA060")]
		public static QualitySettingsBlock Get()
		{
			return null;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xAFA0B0", Offset = "0xAF86B0", VA = "0x180AFA0B0")]
		public static void SetShaderGlobals(ExpanseSettings settings, CommandBuffer cmd)
		{
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xAFA7B0", Offset = "0xAF8DB0", VA = "0x180AFA7B0")]
		public static void build()
		{
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xAFA9C0", Offset = "0xAF8FC0", VA = "0x180AFA9C0")]
		public static void cleanup()
		{
		}

		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0x0")]
		public int samplesT;

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x4")]
		public int samplesAP;

		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0x8")]
		public int samplesSS;

		// Token: 0x040004C1 RID: 1217
		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0xC")]
		public int samplesMS;

		// Token: 0x040004C2 RID: 1218
		[Token(Token = "0x40004C2")]
		[FieldOffset(Offset = "0x10")]
		public int samplesMSAcc;

		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40004C3")]
		[FieldOffset(Offset = "0x14")]
		public int samplesScreenspace;

		// Token: 0x040004C4 RID: 1220
		[Token(Token = "0x40004C4")]
		[FieldOffset(Offset = "0x18")]
		public int samplesScreenspaceScattering;

		// Token: 0x040004C5 RID: 1221
		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0x1C")]
		public int importanceSample;

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0x20")]
		public int AP_importanceSample;

		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0x24")]
		public int screenspaceImportanceSample;

		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0x28")]
		public float AP_depthSkew;

		// Token: 0x040004C9 RID: 1225
		[Token(Token = "0x40004C9")]
		[FieldOffset(Offset = "0x2C")]
		public float screenspace_depthSkew;

		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		[FieldOffset(Offset = "0x30")]
		public int screenspace_historyFrames;

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0x34")]
		public int downsampledDepthMip;

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		[FieldOffset(Offset = "0x38")]
		public int antiAlias;

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0x3C")]
		public int dither;

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x40")]
		public float cloudShadowMapFilmPlaneScale;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x0")]
		private static QualitySettingsBlock m_quality;

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0x8")]
		private static ComputeBuffer kComputeBuffer;

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x10")]
		private static QualityRenderSettings[] kArray;
	}
}
