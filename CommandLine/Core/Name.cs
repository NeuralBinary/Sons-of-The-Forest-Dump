using System;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x020000F6 RID: 246
	[Token(Token = "0x20000F6")]
	internal class Name : Token, IEquatable<Name>
	{
		// Token: 0x0600059E RID: 1438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x9BAF10", Offset = "0x9B9510", VA = "0x1809BAF10")]
		public Name(string text)
		{
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x9BAF70", Offset = "0x9B9570", VA = "0x1809BAF70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00003C18 File Offset: 0x00001E18
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x9BB0C0", Offset = "0x9B96C0", VA = "0x1809BB0C0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00003C30 File Offset: 0x00001E30
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x9BB190", Offset = "0x9B9790", VA = "0x1809BB190", Slot = "4")]
		public bool Equals(Name other)
		{
			return default(bool);
		}
	}
}
