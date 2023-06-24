using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\directLight\\stars\\StarRenderSettings.cs", needAccessors = false)]
	public struct StarRenderSettings
	{
		// Token: 0x0600038D RID: 909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038D")]
		[Address(RVA = "0xAEE760", Offset = "0xAECD60", VA = "0x180AEE760")]
		public static void register(ProceduralStarsBlock b)
		{
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038E")]
		[Address(RVA = "0xAEE810", Offset = "0xAECE10", VA = "0x180AEE810")]
		public static void deregister(ProceduralStarsBlock b)
		{
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038F")]
		[Address(RVA = "0xAEE9D0", Offset = "0xAECFD0", VA = "0x180AEE9D0")]
		public static void register(TextureStarsBlock b)
		{
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000390")]
		[Address(RVA = "0xAEEA80", Offset = "0xAED080", VA = "0x180AEEA80")]
		public static void deregister(TextureStarsBlock b)
		{
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00005298 File Offset: 0x00003498
		[Token(Token = "0x6000391")]
		[Address(RVA = "0xAEEC40", Offset = "0xAED240", VA = "0x180AEEC40")]
		public static int GetStarHashCode()
		{
			return 0;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000052B0 File Offset: 0x000034B0
		[Token(Token = "0x6000392")]
		[Address(RVA = "0xAEF260", Offset = "0xAED860", VA = "0x180AEF260")]
		public static bool Procedural()
		{
			return default(bool);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000052C8 File Offset: 0x000034C8
		[Token(Token = "0x6000393")]
		[Address(RVA = "0xAEF350", Offset = "0xAED950", VA = "0x180AEF350")]
		public static Datatypes.Quality GetQuality()
		{
			return Datatypes.Quality.Potato;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000394")]
		[Address(RVA = "0xAEF3A0", Offset = "0xAED9A0", VA = "0x180AEF3A0")]
		public static void SetShaderGlobals(ExpanseSettings settings, CommandBuffer cmd)
		{
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000395")]
		[Address(RVA = "0xAEF760", Offset = "0xAEDD60", VA = "0x180AEF760")]
		private static void setShaderGlobalsTexture(ExpanseSettings settings, CommandBuffer cmd)
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000396")]
		[Address(RVA = "0xAEFB70", Offset = "0xAEE170", VA = "0x180AEFB70")]
		private static void setShaderGlobalsProcedural(ExpanseSettings settings, CommandBuffer cmd)
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000397")]
		[Address(RVA = "0xAF03A0", Offset = "0xAEE9A0", VA = "0x180AF03A0")]
		public static void build()
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000398")]
		[Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0")]
		public static void cleanup()
		{
		}

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x0")]
		public Matrix4x4 rotation;

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 tint;

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x4C")]
		public int highDensityMode;

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x50")]
		public float density;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 densitySeed;

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x60")]
		public Vector2 sizeRange;

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x68")]
		public float sizeBias;

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x6C")]
		public Vector3 sizeSeed;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x78")]
		public Vector2 intensityRange;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x80")]
		public float intensityBias;

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x84")]
		public Vector3 intensitySeed;

		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x90")]
		public Vector2 temperatureRange;

		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x98")]
		public float temperatureBias;

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x9C")]
		public Vector3 temperatureSeed;

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0xA8")]
		public float nebulaFollowAmount;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0xAC")]
		public int twinkle;

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0xB0")]
		public float twinkleThreshold;

		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0xB4")]
		public Vector2 twinkleFrequencyRange;

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0xBC")]
		public float twinkleBias;

		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0xC0")]
		public float twinkleSmoothAmplitude;

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0xC4")]
		public float twinkleChaoticAmplitude;

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x0")]
		private static TextureStarsBlock m_textureStars;

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x8")]
		private static ProceduralStarsBlock m_proceduralStars;

		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0x10")]
		private static Datatypes.Quality m_quality;

		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x18")]
		private static ComputeBuffer kComputeBuffer;

		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x20")]
		private static StarRenderSettings[] kArray;
	}
}
