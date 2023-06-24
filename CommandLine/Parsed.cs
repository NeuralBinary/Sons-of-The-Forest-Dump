using System;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	public sealed class Parsed<T> : ParserResult<T>, IEquatable<Parsed<T>>
	{
		// Token: 0x0600023C RID: 572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023C")]
		internal Parsed(T value, TypeInfo typeInfo)
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023D")]
		internal Parsed(T value)
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x600023E")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x600023F")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x6000240")]
		public bool Equals(Parsed<T> other)
		{
			return default(bool);
		}
	}
}
