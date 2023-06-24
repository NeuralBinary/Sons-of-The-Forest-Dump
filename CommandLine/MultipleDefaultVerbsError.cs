using System;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	public sealed class MultipleDefaultVerbsError : Error
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x990AB0", Offset = "0x98F0B0", VA = "0x180990AB0")]
		internal MultipleDefaultVerbsError()
		{
		}

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		public const string ErrorMessage = "More than one default verb is not allowed.";
	}
}
