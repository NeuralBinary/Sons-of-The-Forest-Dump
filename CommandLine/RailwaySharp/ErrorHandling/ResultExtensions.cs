using System;
using System.Collections.Generic;
using CSharpx;
using Il2CppDummyDll;

namespace RailwaySharp.ErrorHandling
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	internal static class ResultExtensions
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C4")]
		public static void Match<TSuccess, TMessage>(this Result<TSuccess, TMessage> result, Action<TSuccess, IEnumerable<TMessage>> ifSuccess, Action<IEnumerable<TMessage>> ifFailure)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C5")]
		public static TResult Either<TSuccess, TMessage, TResult>(this Result<TSuccess, TMessage> result, Func<TSuccess, IEnumerable<TMessage>, TResult> ifSuccess, Func<IEnumerable<TMessage>, TResult> ifFailure)
		{
			return null;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		public static Result<TResult, TMessage> Map<TSuccess, TMessage, TResult>(this Result<TSuccess, TMessage> result, Func<TSuccess, TResult> func)
		{
			return null;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C7")]
		public static Result<IEnumerable<TSuccess>, TMessage> Collect<TSuccess, TMessage>(this IEnumerable<Result<TSuccess, TMessage>> values)
		{
			return null;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		public static Result<IEnumerable<TSuccess>, TMessage> Flatten<TSuccess, TMessage>(this Result<IEnumerable<Result<TSuccess, TMessage>>, TMessage> result)
		{
			return null;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C9")]
		public static Result<TResult, TMessage> SelectMany<TSuccess, TMessage, TResult>(this Result<TSuccess, TMessage> result, Func<TSuccess, Result<TResult, TMessage>> func)
		{
			return null;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		public static Result<TResult, TMessage> SelectMany<TSuccess, TMessage, TValue, TResult>(this Result<TSuccess, TMessage> result, Func<TSuccess, Result<TValue, TMessage>> func, Func<TSuccess, TValue, TResult> mapperFunc)
		{
			return null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CB")]
		public static Result<TResult, TMessage> Select<TSuccess, TMessage, TResult>(this Result<TSuccess, TMessage> result, Func<TSuccess, TResult> func)
		{
			return null;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CC")]
		public static IEnumerable<TMessage> FailedWith<TSuccess, TMessage>(this Result<TSuccess, TMessage> result)
		{
			return null;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CD")]
		public static TSuccess SucceededWith<TSuccess, TMessage>(this Result<TSuccess, TMessage> result)
		{
			return null;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		public static IEnumerable<TMessage> SuccessMessages<TSuccess, TMessage>(this Result<TSuccess, TMessage> result)
		{
			return null;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CF")]
		public static Maybe<TSuccess> ToMaybe<TSuccess, TMessage>(this Result<TSuccess, TMessage> result)
		{
			return null;
		}
	}
}
