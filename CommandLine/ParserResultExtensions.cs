using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public static class ParserResultExtensions
	{
		// Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000245")]
		public static ParserResult<T> WithParsed<T>(this ParserResult<T> result, Action<T> action)
		{
			return null;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000246")]
		public static ParserResult<object> WithParsed<T>(this ParserResult<object> result, Action<T> action)
		{
			return null;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000247")]
		public static ParserResult<T> WithNotParsed<T>(this ParserResult<T> result, Action<IEnumerable<Error>> action)
		{
			return null;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000248")]
		public static TResult MapResult<TSource, TResult>(this ParserResult<TSource> result, Func<TSource, TResult> parsedFunc, Func<IEnumerable<Error>, TResult> notParsedFunc)
		{
			return null;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		public static TResult MapResult<T1, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<IEnumerable<Error>, TResult> notParsedFunc)
		{
			return null;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024A")]
		public static TResult MapResult<T1, T2, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<IEnumerable<Error>, TResult> notParsedFunc)
		{
			return null;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024B")]
		public static TResult MapResult<T1, T2, T3, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<IEnumerable<Error>, TResult> notParsedFunc)
		{
			return null;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024C")]
		public static TResult MapResult<T1, T2, T3, T4, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<IEnumerable<Error>, TResult> notParsedFunc)
		{
			return null;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024D")]
		public static TResult MapResult<T1, T2, T3, T4, T5, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<IEnumerable<Error>, TResult> notParsedFunc)
		{
			return null;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024E")]
		public static TResult MapResult<T1, T2, T3, T4, T5, T6, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<IEnumerable<Error>, TResult> notParsedFunc)
		{
			return null;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024F")]
		public static TResult MapResult<T1, T2, T3, T4, T5, T6, T7, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<T7, TResult> parsedFunc7, Func<IEnumerable<Error>, TResult> notParsedFunc)
		{
			return null;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000250")]
		public static TResult MapResult<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<T7, TResult> parsedFunc7, Func<T8, TResult> parsedFunc8, Func<IEnumerable<Error>, TResult> notParsedFunc)
		{
			return null;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000251")]
		public static TResult MapResult<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<T7, TResult> parsedFunc7, Func<T8, TResult> parsedFunc8, Func<T9, TResult> parsedFunc9, Func<IEnumerable<Error>, TResult> notParsedFunc)
		{
			return null;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000252")]
		public static TResult MapResult<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<T7, TResult> parsedFunc7, Func<T8, TResult> parsedFunc8, Func<T9, TResult> parsedFunc9, Func<T10, TResult> parsedFunc10, Func<IEnumerable<Error>, TResult> notParsedFunc)
		{
			return null;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		public static TResult MapResult<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<T7, TResult> parsedFunc7, Func<T8, TResult> parsedFunc8, Func<T9, TResult> parsedFunc9, Func<T10, TResult> parsedFunc10, Func<T11, TResult> parsedFunc11, Func<IEnumerable<Error>, TResult> notParsedFunc)
		{
			return null;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000254")]
		public static TResult MapResult<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<T7, TResult> parsedFunc7, Func<T8, TResult> parsedFunc8, Func<T9, TResult> parsedFunc9, Func<T10, TResult> parsedFunc10, Func<T11, TResult> parsedFunc11, Func<T12, TResult> parsedFunc12, Func<IEnumerable<Error>, TResult> notParsedFunc)
		{
			return null;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000255")]
		public static TResult MapResult<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<T7, TResult> parsedFunc7, Func<T8, TResult> parsedFunc8, Func<T9, TResult> parsedFunc9, Func<T10, TResult> parsedFunc10, Func<T11, TResult> parsedFunc11, Func<T12, TResult> parsedFunc12, Func<T13, TResult> parsedFunc13, Func<IEnumerable<Error>, TResult> notParsedFunc)
		{
			return null;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000256")]
		public static TResult MapResult<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<T7, TResult> parsedFunc7, Func<T8, TResult> parsedFunc8, Func<T9, TResult> parsedFunc9, Func<T10, TResult> parsedFunc10, Func<T11, TResult> parsedFunc11, Func<T12, TResult> parsedFunc12, Func<T13, TResult> parsedFunc13, Func<T14, TResult> parsedFunc14, Func<IEnumerable<Error>, TResult> notParsedFunc)
		{
			return null;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000257")]
		public static TResult MapResult<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<T7, TResult> parsedFunc7, Func<T8, TResult> parsedFunc8, Func<T9, TResult> parsedFunc9, Func<T10, TResult> parsedFunc10, Func<T11, TResult> parsedFunc11, Func<T12, TResult> parsedFunc12, Func<T13, TResult> parsedFunc13, Func<T14, TResult> parsedFunc14, Func<T15, TResult> parsedFunc15, Func<IEnumerable<Error>, TResult> notParsedFunc)
		{
			return null;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000258")]
		public static TResult MapResult<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this ParserResult<object> result, Func<T1, TResult> parsedFunc1, Func<T2, TResult> parsedFunc2, Func<T3, TResult> parsedFunc3, Func<T4, TResult> parsedFunc4, Func<T5, TResult> parsedFunc5, Func<T6, TResult> parsedFunc6, Func<T7, TResult> parsedFunc7, Func<T8, TResult> parsedFunc8, Func<T9, TResult> parsedFunc9, Func<T10, TResult> parsedFunc10, Func<T11, TResult> parsedFunc11, Func<T12, TResult> parsedFunc12, Func<T13, TResult> parsedFunc13, Func<T14, TResult> parsedFunc14, Func<T15, TResult> parsedFunc15, Func<T16, TResult> parsedFunc16, Func<IEnumerable<Error>, TResult> notParsedFunc)
		{
			return null;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000259")]
		public static Task<ParserResult<T>> WithParsedAsync<T>(this ParserResult<T> result, Func<T, Task> action)
		{
			return null;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025A")]
		public static Task<ParserResult<object>> WithParsedAsync<T>(this ParserResult<object> result, Func<T, Task> action)
		{
			return null;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025B")]
		public static Task<ParserResult<T>> WithNotParsedAsync<T>(this ParserResult<T> result, Func<IEnumerable<Error>, Task> action)
		{
			return null;
		}
	}
}
