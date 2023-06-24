using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\atmosphere\\AtmosphereLayerRenderSettings.cs", needAccessors = false)]
	public struct AtmosphereLayerRenderSettings
	{
		// Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000272")]
		[Address(RVA = "0xAC31A0", Offset = "0xAC17A0", VA = "0x180AC31A0")]
		public static void register(AtmosphereLayerBlock b)
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000273")]
		[Address(RVA = "0xAC32E0", Offset = "0xAC18E0", VA = "0x180AC32E0")]
		public static void deregister(AtmosphereLayerBlock b)
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00004EA8 File Offset: 0x000030A8
		[Token(Token = "0x6000274")]
		[Address(RVA = "0xAC3360", Offset = "0xAC1960", VA = "0x180AC3360")]
		public static int GetFogLayers()
		{
			return 0;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00004EC0 File Offset: 0x000030C0
		[Token(Token = "0x6000275")]
		[Address(RVA = "0xAC33B0", Offset = "0xAC19B0", VA = "0x180AC33B0")]
		public static int GetFogLayersUsingDepth()
		{
			return 0;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000276")]
		[Address(RVA = "0xAC3400", Offset = "0xAC1A00", VA = "0x180AC3400")]
		public static void SetShaderGlobals(ExpanseSettings settings, CommandBuffer cmd)
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000277")]
		[Address(RVA = "0xAC4C00", Offset = "0xAC3200", VA = "0x180AC4C00")]
		public static void build()
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000278")]
		[Address(RVA = "0xAC4FC0", Offset = "0xAC35C0", VA = "0x180AC4FC0")]
		public static void cleanup()
		{
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000279")]
		[Address(RVA = "0xAC5010", Offset = "0xAC3610", VA = "0x180AC5010")]
		private static void cleanupAtmo()
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027A")]
		[Address(RVA = "0xAC5120", Offset = "0xAC3720", VA = "0x180AC5120")]
		private static void cleanupFog()
		{
		}

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 extinctionCoefficients;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 scatteringCoefficients;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x18")]
		public int densityDistribution;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x1C")]
		public float height;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x20")]
		public float thickness;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x24")]
		public int phaseFunction;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x28")]
		public float anisotropy;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x2C")]
		public float density;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 tint;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x3C")]
		public float multipleScatteringMultiplier;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x40")]
		public int screenspaceShadows;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x44")]
		public float maxGeometryOcclusion;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x48")]
		public float maxCloudOcclusion;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x4C")]
		public int geometryShadows;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x50")]
		public int cloudShadows;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x54")]
		public int useCloudArray;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x58")]
		public int physicalLighting;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x0")]
		private static List<AtmosphereLayerBlock> kLayers;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x8")]
		private static int m_fogLayers;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0xC")]
		private static int m_fogLayersUsingDepth;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x10")]
		private static ComputeBuffer kAtmosphereComputeBuffer;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x18")]
		private static ComputeBuffer kFogComputeBuffer;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x20")]
		private static AtmosphereLayerRenderSettings[] kAtmosphereArray;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x28")]
		private static AtmosphereLayerRenderSettings[] kFogArray;
	}
}
