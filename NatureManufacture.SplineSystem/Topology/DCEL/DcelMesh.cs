using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.Topology.DCEL
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	public class DcelMesh
	{
		// Token: 0x06000191 RID: 401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x24B6870", Offset = "0x24B4E70", VA = "0x1824B6870")]
		public DcelMesh()
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x24B6880", Offset = "0x24B4E80", VA = "0x1824B6880")]
		protected DcelMesh(bool initialize)
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700003D")]
		public List<Vertex> Vertices
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700003E")]
		public List<HalfEdge> HalfEdges
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700003F")]
		public List<Face> Faces
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000040")]
		public IEnumerable<IEdge> Edges
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x24B6A60", Offset = "0x24B5060", VA = "0x1824B6A60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x24B6A80", Offset = "0x24B5080", VA = "0x1824B6A80", Slot = "4")]
		public virtual bool IsConsistent(bool closed = true, int depth = 0)
		{
			return default(bool);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x24B72E0", Offset = "0x24B58E0", VA = "0x1824B72E0")]
		public void ResolveBoundaryEdges()
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x24B7900", Offset = "0x24B5F00", VA = "0x1824B7900", Slot = "5")]
		protected virtual IEnumerable<IEdge> EnumerateEdges()
		{
			return null;
		}

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x10")]
		protected List<Vertex> vertices;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x18")]
		protected List<HalfEdge> edges;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x20")]
		protected List<Face> faces;
	}
}
