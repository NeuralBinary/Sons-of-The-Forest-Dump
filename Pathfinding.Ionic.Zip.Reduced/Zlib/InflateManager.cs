using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	internal sealed class InflateManager
	{
		// Token: 0x060003F9 RID: 1017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x21BE7E0", Offset = "0x21BCDE0", VA = "0x1821BE7E0")]
		public InflateManager()
		{
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x620AD0", Offset = "0x61F0D0", VA = "0x180620AD0")]
		public InflateManager(bool expectRfc1950HeaderBytes)
		{
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00003D08 File Offset: 0x00001F08
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F7")]
		internal bool HandleRfc1950HeaderBytes
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x620AD0", Offset = "0x61F0D0", VA = "0x180620AD0")]
			set
			{
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x28985B0", Offset = "0x2896BB0", VA = "0x1828985B0")]
		internal int Reset()
		{
			return 0;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x2898650", Offset = "0x2896C50", VA = "0x182898650")]
		internal int End()
		{
			return 0;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x28987A0", Offset = "0x2896DA0", VA = "0x1828987A0")]
		internal int Initialize(ZlibCodec codec, int w)
		{
			return 0;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00003D68 File Offset: 0x00001F68
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x2898A40", Offset = "0x2897040", VA = "0x182898A40")]
		internal int Inflate(FlushType flush)
		{
			return 0;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00003D80 File Offset: 0x00001F80
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x2899410", Offset = "0x2897A10", VA = "0x182899410")]
		internal int SetDictionary(byte[] dictionary)
		{
			return 0;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00003D98 File Offset: 0x00001F98
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x28995A0", Offset = "0x2897BA0", VA = "0x1828995A0")]
		internal int Sync()
		{
			return 0;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x28997A0", Offset = "0x2897DA0", VA = "0x1828997A0")]
		internal int SyncPoint(ZlibCodec z)
		{
			return 0;
		}

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		private const int PRESET_DICT = 32;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		private const int Z_DEFLATED = 8;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x10")]
		private InflateManager.InflateManagerMode mode;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x18")]
		internal ZlibCodec _codec;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x20")]
		internal int method;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x24")]
		internal uint computedCheck;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x28")]
		internal uint expectedCheck;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x2C")]
		internal int marker;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x30")]
		private bool _handleRfc1950HeaderBytes;

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x34")]
		internal int wbits;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x38")]
		internal InflateBlocks blocks;

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] mark;

		// Token: 0x02000057 RID: 87
		[Token(Token = "0x2000057")]
		private enum InflateManagerMode
		{
			// Token: 0x040002E4 RID: 740
			[Token(Token = "0x40002E4")]
			METHOD,
			// Token: 0x040002E5 RID: 741
			[Token(Token = "0x40002E5")]
			FLAG,
			// Token: 0x040002E6 RID: 742
			[Token(Token = "0x40002E6")]
			DICT4,
			// Token: 0x040002E7 RID: 743
			[Token(Token = "0x40002E7")]
			DICT3,
			// Token: 0x040002E8 RID: 744
			[Token(Token = "0x40002E8")]
			DICT2,
			// Token: 0x040002E9 RID: 745
			[Token(Token = "0x40002E9")]
			DICT1,
			// Token: 0x040002EA RID: 746
			[Token(Token = "0x40002EA")]
			DICT0,
			// Token: 0x040002EB RID: 747
			[Token(Token = "0x40002EB")]
			BLOCKS,
			// Token: 0x040002EC RID: 748
			[Token(Token = "0x40002EC")]
			CHECK4,
			// Token: 0x040002ED RID: 749
			[Token(Token = "0x40002ED")]
			CHECK3,
			// Token: 0x040002EE RID: 750
			[Token(Token = "0x40002EE")]
			CHECK2,
			// Token: 0x040002EF RID: 751
			[Token(Token = "0x40002EF")]
			CHECK1,
			// Token: 0x040002F0 RID: 752
			[Token(Token = "0x40002F0")]
			DONE,
			// Token: 0x040002F1 RID: 753
			[Token(Token = "0x40002F1")]
			BAD
		}
	}
}
