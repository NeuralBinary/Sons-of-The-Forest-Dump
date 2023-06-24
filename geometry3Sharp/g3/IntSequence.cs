using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	public struct IntSequence : IList<int>, ICollection<int>, IEnumerable<int>, IEnumerable
	{
		// Token: 0x0600030F RID: 783 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public IntSequence(Interval1i ival)
		{
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1F423D0", Offset = "0x1F409D0", VA = "0x181F423D0")]
		public IntSequence(int iStart, int iEnd)
		{
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000380C File Offset: 0x00001A0C
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1E2F8B0", Offset = "0x1E2DEB0", VA = "0x181E2F8B0")]
		public static IntSequence Range(int N)
		{
			return default(IntSequence);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00003824 File Offset: 0x00001A24
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1E2F8D0", Offset = "0x1E2DED0", VA = "0x181E2F8D0")]
		public static IntSequence RangeInclusive(int N)
		{
			return default(IntSequence);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000383C File Offset: 0x00001A3C
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1E2F8F0", Offset = "0x1E2DEF0", VA = "0x181E2F8F0")]
		public static IntSequence Range(int start, int N)
		{
			return default(IntSequence);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00003854 File Offset: 0x00001A54
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1E2F910", Offset = "0x1E2DF10", VA = "0x181E2F910")]
		public static IntSequence FromToInclusive(int a, int b)
		{
			return default(IntSequence);
		}

		// Token: 0x1700005C RID: 92
		[Token(Token = "0x1700005C")]
		public int this[int index]
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x1F423F0", Offset = "0x1F409F0", VA = "0x181F423F0", Slot = "4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x1F42400", Offset = "0x1F40A00", VA = "0x181F42400", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00003884 File Offset: 0x00001A84
		[Token(Token = "0x1700005D")]
		public int Count
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x1F42440", Offset = "0x1F40A40", VA = "0x181F42440", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0000389C File Offset: 0x00001A9C
		[Token(Token = "0x1700005E")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1F42450", Offset = "0x1F40A50", VA = "0x181F42450", Slot = "11")]
		public void Add(int item)
		{
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1F42490", Offset = "0x1F40A90", VA = "0x181F42490", Slot = "12")]
		public void Clear()
		{
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1F424D0", Offset = "0x1F40AD0", VA = "0x181F424D0", Slot = "7")]
		public void Insert(int index, int item)
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000038B4 File Offset: 0x00001AB4
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1F42510", Offset = "0x1F40B10", VA = "0x181F42510", Slot = "15")]
		public bool Remove(int item)
		{
			return default(bool);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1F42550", Offset = "0x1F40B50", VA = "0x181F42550", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000038CC File Offset: 0x00001ACC
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1E2F960", Offset = "0x1E2DF60", VA = "0x181E2F960", Slot = "13")]
		public bool Contains(int item)
		{
			return default(bool);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000038E4 File Offset: 0x00001AE4
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1F42590", Offset = "0x1F40B90", VA = "0x181F42590", Slot = "6")]
		public int IndexOf(int item)
		{
			return 0;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1F425D0", Offset = "0x1F40BD0", VA = "0x181F425D0", Slot = "14")]
		public void CopyTo(int[] array, int arrayIndex)
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1E2F9E0", Offset = "0x1E2DFE0", VA = "0x181E2F9E0", Slot = "16")]
		public IEnumerator<int> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1E2F9E0", Offset = "0x1E2DFE0", VA = "0x181E2F9E0", Slot = "17")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x0")]
		private Interval1i range;
	}
}
