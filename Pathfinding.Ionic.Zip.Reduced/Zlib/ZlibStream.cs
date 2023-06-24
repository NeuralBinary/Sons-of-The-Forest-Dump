using System;
using System.IO;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	public class ZlibStream : Stream
	{
		// Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x28A13C0", Offset = "0x289F9C0", VA = "0x1828A13C0")]
		public ZlibStream(Stream stream, CompressionMode mode)
		{
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x28A13F0", Offset = "0x289F9F0", VA = "0x1828A13F0")]
		public ZlibStream(Stream stream, CompressionMode mode, CompressionLevel level)
		{
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x28A1410", Offset = "0x289FA10", VA = "0x1828A1410")]
		public ZlibStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x28A1440", Offset = "0x289FA40", VA = "0x1828A1440")]
		public ZlibStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
		{
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x00004230 File Offset: 0x00002430
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010C")]
		public virtual FlushType FlushMode
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x2083910", Offset = "0x2081F10", VA = "0x182083910", Slot = "39")]
			get
			{
				return FlushType.None;
			}
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x28A1540", Offset = "0x289FB40", VA = "0x1828A1540", Slot = "40")]
			set
			{
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00004248 File Offset: 0x00002448
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010D")]
		public int BufferSize
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x2891800", Offset = "0x288FE00", VA = "0x182891800")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x28A15C0", Offset = "0x289FBC0", VA = "0x1828A15C0")]
			set
			{
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x00004260 File Offset: 0x00002460
		[Token(Token = "0x1700010E")]
		public virtual long TotalIn
		{
			[Token(Token = "0x6000476")]
			[Address(RVA = "0x2891A40", Offset = "0x2890040", VA = "0x182891A40", Slot = "41")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00004278 File Offset: 0x00002478
		[Token(Token = "0x1700010F")]
		public virtual long TotalOut
		{
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x2891A70", Offset = "0x2890070", VA = "0x182891A70", Slot = "42")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x28A1740", Offset = "0x289FD40", VA = "0x1828A1740", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x00004290 File Offset: 0x00002490
		[Token(Token = "0x17000110")]
		public override bool CanRead
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x28A17C0", Offset = "0x289FDC0", VA = "0x1828A17C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x17000111")]
		public override bool CanSeek
		{
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x000042C0 File Offset: 0x000024C0
		[Token(Token = "0x17000112")]
		public override bool CanWrite
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x28A1850", Offset = "0x289FE50", VA = "0x1828A1850", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x28A18E0", Offset = "0x289FEE0", VA = "0x1828A18E0", Slot = "21")]
		public override void Flush()
		{
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x17000113")]
		public override long Length
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x28A1960", Offset = "0x289FF60", VA = "0x1828A1960", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x000042F0 File Offset: 0x000024F0
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000114")]
		public override long Position
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x2891D00", Offset = "0x2890300", VA = "0x182891D00", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x28A19A0", Offset = "0x289FFA0", VA = "0x1828A19A0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00004308 File Offset: 0x00002508
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x28A19E0", Offset = "0x289FFE0", VA = "0x1828A19E0", Slot = "33")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x28A1A70", Offset = "0x28A0070", VA = "0x1828A1A70", Slot = "31")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x28A1AB0", Offset = "0x28A00B0", VA = "0x1828A1AB0", Slot = "32")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x28A1AF0", Offset = "0x28A00F0", VA = "0x1828A1AF0", Slot = "36")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x28A1B80", Offset = "0x28A0180", VA = "0x1828A1B80")]
		public static byte[] CompressString(string s)
		{
			return null;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x28A1CD0", Offset = "0x28A02D0", VA = "0x1828A1CD0")]
		public static byte[] CompressBuffer(byte[] b)
		{
			return null;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x28A1E20", Offset = "0x28A0420", VA = "0x1828A1E20")]
		public static string UncompressString(byte[] compressed)
		{
			return null;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x28A1F50", Offset = "0x28A0550", VA = "0x1828A1F50")]
		public static byte[] UncompressBuffer(byte[] compressed)
		{
			return null;
		}

		// Token: 0x0400039B RID: 923
		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x28")]
		internal ZlibBaseStream _baseStream;

		// Token: 0x0400039C RID: 924
		[Token(Token = "0x400039C")]
		[FieldOffset(Offset = "0x30")]
		private bool _disposed;
	}
}
