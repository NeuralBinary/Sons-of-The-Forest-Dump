using System;
using g3;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public class MeshAutoRepair
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1E00F80", Offset = "0x1DFF580", VA = "0x181E00F80", Slot = "4")]
		protected virtual bool Cancelled()
		{
			return default(bool);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1E00FF0", Offset = "0x1DFF5F0", VA = "0x181E00FF0")]
		public MeshAutoRepair(DMesh3 mesh3)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1E01060", Offset = "0x1DFF660", VA = "0x181E01060")]
		public bool Apply()
		{
			return default(bool);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1E019A0", Offset = "0x1DFFFA0", VA = "0x181E019A0")]
		private void fill_trivial_holes(out int nRemaining, out bool saw_spans)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1E01CC0", Offset = "0x1E002C0", VA = "0x181E01CC0")]
		private void fill_any_holes(out int nRemaining, out bool saw_spans)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1E01F80", Offset = "0x1E00580", VA = "0x181E01F80")]
		private bool repair_cracks(bool bUniqueOnly, double mergeDist)
		{
			return default(bool);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1E02060", Offset = "0x1E00660", VA = "0x181E02060")]
		private bool remove_duplicate_faces(double vtxTolerance, out int nRemoved)
		{
			return default(bool);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1E02160", Offset = "0x1E00760", VA = "0x181E02160")]
		private bool collapse_degenerate_edges(double minLength, bool bBoundaryOnly, out int collapseCount)
		{
			return default(bool);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1E02670", Offset = "0x1E00C70", VA = "0x181E02670")]
		private bool collapse_all_degenerate_edges(double minLength, bool bBoundaryOnly)
		{
			return default(bool);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1E026F0", Offset = "0x1E00CF0", VA = "0x181E026F0")]
		private bool disconnect_bowties(out int nRemaining)
		{
			return default(bool);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1E027A0", Offset = "0x1E00DA0", VA = "0x181E027A0")]
		private void repair_orientation(bool bGlobal)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1E02980", Offset = "0x1E00F80", VA = "0x181E02980")]
		private bool remove_interior(out int nRemoved)
		{
			return default(bool);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1E02A80", Offset = "0x1E01080", VA = "0x181E02A80")]
		private bool remove_occluded(out int nRemoved)
		{
			return default(bool);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1E02B80", Offset = "0x1E01180", VA = "0x181E02B80")]
		private bool do_remove_inside()
		{
			return default(bool);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1E02D50", Offset = "0x1E01350", VA = "0x181E02D50")]
		private bool remove_loners()
		{
			return default(bool);
		}

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x10")]
		public double RepairTolerance;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x18")]
		public double MinEdgeLengthTol;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x20")]
		public int ErosionIterations;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x24")]
		public MeshAutoRepair.RemoveModes RemoveMode;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x28")]
		public ProgressCancel Progress;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x30")]
		public DMesh3 Mesh;

		// Token: 0x02000017 RID: 23
		[Token(Token = "0x2000017")]
		public enum RemoveModes
		{
			// Token: 0x04000061 RID: 97
			[Token(Token = "0x4000061")]
			None,
			// Token: 0x04000062 RID: 98
			[Token(Token = "0x4000062")]
			Interior,
			// Token: 0x04000063 RID: 99
			[Token(Token = "0x4000063")]
			Occluded
		}
	}
}
