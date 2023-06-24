using System;
using Il2CppDummyDll;

namespace Pathfinding.Poly2Tri
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	public abstract class TriangulationDebugContext
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public TriangulationDebugContext(TriangulationContext tcx)
		{
		}

		// Token: 0x060000C9 RID: 201
		[Token(Token = "0x60000C9")]
		public abstract void Clear();

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x10")]
		protected TriangulationContext _tcx;
	}
}
