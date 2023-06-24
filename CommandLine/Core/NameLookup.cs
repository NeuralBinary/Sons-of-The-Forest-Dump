using System;
using System.Collections.Generic;
using CSharpx;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	internal static class NameLookup
	{
		// Token: 0x060004A9 RID: 1193 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x9A9AD0", Offset = "0x9A80D0", VA = "0x1809A9AD0")]
		public static NameLookupResult Contains(string name, IEnumerable<OptionSpecification> specifications, StringComparer comparer)
		{
			return NameLookupResult.NoOptionFound;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x9A9CE0", Offset = "0x9A82E0", VA = "0x1809A9CE0")]
		public static Maybe<char> HavingSeparator(string name, IEnumerable<OptionSpecification> specifications, StringComparer comparer)
		{
			return null;
		}
	}
}
