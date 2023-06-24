using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace RailwaySharp.ErrorHandling
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	internal static class Result
	{
		// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009C")]
		public static Result<TSuccess, TMessage> FailWith<TSuccess, TMessage>(IEnumerable<TMessage> messages)
		{
			return null;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009D")]
		public static Result<TSuccess, TMessage> FailWith<TSuccess, TMessage>(TMessage message)
		{
			return null;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009E")]
		public static Result<TSuccess, TMessage> Succeed<TSuccess, TMessage>(TSuccess value)
		{
			return null;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009F")]
		public static Result<TSuccess, TMessage> Succeed<TSuccess, TMessage>(TSuccess value, TMessage message)
		{
			return null;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A0")]
		public static Result<TSuccess, TMessage> Succeed<TSuccess, TMessage>(TSuccess value, IEnumerable<TMessage> messages)
		{
			return null;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A1")]
		public static Result<TSuccess, Exception> Try<TSuccess>(Func<TSuccess> func)
		{
			return null;
		}
	}
}
