using System;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	public static class CastExtensions
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x60001A4")]
		public static bool CanCast<T>(this Type baseType)
		{
			return default(bool);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x60001A5")]
		public static bool CanCast<T>(this object obj)
		{
			return default(bool);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A6")]
		public static T Cast<T>(this object obj)
		{
			return null;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x60001A7")]
		private static bool CanImplicitCast<T>(this Type baseType)
		{
			return default(bool);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x60001A8")]
		private static bool CanImplicitCast<T>(this object obj)
		{
			return default(bool);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x60001A9")]
		private static bool CanExplicitCast<T>(this Type baseType)
		{
			return default(bool);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x60001AA")]
		private static bool CanExplicitCast<T>(this object obj)
		{
			return default(bool);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x60001AB")]
		private static bool CanCast<T>(this Type baseType, string castMethodName)
		{
			return default(bool);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AC")]
		private static T ImplicitCast<T>(this object obj)
		{
			return null;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AD")]
		private static T ExplicitCast<T>(this object obj)
		{
			return null;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AE")]
		private static T Cast<T>(this object obj, string castMethodName)
		{
			return null;
		}

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		private const string ImplicitCastMethodName = "op_Implicit";

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		private const string ExplicitCastMethodName = "op_Explicit";
	}
}
