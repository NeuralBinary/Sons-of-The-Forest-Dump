using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Endnight.Extensions
{
	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	public static class ListExtensions
	{
		// Token: 0x060003CE RID: 974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CE")]
		public static void RemoveMatchingKeys<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey match)
		{
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CF")]
		public static void RemoveNulls<TKey, TValue>(this Dictionary<TKey, TValue> dict) where TKey : class
		{
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D0")]
		public static void RemoveNulls<TKey, TValue>(this Dictionary<TKey?, TValue> dict) where TKey : struct
		{
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D1")]
		public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
		{
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00003C90 File Offset: 0x00001E90
		[Token(Token = "0x60003D2")]
		public static bool IsNullOrEmpty<T>(this ICollection<T> collectionValue)
		{
			return default(bool);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[Token(Token = "0x60003D3")]
		public static bool IsNullOrEmpty<T>(this T[] arrayValue)
		{
			return default(bool);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D4")]
		public static void SafeRemove<T>(this IList<T> list, T item)
		{
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D5")]
		public static void RemoveBySwap<T>(this List<T> list, T item)
		{
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Token(Token = "0x60003D6")]
		public static int SafeCount<T>(this ICollection<T> arrayValue)
		{
			return 0;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x60003D7")]
		public static int SafeCount<T>(this IList<T> arrayValue)
		{
			return 0;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00003CF0 File Offset: 0x00001EF0
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xAA5960", Offset = "0xAA3F60", VA = "0x180AA5960")]
		public static int SafeCount(this ArrayList arrayValue)
		{
			return 0;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00003D08 File Offset: 0x00001F08
		[Token(Token = "0x60003D9")]
		public static int SafeCount<T>(this T[] arrayValue)
		{
			return 0;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x60003DA")]
		public static int WrapIndex<T>(this ICollection<T> arrayValue, int index, int defaultValue = 0)
		{
			return 0;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x60003DB")]
		public static int WrapIndex<T>(this IList<T> arrayValue, int index, int defaultValue = 0)
		{
			return 0;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xAA5980", Offset = "0xAA3F80", VA = "0x180AA5980")]
		public static int WrapIndex(this ArrayList arrayValue, int index, int defaultValue = 0)
		{
			return 0;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00003D68 File Offset: 0x00001F68
		[Token(Token = "0x60003DD")]
		public static int WrapIndex<T>(this T[] arrayValue, int index, int defaultValue = 0)
		{
			return 0;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00003D80 File Offset: 0x00001F80
		[Token(Token = "0x60003DE")]
		public static bool IndexValid<T>(this T[] arrayValue, int arrayIndex)
		{
			return default(bool);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003DF")]
		public static T GetIndexSafe<T>(this T[] arrayValue, int arrayIndex, [Optional] T defaultResult)
		{
			return null;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00003D98 File Offset: 0x00001F98
		[Token(Token = "0x60003E0")]
		public static bool IndexValid<T>(this List<T> arrayValue, int arrayIndex)
		{
			return default(bool);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003E1")]
		public static T GetIndexSafe<T>(this List<T> arrayValue, int arrayIndex, [Optional] T defaultResult)
		{
			return null;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E2")]
		public static void PadOrTrim<T>(this List<T> arrayValue, int count, [Optional] T padValue)
		{
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E3")]
		public static void Pad<T>(this List<T> arrayValue, int count, [Optional] T padValue)
		{
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E4")]
		public static void Trim<T>(this List<T> arrayValue, int count)
		{
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E5")]
		public static void SortStable<T, TC>(this List<T> list, TC comparer) where T : IComparable<T> where TC : IComparer<T>
		{
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E6")]
		public static void SortStable<T>(this List<T> list) where T : IComparable<T>
		{
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E7")]
		public static void InitializeIfNull<T>(ref List<T> list)
		{
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[Token(Token = "0x60003E8")]
		public static bool AddIfUnique<T>(this List<T> list, T item)
		{
			return default(bool);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E9")]
		public static void Shuffle<T>(this IList<T> list)
		{
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003EA")]
		public static List<T> Validate<T>(List<T> existing, List<T> source)
		{
			return null;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x60003EB")]
		public static int IndexOf<T>(this IEnumerable<T> source, T value)
		{
			return 0;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x60003EC")]
		public static int FindIndex<T>(this IEnumerable<T> source, Predicate<T> value)
		{
			return 0;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[Token(Token = "0x60003ED")]
		public static int FindIndex<T>(this T[] source, Predicate<T> predicate)
		{
			return 0;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EE")]
		public static void RemoveLastSafe<T>(this List<T> list)
		{
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EF")]
		public static void RemoveLast<T>(this List<T> list)
		{
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F0")]
		public static void RemoveAndReplaceWithLast<T>(this List<T> list, T listEntry)
		{
		}

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Random rng;

		// Token: 0x020000AC RID: 172
		[Token(Token = "0x20000AC")]
		private class ComparableComparer<T> : IComparer<T> where T : IComparable<T>
		{
			// Token: 0x060003F2 RID: 1010 RVA: 0x00003E10 File Offset: 0x00002010
			[Token(Token = "0x60003F2")]
			public int Compare(T x, T y)
			{
				return 0;
			}

			// Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003F3")]
			public ComparableComparer()
			{
			}
		}
	}
}
