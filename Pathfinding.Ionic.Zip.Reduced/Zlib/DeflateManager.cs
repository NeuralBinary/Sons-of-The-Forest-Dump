using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	internal sealed class DeflateManager
	{
		// Token: 0x06000378 RID: 888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x288AE50", Offset = "0x2889450", VA = "0x18288AE50")]
		internal DeflateManager()
		{
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x288B690", Offset = "0x2889C90", VA = "0x18288B690")]
		private void _InitializeLazyMatch()
		{
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x288B7C0", Offset = "0x2889DC0", VA = "0x18288B7C0")]
		private void _InitializeTreeData()
		{
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x288BAD0", Offset = "0x288A0D0", VA = "0x18288BAD0")]
		internal void _InitializeBlocks()
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x288BCA0", Offset = "0x288A2A0", VA = "0x18288BCA0")]
		internal void pqdownheap(short[] tree, int k)
		{
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00003840 File Offset: 0x00001A40
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x288BF00", Offset = "0x288A500", VA = "0x18288BF00")]
		internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth)
		{
			return default(bool);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x288BF80", Offset = "0x288A580", VA = "0x18288BF80")]
		internal void scan_tree(short[] tree, int max_code)
		{
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x288C200", Offset = "0x288A800", VA = "0x18288C200")]
		internal int build_bl_tree()
		{
			return 0;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x288C370", Offset = "0x288A970", VA = "0x18288C370")]
		internal void send_all_trees(int lcodes, int dcodes, int blcodes)
		{
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x288C4C0", Offset = "0x288AAC0", VA = "0x18288C4C0")]
		internal void send_tree(short[] tree, int max_code)
		{
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x288C840", Offset = "0x288AE40", VA = "0x18288C840")]
		private void put_bytes(byte[] p, int start, int len)
		{
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x288C890", Offset = "0x288AE90", VA = "0x18288C890")]
		internal void send_code(int c, short[] tree)
		{
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x288C8E0", Offset = "0x288AEE0", VA = "0x18288C8E0")]
		internal void send_bits(int value, int length)
		{
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x288CA50", Offset = "0x288B050", VA = "0x18288CA50")]
		internal void _tr_align()
		{
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00003870 File Offset: 0x00001A70
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x288CC30", Offset = "0x288B230", VA = "0x18288CC30")]
		internal bool _tr_tally(int dist, int lc)
		{
			return default(bool);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x288CF60", Offset = "0x288B560", VA = "0x18288CF60")]
		internal void send_compressed_block(short[] ltree, short[] dtree)
		{
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x288D350", Offset = "0x288B950", VA = "0x18288D350")]
		internal void set_data_type()
		{
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x288D4E0", Offset = "0x288BAE0", VA = "0x18288D4E0")]
		internal void bi_flush()
		{
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x288D5B0", Offset = "0x288BBB0", VA = "0x18288D5B0")]
		internal void bi_windup()
		{
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x288D680", Offset = "0x288BC80", VA = "0x18288D680")]
		internal void copy_block(int buf, int len, bool header)
		{
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x288D7A0", Offset = "0x288BDA0", VA = "0x18288D7A0")]
		internal void flush_block_only(bool eof)
		{
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00003888 File Offset: 0x00001A88
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x288D810", Offset = "0x288BE10", VA = "0x18288D810")]
		internal BlockState DeflateNone(FlushType flush)
		{
			return BlockState.NeedMore;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x288DA40", Offset = "0x288C040", VA = "0x18288DA40")]
		internal void _tr_stored_block(int buf, int stored_len, bool eof)
		{
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x288DBC0", Offset = "0x288C1C0", VA = "0x18288DBC0")]
		internal void _tr_flush_block(int buf, int stored_len, bool eof)
		{
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x288E1B0", Offset = "0x288C7B0", VA = "0x18288E1B0")]
		private void _fillWindow()
		{
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000038A0 File Offset: 0x00001AA0
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x288E520", Offset = "0x288CB20", VA = "0x18288E520")]
		internal BlockState DeflateFast(FlushType flush)
		{
			return BlockState.NeedMore;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000038B8 File Offset: 0x00001AB8
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x288EAA0", Offset = "0x288D0A0", VA = "0x18288EAA0")]
		internal BlockState DeflateSlow(FlushType flush)
		{
			return BlockState.NeedMore;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x288F1B0", Offset = "0x288D7B0", VA = "0x18288F1B0")]
		internal int longest_match(int cur_match)
		{
			return 0;
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000395 RID: 917 RVA: 0x000038E8 File Offset: 0x00001AE8
		// (set) Token: 0x06000396 RID: 918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E0")]
		internal bool WantRfc1950HeaderBytes
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x288F660", Offset = "0x288DC60", VA = "0x18288F660")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x288F670", Offset = "0x288DC70", VA = "0x18288F670")]
			set
			{
			}
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00003900 File Offset: 0x00001B00
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x288F680", Offset = "0x288DC80", VA = "0x18288F680")]
		internal int Initialize(ZlibCodec codec, CompressionLevel level)
		{
			return 0;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x288F710", Offset = "0x288DD10", VA = "0x18288F710")]
		internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits)
		{
			return 0;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x288F7B0", Offset = "0x288DDB0", VA = "0x18288F7B0")]
		internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits, CompressionStrategy compressionStrategy)
		{
			return 0;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00003948 File Offset: 0x00001B48
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x288F850", Offset = "0x288DE50", VA = "0x18288F850")]
		internal int Initialize(ZlibCodec codec, CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy)
		{
			return 0;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x288FC00", Offset = "0x288E200", VA = "0x18288FC00")]
		internal void Reset()
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00003960 File Offset: 0x00001B60
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x288FE90", Offset = "0x288E490", VA = "0x18288FE90")]
		internal int End()
		{
			return 0;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x28900D0", Offset = "0x288E6D0", VA = "0x1828900D0")]
		private void SetDeflater()
		{
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00003978 File Offset: 0x00001B78
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x28902F0", Offset = "0x288E8F0", VA = "0x1828902F0")]
		internal int SetParams(CompressionLevel level, CompressionStrategy strategy)
		{
			return 0;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x2890430", Offset = "0x288EA30", VA = "0x182890430")]
		internal int SetDictionary(byte[] dictionary)
		{
			return 0;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x000039A8 File Offset: 0x00001BA8
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x2890750", Offset = "0x288ED50", VA = "0x182890750")]
		internal int Deflate(FlushType flush)
		{
			return 0;
		}

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int MEM_LEVEL_MAX;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int MEM_LEVEL_DEFAULT;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x10")]
		private DeflateManager.CompressFunc DeflateFunction;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string[] _ErrorMessage;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int PRESET_DICT;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int INIT_STATE;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int BUSY_STATE;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int FINISH_STATE;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int Z_DEFLATED;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int STORED_BLOCK;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int STATIC_TREES;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x2C")]
		private static readonly int DYN_TREES;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x30")]
		private static readonly int Z_BINARY;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x34")]
		private static readonly int Z_ASCII;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x38")]
		private static readonly int Z_UNKNOWN;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x3C")]
		private static readonly int Buf_size;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x40")]
		private static readonly int MIN_MATCH;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x44")]
		private static readonly int MAX_MATCH;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x48")]
		private static readonly int MIN_LOOKAHEAD;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x4C")]
		private static readonly int HEAP_SIZE;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x50")]
		private static readonly int END_BLOCK;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x18")]
		internal ZlibCodec _codec;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x20")]
		internal int status;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x28")]
		internal byte[] pending;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x30")]
		internal int nextPending;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x34")]
		internal int pendingCount;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x38")]
		internal sbyte data_type;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x3C")]
		internal int last_flush;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x40")]
		internal int w_size;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x44")]
		internal int w_bits;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x48")]
		internal int w_mask;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x50")]
		internal byte[] window;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x58")]
		internal int window_size;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x60")]
		internal short[] prev;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x68")]
		internal short[] head;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x70")]
		internal int ins_h;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x74")]
		internal int hash_size;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x78")]
		internal int hash_bits;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x7C")]
		internal int hash_mask;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x80")]
		internal int hash_shift;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x84")]
		internal int block_start;

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x88")]
		private DeflateManager.Config config;

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x90")]
		internal int match_length;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x94")]
		internal int prev_match;

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x98")]
		internal int match_available;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x9C")]
		internal int strstart;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0xA0")]
		internal int match_start;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0xA4")]
		internal int lookahead;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0xA8")]
		internal int prev_length;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0xAC")]
		internal CompressionLevel compressionLevel;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0xB0")]
		internal CompressionStrategy compressionStrategy;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0xB8")]
		internal short[] dyn_ltree;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0xC0")]
		internal short[] dyn_dtree;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0xC8")]
		internal short[] bl_tree;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0xD0")]
		internal Tree treeLiterals;

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0xD8")]
		internal Tree treeDistances;

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0xE0")]
		internal Tree treeBitLengths;

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0xE8")]
		internal short[] bl_count;

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0xF0")]
		internal int[] heap;

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0xF8")]
		internal int heap_len;

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0xFC")]
		internal int heap_max;

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x100")]
		internal sbyte[] depth;

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x108")]
		internal int _lengthOffset;

		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x10C")]
		internal int lit_bufsize;

		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x110")]
		internal int last_lit;

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x114")]
		internal int _distanceOffset;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x118")]
		internal int opt_len;

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x11C")]
		internal int static_len;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x120")]
		internal int matches;

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x124")]
		internal int last_eob_len;

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x128")]
		internal short bi_buf;

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x12C")]
		internal int bi_valid;

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x130")]
		private bool Rfc1950BytesEmitted;

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x131")]
		private bool _WantRfc1950HeaderBytes;

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x060003A2 RID: 930
		[Token(Token = "0x200004D")]
		internal delegate BlockState CompressFunc(FlushType flush);

		// Token: 0x0200004E RID: 78
		[Token(Token = "0x200004E")]
		internal class Config
		{
			// Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x2891020", Offset = "0x288F620", VA = "0x182891020")]
			private Config(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor)
			{
			}

			// Token: 0x060003A7 RID: 935 RVA: 0x000020B2 File Offset: 0x000002B2
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x2891520", Offset = "0x288FB20", VA = "0x182891520")]
			public static DeflateManager.Config Lookup(CompressionLevel level)
			{
				return null;
			}

			// Token: 0x04000271 RID: 625
			[Token(Token = "0x4000271")]
			[FieldOffset(Offset = "0x10")]
			internal int GoodLength;

			// Token: 0x04000272 RID: 626
			[Token(Token = "0x4000272")]
			[FieldOffset(Offset = "0x14")]
			internal int MaxLazy;

			// Token: 0x04000273 RID: 627
			[Token(Token = "0x4000273")]
			[FieldOffset(Offset = "0x18")]
			internal int NiceLength;

			// Token: 0x04000274 RID: 628
			[Token(Token = "0x4000274")]
			[FieldOffset(Offset = "0x1C")]
			internal int MaxChainLength;

			// Token: 0x04000275 RID: 629
			[Token(Token = "0x4000275")]
			[FieldOffset(Offset = "0x20")]
			internal DeflateFlavor Flavor;

			// Token: 0x04000276 RID: 630
			[Token(Token = "0x4000276")]
			[FieldOffset(Offset = "0x0")]
			private static readonly DeflateManager.Config[] Table;
		}
	}
}
