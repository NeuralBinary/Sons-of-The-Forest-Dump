using System;
using System.Collections.Generic;
using System.Threading;
using g3;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public class RemesherPro : Remesher
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1DF2DD0", Offset = "0x1DF13D0", VA = "0x181DF2DD0")]
		public RemesherPro(DMesh3 m)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1DF2FE0", Offset = "0x1DF15E0", VA = "0x181DF2FE0")]
		protected IEnumerable<int> EdgesIterator()
		{
			return null;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1DF3080", Offset = "0x1DF1680", VA = "0x181DF3080")]
		private void queue_one_ring_safe(int vid)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1DF3350", Offset = "0x1DF1950", VA = "0x181DF3350")]
		private void queue_one_ring(int vid)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1DF3590", Offset = "0x1DF1B90", VA = "0x181DF3590")]
		private void queue_edge_safe(int eid)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1DF3680", Offset = "0x1DF1C80", VA = "0x181DF3680")]
		private void queue_edge(int eid)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1DF36F0", Offset = "0x1DF1CF0", VA = "0x181DF36F0", Slot = "7")]
		protected override void OnEdgeSplit(int edgeID, int va, int vb, DMesh3.EdgeSplitInfo splitInfo)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1DF3740", Offset = "0x1DF1D40", VA = "0x181DF3740")]
		public void FastestRemesh(int nMaxIterations = 25, bool bDoFastSplits = true)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1DF38D0", Offset = "0x1DF1ED0", VA = "0x181DF38D0")]
		public void SharpEdgeReprojectionRemesh(int nRemeshIterations, int nTuneIterations, bool bDoFastSplits = true)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1DF3B40", Offset = "0x1DF2140", VA = "0x181DF3B40")]
		public void ResetQueue()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1DF3C20", Offset = "0x1DF2220", VA = "0x181DF3C20")]
		public int FastSplitIteration()
		{
			return 0;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1DF4400", Offset = "0x1DF2A00", VA = "0x181DF4400", Slot = "38")]
		public virtual void RemeshIteration()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1DF4980", Offset = "0x1DF2F80", VA = "0x181DF4980", Slot = "39")]
		protected virtual void TrackedSmoothPass(bool bParallel)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1DF4E40", Offset = "0x1DF3440", VA = "0x181DF4E40", Slot = "40")]
		protected virtual void TrackedProjectionPass(bool bParallel)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1DF50E0", Offset = "0x1DF36E0", VA = "0x181DF50E0", Slot = "41")]
		protected virtual Vector3d ComputeProjectedVertexPos(int vID, out bool bModified)
		{
			return default(Vector3d);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1DF52C0", Offset = "0x1DF38C0", VA = "0x181DF52C0", Slot = "42")]
		protected virtual void InitializeBuffersForFacePass()
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1DF5520", Offset = "0x1DF3B20", VA = "0x181DF5520", Slot = "43")]
		protected virtual void TrackedFaceProjectionPass()
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1DF57A0", Offset = "0x1DF3DA0", VA = "0x181DF57A0")]
		public void PushState()
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1DF58D0", Offset = "0x1DF3ED0", VA = "0x181DF58D0")]
		public void PopState()
		{
		}

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0xE8")]
		public bool UseFaceAlignedProjection;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0xEC")]
		public int FaceProjectionPassesPerIteration;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0xF0")]
		private HashSet<int> modified_edges;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0xF8")]
		private SpinLock modified_edges_lock;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x100")]
		private Action<int, int, int, int> SplitF;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x108")]
		private List<int> edges_buffer;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x110")]
		protected DVector<double> vBufferVWeights;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x118")]
		private List<RemesherPro.SettingState> stateStack;

		// Token: 0x02000008 RID: 8
		[Token(Token = "0x2000008")]
		private struct SettingState
		{
			// Token: 0x04000010 RID: 16
			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x0")]
			public bool EnableFlips;

			// Token: 0x04000011 RID: 17
			[Token(Token = "0x4000011")]
			[FieldOffset(Offset = "0x1")]
			public bool EnableCollapses;

			// Token: 0x04000012 RID: 18
			[Token(Token = "0x4000012")]
			[FieldOffset(Offset = "0x2")]
			public bool EnableSplits;

			// Token: 0x04000013 RID: 19
			[Token(Token = "0x4000013")]
			[FieldOffset(Offset = "0x3")]
			public bool EnableSmoothing;

			// Token: 0x04000014 RID: 20
			[Token(Token = "0x4000014")]
			[FieldOffset(Offset = "0x8")]
			public double MinEdgeLength;

			// Token: 0x04000015 RID: 21
			[Token(Token = "0x4000015")]
			[FieldOffset(Offset = "0x10")]
			public double MaxEdgeLength;

			// Token: 0x04000016 RID: 22
			[Token(Token = "0x4000016")]
			[FieldOffset(Offset = "0x18")]
			public double SmoothSpeedT;

			// Token: 0x04000017 RID: 23
			[Token(Token = "0x4000017")]
			[FieldOffset(Offset = "0x20")]
			public Remesher.SmoothTypes SmoothType;

			// Token: 0x04000018 RID: 24
			[Token(Token = "0x4000018")]
			[FieldOffset(Offset = "0x24")]
			public Remesher.TargetProjectionMode ProjectionMode;
		}
	}
}
