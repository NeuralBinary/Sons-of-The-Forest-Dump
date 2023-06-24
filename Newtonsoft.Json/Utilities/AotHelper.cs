using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	[NullableContext(2)]
	[Nullable(0)]
	public static class AotHelper
	{
		// Token: 0x060004CD RID: 1229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x254D600", Offset = "0x254BC00", VA = "0x18254D600")]
		[NullableContext(1)]
		public static void Ensure(Action action)
		{
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CE")]
		public static void EnsureType<T>() where T : new()
		{
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CF")]
		public static void EnsureList<T>()
		{
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D0")]
		public static void EnsureDictionary<TKey, TValue>()
		{
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00003258 File Offset: 0x00001458
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x254D710", Offset = "0x254BD10", VA = "0x18254D710")]
		public static bool IsFalse()
		{
			return default(bool);
		}

		// Token: 0x04000360 RID: 864
		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_alwaysFalse;
	}
}
