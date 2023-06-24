using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000EC RID: 236
	[Token(Token = "0x20000EC")]
	public class DCurve3 : ISampledCurve3d
	{
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00004DCC File Offset: 0x00002FCC
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000DB")]
		public bool Closed
		{
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x75A6B0", Offset = "0x758CB0", VA = "0x18075A6B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1FA07A0", Offset = "0x1F9EDA0", VA = "0x181FA07A0")]
		public DCurve3()
		{
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1FA0860", Offset = "0x1F9EE60", VA = "0x181FA0860")]
		public DCurve3(List<Vector3d> verticesIn, bool bClosed, bool bTakeOwnership = false)
		{
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1FA09A0", Offset = "0x1F9EFA0", VA = "0x181FA09A0")]
		public DCurve3(IEnumerable<Vector3d> verticesIn, bool bClosed)
		{
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1FA0A80", Offset = "0x1F9F080", VA = "0x181FA0A80")]
		public DCurve3(DCurve3 copy)
		{
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1FA0B60", Offset = "0x1F9F160", VA = "0x181FA0B60")]
		public DCurve3(ISampledCurve3d icurve)
		{
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1FA0C70", Offset = "0x1F9F270", VA = "0x181FA0C70")]
		public DCurve3(Polygon2d poly, int ix = 0, int iy = 1)
		{
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1FA0FB0", Offset = "0x1F9F5B0", VA = "0x181FA0FB0")]
		public void AppendVertex(Vector3d v)
		{
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00004DE4 File Offset: 0x00002FE4
		[Token(Token = "0x170000DC")]
		public int VertexCount
		{
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x1FA1080", Offset = "0x1F9F680", VA = "0x181FA1080", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x00004DFC File Offset: 0x00002FFC
		[Token(Token = "0x170000DD")]
		public int SegmentCount
		{
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x1FA10C0", Offset = "0x1F9F6C0", VA = "0x181FA10C0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00004E14 File Offset: 0x00003014
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1FA1120", Offset = "0x1F9F720", VA = "0x181FA1120", Slot = "7")]
		public Vector3d GetVertex(int i)
		{
			return default(Vector3d);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1FA11B0", Offset = "0x1F9F7B0", VA = "0x181FA11B0")]
		public void SetVertex(int i, Vector3d v)
		{
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1FA1250", Offset = "0x1F9F850", VA = "0x181FA1250")]
		public void SetVertices(VectorArray3d v)
		{
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1FA1470", Offset = "0x1F9FA70", VA = "0x181FA1470")]
		public void SetVertices(IEnumerable<Vector3d> v)
		{
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1FA1540", Offset = "0x1F9FB40", VA = "0x181FA1540")]
		public void SetVertices(List<Vector3d> vertices, bool bTakeOwnership)
		{
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1FA1680", Offset = "0x1F9FC80", VA = "0x181FA1680")]
		public void ClearVertices()
		{
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1FA1740", Offset = "0x1F9FD40", VA = "0x181FA1740")]
		public void RemoveVertex(int idx)
		{
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x1FA17D0", Offset = "0x1F9FDD0", VA = "0x181FA17D0")]
		public void Reverse()
		{
		}

		// Token: 0x170000DE RID: 222
		[Token(Token = "0x170000DE")]
		public Vector3d this[int key]
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x1FA1940", Offset = "0x1F9FF40", VA = "0x181FA1940")]
			get
			{
				return default(Vector3d);
			}
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x1FA19D0", Offset = "0x1F9FFD0", VA = "0x181FA19D0")]
			set
			{
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00004E44 File Offset: 0x00003044
		[Token(Token = "0x170000DF")]
		public Vector3d Start
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x1FA1A70", Offset = "0x1FA0070", VA = "0x181FA1A70")]
			get
			{
				return default(Vector3d);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00004E5C File Offset: 0x0000305C
		[Token(Token = "0x170000E0")]
		public Vector3d End
		{
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x1FA1AF0", Offset = "0x1FA00F0", VA = "0x181FA1AF0")]
			get
			{
				return default(Vector3d);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000E1")]
		public IEnumerable<Vector3d> Vertices
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00004E74 File Offset: 0x00003074
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x1FA1BB0", Offset = "0x1FA01B0", VA = "0x181FA1BB0", Slot = "8")]
		public Segment3d GetSegment(int iSegment)
		{
			return default(Segment3d);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x1FA1D80", Offset = "0x1FA0380", VA = "0x181FA1D80")]
		public IEnumerable<Segment3d> SegmentItr()
		{
			return null;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00004E8C File Offset: 0x0000308C
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x1FA1E20", Offset = "0x1FA0420", VA = "0x181FA1E20")]
		public Vector3d PointAt(int iSegment, double fSegT)
		{
			return default(Vector3d);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00004EA4 File Offset: 0x000030A4
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x1FA20B0", Offset = "0x1FA06B0", VA = "0x181FA20B0")]
		public AxisAlignedBox3d GetBoundingBox()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x00004EBC File Offset: 0x000030BC
		[Token(Token = "0x170000E2")]
		public double ArcLength
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x1FA2290", Offset = "0x1FA0890", VA = "0x181FA2290")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00004ED4 File Offset: 0x000030D4
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x1FA22A0", Offset = "0x1FA08A0", VA = "0x181FA22A0")]
		public Vector3d Tangent(int i)
		{
			return default(Vector3d);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00004EEC File Offset: 0x000030EC
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x1FA22E0", Offset = "0x1FA08E0", VA = "0x181FA22E0")]
		public Vector3d Centroid(int i)
		{
			return default(Vector3d);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00004F04 File Offset: 0x00003104
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x1FA25E0", Offset = "0x1FA0BE0", VA = "0x181FA25E0")]
		public Index2i Neighbours(int i)
		{
			return default(Index2i);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00004F1C File Offset: 0x0000311C
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x1FA26D0", Offset = "0x1FA0CD0", VA = "0x181FA26D0")]
		public double OpeningAngleDeg(int i)
		{
			return 0.0;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00004F34 File Offset: 0x00003134
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x1FA2B60", Offset = "0x1FA1160", VA = "0x181FA2B60")]
		public int NearestVertex(Vector3d p)
		{
			return 0;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00004F4C File Offset: 0x0000314C
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x1FA2C70", Offset = "0x1FA1270", VA = "0x181FA2C70")]
		public double DistanceSquared(Vector3d p, out int iNearSeg, out double fNearSegT)
		{
			return 0.0;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00004F64 File Offset: 0x00003164
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x1FA3190", Offset = "0x1FA1790", VA = "0x181FA3190")]
		public double DistanceSquared(Vector3d p)
		{
			return 0.0;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x1FA31E0", Offset = "0x1FA17E0", VA = "0x181FA31E0")]
		public DCurve3 ResampleSharpTurns(double sharp_thresh = 90.0, double flat_thresh = 189.0, double corner_t = 0.01)
		{
			return null;
		}

		// Token: 0x0400037B RID: 891
		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x10")]
		protected List<Vector3d> vertices;

		// Token: 0x0400037D RID: 893
		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x1C")]
		public int Timestamp;
	}
}
