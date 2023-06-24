using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000133 RID: 307
	[Token(Token = "0x2000133")]
	public class DPolyLine2f
	{
		// Token: 0x06000890 RID: 2192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000890")]
		[Address(RVA = "0x1FDD240", Offset = "0x1FDB840", VA = "0x181FDD240")]
		public DPolyLine2f()
		{
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x1FDD390", Offset = "0x1FDB990", VA = "0x181FDD390")]
		public DPolyLine2f(DPolyLine2f copy)
		{
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000177")]
		public List<DPolyLine2f.Edge> Edges
		{
			[Token(Token = "0x6000892")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000178")]
		public List<DPolyLine2f.Vertex> Vertices
		{
			[Token(Token = "0x6000893")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x000067F4 File Offset: 0x000049F4
		[Token(Token = "0x17000179")]
		public int VertexCount
		{
			[Token(Token = "0x6000894")]
			[Address(RVA = "0x1FDD510", Offset = "0x1FDBB10", VA = "0x181FDD510")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x0000680C File Offset: 0x00004A0C
		[Token(Token = "0x1700017A")]
		public int EdgeCount
		{
			[Token(Token = "0x6000895")]
			[Address(RVA = "0x1FDD550", Offset = "0x1FDBB50", VA = "0x181FDD550")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000896")]
		[Address(RVA = "0x1FDD590", Offset = "0x1FDBB90", VA = "0x181FDD590")]
		public void Clear()
		{
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00006824 File Offset: 0x00004A24
		[Token(Token = "0x6000897")]
		[Address(RVA = "0x1FDD5F0", Offset = "0x1FDBBF0", VA = "0x181FDD5F0")]
		public DPolyLine2f.Vertex GetVertex(int i)
		{
			return default(DPolyLine2f.Vertex);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0000683C File Offset: 0x00004A3C
		[Token(Token = "0x6000898")]
		[Address(RVA = "0x1FDD680", Offset = "0x1FDBC80", VA = "0x181FDD680")]
		public int AddVertex(float fX, float fY)
		{
			return 0;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00006854 File Offset: 0x00004A54
		[Token(Token = "0x6000899")]
		[Address(RVA = "0x1FDD790", Offset = "0x1FDBD90", VA = "0x181FDD790")]
		public int AddEdge(int v1, int v2)
		{
			return 0;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0000686C File Offset: 0x00004A6C
		[Token(Token = "0x600089A")]
		[Address(RVA = "0x1FDD860", Offset = "0x1FDBE60", VA = "0x181FDD860")]
		public bool OrderVertices()
		{
			return default(bool);
		}

		// Token: 0x040004A0 RID: 1184
		[Token(Token = "0x40004A0")]
		[FieldOffset(Offset = "0x10")]
		private List<DPolyLine2f.Vertex> m_vertices;

		// Token: 0x040004A1 RID: 1185
		[Token(Token = "0x40004A1")]
		[FieldOffset(Offset = "0x18")]
		private List<DPolyLine2f.Edge> m_edges;

		// Token: 0x02000134 RID: 308
		[Token(Token = "0x2000134")]
		public struct Edge
		{
			// Token: 0x0600089B RID: 2203 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600089B")]
			[Address(RVA = "0x60DE80", Offset = "0x60C480", VA = "0x18060DE80")]
			public Edge(int vertex1, int vertex2)
			{
			}

			// Token: 0x040004A2 RID: 1186
			[Token(Token = "0x40004A2")]
			[FieldOffset(Offset = "0x0")]
			public int v1;

			// Token: 0x040004A3 RID: 1187
			[Token(Token = "0x40004A3")]
			[FieldOffset(Offset = "0x4")]
			public int v2;
		}

		// Token: 0x02000135 RID: 309
		[Token(Token = "0x2000135")]
		public struct Vertex
		{
			// Token: 0x0600089C RID: 2204 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600089C")]
			[Address(RVA = "0x1FDDDC0", Offset = "0x1FDC3C0", VA = "0x181FDDDC0")]
			public Vertex(float fX, float fY, int nIndex)
			{
			}

			// Token: 0x040004A4 RID: 1188
			[Token(Token = "0x40004A4")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x040004A5 RID: 1189
			[Token(Token = "0x40004A5")]
			[FieldOffset(Offset = "0x4")]
			public float x;

			// Token: 0x040004A6 RID: 1190
			[Token(Token = "0x40004A6")]
			[FieldOffset(Offset = "0x8")]
			public float y;
		}
	}
}
