using System;
using Il2CppDummyDll;

namespace Sons.Construction.Branching
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public enum BranchingActionTypes
	{
		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		Cut,
		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		Combine,
		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		Interact,
		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		CombineIntoPreset,
		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		CombineAndAddFromTemplate,
		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		AddFromTemplate,
		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		SwapAndAddFromTemplate,
		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		CutSwap
	}
}
