using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public static class AiRandom
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2A8CEF0", Offset = "0x2A8B4F0", VA = "0x182A8CEF0")]
		public static int Range(int min, int maxExclusive)
		{
			return 0;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2A8D090", Offset = "0x2A8B690", VA = "0x182A8D090")]
		public static float Range(float min, float max)
		{
			return 0f;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020B0 File Offset: 0x000002B0
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2A8D240", Offset = "0x2A8B840", VA = "0x182A8D240")]
		public static float Range(Vector2 minMax)
		{
			return 0f;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020C8 File Offset: 0x000002C8
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2A8D3E0", Offset = "0x2A8B9E0", VA = "0x182A8D3E0")]
		public static int Range(Vector2Int minMax)
		{
			return 0;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020E0 File Offset: 0x000002E0
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2A8D400", Offset = "0x2A8BA00", VA = "0x182A8D400")]
		public static bool Chance(float chanceTrue)
		{
			return default(bool);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020F8 File Offset: 0x000002F8
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2A8D430", Offset = "0x2A8BA30", VA = "0x182A8D430")]
		public static Vector3 InsideSphere(float radius)
		{
			return default(Vector3);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002110 File Offset: 0x00000310
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2A8D560", Offset = "0x2A8BB60", VA = "0x182A8D560")]
		public static Vector3 InsideCircleXZ(float radius)
		{
			return default(Vector3);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002128 File Offset: 0x00000328
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2A8D670", Offset = "0x2A8BC70", VA = "0x182A8D670")]
		public static Vector3 InRing(float minRadius, float maxRadius)
		{
			return default(Vector3);
		}

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x0")]
		private static System.Random _random;
	}
}
