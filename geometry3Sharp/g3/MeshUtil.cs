using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000274 RID: 628
	[Token(Token = "0x2000274")]
	public static class MeshUtil
	{
		// Token: 0x0600163E RID: 5694 RVA: 0x00010ED4 File Offset: 0x0000F0D4
		[Token(Token = "0x600163E")]
		[Address(RVA = "0x1EA8A80", Offset = "0x1EA7080", VA = "0x181EA8A80")]
		public static Vector3d UniformSmooth(DMesh3 mesh, int vID, double t)
		{
			return default(Vector3d);
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00010EEC File Offset: 0x0000F0EC
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x1EA8BD0", Offset = "0x1EA71D0", VA = "0x181EA8BD0")]
		public static Vector3d MeanValueSmooth(DMesh3 mesh, int vID, double t)
		{
			return default(Vector3d);
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00010F04 File Offset: 0x0000F104
		[Token(Token = "0x6001640")]
		[Address(RVA = "0x1EA8D00", Offset = "0x1EA7300", VA = "0x181EA8D00")]
		public static Vector3d CotanSmooth(DMesh3 mesh, int vID, double t)
		{
			return default(Vector3d);
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001641")]
		[Address(RVA = "0x1EA8E30", Offset = "0x1EA7430", VA = "0x181EA8E30")]
		public static void ScaleMesh(DMesh3 mesh, Frame3f f, Vector3f vScale)
		{
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00010F1C File Offset: 0x0000F11C
		[Token(Token = "0x6001642")]
		[Address(RVA = "0x1EA91C0", Offset = "0x1EA77C0", VA = "0x181EA91C0")]
		public static double OpeningAngleD(DMesh3 mesh, int eid)
		{
			return 0.0;
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00010F34 File Offset: 0x0000F134
		[Token(Token = "0x6001643")]
		[Address(RVA = "0x1EA9380", Offset = "0x1EA7980", VA = "0x181EA9380")]
		public static double DiscreteGaussCurvature(DMesh3 mesh, int vid)
		{
			return 0.0;
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00010F4C File Offset: 0x0000F14C
		[Token(Token = "0x6001644")]
		[Address(RVA = "0x1EA95E0", Offset = "0x1EA7BE0", VA = "0x181EA95E0")]
		public static bool CheckIfCollapseCreatesFlip(DMesh3 mesh, int edgeID, Vector3d newv)
		{
			return default(bool);
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00010F64 File Offset: 0x0000F164
		[Token(Token = "0x6001645")]
		[Address(RVA = "0x1EA9D60", Offset = "0x1EA8360", VA = "0x181EA9D60")]
		public static bool CheckIfEdgeFlipCreatesFlip(DMesh3 mesh, int eID, double flip_dot_tol = 0.0)
		{
			return default(bool);
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00010F7C File Offset: 0x0000F17C
		[Token(Token = "0x6001646")]
		[Address(RVA = "0x1EAA540", Offset = "0x1EA8B40", VA = "0x181EAA540")]
		private static double edge_flip_metric(ref Vector3d n0, ref Vector3d n1, double flip_dot_tol)
		{
			return 0.0;
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001647")]
		[Address(RVA = "0x1EAA5F0", Offset = "0x1EA8BF0", VA = "0x181EAA5F0")]
		public static void GetEdgeFlipTris(DMesh3 mesh, int eID, out Index3i orig_t0, out Index3i orig_t1, out Index3i flip_t0, out Index3i flip_t1)
		{
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001648")]
		[Address(RVA = "0x1EAA750", Offset = "0x1EA8D50", VA = "0x181EAA750")]
		public static void GetEdgeFlipNormals(DMesh3 mesh, int eID, out Vector3d n1, out Vector3d n2, out Vector3d on1, out Vector3d on2)
		{
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001649")]
		[Address(RVA = "0x1EAA9A0", Offset = "0x1EA8FA0", VA = "0x181EAA9A0")]
		public static DCurve3 ExtractLoopV(IMesh mesh, IEnumerable<int> vertices)
		{
			return null;
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600164A")]
		[Address(RVA = "0x1EAAC70", Offset = "0x1EA9270", VA = "0x181EAAC70")]
		public static DCurve3 ExtractLoopV(IMesh mesh, int[] vertices)
		{
			return null;
		}
	}
}
