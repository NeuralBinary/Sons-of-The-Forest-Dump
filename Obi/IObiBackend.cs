using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000F5 RID: 245
	[Token(Token = "0x20000F5")]
	public interface IObiBackend
	{
		// Token: 0x06000462 RID: 1122
		[Token(Token = "0x6000462")]
		ISolverImpl CreateSolver(ObiSolver solver, int capacity);

		// Token: 0x06000463 RID: 1123
		[Token(Token = "0x6000463")]
		void DestroySolver(ISolverImpl solver);
	}
}
