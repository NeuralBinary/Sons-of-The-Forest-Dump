using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Logging;
using TriangleNet.Meshing;
using TriangleNet.Topology;

namespace TriangleNet
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	public class Mesh : IMesh
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000015")]
		public Rectangle Bounds
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000016")]
		public ICollection<Vertex> Vertices
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x2486BC0", Offset = "0x24851C0", VA = "0x182486BC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000017")]
		public IList<Point> Holes
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000018")]
		public ICollection<Triangle> Triangles
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000019")]
		public ICollection<SubSegment> Segments
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x2486C10", Offset = "0x2485210", VA = "0x182486C10", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700001A")]
		public IEnumerable<Edge> Edges
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x2486C60", Offset = "0x2485260", VA = "0x182486C60", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x1700001B")]
		public int NumberOfInputPoints
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x8DCFC0", Offset = "0x8DB5C0", VA = "0x1808DCFC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x1700001C")]
		public int NumberOfEdges
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x2486D00", Offset = "0x2485300", VA = "0x182486D00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x1700001D")]
		public bool IsPolygon
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x2486D60", Offset = "0x2485360", VA = "0x182486D60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x1700001E")]
		public NodeNumbering CurrentNumbering
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0xAFF3A0", Offset = "0xAFD9A0", VA = "0x180AFF3A0")]
			get
			{
				return NodeNumbering.None;
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2486D70", Offset = "0x2485370", VA = "0x182486D70")]
		private void Initialize()
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x24872F0", Offset = "0x24858F0", VA = "0x1824872F0")]
		public Mesh(Configuration config)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x24878E0", Offset = "0x2485EE0", VA = "0x1824878E0", Slot = "11")]
		public void Refine(QualityOptions quality, bool delaunay = false)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2487A60", Offset = "0x2486060", VA = "0x182487A60", Slot = "10")]
		public void Renumber()
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2487A70", Offset = "0x2486070", VA = "0x182487A70")]
		public void Renumber(NodeNumbering num)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		internal void SetQualityMesher(QualityMesher qmesher)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2488110", Offset = "0x2486710", VA = "0x182488110")]
		internal void CopyTo(Mesh target)
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2488320", Offset = "0x2486920", VA = "0x182488320")]
		private void ResetData()
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x24884E0", Offset = "0x2486AE0", VA = "0x1824884E0")]
		private void Reset()
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x24885D0", Offset = "0x2486BD0", VA = "0x1824885D0")]
		internal void TransferNodes(IList<Vertex> points)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2488A10", Offset = "0x2487010", VA = "0x182488A10")]
		internal void MakeVertexMap()
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2488BB0", Offset = "0x24871B0", VA = "0x182488BB0")]
		internal void MakeTriangle(ref Otri newotri)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2488F50", Offset = "0x2487550", VA = "0x182488F50")]
		internal void MakeSegment(ref Osub newsubseg)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2489270", Offset = "0x2487870", VA = "0x182489270")]
		internal InsertVertexResult InsertVertex(Vertex newvertex, ref Otri searchtri, ref Osub splitseg, bool segmentflaws, bool triflaws)
		{
			return InsertVertexResult.Successful;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x248B870", Offset = "0x2489E70", VA = "0x18248B870")]
		internal void InsertSubseg(ref Otri tri, int subsegmark)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x248BB70", Offset = "0x248A170", VA = "0x18248BB70")]
		internal void Flip(ref Otri flipedge)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x248C920", Offset = "0x248AF20", VA = "0x18248C920")]
		internal void Unflip(ref Otri flipedge)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x248D6C0", Offset = "0x248BCC0", VA = "0x18248D6C0")]
		private void TriangulatePolygon(Otri firstedge, Otri lastedge, int edgecount, bool doflip, bool triflaws)
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x248DE30", Offset = "0x248C430", VA = "0x18248DE30")]
		internal void DeleteVertex(ref Otri deltri)
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x248E380", Offset = "0x248C980", VA = "0x18248E380")]
		internal void UndoVertex()
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x248EC70", Offset = "0x248D270", VA = "0x18248EC70")]
		internal void TriangleDealloc(Triangle dyingtriangle)
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x248EE00", Offset = "0x248D400", VA = "0x18248EE00")]
		internal void VertexDealloc(Vertex dyingvertex)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x248EE60", Offset = "0x248D460", VA = "0x18248EE60")]
		internal void SubsegDealloc(SubSegment dyingsubseg)
		{
		}

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x10")]
		private IPredicates predicates;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x18")]
		private ILog<LogItem> logger;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x20")]
		private QualityMesher qualityMesher;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x28")]
		private Stack<Otri> flipstack;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x30")]
		internal TrianglePool triangles;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x38")]
		internal Dictionary<int, SubSegment> subsegs;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x40")]
		internal Dictionary<int, Vertex> vertices;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x48")]
		internal int hash_vtx;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x4C")]
		internal int hash_seg;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x50")]
		internal int hash_tri;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x58")]
		internal List<Point> holes;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x60")]
		internal List<RegionPointer> regions;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x68")]
		internal Rectangle bounds;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x70")]
		internal int invertices;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x74")]
		internal int insegments;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x78")]
		internal int undeads;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x7C")]
		internal int mesh_dim;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x80")]
		internal int nextras;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x84")]
		internal int hullsize;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x88")]
		internal int steinerleft;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x8C")]
		internal bool checksegments;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x8D")]
		internal bool checkquality;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x90")]
		internal Vertex infvertex1;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x98")]
		internal Vertex infvertex2;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0xA0")]
		internal Vertex infvertex3;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0xA8")]
		internal TriangleLocator locator;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0xB0")]
		internal Behavior behavior;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0xB8")]
		internal NodeNumbering numbering;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		internal const int DUMMY = -1;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0xC0")]
		internal Triangle dummytri;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0xC8")]
		internal SubSegment dummysub;
	}
}
