using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public class BurstBackend : IObiBackend
	{
		// Token: 0x06000248 RID: 584 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x27655D0", Offset = "0x2763BD0", VA = "0x1827655D0", Slot = "4")]
		public ISolverImpl CreateSolver(ObiSolver solver, int capacity)
		{
			return null;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2765630", Offset = "0x2763C30", VA = "0x182765630", Slot = "5")]
		public void DestroySolver(ISolverImpl solver)
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BurstBackend()
		{
		}
	}
}
