using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CSharpx
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	internal static class MaybeExtensions
	{
		// Token: 0x0600017D RID: 381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600017D")]
		public static void Match<T>(this Maybe<T> maybe, Action<T> ifJust, Action ifNothing)
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600017E")]
		public static void Match<T1, T2>(this Maybe<Tuple<T1, T2>> maybe, Action<T1, T2> ifJust, Action ifNothing)
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x600017F")]
		public static bool MatchJust<T1, T2>(this Maybe<Tuple<T1, T2>> maybe, out T1 value1, out T2 value2)
		{
			return default(bool);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000180")]
		public static Maybe<T> ToMaybe<T>(this T value)
		{
			return null;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000181")]
		public static Maybe<T2> Bind<T1, T2>(this Maybe<T1> maybe, Func<T1, Maybe<T2>> func)
		{
			return null;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000182")]
		public static Maybe<T2> Map<T1, T2>(this Maybe<T1> maybe, Func<T1, T2> func)
		{
			return null;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000183")]
		public static Maybe<TResult> Select<TSource, TResult>(this Maybe<TSource> maybe, Func<TSource, TResult> selector)
		{
			return null;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000184")]
		public static Maybe<TResult> SelectMany<TSource, TValue, TResult>(this Maybe<TSource> maybe, Func<TSource, Maybe<TValue>> valueSelector, Func<TSource, TValue, TResult> resultSelector)
		{
			return null;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000185")]
		public static void Do<T>(this Maybe<T> maybe, Action<T> action)
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000186")]
		public static void Do<T1, T2>(this Maybe<Tuple<T1, T2>> maybe, Action<T1, T2> action)
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x6000187")]
		public static bool IsJust<T>(this Maybe<T> maybe)
		{
			return default(bool);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x6000188")]
		public static bool IsNothing<T>(this Maybe<T> maybe)
		{
			return default(bool);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000189")]
		public static T FromJust<T>(this Maybe<T> maybe)
		{
			return null;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018A")]
		public static T FromJustOrFail<T>(this Maybe<T> maybe, [Optional] Exception exceptionToThrow)
		{
			return null;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018B")]
		public static T GetValueOrDefault<T>(this Maybe<T> maybe, T noneValue)
		{
			return null;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018C")]
		public static T2 MapValueOrDefault<T1, T2>(this Maybe<T1> maybe, Func<T1, T2> func, T2 noneValue)
		{
			return null;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018D")]
		public static T2 MapValueOrDefault<T1, T2>(this Maybe<T1> maybe, Func<T1, T2> func, Func<T2> noneValueFactory)
		{
			return null;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018E")]
		public static IEnumerable<T> ToEnumerable<T>(this Maybe<T> maybe)
		{
			return null;
		}
	}
}
