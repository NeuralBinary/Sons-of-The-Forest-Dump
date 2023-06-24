using System;
using System.Collections;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000AE RID: 174
	[Token(Token = "0x20000AE")]
	public class RefCountVector : IEnumerable
	{
		// Token: 0x060003C7 RID: 967 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1F48E60", Offset = "0x1F47460", VA = "0x181F48E60")]
		public RefCountVector()
		{
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1F48FA0", Offset = "0x1F475A0", VA = "0x181F48FA0")]
		public RefCountVector(RefCountVector copy)
		{
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1F49130", Offset = "0x1F47730", VA = "0x181F49130")]
		public RefCountVector(short[] raw_ref_counts, bool build_free_list = false)
		{
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060003CA RID: 970 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700007A")]
		public DVector<short> RawRefCounts
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00003C74 File Offset: 0x00001E74
		[Token(Token = "0x1700007B")]
		public bool empty
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x74DB00", Offset = "0x74C100", VA = "0x18074DB00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00003C8C File Offset: 0x00001E8C
		[Token(Token = "0x1700007C")]
		public int count
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00003CA4 File Offset: 0x00001EA4
		[Token(Token = "0x1700007D")]
		public int max_index
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x1F492C0", Offset = "0x1F478C0", VA = "0x181F492C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00003CBC File Offset: 0x00001EBC
		[Token(Token = "0x1700007E")]
		public bool is_dense
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x1F49310", Offset = "0x1F47910", VA = "0x181F49310")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00003CD4 File Offset: 0x00001ED4
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1F49360", Offset = "0x1F47960", VA = "0x181F49360")]
		public bool isValid(int index)
		{
			return default(bool);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00003CEC File Offset: 0x00001EEC
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1F493E0", Offset = "0x1F479E0", VA = "0x181F493E0")]
		public bool isValidUnsafe(int index)
		{
			return default(bool);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00003D04 File Offset: 0x00001F04
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1F49480", Offset = "0x1F47A80", VA = "0x181F49480")]
		public int refCount(int index)
		{
			return 0;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00003D1C File Offset: 0x00001F1C
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1F49550", Offset = "0x1F47B50", VA = "0x181F49550")]
		public int rawRefCount(int index)
		{
			return 0;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00003D34 File Offset: 0x00001F34
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1F495F0", Offset = "0x1F47BF0", VA = "0x181F495F0")]
		public int allocate()
		{
			return 0;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00003D4C File Offset: 0x00001F4C
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1F49880", Offset = "0x1F47E80", VA = "0x181F49880")]
		public int increment(int index, short increment = 1)
		{
			return 0;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1F499C0", Offset = "0x1F47FC0", VA = "0x181F499C0")]
		public void decrement(int index, short decrement = 1)
		{
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00003D64 File Offset: 0x00001F64
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1F49BF0", Offset = "0x1F481F0", VA = "0x181F49BF0")]
		public bool allocate_at(int index)
		{
			return default(bool);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00003D7C File Offset: 0x00001F7C
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1F49E70", Offset = "0x1F48470", VA = "0x181F49E70")]
		public bool allocate_at_unsafe(int index)
		{
			return default(bool);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1F49FD0", Offset = "0x1F485D0", VA = "0x181F49FD0")]
		public void set_Unsafe(int index, short count)
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1F4A070", Offset = "0x1F48670", VA = "0x181F4A070")]
		public void rebuild_free_list()
		{
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1F4A210", Offset = "0x1F48810", VA = "0x181F4A210")]
		public void trim(int maxIndex)
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1F4A300", Offset = "0x1F48900", VA = "0x181F4A300", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060003DC RID: 988 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700007F")]
		public string UsageStats
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x1F4A390", Offset = "0x1F48990", VA = "0x181F4A390")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1F4A5F0", Offset = "0x1F48BF0", VA = "0x181F4A5F0")]
		public string debug_print()
		{
			return null;
		}

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly short invalid;

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x10")]
		private DVector<short> ref_counts;

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x18")]
		private DVector<int> free_indices;

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x20")]
		private int used_count;
	}
}
