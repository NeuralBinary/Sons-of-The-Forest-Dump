using System;
using g3;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public class MergeCoincidentEdges
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1DFF1C0", Offset = "0x1DFD7C0", VA = "0x181DFF1C0")]
		public MergeCoincidentEdges(DMesh3 mesh)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1DFF220", Offset = "0x1DFD820", VA = "0x181DFF220", Slot = "4")]
		public virtual bool Apply()
		{
			return default(bool);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1E00500", Offset = "0x1DFEB00", VA = "0x181E00500")]
		private bool is_same_edge(ref Vector3d a, ref Vector3d b, ref Vector3d c, ref Vector3d d)
		{
			return default(bool);
		}

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x18")]
		public double MergeDistance;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x20")]
		public bool OnlyUniquePairs;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x28")]
		private double merge_r2;

		// Token: 0x02000014 RID: 20
		[Token(Token = "0x2000014")]
		private class DuplicateEdge : DynamicPriorityQueueNode
		{
			// Token: 0x0600005F RID: 95 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public DuplicateEdge()
			{
			}

			// Token: 0x04000055 RID: 85
			[Token(Token = "0x4000055")]
			[FieldOffset(Offset = "0x18")]
			public int eid;
		}
	}
}
