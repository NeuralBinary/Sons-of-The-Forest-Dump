using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.Poly2Tri
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public class PointSet : Triangulatable
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x28AE170", Offset = "0x28AC770", VA = "0x1828AE170")]
		public PointSet(List<TriangulationPoint> points)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		public IList<TriangulationPoint> Points
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000018")]
		public IList<DelaunayTriangle> Triangles
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x17000019")]
		public virtual TriangulationMode TriangulationMode
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "11")]
			get
			{
				return TriangulationMode.Unconstrained;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x28AE240", Offset = "0x28AC840", VA = "0x1828AE240", Slot = "7")]
		public void AddTriangle(DelaunayTriangle t)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x28AE2A0", Offset = "0x28AC8A0", VA = "0x1828AE2A0", Slot = "8")]
		public void AddTriangles(IEnumerable<DelaunayTriangle> list)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x28AE500", Offset = "0x28ACB00", VA = "0x1828AE500", Slot = "9")]
		public void ClearTriangles()
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x28AE550", Offset = "0x28ACB50", VA = "0x1828AE550", Slot = "12")]
		public virtual void Prepare(TriangulationContext tcx)
		{
		}
	}
}
