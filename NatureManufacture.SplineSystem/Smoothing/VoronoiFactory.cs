using System;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Topology.DCEL;
using TriangleNet.Voronoi;

namespace TriangleNet.Smoothing
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	internal class VoronoiFactory : IVoronoiFactory
	{
		// Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x24C3E20", Offset = "0x24C2420", VA = "0x1824C3E20")]
		public VoronoiFactory()
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x24C4000", Offset = "0x24C2600", VA = "0x1824C4000", Slot = "4")]
		public void Initialize(int vertexCount, int edgeCount, int faceCount)
		{
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x24C4430", Offset = "0x24C2A30", VA = "0x1824C4430", Slot = "5")]
		public void Reset()
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x24C44A0", Offset = "0x24C2AA0", VA = "0x1824C44A0", Slot = "6")]
		public TriangleNet.Topology.DCEL.Vertex CreateVertex(double x, double y)
		{
			return null;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x24C4680", Offset = "0x24C2C80", VA = "0x1824C4680", Slot = "7")]
		public HalfEdge CreateHalfEdge(TriangleNet.Topology.DCEL.Vertex origin, Face face)
		{
			return null;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x24C4970", Offset = "0x24C2F70", VA = "0x1824C4970", Slot = "8")]
		public Face CreateFace(TriangleNet.Geometry.Vertex vertex)
		{
			return null;
		}

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x10")]
		private VoronoiFactory.ObjectPool<TriangleNet.Topology.DCEL.Vertex> vertices;

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x18")]
		private VoronoiFactory.ObjectPool<HalfEdge> edges;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x20")]
		private VoronoiFactory.ObjectPool<Face> faces;

		// Token: 0x02000045 RID: 69
		[Token(Token = "0x2000045")]
		private class ObjectPool<T> where T : class
		{
			// Token: 0x17000067 RID: 103
			// (get) Token: 0x0600023F RID: 575 RVA: 0x00002CE8 File Offset: 0x00000EE8
			[Token(Token = "0x17000067")]
			public int Count
			{
				[Token(Token = "0x600023F")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000240 RID: 576 RVA: 0x00002D00 File Offset: 0x00000F00
			// (set) Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000068")]
			public int Capacity
			{
				[Token(Token = "0x6000240")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000241")]
				set
				{
				}
			}

			// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000242")]
			public ObjectPool(int capacity = 3)
			{
			}

			// Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000243")]
			public ObjectPool(T[] pool)
			{
			}

			// Token: 0x06000244 RID: 580 RVA: 0x00002D18 File Offset: 0x00000F18
			[Token(Token = "0x6000244")]
			public bool TryGet(out T obj)
			{
				return default(bool);
			}

			// Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000245")]
			public void Put(T obj)
			{
			}

			// Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000246")]
			public void Release()
			{
			}

			// Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000247")]
			private void Resize(int size)
			{
			}

			// Token: 0x04000291 RID: 657
			[Token(Token = "0x4000291")]
			[FieldOffset(Offset = "0x0")]
			private int index;

			// Token: 0x04000292 RID: 658
			[Token(Token = "0x4000292")]
			[FieldOffset(Offset = "0x0")]
			private int count;

			// Token: 0x04000293 RID: 659
			[Token(Token = "0x4000293")]
			[FieldOffset(Offset = "0x0")]
			private T[] pool;
		}
	}
}
