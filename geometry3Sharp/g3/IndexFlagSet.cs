using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	public class IndexFlagSet : IEnumerable<int>, IEnumerable
	{
		// Token: 0x06000365 RID: 869 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1F439D0", Offset = "0x1F41FD0", VA = "0x181F439D0")]
		public IndexFlagSet(bool bForceSparse, int MaxIndex = -1)
		{
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1F43B20", Offset = "0x1F42120", VA = "0x181F43B20")]
		public IndexFlagSet(int MaxIndex, int SubsetCountEst)
		{
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00003A4C File Offset: 0x00001C4C
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x1F43CB0", Offset = "0x1F422B0", VA = "0x181F43CB0")]
		public bool Contains(int i)
		{
			return default(bool);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1F43CC0", Offset = "0x1F422C0", VA = "0x181F43CC0")]
		public void Add(int i)
		{
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00003A64 File Offset: 0x00001C64
		[Token(Token = "0x1700006A")]
		public int Count
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x1F43CD0", Offset = "0x1F422D0", VA = "0x181F43CD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700006B RID: 107
		[Token(Token = "0x1700006B")]
		public bool this[int key]
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x1F43D20", Offset = "0x1F42320", VA = "0x181F43D20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x1F43D90", Offset = "0x1F42390", VA = "0x181F43D90")]
			set
			{
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1F43EE0", Offset = "0x1F424E0", VA = "0x181F43EE0", Slot = "4")]
		public IEnumerator<int> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1F43F70", Offset = "0x1F42570", VA = "0x181F43F70", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x10")]
		private BitArray bits;

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x18")]
		private HashSet<int> hash;

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x20")]
		private int count;
	}
}
