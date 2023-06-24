using System;
using System.IO;
using System.Text;
using Il2CppDummyDll;
using Pathfinding.Ionic.Zlib;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	internal class ZipContainer
	{
		// Token: 0x060002BD RID: 701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x287B6F0", Offset = "0x2879CF0", VA = "0x18287B6F0")]
		public ZipContainer(object o)
		{
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002BE RID: 702 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x170000AC")]
		public ZipFile ZipFile
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002BF RID: 703 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x170000AD")]
		public ZipOutputStream ZipOutputStream
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x170000AE")]
		public string Name
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x287B900", Offset = "0x2879F00", VA = "0x18287B900")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x170000AF")]
		public string Password
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x287B980", Offset = "0x2879F80", VA = "0x18287B980")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x170000B0")]
		public Zip64Option Zip64
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x287B9C0", Offset = "0x2879FC0", VA = "0x18287B9C0")]
			get
			{
				return Zip64Option.Default;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00003258 File Offset: 0x00001458
		[Token(Token = "0x170000B1")]
		public int BufferSize
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x287BA40", Offset = "0x287A040", VA = "0x18287BA40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B2")]
		public ParallelDeflateOutputStream ParallelDeflater
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x287BAB0", Offset = "0x287A0B0", VA = "0x18287BAB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x287BB00", Offset = "0x287A100", VA = "0x18287BB00")]
			set
			{
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x170000B3")]
		public long ParallelDeflateThreshold
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x287BBE0", Offset = "0x287A1E0", VA = "0x18287BBE0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x170000B4")]
		public int ParallelDeflateMaxBufferPairs
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x287BC20", Offset = "0x287A220", VA = "0x18287BC20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x170000B5")]
		public int CodecBufferSize
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x287BC60", Offset = "0x287A260", VA = "0x18287BC60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x170000B6")]
		public CompressionStrategy Strategy
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x287BCB0", Offset = "0x287A2B0", VA = "0x18287BCB0")]
			get
			{
				return CompressionStrategy.Default;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002CA RID: 714 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x170000B7")]
		public Zip64Option UseZip64WhenSaving
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x287BCF0", Offset = "0x287A2F0", VA = "0x18287BCF0")]
			get
			{
				return Zip64Option.Default;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002CB RID: 715 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x170000B8")]
		public Encoding AlternateEncoding
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x287BD20", Offset = "0x287A320", VA = "0x18287BD20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002CC RID: 716 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x170000B9")]
		public Encoding DefaultEncoding
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x287BD40", Offset = "0x287A340", VA = "0x18287BD40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002CD RID: 717 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x170000BA")]
		public ZipOption AlternateEncodingUsage
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x287BDF0", Offset = "0x287A3F0", VA = "0x18287BDF0")]
			get
			{
				return ZipOption.Default;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002CE RID: 718 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x170000BB")]
		public Stream ReadStream
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x287BE10", Offset = "0x287A410", VA = "0x18287BE10")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x10")]
		private ZipFile _zf;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x18")]
		private ZipOutputStream _zos;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x20")]
		private ZipInputStream _zis;
	}
}
