using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x020000DD RID: 221
	[Token(Token = "0x20000DD")]
	internal static class PreprocessorGuards
	{
		// Token: 0x060004C7 RID: 1223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x9ABDC0", Offset = "0x9AA3C0", VA = "0x1809ABDC0")]
		public static IEnumerable<Func<IEnumerable<string>, IEnumerable<Error>>> Lookup(StringComparer nameComparer, bool autoHelp, bool autoVersion)
		{
			return null;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x9AC010", Offset = "0x9AA610", VA = "0x1809AC010")]
		public static Func<IEnumerable<string>, IEnumerable<Error>> HelpCommand(StringComparer nameComparer)
		{
			return null;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x9AC0F0", Offset = "0x9AA6F0", VA = "0x1809AC0F0")]
		public static Func<IEnumerable<string>, IEnumerable<Error>> VersionCommand(StringComparer nameComparer)
		{
			return null;
		}
	}
}
