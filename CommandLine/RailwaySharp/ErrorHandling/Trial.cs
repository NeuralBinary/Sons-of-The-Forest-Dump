using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace RailwaySharp.ErrorHandling
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	internal static class Trial
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		public static Result<TSuccess, TMessage> Ok<TSuccess, TMessage>(TSuccess value)
		{
			return null;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A3")]
		public static Result<TSuccess, TMessage> Pass<TSuccess, TMessage>(TSuccess value)
		{
			return null;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		public static Result<TSuccess, TMessage> Warn<TSuccess, TMessage>(TMessage message, TSuccess value)
		{
			return null;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A5")]
		public static Result<TSuccess, TMessage> Fail<TSuccess, TMessage>(TMessage message)
		{
			return null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x60000A6")]
		public static bool Failed<TSuccess, TMessage>(Result<TSuccess, TMessage> result)
		{
			return default(bool);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A7")]
		public static TResult Either<TSuccess, TMessage, TResult>(Func<TSuccess, IEnumerable<TMessage>, TResult> successFunc, Func<IEnumerable<TMessage>, TResult> failureFunc, Result<TSuccess, TMessage> trialResult)
		{
			return null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A8")]
		public static TSuccess ReturnOrFail<TSuccess, TMessage>(Result<TSuccess, TMessage> result)
		{
			return null;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		public static Result<TSuccess, TMessage> MergeMessages<TSuccess, TMessage>(IEnumerable<TMessage> messages, Result<TSuccess, TMessage> result)
		{
			return null;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AA")]
		public static Result<TSuccess, TMessage> Bind<TValue, TSuccess, TMessage>(Func<TValue, Result<TSuccess, TMessage>> func, Result<TValue, TMessage> result)
		{
			return null;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		public static Result<TSuccess, TMessage> Flatten<TSuccess, TMessage>(Result<Result<TSuccess, TMessage>, TMessage> result)
		{
			return null;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		public static Result<TSuccess, TMessage> Apply<TValue, TSuccess, TMessage>(Result<Func<TValue, TSuccess>, TMessage> wrappedFunction, Result<TValue, TMessage> result)
		{
			return null;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		public static Result<TSuccess, TMessage> Lift<TValue, TSuccess, TMessage>(Func<TValue, TSuccess> func, Result<TValue, TMessage> result)
		{
			return null;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AE")]
		public static Result<TSuccess1, TMessage1> Lift2<TSuccess, TMessage, TSuccess1, TMessage1>(Func<TSuccess, Func<TMessage, TSuccess1>> func, Result<TSuccess, TMessage1> first, Result<TMessage, TMessage1> second)
		{
			return null;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AF")]
		public static Result<IEnumerable<TSuccess>, TMessage> Collect<TSuccess, TMessage>(IEnumerable<Result<TSuccess, TMessage>> xs)
		{
			return null;
		}
	}
}
