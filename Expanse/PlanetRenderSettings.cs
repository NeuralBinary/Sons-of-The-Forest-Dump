using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\directLight\\planet\\PlanetRenderSettings.cs", needAccessors = false)]
	public struct PlanetRenderSettings
	{
		// Token: 0x06000376 RID: 886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000376")]
		[Address(RVA = "0xAEC6B0", Offset = "0xAEACB0", VA = "0x180AEC6B0")]
		public static void register(PlanetBlock b)
		{
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000377")]
		[Address(RVA = "0xAEC760", Offset = "0xAEAD60", VA = "0x180AEC760")]
		public static void deregister(PlanetBlock b)
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000378")]
		[Address(RVA = "0xAEC920", Offset = "0xAEAF20", VA = "0x180AEC920")]
		public static void SetShaderGlobals(ExpanseSettings settings, CommandBuffer cmd)
		{
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000379")]
		[Address(RVA = "0xAED300", Offset = "0xAEB900", VA = "0x180AED300")]
		public static void build()
		{
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037A")]
		[Address(RVA = "0xAED510", Offset = "0xAEBB10", VA = "0x180AED510")]
		public static void cleanup()
		{
		}

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x0")]
		public float radius;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x4")]
		public float atmosphereRadius;

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 originOffset;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x14")]
		public float clipFade;

		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x18")]
		public Color groundTint;

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x28")]
		public float groundEmissionMultiplier;

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x2C")]
		public Matrix4x4 rotation;

		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x6C")]
		public int hasAlbedoTexture;

		// Token: 0x04000436 RID: 1078
		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x70")]
		public int hasEmissionTexture;

		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x0")]
		private static PlanetBlock m_planet;

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x8")]
		private static ComputeBuffer kComputeBuffer;

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x10")]
		private static PlanetRenderSettings[] kArray;
	}
}
