using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	internal static class ShapesExtensions
	{
		// Token: 0x06000C04 RID: 3076 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C04")]
		public static void ForEach<T>(this IEnumerable<T> elems, Action<T> action)
		{
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00004B8C File Offset: 0x00002D8C
		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x2A4A700", Offset = "0x2A48D00", VA = "0x182A4A700")]
		public static Vector3 Rot90CCW(this Vector3 v)
		{
			return default(Vector3);
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00004BA4 File Offset: 0x00002DA4
		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x225CFB0", Offset = "0x225B5B0", VA = "0x18225CFB0")]
		public static int AsInt(this bool b)
		{
			return 0;
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00004BBC File Offset: 0x00002DBC
		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x2A4A720", Offset = "0x2A48D20", VA = "0x182A4A720")]
		public static Vector4 ToVector4(this Rect r)
		{
			return default(Vector4);
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00004BD4 File Offset: 0x00002DD4
		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x2A4A740", Offset = "0x2A48D40", VA = "0x182A4A740")]
		public static float TaxicabMagnitude(this Vector3 v)
		{
			return 0f;
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00004BEC File Offset: 0x00002DEC
		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x2A4A770", Offset = "0x2A48D70", VA = "0x182A4A770")]
		public static float AvgComponentMagnitude(this Vector3 v)
		{
			return 0f;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00004C04 File Offset: 0x00002E04
		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x2A4A7A0", Offset = "0x2A48DA0", VA = "0x182A4A7A0")]
		internal static Color ColorSpaceAdjusted(this Color c)
		{
			return default(Color);
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x2A4A830", Offset = "0x2A48E30", VA = "0x182A4A830")]
		public static void DestroyBranched(this UnityEngine.Object obj)
		{
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x2A4A880", Offset = "0x2A48E80", VA = "0x182A4A880")]
		public static void DestroyEndOfFrameEmulated(this UnityEngine.Object obj)
		{
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x2A4A8D0", Offset = "0x2A48ED0", VA = "0x182A4A8D0")]
		public static void TryDestroyInOnDestroy(this UnityEngine.Object caller, UnityEngine.Object obj)
		{
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00004C1C File Offset: 0x00002E1C
		[Token(Token = "0x6000C0E")]
		public static int Product<T>(this IEnumerable<T> arr, Func<T, int> mulVal)
		{
			return 0;
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00004C34 File Offset: 0x00002E34
		[Token(Token = "0x6000C0F")]
		public static float Product<T>(this IEnumerable<T> arr, Func<T, float> mulVal)
		{
			return 0f;
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000C10")]
		public static IEnumerable<TResult> Zip<T1, T2, T3, TResult>(this IEnumerable<T1> source, IEnumerable<T2> second, IEnumerable<T3> third, Func<T1, T2, T3, TResult> func)
		{
			return null;
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00004C4C File Offset: 0x00002E4C
		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x2A4A9B0", Offset = "0x2A48FB0", VA = "0x182A4A9B0")]
		public static int PopCount(this uint i)
		{
			return 0;
		}
	}
}
