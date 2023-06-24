using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	public class PathNode
	{
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00004484 File Offset: 0x00002684
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000E1")]
		public uint cost
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x673F80", Offset = "0x672580", VA = "0x180673F80")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x673F90", Offset = "0x672590", VA = "0x180673F90")]
			set
			{
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0000449C File Offset: 0x0000269C
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000E2")]
		public bool flag1
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x673FA0", Offset = "0x6725A0", VA = "0x180673FA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x673FB0", Offset = "0x6725B0", VA = "0x180673FB0")]
			set
			{
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x000044B4 File Offset: 0x000026B4
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000E3")]
		public bool flag2
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x673FE0", Offset = "0x6725E0", VA = "0x180673FE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x673FF0", Offset = "0x6725F0", VA = "0x180673FF0")]
			set
			{
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x000044CC File Offset: 0x000026CC
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000E4")]
		public uint G
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x670F30", Offset = "0x66F530", VA = "0x180670F30")]
			set
			{
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x000044E4 File Offset: 0x000026E4
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000E5")]
		public uint H
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x674020", Offset = "0x672620", VA = "0x180674020")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x674030", Offset = "0x672630", VA = "0x180674030")]
			set
			{
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x000044FC File Offset: 0x000026FC
		[Token(Token = "0x170000E6")]
		public uint F
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x674040", Offset = "0x672640", VA = "0x180674040")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x674050", Offset = "0x672650", VA = "0x180674050")]
		public void UpdateG(Path path)
		{
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x6740B0", Offset = "0x6726B0", VA = "0x1806740B0")]
		public PathNode()
		{
		}

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x10")]
		public GraphNode node;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x18")]
		public PathNode parent;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x20")]
		public ushort pathID;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x22")]
		public ushort heapIndex;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x24")]
		private uint flags;

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		private const uint CostMask = 268435455U;

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		private const int Flag1Offset = 28;

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		private const uint Flag1Mask = 268435456U;

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		private const int Flag2Offset = 29;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		private const uint Flag2Mask = 536870912U;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x28")]
		private uint g;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x2C")]
		private uint h;
	}
}
