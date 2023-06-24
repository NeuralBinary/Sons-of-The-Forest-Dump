using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000097 RID: 151
	[Token(Token = "0x2000097")]
	public class HBitArray : IEnumerable<int>, IEnumerable
	{
		// Token: 0x06000344 RID: 836 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1F42EA0", Offset = "0x1F414A0", VA = "0x181F42EA0")]
		public HBitArray(int maxIndex)
		{
		}

		// Token: 0x17000060 RID: 96
		[Token(Token = "0x17000060")]
		public bool this[int i]
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x1F43070", Offset = "0x1F41670", VA = "0x181F43070")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x1F430C0", Offset = "0x1F416C0", VA = "0x181F430C0")]
			set
			{
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000347 RID: 839 RVA: 0x00003944 File Offset: 0x00001B44
		[Token(Token = "0x17000061")]
		public int Count
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000348 RID: 840 RVA: 0x0000395C File Offset: 0x00001B5C
		[Token(Token = "0x17000062")]
		public int TrueCount
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00003974 File Offset: 0x00001B74
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1F43070", Offset = "0x1F41670", VA = "0x181F43070")]
		public bool Contains(int i)
		{
			return default(bool);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1F430D0", Offset = "0x1F416D0", VA = "0x181F430D0")]
		public void Add(int i)
		{
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1F430E0", Offset = "0x1F416E0", VA = "0x181F430E0")]
		public void Set(int i, bool value)
		{
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000398C File Offset: 0x00001B8C
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1F43070", Offset = "0x1F41670", VA = "0x181F43070")]
		public bool Get(int i)
		{
			return default(bool);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1F43290", Offset = "0x1F41890", VA = "0x181F43290", Slot = "4")]
		public IEnumerator<int> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1F43290", Offset = "0x1F41890", VA = "0x181F43290", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x10")]
		private HBitArray.MyBitVector32[] bits;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x18")]
		private HBitArray.Layer[] layers;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x20")]
		private int layerCount;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x24")]
		private int max_index;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x28")]
		private int count;

		// Token: 0x02000098 RID: 152
		[Token(Token = "0x2000098")]
		private struct MyBitVector32
		{
			// Token: 0x17000063 RID: 99
			[Token(Token = "0x17000063")]
			public bool this[int i]
			{
				[Token(Token = "0x600034F")]
				[Address(RVA = "0x1F43320", Offset = "0x1F41920", VA = "0x181F43320")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000350")]
				[Address(RVA = "0x1F43340", Offset = "0x1F41940", VA = "0x181F43340")]
				set
				{
				}
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x06000351 RID: 849 RVA: 0x000039BC File Offset: 0x00001BBC
			[Token(Token = "0x17000064")]
			public int Data
			{
				[Token(Token = "0x6000351")]
				[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050")]
				get
				{
					return 0;
				}
			}

			// Token: 0x04000282 RID: 642
			[Token(Token = "0x4000282")]
			[FieldOffset(Offset = "0x0")]
			private int bits;
		}

		// Token: 0x02000099 RID: 153
		[Token(Token = "0x2000099")]
		private struct Layer
		{
			// Token: 0x04000283 RID: 643
			[Token(Token = "0x4000283")]
			[FieldOffset(Offset = "0x0")]
			public HBitArray.MyBitVector32[] layer_bits;
		}
	}
}
