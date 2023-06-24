using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000D8")]
	public class BitSet : BoltObject
	{
		// Token: 0x0600067C RID: 1660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x8FEE30", Offset = "0x8FD430", VA = "0x1808FEE30")]
		public BitSet(ulong bits0, ulong bits1, ulong bits2, ulong bits3, ulong bits4, ulong bits5, ulong bits6, ulong bits7, ulong bits8, ulong bits9, ulong bits10, ulong bits11, ulong bits12, ulong bits13, ulong bits14, ulong bits15)
		{
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BitSet()
		{
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x17000129")]
		public bool IsZero
		{
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x8FEED0", Offset = "0x8FD4D0", VA = "0x1808FEED0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x8FEF60", Offset = "0x8FD560", VA = "0x1808FEF60")]
		public void Set(int bit)
		{
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x8FF190", Offset = "0x8FD790", VA = "0x1808FF190")]
		public void Clear(int bit)
		{
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x8FF3C0", Offset = "0x8FD9C0", VA = "0x1808FF3C0")]
		public void Combine(BitSet other)
		{
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x8FF480", Offset = "0x8FDA80", VA = "0x1808FF480")]
		public void ClearAll()
		{
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x000042F0 File Offset: 0x000024F0
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x8FF4E0", Offset = "0x8FDAE0", VA = "0x1808FF4E0")]
		public bool IsSet(int bit)
		{
			return default(bool);
		}

		// Token: 0x1700012A RID: 298
		[Token(Token = "0x1700012A")]
		public ulong this[int index]
		{
			[Token(Token = "0x6000684")]
			[Address(RVA = "0x8FF6E0", Offset = "0x8FDCE0", VA = "0x1808FF6E0")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x8FF830", Offset = "0x8FDE30", VA = "0x1808FF830")]
			set
			{
			}
		}

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		public const int BITSET_LONGS = 16;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly BitSet Full;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x28")]
		private ulong Bits0;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x30")]
		private ulong Bits1;

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x38")]
		private ulong Bits2;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x40")]
		private ulong Bits3;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x48")]
		private ulong Bits4;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x50")]
		private ulong Bits5;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x58")]
		private ulong Bits6;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x60")]
		private ulong Bits7;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x68")]
		private ulong Bits8;

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x70")]
		private ulong Bits9;

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x78")]
		private ulong Bits10;

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x80")]
		private ulong Bits11;

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x88")]
		private ulong Bits12;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x90")]
		private ulong Bits13;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x98")]
		private ulong Bits14;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0xA0")]
		private ulong Bits15;
	}
}
