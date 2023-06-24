using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace CSharpx
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	internal static class EnumerableExtensions
	{
		// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FC")]
		public static Maybe<T> TryHead<T>(this IEnumerable<T> source)
		{
			return null;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FD")]
		public static Maybe<IEnumerable<T>> ToMaybe<T>(this IEnumerable<T> source)
		{
			return null;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FE")]
		private static IEnumerable<TSource> AssertCountImpl<TSource>(IEnumerable<TSource> source, int count, Func<int, int, Exception> errorSelector)
		{
			return null;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FF")]
		private static IEnumerable<TSource> ExpectingCountYieldingImpl<TSource>(IEnumerable<TSource> source, int count, Func<int, int, Exception> errorSelector)
		{
			return null;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000100")]
		public static IEnumerable<TResult> Cartesian<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
		{
			return null;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000101")]
		public static IEnumerable<TSource> Prepend<TSource>(this IEnumerable<TSource> source, TSource value)
		{
			return null;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000102")]
		public static IEnumerable<T> Concat<T>(this T head, IEnumerable<T> tail)
		{
			return null;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000103")]
		public static IEnumerable<T> Concat<T>(this IEnumerable<T> head, T tail)
		{
			return null;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000104")]
		public static IEnumerable<T> Exclude<T>(this IEnumerable<T> sequence, int startIndex, int count)
		{
			return null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000105")]
		private static IEnumerable<T> ExcludeImpl<T>(IEnumerable<T> sequence, int startIndex, int count)
		{
			return null;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000106")]
		public static IEnumerable<KeyValuePair<int, TSource>> Index<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000107")]
		public static IEnumerable<KeyValuePair<int, TSource>> Index<TSource>(this IEnumerable<TSource> source, int startIndex)
		{
			return null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000108")]
		public static TResult Fold<T, TResult>(this IEnumerable<T> source, Func<T, TResult> folder)
		{
			return null;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000109")]
		public static TResult Fold<T, TResult>(this IEnumerable<T> source, Func<T, T, TResult> folder)
		{
			return null;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010A")]
		public static TResult Fold<T, TResult>(this IEnumerable<T> source, Func<T, T, T, TResult> folder)
		{
			return null;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010B")]
		public static TResult Fold<T, TResult>(this IEnumerable<T> source, Func<T, T, T, T, TResult> folder)
		{
			return null;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010C")]
		private static TResult FoldImpl<T, TResult>(IEnumerable<T> source, int count, Func<T, TResult> folder1, Func<T, T, TResult> folder2, Func<T, T, T, TResult> folder3, Func<T, T, T, T, TResult> folder4)
		{
			return null;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x98E740", Offset = "0x98CD40", VA = "0x18098E740")]
		private static Exception OnFolderSourceSizeError(int cmp, int count)
		{
			return null;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010E")]
		public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010F")]
		public static IEnumerable<TResult> Pairwise<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TSource, TResult> resultSelector)
		{
			return null;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000110")]
		private static IEnumerable<TResult> PairwiseImpl<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TSource, TResult> resultSelector)
		{
			return null;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000111")]
		public static string ToDelimitedString<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000112")]
		public static string ToDelimitedString<TSource>(this IEnumerable<TSource> source, string delimiter)
		{
			return null;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000113")]
		private static string ToDelimitedStringImpl<T>(IEnumerable<T> source, string delimiter, Func<StringBuilder, T, StringBuilder> append)
		{
			return null;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000114")]
		public static IEnumerable<T> Tail<T>(this IEnumerable<T> source)
		{
			return null;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000115")]
		public static IEnumerable<T> TailNoFail<T>(this IEnumerable<T> source)
		{
			return null;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000116")]
		public static IEnumerable<T> Memoize<T>(this IEnumerable<T> source)
		{
			return null;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000117")]
		public static IEnumerable<T> Materialize<T>(this IEnumerable<T> source)
		{
			return null;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000118")]
		public static T Choice<T>(this IEnumerable<T> source)
		{
			return null;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000119")]
		public static IEnumerable<T> Intersperse<T>(this IEnumerable<T> source, T element)
		{
			return null;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011A")]
		public static IEnumerable<T> FlattenOnce<T>(this IEnumerable<IEnumerable<T>> source)
		{
			return null;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x98E8B0", Offset = "0x98CEB0", VA = "0x18098E8B0")]
		public static IEnumerable<string> FlattenOnce(this IEnumerable<string> source)
		{
			return null;
		}

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Func<int, int, Exception> OnFolderSourceSizeErrorSelector;

		// Token: 0x02000033 RID: 51
		[Token(Token = "0x2000033")]
		private class MaterializedEnumerable<T> : IEnumerable<T>, IEnumerable
		{
			// Token: 0x0600011D RID: 285 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600011D")]
			public MaterializedEnumerable(IEnumerable<T> enumerable)
			{
			}

			// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600011E")]
			public IEnumerator<T> GetEnumerator()
			{
				return null;
			}

			// Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600011F")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x0400005A RID: 90
			[Token(Token = "0x400005A")]
			[FieldOffset(Offset = "0x0")]
			private readonly ICollection<T> inner;
		}
	}
}
