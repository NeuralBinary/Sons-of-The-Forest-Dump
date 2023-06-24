using System;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	public sealed class GroupOptionAmbiguityError : NamedError
	{
		// Token: 0x060001E0 RID: 480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x9909F0", Offset = "0x98EFF0", VA = "0x1809909F0")]
		internal GroupOptionAmbiguityError(NameInfo option)
		{
		}

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x20")]
		public NameInfo Option;
	}
}
