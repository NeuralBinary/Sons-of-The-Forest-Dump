using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000B1 RID: 177
	[Token(Token = "0x20000B1")]
	public class SmallListSet
	{
		// Token: 0x060003E9 RID: 1001 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1F4AD80", Offset = "0x1F49380", VA = "0x181F4AD80")]
		public SmallListSet()
		{
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1F4AF90", Offset = "0x1F49590", VA = "0x181F4AF90")]
		public SmallListSet(SmallListSet copy)
		{
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00003DAC File Offset: 0x00001FAC
		[Token(Token = "0x17000083")]
		public int Size
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x1F4B1E0", Offset = "0x1F497E0", VA = "0x181F4B1E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1F4B230", Offset = "0x1F49830", VA = "0x181F4B230")]
		public void Resize(int new_size)
		{
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1F4B320", Offset = "0x1F49920", VA = "0x181F4B320")]
		public void AllocateAt(int list_index)
		{
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1F4B4D0", Offset = "0x1F49AD0", VA = "0x181F4B4D0")]
		public void Insert(int list_index, int val)
		{
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00003DC4 File Offset: 0x00001FC4
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1F4B8C0", Offset = "0x1F49EC0", VA = "0x181F4B8C0")]
		public bool Remove(int list_index, int val)
		{
			return default(bool);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1F4BBA0", Offset = "0x1F4A1A0", VA = "0x181F4BBA0")]
		public void Move(int from_index, int to_index)
		{
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1F4BDB0", Offset = "0x1F4A3B0", VA = "0x181F4BDB0")]
		public void Clear(int list_index)
		{
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00003DDC File Offset: 0x00001FDC
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1F4C0B0", Offset = "0x1F4A6B0", VA = "0x181F4C0B0")]
		public int Count(int list_index)
		{
			return 0;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00003DF4 File Offset: 0x00001FF4
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1F4C160", Offset = "0x1F4A760", VA = "0x181F4C160")]
		public bool Contains(int list_index, int val)
		{
			return default(bool);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00003E0C File Offset: 0x0000200C
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1F4C3F0", Offset = "0x1F4A9F0", VA = "0x181F4C3F0")]
		public int First(int list_index)
		{
			return 0;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1F4C4E0", Offset = "0x1F4AAE0", VA = "0x181F4C4E0")]
		public IEnumerable<int> ValueItr(int list_index)
		{
			return null;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00003E24 File Offset: 0x00002024
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1F4C5A0", Offset = "0x1F4ABA0", VA = "0x181F4C5A0")]
		public int Find(int list_index, Func<int, bool> findF, int invalidValue = -1)
		{
			return 0;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00003E3C File Offset: 0x0000203C
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1F4C890", Offset = "0x1F4AE90", VA = "0x181F4C890")]
		public bool Replace(int list_index, Func<int, bool> findF, int new_value)
		{
			return default(bool);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00003E54 File Offset: 0x00002054
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1F4CB90", Offset = "0x1F4B190", VA = "0x181F4CB90")]
		protected int allocate_block()
		{
			return 0;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1F4CD00", Offset = "0x1F4B300", VA = "0x181F4CD00")]
		private void add_free_link(int ptr)
		{
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00003E6C File Offset: 0x0000206C
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1F4CDA0", Offset = "0x1F4B3A0", VA = "0x181F4CDA0")]
		private bool remove_from_linked_list(int block_ptr, int val)
		{
			return default(bool);
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000084")]
		public string MemoryUsage
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x1F4CF50", Offset = "0x1F4B550", VA = "0x181F4CF50")]
			get
			{
				return null;
			}
		}

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		private const int Null = -1;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		private const int BLOCKSIZE = 8;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		private const int BLOCK_LIST_OFFSET = 9;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x10")]
		private DVector<int> list_heads;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x18")]
		private DVector<int> block_store;

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x20")]
		private DVector<int> free_blocks;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x28")]
		private int allocated_count;

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x30")]
		private DVector<int> linked_store;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x38")]
		private int free_head_ptr;
	}
}
