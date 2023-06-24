using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public class PathNNConstraint : NNConstraint
	{
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000084")]
		public new static PathNNConstraint Default
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x633360", Offset = "0x631960", VA = "0x180633360")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x6333C0", Offset = "0x6319C0", VA = "0x1806333C0", Slot = "6")]
		public virtual void SetStart(GraphNode node)
		{
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x633330", Offset = "0x631930", VA = "0x180633330")]
		public PathNNConstraint()
		{
		}
	}
}
