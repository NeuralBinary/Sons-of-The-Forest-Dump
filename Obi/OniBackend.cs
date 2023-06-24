using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000115 RID: 277
	[Token(Token = "0x2000115")]
	public class OniBackend : IObiBackend
	{
		// Token: 0x060004EB RID: 1259 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x27AD820", Offset = "0x27ABE20", VA = "0x1827AD820", Slot = "4")]
		public ISolverImpl CreateSolver(ObiSolver solver, int capacity)
		{
			return null;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x27AD910", Offset = "0x27ABF10", VA = "0x1827AD910", Slot = "5")]
		public void DestroySolver(ISolverImpl solver)
		{
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x27ADB80", Offset = "0x27AC180", VA = "0x1827ADB80")]
		private void GetOrCreateColliderWorld()
		{
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public OniBackend()
		{
		}

		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x10")]
		private OniColliderWorld colliderGrid;
	}
}
