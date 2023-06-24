using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.Poly2Tri
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public class ConstrainedPointSet : PointSet
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x28ADD10", Offset = "0x28AC310", VA = "0x1828ADD10")]
		public ConstrainedPointSet(List<TriangulationPoint> points, int[] index)
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000015")]
		public int[] EdgeIndex
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x17000016")]
		public override TriangulationMode TriangulationMode
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "11")]
			get
			{
				return TriangulationMode.Unconstrained;
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x28ADE30", Offset = "0x28AC430", VA = "0x1828ADE30", Slot = "12")]
		public override void Prepare(TriangulationContext tcx)
		{
		}
	}
}
