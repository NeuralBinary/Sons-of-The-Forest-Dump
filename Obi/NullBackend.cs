using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000F8 RID: 248
	[Token(Token = "0x20000F8")]
	public class NullBackend : IObiBackend
	{
		// Token: 0x0600047F RID: 1151 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x27AAA60", Offset = "0x27A9060", VA = "0x1827AAA60", Slot = "4")]
		public ISolverImpl CreateSolver(ObiSolver solver, int capacity)
		{
			return null;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public void DestroySolver(ISolverImpl solver)
		{
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NullBackend()
		{
		}
	}
}
