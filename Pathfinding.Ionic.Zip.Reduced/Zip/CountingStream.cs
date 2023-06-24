using System;
using System.IO;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public class CountingStream : Stream
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2858E50", Offset = "0x2857450", VA = "0x182858E50")]
		public CountingStream(Stream stream)
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000018")]
		public Stream WrappedStream
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x17000019")]
		public long BytesWritten
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x1700001A")]
		public long BytesRead
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2858F40", Offset = "0x2857540", VA = "0x182858F40")]
		public void Adjust(long delta)
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2859020", Offset = "0x2857620", VA = "0x182859020", Slot = "33")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2859060", Offset = "0x2857660", VA = "0x182859060", Slot = "36")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x1700001B")]
		public override bool CanRead
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x28590B0", Offset = "0x28576B0", VA = "0x1828590B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x1700001C")]
		public override bool CanSeek
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x28590E0", Offset = "0x28576E0", VA = "0x1828590E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x1700001D")]
		public override bool CanWrite
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x2859110", Offset = "0x2857710", VA = "0x182859110", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2859140", Offset = "0x2857740", VA = "0x182859140", Slot = "21")]
		public override void Flush()
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x1700001E")]
		public override long Length
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x2859170", Offset = "0x2857770", VA = "0x182859170", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x1700001F")]
		public long ComputedPosition
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x28591A0", Offset = "0x28577A0", VA = "0x1828591A0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00002568 File Offset: 0x00000768
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000020")]
		public override long Position
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x28591B0", Offset = "0x28577B0", VA = "0x1828591B0", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x28591E0", Offset = "0x28577E0", VA = "0x1828591E0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2859210", Offset = "0x2857810", VA = "0x182859210", Slot = "31")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2859240", Offset = "0x2857840", VA = "0x182859240", Slot = "32")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x28")]
		private Stream _s;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x30")]
		private long _bytesWritten;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x38")]
		private long _bytesRead;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x40")]
		private long _initialOffset;
	}
}
