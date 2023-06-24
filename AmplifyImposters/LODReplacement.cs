using System;
using Il2CppDummyDll;

namespace AmplifyImpostors
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public enum LODReplacement
	{
		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		DoNothing,
		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		ReplaceCulled,
		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		ReplaceLast,
		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		ReplaceAllExceptFirst,
		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		ReplaceSpecific,
		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		ReplaceAfterSpecific,
		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		InsertAfter
	}
}
