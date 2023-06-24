using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Meshing.Iterators
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public class EdgeIterator : IEnumerator<Edge>, IEnumerator, IDisposable
	{
		// Token: 0x06000292 RID: 658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x24D0870", Offset = "0x24CEE70", VA = "0x1824D0870")]
		public EdgeIterator(Mesh mesh)
		{
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000293 RID: 659 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000079")]
		public Edge Current
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x24D09D0", Offset = "0x24CEFD0", VA = "0x1824D09D0", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700007A")]
		private object Current
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x24D0A20", Offset = "0x24CF020", VA = "0x1824D0A20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x24D0C40", Offset = "0x24CF240", VA = "0x1824D0C40", Slot = "8")]
		public void Reset()
		{
		}

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x10")]
		private IEnumerator<Triangle> triangles;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x18")]
		private Otri tri;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x28")]
		private Otri neighbor;

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x38")]
		private Osub sub;

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x48")]
		private Edge current;

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x50")]
		private Vertex p1;

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x58")]
		private Vertex p2;
	}
}
