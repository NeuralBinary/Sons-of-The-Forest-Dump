using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	public class NNConstraint
	{
		// Token: 0x060001CD RID: 461 RVA: 0x00002D2C File Offset: 0x00000F2C
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x6331C0", Offset = "0x6317C0", VA = "0x1806331C0", Slot = "4")]
		public virtual bool SuitableGraph(int graphIndex, NavGraph graph)
		{
			return default(bool);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002D44 File Offset: 0x00000F44
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x6331E0", Offset = "0x6317E0", VA = "0x1806331E0", Slot = "5")]
		public virtual bool Suitable(GraphNode node)
		{
			return default(bool);
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000082")]
		public static NNConstraint Default
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x633270", Offset = "0x631870", VA = "0x180633270")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000083")]
		public static NNConstraint None
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x6332D0", Offset = "0x6318D0", VA = "0x1806332D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x633330", Offset = "0x631930", VA = "0x180633330")]
		public NNConstraint()
		{
		}

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x10")]
		public GraphMask graphMask;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x14")]
		public bool constrainArea;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x18")]
		public int area;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x1C")]
		public bool constrainWalkability;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x1D")]
		public bool walkable;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x1E")]
		public bool distanceXZ;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x1F")]
		public bool constrainTags;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x20")]
		public int tags;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x24")]
		public bool constrainDistance;
	}
}
