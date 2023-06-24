using System;
using Il2CppDummyDll;
using Unity.Mathematics;
using UnityEngine;

namespace MudBun
{
	// Token: 0x02000144 RID: 324
	[Token(Token = "0x2000144")]
	public static class VectorUtil
	{
		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x00005FE8 File Offset: 0x000041E8
		[Token(Token = "0x1700011D")]
		public static Vector3 Invalid
		{
			[Token(Token = "0x600083C")]
			[Address(RVA = "0x2453130", Offset = "0x2451730", VA = "0x182453130")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00006000 File Offset: 0x00004200
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x24531A0", Offset = "0x24517A0", VA = "0x1824531A0")]
		public static bool IsValid(Vector3 v)
		{
			return default(bool);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00006018 File Offset: 0x00004218
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x2453280", Offset = "0x2451880", VA = "0x182453280")]
		public static Vector3 Saturate(Vector3 v)
		{
			return default(Vector3);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00006030 File Offset: 0x00004230
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x1E742C0", Offset = "0x1E728C0", VA = "0x181E742C0")]
		public static Vector3 CompMul(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00006048 File Offset: 0x00004248
		[Token(Token = "0x6000840")]
		[Address(RVA = "0x1E70720", Offset = "0x1E6ED20", VA = "0x181E70720")]
		public static float2 CompMul(float2 a, float2 b)
		{
			return default(float2);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00006060 File Offset: 0x00004260
		[Token(Token = "0x6000841")]
		[Address(RVA = "0x1E74300", Offset = "0x1E72900", VA = "0x181E74300")]
		public static Vector3 CompDiv(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00006078 File Offset: 0x00004278
		[Token(Token = "0x6000842")]
		[Address(RVA = "0x24533B0", Offset = "0x24519B0", VA = "0x1824533B0")]
		public static float3 CompDiv(float3 a, float3 b)
		{
			return default(float3);
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00006090 File Offset: 0x00004290
		[Token(Token = "0x6000843")]
		[Address(RVA = "0x1E70760", Offset = "0x1E6ED60", VA = "0x181E70760")]
		public static float2 CompDiv(float2 a, float2 b)
		{
			return default(float2);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x000060A8 File Offset: 0x000042A8
		[Token(Token = "0x6000844")]
		[Address(RVA = "0x2453400", Offset = "0x2451A00", VA = "0x182453400")]
		public static float MinComp(Vector3 v)
		{
			return 0f;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x000060C0 File Offset: 0x000042C0
		[Token(Token = "0x6000845")]
		[Address(RVA = "0x2453420", Offset = "0x2451A20", VA = "0x182453420")]
		public static float MaxComp(Vector3 v)
		{
			return 0f;
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x000060D8 File Offset: 0x000042D8
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x2453440", Offset = "0x2451A40", VA = "0x182453440")]
		public static Vector3 Rotate2D(Vector3 v, float deg)
		{
			return default(Vector3);
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x000060F0 File Offset: 0x000042F0
		[Token(Token = "0x6000847")]
		[Address(RVA = "0x2453510", Offset = "0x2451B10", VA = "0x182453510")]
		public static Vector3 NormalizeSafe(Vector3 v, Vector3 fallback, float epsilon = 1E-09f)
		{
			return default(Vector3);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00006108 File Offset: 0x00004308
		[Token(Token = "0x6000848")]
		[Address(RVA = "0x2453580", Offset = "0x2451B80", VA = "0x182453580")]
		public static Vector3 FindOrthogonal(Vector3 v)
		{
			return default(Vector3);
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x2453640", Offset = "0x2451C40", VA = "0x182453640")]
		public static void FormOrthonormalBasis(Vector3 v, out Vector3 a, out Vector3 b)
		{
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00006120 File Offset: 0x00004320
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x2453850", Offset = "0x2451E50", VA = "0x182453850")]
		public static Vector3 ClampLength(Vector3 v, float minLen, float maxLen)
		{
			return default(Vector3);
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00006138 File Offset: 0x00004338
		[Token(Token = "0x600084B")]
		[Address(RVA = "0x2453980", Offset = "0x2451F80", VA = "0x182453980")]
		public static Vector3 Slerp(Vector3 a, Vector3 b, float t)
		{
			return default(Vector3);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00006150 File Offset: 0x00004350
		[Token(Token = "0x600084C")]
		[Address(RVA = "0x2453D70", Offset = "0x2452370", VA = "0x182453D70")]
		public static Vector3 BezierQuad(Vector3 a, Vector3 b, Vector3 controlPoint, float t)
		{
			return default(Vector3);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00006168 File Offset: 0x00004368
		[Token(Token = "0x600084D")]
		[Address(RVA = "0x2453F30", Offset = "0x2452530", VA = "0x182453F30")]
		public static Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00006180 File Offset: 0x00004380
		[Token(Token = "0x600084E")]
		[Address(RVA = "0xA8D700", Offset = "0xA8BD00", VA = "0x180A8D700")]
		public static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00006198 File Offset: 0x00004398
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x2454240", Offset = "0x2452840", VA = "0x182454240")]
		public static Vector3 Min(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x000061B0 File Offset: 0x000043B0
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x2454280", Offset = "0x2452880", VA = "0x182454280")]
		public static Vector3 Max(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x000061C8 File Offset: 0x000043C8
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x24542C0", Offset = "0x24528C0", VA = "0x1824542C0")]
		public static float GetComopnent(Vector3 v, int i)
		{
			return 0f;
		}

		// Token: 0x040004C2 RID: 1218
		[Token(Token = "0x40004C2")]
		[FieldOffset(Offset = "0x0")]
		private static Vector3 s_invalid;
	}
}
