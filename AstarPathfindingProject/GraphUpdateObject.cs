using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	public class GraphUpdateObject
	{
		// Token: 0x17000086 RID: 134
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000086")]
		[Obsolete("Not necessary anymore")]
		public bool requiresFloodFill
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			set
			{
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[Token(Token = "0x17000087")]
		public GraphUpdateStage stage
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x633920", Offset = "0x631F20", VA = "0x180633920")]
			get
			{
				return GraphUpdateStage.Created;
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x633950", Offset = "0x631F50", VA = "0x180633950", Slot = "4")]
		public virtual void WillUpdateNode(GraphNode node)
		{
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x633BC0", Offset = "0x6321C0", VA = "0x180633BC0", Slot = "5")]
		public virtual void RevertFromBackup()
		{
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x6340A0", Offset = "0x6326A0", VA = "0x1806340A0", Slot = "6")]
		public virtual void Apply(GraphNode node)
		{
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x6341A0", Offset = "0x6327A0", VA = "0x1806341A0")]
		public GraphUpdateObject()
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x634260", Offset = "0x632860", VA = "0x180634260")]
		public GraphUpdateObject(Bounds b)
		{
		}

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x10")]
		public Bounds bounds;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x28")]
		public bool updatePhysics;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x29")]
		public bool resetPenaltyOnPhysics;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x2A")]
		public bool updateErosion;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x30")]
		public NNConstraint nnConstraint;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x38")]
		public int addPenalty;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x3C")]
		public bool modifyWalkability;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x3D")]
		public bool setWalkability;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x3E")]
		public bool modifyTag;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x40")]
		public int setTag;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x44")]
		public bool trackChangedNodes;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x48")]
		public List<GraphNode> changedNodes;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x50")]
		private List<uint> backupData;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x58")]
		private List<Int3> backupPositionData;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x60")]
		public GraphUpdateShape shape;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x68")]
		internal int internalStage;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		internal const int STAGE_CREATED = -1;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		internal const int STAGE_PENDING = -2;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		internal const int STAGE_ABORTED = -3;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		internal const int STAGE_APPLIED = 0;
	}
}
