using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200024E RID: 590
	[Token(Token = "0x200024E")]
	[Flags]
	public enum EdgeRefineFlags
	{
		// Token: 0x040009C1 RID: 2497
		[Token(Token = "0x40009C1")]
		NoConstraint = 0,
		// Token: 0x040009C2 RID: 2498
		[Token(Token = "0x40009C2")]
		NoFlip = 1,
		// Token: 0x040009C3 RID: 2499
		[Token(Token = "0x40009C3")]
		NoSplit = 2,
		// Token: 0x040009C4 RID: 2500
		[Token(Token = "0x40009C4")]
		NoCollapse = 4,
		// Token: 0x040009C5 RID: 2501
		[Token(Token = "0x40009C5")]
		FullyConstrained = 7,
		// Token: 0x040009C6 RID: 2502
		[Token(Token = "0x40009C6")]
		PreserveTopology = 8
	}
}
