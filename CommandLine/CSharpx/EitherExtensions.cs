using System;
using Il2CppDummyDll;

namespace CSharpx
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	internal static class EitherExtensions
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F5")]
		public static void Match<TLeft, TRight>(this Either<TLeft, TRight> either, Action<TLeft> ifLeft, Action<TRight> ifRight)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F6")]
		public static Either<string, TRight> ToEither<TRight>(this TRight value)
		{
			return null;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		public static Either<TLeft, TResult> Bind<TLeft, TRight, TResult>(this Either<TLeft, TRight> either, Func<TRight, Either<TLeft, TResult>> func)
		{
			return null;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F8")]
		public static Either<TLeft, TResult> Map<TLeft, TRight, TResult>(this Either<TLeft, TRight> either, Func<TRight, TResult> func)
		{
			return null;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F9")]
		public static Either<TLeft1, TRight1> Bimap<TLeft, TRight, TLeft1, TRight1>(this Either<TLeft, TRight> either, Func<TLeft, TLeft1> mapLeft, Func<TRight, TRight1> mapRight)
		{
			return null;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x60000FA")]
		public static bool IsLeft<TLeft, TRight>(this Either<TLeft, TRight> either)
		{
			return default(bool);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x60000FB")]
		public static bool IsRight<TLeft, TRight>(this Either<TLeft, TRight> either)
		{
			return default(bool);
		}
	}
}
