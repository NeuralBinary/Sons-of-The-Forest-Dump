using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\directLight\\general\\NightSkyRenderSettings.cs", needAccessors = false)]
	public struct NightSkyRenderSettings
	{
		// Token: 0x06000350 RID: 848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000350")]
		[Address(RVA = "0xAE7B30", Offset = "0xAE6130", VA = "0x180AE7B30")]
		public static void register(NightSkyBlock b)
		{
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000351")]
		[Address(RVA = "0xAE7BE0", Offset = "0xAE61E0", VA = "0x180AE7BE0")]
		public static void deregister(NightSkyBlock b)
		{
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000352")]
		[Address(RVA = "0xAE7DA0", Offset = "0xAE63A0", VA = "0x180AE7DA0")]
		public static void SetShaderGlobals(ExpanseSettings settings, CommandBuffer cmd)
		{
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000353")]
		[Address(RVA = "0xAE8260", Offset = "0xAE6860", VA = "0x180AE8260")]
		public static void build()
		{
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000354")]
		[Address(RVA = "0xAE8470", Offset = "0xAE6A70", VA = "0x180AE8470")]
		public static void cleanup()
		{
		}

		// Token: 0x040003F2 RID: 1010
		[Token(Token = "0x40003F2")]
		[FieldOffset(Offset = "0x0")]
		public Matrix4x4 rotation;

		// Token: 0x040003F3 RID: 1011
		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 tint;

		// Token: 0x040003F4 RID: 1012
		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0x4C")]
		public Vector3 scatterTint;

		// Token: 0x040003F5 RID: 1013
		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0x58")]
		public Vector3 lightPollution;

		// Token: 0x040003F6 RID: 1014
		[Token(Token = "0x40003F6")]
		[FieldOffset(Offset = "0x64")]
		public float ambientMultiplier;

		// Token: 0x040003F7 RID: 1015
		[Token(Token = "0x40003F7")]
		[FieldOffset(Offset = "0x0")]
		private static NightSkyBlock m_nightSky;

		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x8")]
		private static ComputeBuffer kComputeBuffer;

		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x10")]
		private static NightSkyRenderSettings[] kArray;
	}
}
