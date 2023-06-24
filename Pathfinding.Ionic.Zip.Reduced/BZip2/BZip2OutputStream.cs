using System;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.BZip2
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	public class BZip2OutputStream : Stream
	{
		// Token: 0x06000338 RID: 824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x28872B0", Offset = "0x28858B0", VA = "0x1828872B0")]
		public BZip2OutputStream(Stream output)
		{
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x2887330", Offset = "0x2885930", VA = "0x182887330")]
		public BZip2OutputStream(Stream output, int blockSize)
		{
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x2887350", Offset = "0x2885950", VA = "0x182887350")]
		public BZip2OutputStream(Stream output, bool leaveOpen)
		{
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x28873E0", Offset = "0x28859E0", VA = "0x1828873E0")]
		public BZip2OutputStream(Stream output, int blockSize, bool leaveOpen)
		{
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x28877D0", Offset = "0x2885DD0", VA = "0x1828877D0", Slot = "19")]
		public override void Close()
		{
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x2887820", Offset = "0x2885E20", VA = "0x182887820", Slot = "21")]
		public override void Flush()
		{
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x2887880", Offset = "0x2885E80", VA = "0x182887880")]
		private void EmitHeader()
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x2887930", Offset = "0x2885F30", VA = "0x182887930")]
		private void EmitTrailer()
		{
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x2887A50", Offset = "0x2886050", VA = "0x182887A50")]
		private void Finish()
		{
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x170000CE")]
		public int BlockSize
		{
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x9AF280", Offset = "0x9AD880", VA = "0x1809AF280")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x2887D60", Offset = "0x2886360", VA = "0x182887D60", Slot = "36")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00003648 File Offset: 0x00001848
		[Token(Token = "0x170000CF")]
		public override bool CanRead
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00003660 File Offset: 0x00001860
		[Token(Token = "0x170000D0")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000345 RID: 837 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x170000D1")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x2888080", Offset = "0x2886680", VA = "0x182888080", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x170000D2")]
		public override long Length
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x2888100", Offset = "0x2886700", VA = "0x182888100", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000347 RID: 839 RVA: 0x000036A8 File Offset: 0x000018A8
		// (set) Token: 0x06000348 RID: 840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D3")]
		public override long Position
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x2888140", Offset = "0x2886740", VA = "0x182888140", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x2888150", Offset = "0x2886750", VA = "0x182888150", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x2888190", Offset = "0x2886790", VA = "0x182888190", Slot = "31")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x28881D0", Offset = "0x28867D0", VA = "0x1828881D0", Slot = "32")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000036D8 File Offset: 0x000018D8
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x2888210", Offset = "0x2886810", VA = "0x182888210", Slot = "33")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x2888250", Offset = "0x2886850", VA = "0x182888250")]
		[Conditional("Trace")]
		private void TraceOutput(BZip2OutputStream.TraceBits bits, string format, params object[] varParams)
		{
		}

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x28")]
		private int totalBytesWrittenIn;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x2C")]
		private bool leaveOpen;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x30")]
		private BZip2Compressor compressor;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x38")]
		private uint combinedCRC;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x40")]
		private Stream output;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x48")]
		private BitWriter bw;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x50")]
		private int blockSize100k;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x54")]
		private BZip2OutputStream.TraceBits desiredTrace;

		// Token: 0x02000044 RID: 68
		[Token(Token = "0x2000044")]
		[Flags]
		private enum TraceBits : uint
		{
			// Token: 0x040001F2 RID: 498
			[Token(Token = "0x40001F2")]
			None = 0U,
			// Token: 0x040001F3 RID: 499
			[Token(Token = "0x40001F3")]
			Crc = 1U,
			// Token: 0x040001F4 RID: 500
			[Token(Token = "0x40001F4")]
			Write = 2U,
			// Token: 0x040001F5 RID: 501
			[Token(Token = "0x40001F5")]
			All = 4294967295U
		}
	}
}
