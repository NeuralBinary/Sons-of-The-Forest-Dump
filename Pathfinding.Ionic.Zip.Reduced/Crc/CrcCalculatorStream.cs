using System;
using System.IO;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Crc
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	public class CrcCalculatorStream : Stream, IDisposable
	{
		// Token: 0x0600049B RID: 1179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x28A2B80", Offset = "0x28A1180", VA = "0x1828A2B80")]
		public CrcCalculatorStream(Stream stream)
		{
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x28A2C00", Offset = "0x28A1200", VA = "0x1828A2C00")]
		public CrcCalculatorStream(Stream stream, bool leaveOpen)
		{
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x28A2C90", Offset = "0x28A1290", VA = "0x1828A2C90")]
		public CrcCalculatorStream(Stream stream, long length)
		{
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x28A2D10", Offset = "0x28A1310", VA = "0x1828A2D10")]
		public CrcCalculatorStream(Stream stream, long length, bool leaveOpen)
		{
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x28A2D90", Offset = "0x28A1390", VA = "0x1828A2D90")]
		public CrcCalculatorStream(Stream stream, long length, bool leaveOpen, CRC32 crc32)
		{
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x28A2E10", Offset = "0x28A1410", VA = "0x1828A2E10")]
		private CrcCalculatorStream(bool leaveOpen, long length, Stream stream, CRC32 crc32)
		{
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x660460", Offset = "0x65EA60", VA = "0x180660460", Slot = "6")]
		private void Dispose()
		{
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00004410 File Offset: 0x00002610
		[Token(Token = "0x17000117")]
		public long TotalBytesSlurped
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x28A2FC0", Offset = "0x28A15C0", VA = "0x1828A2FC0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00004428 File Offset: 0x00002628
		[Token(Token = "0x17000118")]
		public int Crc
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x28A2FE0", Offset = "0x28A15E0", VA = "0x1828A2FE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00004440 File Offset: 0x00002640
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000119")]
		public bool LeaveOpen
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x674880", Offset = "0x672E80", VA = "0x180674880")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x674890", Offset = "0x672E90", VA = "0x180674890")]
			set
			{
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00004458 File Offset: 0x00002658
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x28A3000", Offset = "0x28A1600", VA = "0x1828A3000", Slot = "33")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x28A3110", Offset = "0x28A1710", VA = "0x1828A3110", Slot = "36")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00004470 File Offset: 0x00002670
		[Token(Token = "0x1700011A")]
		public override bool CanRead
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x28590B0", Offset = "0x28576B0", VA = "0x1828590B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x00004488 File Offset: 0x00002688
		[Token(Token = "0x1700011B")]
		public override bool CanSeek
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x000044A0 File Offset: 0x000026A0
		[Token(Token = "0x1700011C")]
		public override bool CanWrite
		{
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x2859110", Offset = "0x2857710", VA = "0x182859110", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x2859140", Offset = "0x2857740", VA = "0x182859140", Slot = "21")]
		public override void Flush()
		{
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x000044B8 File Offset: 0x000026B8
		[Token(Token = "0x1700011D")]
		public override long Length
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x28A3190", Offset = "0x28A1790", VA = "0x1828A3190", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x000044D0 File Offset: 0x000026D0
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011E")]
		public override long Position
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x28A2FC0", Offset = "0x28A15C0", VA = "0x1828A2FC0", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x28A3230", Offset = "0x28A1830", VA = "0x1828A3230", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000044E8 File Offset: 0x000026E8
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x28A3270", Offset = "0x28A1870", VA = "0x1828A3270", Slot = "31")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x28A32B0", Offset = "0x28A18B0", VA = "0x1828A32B0", Slot = "32")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x28A32F0", Offset = "0x28A18F0", VA = "0x1828A32F0", Slot = "19")]
		public override void Close()
		{
		}

		// Token: 0x040003A3 RID: 931
		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly long UnsetLengthLimit;

		// Token: 0x040003A4 RID: 932
		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0x28")]
		internal Stream _innerStream;

		// Token: 0x040003A5 RID: 933
		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x30")]
		private CRC32 _Crc32;

		// Token: 0x040003A6 RID: 934
		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x38")]
		private long _lengthLimit;

		// Token: 0x040003A7 RID: 935
		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x40")]
		private bool _leaveOpen;
	}
}
