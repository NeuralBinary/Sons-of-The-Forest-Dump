using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200023B RID: 571
	[Token(Token = "0x200023B")]
	public class EdgeLoop
	{
		// Token: 0x06001471 RID: 5233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001471")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public EdgeLoop(DMesh3 mesh)
		{
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001472")]
		[Address(RVA = "0x1E828B0", Offset = "0x1E80EB0", VA = "0x181E828B0")]
		public EdgeLoop(DMesh3 mesh, int[] vertices, int[] edges, bool bCopyArrays)
		{
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001473")]
		[Address(RVA = "0x1E82C10", Offset = "0x1E81210", VA = "0x181E82C10")]
		public EdgeLoop(EdgeLoop copy)
		{
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001474")]
		[Address(RVA = "0x1E830A0", Offset = "0x1E816A0", VA = "0x181E830A0")]
		public static EdgeLoop FromEdges(DMesh3 mesh, IList<int> edges)
		{
			return null;
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001475")]
		[Address(RVA = "0x1E83320", Offset = "0x1E81920", VA = "0x181E83320")]
		public static EdgeLoop FromVertices(DMesh3 mesh, IList<int> vertices)
		{
			return null;
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001476")]
		[Address(RVA = "0x1E835D0", Offset = "0x1E81BD0", VA = "0x181E835D0")]
		public static EdgeLoop FromVertices(DMesh3 mesh, IList<int> vertices, bool bAutoOrient = true)
		{
			return null;
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x0000FFBC File Offset: 0x0000E1BC
		[Token(Token = "0x17000342")]
		public int VertexCount
		{
			[Token(Token = "0x6001477")]
			[Address(RVA = "0x13161C0", Offset = "0x13147C0", VA = "0x1813161C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x0000FFD4 File Offset: 0x0000E1D4
		[Token(Token = "0x17000343")]
		public int EdgeCount
		{
			[Token(Token = "0x6001478")]
			[Address(RVA = "0x12C8150", Offset = "0x12C6750", VA = "0x1812C8150")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x0000FFEC File Offset: 0x0000E1EC
		[Token(Token = "0x6001479")]
		[Address(RVA = "0x1E839C0", Offset = "0x1E81FC0", VA = "0x181E839C0")]
		public Vector3d GetVertex(int i)
		{
			return default(Vector3d);
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x00010004 File Offset: 0x0000E204
		[Token(Token = "0x600147A")]
		[Address(RVA = "0x1E83A20", Offset = "0x1E82020", VA = "0x181E83A20")]
		public AxisAlignedBox3d GetBounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600147B")]
		[Address(RVA = "0x1E83B40", Offset = "0x1E82140", VA = "0x181E83B40")]
		public DCurve3 ToCurve([Optional] DMesh3 sourceMesh)
		{
			return null;
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0001001C File Offset: 0x0000E21C
		[Token(Token = "0x600147C")]
		[Address(RVA = "0x1E83B80", Offset = "0x1E82180", VA = "0x181E83B80")]
		public bool CorrectOrientation()
		{
			return default(bool);
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600147D")]
		[Address(RVA = "0x1E83D50", Offset = "0x1E82350", VA = "0x181E83D50")]
		public void Reverse()
		{
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x00010034 File Offset: 0x0000E234
		[Token(Token = "0x600147E")]
		[Address(RVA = "0x1E83E80", Offset = "0x1E82480", VA = "0x181E83E80")]
		public bool IsInternalLoop()
		{
			return default(bool);
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x0001004C File Offset: 0x0000E24C
		[Token(Token = "0x600147F")]
		[Address(RVA = "0x1E83F40", Offset = "0x1E82540", VA = "0x181E83F40")]
		public bool IsBoundaryLoop([Optional] DMesh3 testMesh)
		{
			return default(bool);
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x00010064 File Offset: 0x0000E264
		[Token(Token = "0x6001480")]
		[Address(RVA = "0x1E84000", Offset = "0x1E82600", VA = "0x181E84000")]
		public int FindVertexIndex(int vID)
		{
			return 0;
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x0001007C File Offset: 0x0000E27C
		[Token(Token = "0x6001481")]
		[Address(RVA = "0x1E84050", Offset = "0x1E82650", VA = "0x181E84050")]
		public int FindNearestVertex(Vector3d v)
		{
			return 0;
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x00010094 File Offset: 0x0000E294
		[Token(Token = "0x6001482")]
		[Address(RVA = "0x1E84180", Offset = "0x1E82780", VA = "0x181E84180")]
		public int CountWithinTolerance(Vector3d v, double tol, out int last_in_tol)
		{
			return 0;
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x000100AC File Offset: 0x0000E2AC
		[Token(Token = "0x6001483")]
		[Address(RVA = "0x1E84310", Offset = "0x1E82910", VA = "0x181E84310")]
		public bool IsSameLoop(EdgeLoop Loop2, bool bReverse2 = false, double tolerance = 1E-08)
		{
			return default(bool);
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001484")]
		[Address(RVA = "0x1E84720", Offset = "0x1E82D20", VA = "0x181E84720")]
		public int[] GetVertexSpan(int starti, int count, int[] span, bool reverse = false)
		{
			return null;
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x000100C4 File Offset: 0x0000E2C4
		[Token(Token = "0x6001485")]
		[Address(RVA = "0x1E84840", Offset = "0x1E82E40", VA = "0x181E84840")]
		public bool CheckValidity(FailMode eFailMode = FailMode.Throw)
		{
			return default(bool);
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001486")]
		[Address(RVA = "0x1E850B0", Offset = "0x1E836B0", VA = "0x181E850B0")]
		public static int[] VertexLoopToEdgeLoop(DMesh3 mesh, int[] vertex_loop)
		{
			return null;
		}

		// Token: 0x04000992 RID: 2450
		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000993 RID: 2451
		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] Vertices;

		// Token: 0x04000994 RID: 2452
		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] Edges;

		// Token: 0x04000995 RID: 2453
		[Token(Token = "0x4000995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int[] BowtieVertices;
	}
}
