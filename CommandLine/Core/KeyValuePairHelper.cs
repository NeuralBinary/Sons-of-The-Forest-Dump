using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x020000CD RID: 205
	[Token(Token = "0x20000CD")]
	internal static class KeyValuePairHelper
	{
		// Token: 0x06000496 RID: 1174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x9A89D0", Offset = "0x9A6FD0", VA = "0x1809A89D0")]
		public static IEnumerable<KeyValuePair<string, IEnumerable<string>>> ForSwitch(IEnumerable<Token> tokens)
		{
			return null;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x9A8B20", Offset = "0x9A7120", VA = "0x1809A8B20")]
		public static IEnumerable<KeyValuePair<string, IEnumerable<string>>> ForScalar(IEnumerable<Token> tokens)
		{
			return null;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x9A8D40", Offset = "0x9A7340", VA = "0x1809A8D40")]
		public static IEnumerable<KeyValuePair<string, IEnumerable<string>>> ForSequence(IEnumerable<Token> tokens)
		{
			return null;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x9A8FC0", Offset = "0x9A75C0", VA = "0x1809A8FC0")]
		private static KeyValuePair<string, IEnumerable<string>> ToKeyValuePair(this string value, params string[] values)
		{
			return default(KeyValuePair<string, IEnumerable<string>>);
		}
	}
}
