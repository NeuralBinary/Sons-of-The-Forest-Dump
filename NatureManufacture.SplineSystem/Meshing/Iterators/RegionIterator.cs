using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Topology;

namespace TriangleNet.Meshing.Iterators
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	public class RegionIterator
	{
		// Token: 0x06000298 RID: 664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x24D0C90", Offset = "0x24CF290", VA = "0x1824D0C90")]
		public RegionIterator(Mesh mesh)
		{
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x24D0D40", Offset = "0x24CF340", VA = "0x1824D0D40")]
		public void Process(Triangle triangle, int boundary = 0)
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x24D0E70", Offset = "0x24CF470", VA = "0x1824D0E70")]
		public void Process(Triangle triangle, Action<Triangle> action, int boundary = 0)
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x24D10B0", Offset = "0x24CF6B0", VA = "0x1824D10B0")]
		private void ProcessRegion(Action<Triangle> action, Func<SubSegment, bool> protector)
		{
		}

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x10")]
		private List<Triangle> region;
	}
}
