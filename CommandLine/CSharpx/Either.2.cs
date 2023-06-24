using System;
using Il2CppDummyDll;

namespace CSharpx
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	internal static class Either
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		public static Either<TLeft, TRight> Left<TLeft, TRight>(TLeft value)
		{
			return null;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E4")]
		public static Either<TLeft, TRight> Right<TLeft, TRight>(TRight value)
		{
			return null;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E5")]
		public static Either<string, TRight> Return<TRight>(TRight value)
		{
			return null;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E6")]
		public static Either<string, TRight> Fail<TRight>(string message)
		{
			return null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E7")]
		public static Either<TLeft, TResult> Bind<TLeft, TRight, TResult>(Either<TLeft, TRight> either, Func<TRight, Either<TLeft, TResult>> func)
		{
			return null;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E8")]
		public static Either<TLeft, TResult> Map<TLeft, TRight, TResult>(Either<TLeft, TRight> either, Func<TRight, TResult> func)
		{
			return null;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E9")]
		public static Either<TLeft1, TRight1> Bimap<TLeft, TRight, TLeft1, TRight1>(Either<TLeft, TRight> either, Func<TLeft, TLeft1> mapLeft, Func<TRight, TRight1> mapRight)
		{
			return null;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EA")]
		public static Either<TLeft, TResult> Select<TLeft, TRight, TResult>(this Either<TLeft, TRight> either, Func<TRight, TResult> selector)
		{
			return null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EB")]
		public static Either<TLeft, TResult> SelectMany<TLeft, TRight, TResult>(this Either<TLeft, TRight> result, Func<TRight, Either<TLeft, TResult>> func)
		{
			return null;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EC")]
		public static TRight GetOrFail<TLeft, TRight>(Either<TLeft, TRight> either)
		{
			return null;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000ED")]
		public static TLeft GetLeftOrDefault<TLeft, TRight>(Either<TLeft, TRight> either, TLeft @default)
		{
			return null;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EE")]
		public static TRight GetRightOrDefault<TLeft, TRight>(Either<TLeft, TRight> either, TRight @default)
		{
			return null;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EF")]
		public static Either<Exception, TRight> Try<TRight>(Func<TRight> func)
		{
			return null;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F0")]
		public static Either<Exception, TRight> Cast<TRight>(object obj)
		{
			return null;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F1")]
		public static Either<TLeft, TRight> FromMaybe<TLeft, TRight>(Maybe<TRight> maybe, TLeft left)
		{
			return null;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F2")]
		private static TLeft GetLeft<TLeft, TRight>(this Either<TLeft, TRight> either)
		{
			return null;
		}
	}
}
