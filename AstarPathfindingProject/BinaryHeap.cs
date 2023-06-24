using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	public class BinaryHeap
	{
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002FA RID: 762 RVA: 0x000039D4 File Offset: 0x00001BD4
		[Token(Token = "0x170000A0")]
		public bool isEmpty
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x64A390", Offset = "0x648990", VA = "0x18064A390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x000039EC File Offset: 0x00001BEC
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x64A3A0", Offset = "0x6489A0", VA = "0x18064A3A0")]
		private static int RoundUpToNextMultipleMod1(int v)
		{
			return 0;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x64A3D0", Offset = "0x6489D0", VA = "0x18064A3D0")]
		public BinaryHeap(int capacity)
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x64A4A0", Offset = "0x648AA0", VA = "0x18064A4A0")]
		public void Clear()
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x64A500", Offset = "0x648B00", VA = "0x18064A500")]
		internal PathNode GetNode(int i)
		{
			return null;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x64A540", Offset = "0x648B40", VA = "0x18064A540")]
		internal void SetF(int i, uint f)
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x64A570", Offset = "0x648B70", VA = "0x18064A570")]
		private void Expand()
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x64A710", Offset = "0x648D10", VA = "0x18064A710")]
		public void Add(PathNode node)
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x64A880", Offset = "0x648E80", VA = "0x18064A880")]
		private void DecreaseKey(BinaryHeap.Tuple node, ushort index)
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x64AA80", Offset = "0x649080", VA = "0x18064AA80")]
		public PathNode Remove()
		{
			return null;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x64AEC0", Offset = "0x6494C0", VA = "0x18064AEC0")]
		private void Validate()
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x64B1B0", Offset = "0x6497B0", VA = "0x18064B1B0")]
		public void Rebuild()
		{
		}

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x10")]
		public int numberOfItems;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x14")]
		public float growthFactor;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		private const int D = 4;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		private const bool SortGScores = true;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		public const ushort NotInHeap = 65535;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x18")]
		private BinaryHeap.Tuple[] heap;

		// Token: 0x02000054 RID: 84
		[Token(Token = "0x2000054")]
		private struct Tuple
		{
			// Token: 0x06000306 RID: 774 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x658230", Offset = "0x656830", VA = "0x180658230")]
			public Tuple(uint f, PathNode node)
			{
			}

			// Token: 0x0400022C RID: 556
			[Token(Token = "0x400022C")]
			[FieldOffset(Offset = "0x0")]
			public PathNode node;

			// Token: 0x0400022D RID: 557
			[Token(Token = "0x400022D")]
			[FieldOffset(Offset = "0x8")]
			public uint F;
		}
	}
}
