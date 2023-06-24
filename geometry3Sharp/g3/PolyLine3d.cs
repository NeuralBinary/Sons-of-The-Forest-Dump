using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000136 RID: 310
	[Token(Token = "0x2000136")]
	public class PolyLine3d : IEnumerable<Vector3d>, IEnumerable
	{
		// Token: 0x0600089D RID: 2205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089D")]
		[Address(RVA = "0x1FDDDD0", Offset = "0x1FDC3D0", VA = "0x181FDDDD0")]
		public PolyLine3d()
		{
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089E")]
		[Address(RVA = "0x1FDDE90", Offset = "0x1FDC490", VA = "0x181FDDE90")]
		public PolyLine3d(PolyLine3d copy)
		{
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089F")]
		[Address(RVA = "0x1FDDF70", Offset = "0x1FDC570", VA = "0x181FDDF70")]
		public PolyLine3d(Vector3d[] v)
		{
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x1FDE040", Offset = "0x1FDC640", VA = "0x181FDE040")]
		public PolyLine3d(VectorArray3d v)
		{
		}

		// Token: 0x1700017B RID: 379
		[Token(Token = "0x1700017B")]
		public Vector3d this[int key]
		{
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x1FDE1D0", Offset = "0x1FDC7D0", VA = "0x181FDE1D0")]
			get
			{
				return default(Vector3d);
			}
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x1FDE260", Offset = "0x1FDC860", VA = "0x181FDE260")]
			set
			{
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x0000689C File Offset: 0x00004A9C
		[Token(Token = "0x1700017C")]
		public Vector3d Start
		{
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x1FDE300", Offset = "0x1FDC900", VA = "0x181FDE300")]
			get
			{
				return default(Vector3d);
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x000068B4 File Offset: 0x00004AB4
		[Token(Token = "0x1700017D")]
		public Vector3d End
		{
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x1FDE380", Offset = "0x1FDC980", VA = "0x181FDE380")]
			get
			{
				return default(Vector3d);
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700017E")]
		public ReadOnlyCollection<Vector3d> Vertices
		{
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x1FDE420", Offset = "0x1FDCA20", VA = "0x181FDE420")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x000068CC File Offset: 0x00004ACC
		[Token(Token = "0x1700017F")]
		public int VertexCount
		{
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x1FDE4E0", Offset = "0x1FDCAE0", VA = "0x181FDE4E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x1FDE520", Offset = "0x1FDCB20", VA = "0x181FDE520")]
		public void AppendVertex(Vector3d v)
		{
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x000068E4 File Offset: 0x00004AE4
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x1FDE5F0", Offset = "0x1FDCBF0", VA = "0x181FDE5F0")]
		public Vector3d GetTangent(int i)
		{
			return default(Vector3d);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x000068FC File Offset: 0x00004AFC
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x1FDE990", Offset = "0x1FDCF90", VA = "0x181FDE990")]
		public AxisAlignedBox3d GetBounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x1FDEB30", Offset = "0x1FDD130", VA = "0x181FDEB30")]
		public IEnumerable<Segment3d> SegmentItr()
		{
			return null;
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x1FDEBD0", Offset = "0x1FDD1D0", VA = "0x181FDEBD0", Slot = "4")]
		public IEnumerator<Vector3d> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x1FDECD0", Offset = "0x1FDD2D0", VA = "0x181FDECD0", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x10")]
		protected List<Vector3d> vertices;

		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x18")]
		public int Timestamp;
	}
}
