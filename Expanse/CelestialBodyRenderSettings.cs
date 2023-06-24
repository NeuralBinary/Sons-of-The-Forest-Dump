using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\celestialBodies\\CelestialBodyRenderSettings.cs", needAccessors = false)]
	public struct CelestialBodyRenderSettings
	{
		// Token: 0x06000299 RID: 665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000299")]
		[Address(RVA = "0xACB110", Offset = "0xAC9710", VA = "0x180ACB110")]
		public static void register(CelestialBodyBlock b)
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029A")]
		[Address(RVA = "0xACB250", Offset = "0xAC9850", VA = "0x180ACB250")]
		public static void deregister(CelestialBodyBlock b)
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029B")]
		[Address(RVA = "0xACB2D0", Offset = "0xAC98D0", VA = "0x180ACB2D0")]
		public static void SetShaderGlobals(ExpanseSettings settings, CommandBuffer cmd)
		{
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029C")]
		[Address(RVA = "0xACCDF0", Offset = "0xACB3F0", VA = "0x180ACCDF0")]
		public static void build()
		{
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029D")]
		[Address(RVA = "0xACD280", Offset = "0xACB880", VA = "0x180ACD280")]
		public static void cleanup()
		{
		}

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 direction;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0xC")]
		public float cosAngularRadius;

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x10")]
		public float distance;

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x14")]
		public int receivesLight;

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x18")]
		public int hasAlbedoTexture;

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 albedoTextureResolution;

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x24")]
		public Matrix4x4 albedoTextureRotation;

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x64")]
		public Vector4 albedoTint;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x74")]
		public int moonMode;

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x78")]
		public float retrodirection;

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x7C")]
		public float anisotropy;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x80")]
		public int emissive;

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x84")]
		public int hasEmissionTexture;

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x88")]
		public Vector2 emissionTextureResolution;

		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x90")]
		public Vector4 lightColor;

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0xA0")]
		public float limbDarkening;

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0xA4")]
		public Matrix4x4 emissionTextureRotation;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0xE4")]
		public Vector4 emissionTint;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x0")]
		private static List<CelestialBodyBlock> kBodies;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x8")]
		private static ComputeBuffer kComputeBuffer;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x10")]
		private static CelestialBodyRenderSettings[] kArray;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x18")]
		private static int[] kAlbedoTextureNames;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x20")]
		private static int[] kEmissionTextureNames;
	}
}
