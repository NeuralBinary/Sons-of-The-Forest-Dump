using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	public sealed class NotParsed<T> : ParserResult<T>, IEquatable<NotParsed<T>>
	{
		// Token: 0x06000241 RID: 577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000241")]
		internal NotParsed(TypeInfo typeInfo, IEnumerable<Error> errors)
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x6000242")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x6000243")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x6000244")]
		public bool Equals(NotParsed<T> other)
		{
			return default(bool);
		}
	}
}
