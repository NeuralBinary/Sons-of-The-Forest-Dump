using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000242 RID: 578
	[Token(Token = "0x2000242")]
	public class EdgeSpan
	{
		// Token: 0x060014A5 RID: 5285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014A5")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public EdgeSpan(DMesh3 mesh)
		{
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014A6")]
		[Address(RVA = "0x1E86CA0", Offset = "0x1E852A0", VA = "0x181E86CA0")]
		public EdgeSpan(DMesh3 mesh, int[] vertices, int[] edges, bool bCopyArrays)
		{
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60014A7")]
		[Address(RVA = "0x1E87000", Offset = "0x1E85600", VA = "0x181E87000")]
		public static EdgeSpan FromEdges(DMesh3 mesh, IList<int> edges)
		{
			return null;
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60014A8")]
		[Address(RVA = "0x1E87300", Offset = "0x1E85900", VA = "0x181E87300")]
		public static EdgeSpan FromVertices(DMesh3 mesh, IList<int> vertices)
		{
			return null;
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x000101CC File Offset: 0x0000E3CC
		[Token(Token = "0x17000344")]
		public int VertexCount
		{
			[Token(Token = "0x60014A9")]
			[Address(RVA = "0x13161C0", Offset = "0x13147C0", VA = "0x1813161C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x000101E4 File Offset: 0x0000E3E4
		[Token(Token = "0x17000345")]
		public int EdgeCount
		{
			[Token(Token = "0x60014AA")]
			[Address(RVA = "0x12C8150", Offset = "0x12C6750", VA = "0x1812C8150")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x000101FC File Offset: 0x0000E3FC
		[Token(Token = "0x60014AB")]
		[Address(RVA = "0x1E839C0", Offset = "0x1E81FC0", VA = "0x181E839C0")]
		public Vector3d GetVertex(int i)
		{
			return default(Vector3d);
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00010214 File Offset: 0x0000E414
		[Token(Token = "0x60014AC")]
		[Address(RVA = "0x1E87580", Offset = "0x1E85B80", VA = "0x181E87580")]
		public AxisAlignedBox3d GetBounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60014AD")]
		[Address(RVA = "0x1E876A0", Offset = "0x1E85CA0", VA = "0x181E876A0")]
		public DCurve3 ToCurve([Optional] DMesh3 sourceMesh)
		{
			return null;
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0001022C File Offset: 0x0000E42C
		[Token(Token = "0x60014AE")]
		[Address(RVA = "0x1E876E0", Offset = "0x1E85CE0", VA = "0x181E876E0")]
		public bool IsInternalSpan()
		{
			return default(bool);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00010244 File Offset: 0x0000E444
		[Token(Token = "0x60014AF")]
		[Address(RVA = "0x1E87790", Offset = "0x1E85D90", VA = "0x181E87790")]
		public bool IsBoundarySpan([Optional] DMesh3 testMesh)
		{
			return default(bool);
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x0001025C File Offset: 0x0000E45C
		[Token(Token = "0x60014B0")]
		[Address(RVA = "0x1E84050", Offset = "0x1E82650", VA = "0x181E84050")]
		public int FindNearestVertex(Vector3d v)
		{
			return 0;
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x00010274 File Offset: 0x0000E474
		[Token(Token = "0x60014B1")]
		[Address(RVA = "0x1E84180", Offset = "0x1E82780", VA = "0x181E84180")]
		public int CountWithinTolerance(Vector3d v, double tol, out int last_in_tol)
		{
			return 0;
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x0001028C File Offset: 0x0000E48C
		[Token(Token = "0x60014B2")]
		[Address(RVA = "0x1E87840", Offset = "0x1E85E40", VA = "0x181E87840")]
		public bool IsSameSpan(EdgeSpan Spanw, bool bReverse2 = false, double tolerance = 1E-08)
		{
			return default(bool);
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x000102A4 File Offset: 0x0000E4A4
		[Token(Token = "0x60014B3")]
		[Address(RVA = "0x1E87890", Offset = "0x1E85E90", VA = "0x181E87890")]
		public bool CheckValidity(FailMode eFailMode = FailMode.Throw)
		{
			return default(bool);
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60014B4")]
		[Address(RVA = "0x1E88000", Offset = "0x1E86600", VA = "0x181E88000")]
		public static int[] VerticesToEdges(DMesh3 mesh, int[] vertex_span)
		{
			return null;
		}

		// Token: 0x040009A7 RID: 2471
		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x040009A8 RID: 2472
		[Token(Token = "0x40009A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] Vertices;

		// Token: 0x040009A9 RID: 2473
		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] Edges;

		// Token: 0x040009AA RID: 2474
		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int[] BowtieVertices;
	}
}
