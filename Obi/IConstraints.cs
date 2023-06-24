using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000E9")]
	public interface IConstraints
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000456 RID: 1110
		[Token(Token = "0x17000088")]
		Oni.ConstraintType constraintType { [Token(Token = "0x6000456")] get; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000457 RID: 1111
		[Token(Token = "0x17000089")]
		ISolverImpl solver { [Token(Token = "0x6000457")] get; }

		// Token: 0x06000458 RID: 1112
		[Token(Token = "0x6000458")]
		int GetConstraintCount();
	}
}
