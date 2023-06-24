using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	public class MappedList : IList<int>, ICollection<int>, IEnumerable<int>, IEnumerable
	{
		// Token: 0x060002F5 RID: 757 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1F41B00", Offset = "0x1F40100", VA = "0x181F41B00")]
		public MappedList(IList<int> list, int[] map)
		{
		}

		// Token: 0x17000057 RID: 87
		[Token(Token = "0x17000057")]
		public int this[int index]
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x1F41E00", Offset = "0x1F40400", VA = "0x181F41E00", Slot = "4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x1F41E80", Offset = "0x1F40480", VA = "0x181F41E80", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00003734 File Offset: 0x00001934
		[Token(Token = "0x17000058")]
		public int Count
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x1F41EC0", Offset = "0x1F404C0", VA = "0x181F41EC0", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x0000374C File Offset: 0x0000194C
		[Token(Token = "0x17000059")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1F41F10", Offset = "0x1F40510", VA = "0x181F41F10", Slot = "11")]
		public void Add(int item)
		{
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1F41F50", Offset = "0x1F40550", VA = "0x181F41F50", Slot = "12")]
		public void Clear()
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1F41F90", Offset = "0x1F40590", VA = "0x181F41F90", Slot = "7")]
		public void Insert(int index, int item)
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00003764 File Offset: 0x00001964
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1F41FD0", Offset = "0x1F405D0", VA = "0x181F41FD0", Slot = "15")]
		public bool Remove(int item)
		{
			return default(bool);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1F42010", Offset = "0x1F40610", VA = "0x181F42010", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000377C File Offset: 0x0000197C
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1F42050", Offset = "0x1F40650", VA = "0x181F42050", Slot = "13")]
		public bool Contains(int item)
		{
			return default(bool);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00003794 File Offset: 0x00001994
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1F42090", Offset = "0x1F40690", VA = "0x181F42090", Slot = "6")]
		public int IndexOf(int item)
		{
			return 0;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1F420D0", Offset = "0x1F406D0", VA = "0x181F420D0", Slot = "14")]
		public void CopyTo(int[] array, int arrayIndex)
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1F42110", Offset = "0x1F40710", VA = "0x181F42110", Slot = "16")]
		public IEnumerator<int> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x1F42110", Offset = "0x1F40710", VA = "0x181F42110", Slot = "17")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x10")]
		public IList<int> BaseList;

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x18")]
		public Func<int, int> MapF;
	}
}
