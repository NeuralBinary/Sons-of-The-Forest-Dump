using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200023E RID: 574
	[Token(Token = "0x200023E")]
	public class EdgeLoopRemesher : Remesher
	{
		// Token: 0x0600148E RID: 5262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600148E")]
		[Address(RVA = "0x1E852A0", Offset = "0x1E838A0", VA = "0x181E852A0")]
		public EdgeLoopRemesher(DMesh3 m, EdgeLoop loop)
		{
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600148F")]
		[Address(RVA = "0x1E85430", Offset = "0x1E83A30", VA = "0x181E85430")]
		public void UpdateLoop(EdgeLoop loop)
		{
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001490")]
		[Address(RVA = "0x1E85640", Offset = "0x1E83C40", VA = "0x181E85640", Slot = "5")]
		public override void Precompute()
		{
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x000100DC File Offset: 0x0000E2DC
		[Token(Token = "0x6001491")]
		[Address(RVA = "0x1E85650", Offset = "0x1E83C50", VA = "0x181E85650", Slot = "9")]
		protected override int start_edges()
		{
			return 0;
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x000100F4 File Offset: 0x0000E2F4
		[Token(Token = "0x6001492")]
		[Address(RVA = "0x1E858A0", Offset = "0x1E83EA0", VA = "0x181E858A0", Slot = "10")]
		protected override int next_edge(int cur_eid, out bool bDone)
		{
			return 0;
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001493")]
		[Address(RVA = "0x1E85990", Offset = "0x1E83F90", VA = "0x181E85990", Slot = "25")]
		protected override void end_pass()
		{
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001494")]
		[Address(RVA = "0x1E85AB0", Offset = "0x1E840B0", VA = "0x181E85AB0", Slot = "28")]
		protected override void begin_smooth()
		{
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001495")]
		[Address(RVA = "0x1E85FC0", Offset = "0x1E845C0", VA = "0x181E85FC0", Slot = "11")]
		protected override IEnumerable<int> smooth_vertices()
		{
			return null;
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x0001010C File Offset: 0x0000E30C
		[Token(Token = "0x6001496")]
		[Address(RVA = "0x1E85FE0", Offset = "0x1E845E0", VA = "0x181E85FE0")]
		private Vector3d loop_smooth_vertex(DMesh3 mesh, int vid, double alpha)
		{
			return default(Vector3d);
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001497")]
		[Address(RVA = "0x1E85FC0", Offset = "0x1E845C0", VA = "0x181E85FC0", Slot = "12")]
		protected override IEnumerable<int> project_vertices()
		{
			return null;
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001498")]
		[Address(RVA = "0x1E863B0", Offset = "0x1E849B0", VA = "0x181E863B0", Slot = "7")]
		protected override void OnEdgeSplit(int edgeID, int va, int vb, DMesh3.EdgeSplitInfo splitInfo)
		{
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001499")]
		[Address(RVA = "0x1E86740", Offset = "0x1E84D40", VA = "0x181E86740", Slot = "8")]
		protected override void OnEdgeCollapse(int edgeID, int va, int vb, DMesh3.EdgeCollapseInfo collapseInfo)
		{
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x00010124 File Offset: 0x0000E324
		[Token(Token = "0x600149A")]
		[Address(RVA = "0x1E86A00", Offset = "0x1E85000", VA = "0x181E86A00")]
		private bool check_loop()
		{
			return default(bool);
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600149B")]
		[Address(RVA = "0x1E86AE0", Offset = "0x1E850E0", VA = "0x181E86AE0")]
		private void rebuild_edge_list()
		{
		}

		// Token: 0x04000999 RID: 2457
		[Token(Token = "0x4000999")]
		[FieldOffset(Offset = "0xE8")]
		public EdgeLoop InputLoop;

		// Token: 0x0400099A RID: 2458
		[Token(Token = "0x400099A")]
		[FieldOffset(Offset = "0xF0")]
		public EdgeLoop OutputLoop;

		// Token: 0x0400099B RID: 2459
		[Token(Token = "0x400099B")]
		[FieldOffset(Offset = "0xF8")]
		public int LocalSmoothingRings;

		// Token: 0x0400099C RID: 2460
		[Token(Token = "0x400099C")]
		[FieldOffset(Offset = "0x100")]
		private List<int> CurrentLoopE;

		// Token: 0x0400099D RID: 2461
		[Token(Token = "0x400099D")]
		[FieldOffset(Offset = "0x108")]
		private List<int> CurrentLoopV;

		// Token: 0x0400099E RID: 2462
		[Token(Token = "0x400099E")]
		[FieldOffset(Offset = "0x110")]
		private List<int> RemainingE;

		// Token: 0x0400099F RID: 2463
		[Token(Token = "0x400099F")]
		private const int nPrime = 31337;

		// Token: 0x040009A0 RID: 2464
		[Token(Token = "0x40009A0")]
		[FieldOffset(Offset = "0x118")]
		private HashSet<int> smoothV;
	}
}
