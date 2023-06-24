using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	public static class HelpTextExtensions
	{
		// Token: 0x060001E8 RID: 488 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x990F30", Offset = "0x98F530", VA = "0x180990F30")]
		public static bool IsHelp(this IEnumerable<Error> errs)
		{
			return default(bool);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x9911B0", Offset = "0x98F7B0", VA = "0x1809911B0")]
		public static bool IsVersion(this IEnumerable<Error> errs)
		{
			return default(bool);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x991430", Offset = "0x98FA30", VA = "0x180991430")]
		public static TextWriter Output(this IEnumerable<Error> errs)
		{
			return null;
		}
	}
}
