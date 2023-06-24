using System;
using Il2CppDummyDll;

namespace CSharpx
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	internal static class Maybe
	{
		// Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000177")]
		public static Maybe<T> Nothing<T>()
		{
			return null;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000178")]
		public static Just<T> Just<T>(T value)
		{
			return null;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000179")]
		public static Maybe<T> Return<T>(T value)
		{
			return null;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017A")]
		public static Maybe<T2> Bind<T1, T2>(Maybe<T1> maybe, Func<T1, Maybe<T2>> func)
		{
			return null;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017B")]
		public static Maybe<T2> Map<T1, T2>(Maybe<T1> maybe, Func<T1, T2> func)
		{
			return null;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017C")]
		public static Maybe<Tuple<T1, T2>> Merge<T1, T2>(Maybe<T1> first, Maybe<T2> second)
		{
			return null;
		}
	}
}
