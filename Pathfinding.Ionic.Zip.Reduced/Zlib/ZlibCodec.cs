using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000D")]
	public sealed class ZlibCodec
	{
		// Token: 0x06000457 RID: 1111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x28A0590", Offset = "0x289EB90", VA = "0x1828A0590")]
		public ZlibCodec()
		{
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x28A05A0", Offset = "0x289EBA0", VA = "0x1828A05A0")]
		public ZlibCodec(CompressionMode mode)
		{
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x00004068 File Offset: 0x00002268
		[Token(Token = "0x1700010B")]
		public int Adler32
		{
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x8F47A0", Offset = "0x8F2DA0", VA = "0x1808F47A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00004080 File Offset: 0x00002280
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x28A06D0", Offset = "0x289ECD0", VA = "0x1828A06D0")]
		public int InitializeInflate()
		{
			return 0;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00004098 File Offset: 0x00002298
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x28A06E0", Offset = "0x289ECE0", VA = "0x1828A06E0")]
		public int InitializeInflate(bool expectRfc1950Header)
		{
			return 0;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x000040B0 File Offset: 0x000022B0
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x28A06F0", Offset = "0x289ECF0", VA = "0x1828A06F0")]
		public int InitializeInflate(int windowBits)
		{
			return 0;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000040C8 File Offset: 0x000022C8
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x28A0700", Offset = "0x289ED00", VA = "0x1828A0700")]
		public int InitializeInflate(int windowBits, bool expectRfc1950Header)
		{
			return 0;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000040E0 File Offset: 0x000022E0
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x28A0820", Offset = "0x289EE20", VA = "0x1828A0820")]
		public int Inflate(FlushType flush)
		{
			return 0;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x000040F8 File Offset: 0x000022F8
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x28A0890", Offset = "0x289EE90", VA = "0x1828A0890")]
		public int EndInflate()
		{
			return 0;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00004110 File Offset: 0x00002310
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x28A0950", Offset = "0x289EF50", VA = "0x1828A0950")]
		public int SyncInflate()
		{
			return 0;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00004128 File Offset: 0x00002328
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x28A09C0", Offset = "0x289EFC0", VA = "0x1828A09C0")]
		public int InitializeDeflate()
		{
			return 0;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x28A09D0", Offset = "0x289EFD0", VA = "0x1828A09D0")]
		public int InitializeDeflate(CompressionLevel level)
		{
			return 0;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00004158 File Offset: 0x00002358
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x28A09E0", Offset = "0x289EFE0", VA = "0x1828A09E0")]
		public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header)
		{
			return 0;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00004170 File Offset: 0x00002370
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x28A0A00", Offset = "0x289F000", VA = "0x1828A0A00")]
		public int InitializeDeflate(CompressionLevel level, int bits)
		{
			return 0;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00004188 File Offset: 0x00002388
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x28A0A20", Offset = "0x289F020", VA = "0x1828A0A20")]
		public int InitializeDeflate(CompressionLevel level, int bits, bool wantRfc1950Header)
		{
			return 0;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x000041A0 File Offset: 0x000023A0
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x28A0A40", Offset = "0x289F040", VA = "0x1828A0A40")]
		private int _InternalInitializeDeflate(bool wantRfc1950Header)
		{
			return 0;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000041B8 File Offset: 0x000023B8
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x28A0BF0", Offset = "0x289F1F0", VA = "0x1828A0BF0")]
		public int Deflate(FlushType flush)
		{
			return 0;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000041D0 File Offset: 0x000023D0
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x28A0C60", Offset = "0x289F260", VA = "0x1828A0C60")]
		public int EndDeflate()
		{
			return 0;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x28A0D10", Offset = "0x289F310", VA = "0x1828A0D10")]
		public void ResetDeflate()
		{
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x000041E8 File Offset: 0x000023E8
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x28A0D80", Offset = "0x289F380", VA = "0x1828A0D80")]
		public int SetDeflateParams(CompressionLevel level, CompressionStrategy strategy)
		{
			return 0;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00004200 File Offset: 0x00002400
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x28A0F00", Offset = "0x289F500", VA = "0x1828A0F00")]
		public int SetDictionary(byte[] dictionary)
		{
			return 0;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x28A1100", Offset = "0x289F700", VA = "0x1828A1100")]
		internal void flush_pending()
		{
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00004218 File Offset: 0x00002418
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x28A12B0", Offset = "0x289F8B0", VA = "0x1828A12B0")]
		internal int read_buf(byte[] buf, int start, int size)
		{
			return 0;
		}

		// Token: 0x04000382 RID: 898
		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] InputBuffer;

		// Token: 0x04000383 RID: 899
		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int NextIn;

		// Token: 0x04000384 RID: 900
		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int AvailableBytesIn;

		// Token: 0x04000385 RID: 901
		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public long TotalBytesIn;

		// Token: 0x04000386 RID: 902
		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public byte[] OutputBuffer;

		// Token: 0x04000387 RID: 903
		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int NextOut;

		// Token: 0x04000388 RID: 904
		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int AvailableBytesOut;

		// Token: 0x04000389 RID: 905
		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public long TotalBytesOut;

		// Token: 0x0400038A RID: 906
		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string Message;

		// Token: 0x0400038B RID: 907
		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal DeflateManager dstate;

		// Token: 0x0400038C RID: 908
		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal InflateManager istate;

		// Token: 0x0400038D RID: 909
		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal uint _Adler32;

		// Token: 0x0400038E RID: 910
		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public CompressionLevel CompressLevel;

		// Token: 0x0400038F RID: 911
		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int WindowBits;

		// Token: 0x04000390 RID: 912
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public CompressionStrategy Strategy;
	}
}
