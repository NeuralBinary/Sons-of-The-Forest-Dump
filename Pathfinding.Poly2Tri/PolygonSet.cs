using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Poly2Tri
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class PolygonSet
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x28A5280", Offset = "0x28A3880", VA = "0x1828A5280")]
		public PolygonSet()
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x28A5330", Offset = "0x28A3930", VA = "0x1828A5330")]
		public PolygonSet(Polygon poly)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x28A5460", Offset = "0x28A3A60", VA = "0x1828A5460")]
		public void Add(Polygon p)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000007")]
		public IEnumerable<Polygon> Polygons
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x10")]
		protected List<Polygon> _polygons;
	}
}
