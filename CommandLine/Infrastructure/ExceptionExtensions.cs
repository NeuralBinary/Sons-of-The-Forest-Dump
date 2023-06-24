using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommandLine.Infrastructure
{
	// Token: 0x020000AD RID: 173
	[Token(Token = "0x20000AD")]
	internal static class ExceptionExtensions
	{
		// Token: 0x060003F6 RID: 1014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x9A2220", Offset = "0x9A0820", VA = "0x1809A2220")]
		public static void RethrowWhenAbsentIn(this Exception exception, IEnumerable<Type> validExceptions)
		{
		}
	}
}
