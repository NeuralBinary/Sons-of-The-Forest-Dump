using System;
using System.IO;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	internal class ZipCipherStream : Stream
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2859CC0", Offset = "0x28582C0", VA = "0x182859CC0")]
		public ZipCipherStream(Stream s, ZipCrypto cipher, CryptoMode mode)
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2859DE0", Offset = "0x28583E0", VA = "0x182859DE0", Slot = "33")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2859F90", Offset = "0x2858590", VA = "0x182859F90", Slot = "36")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x17000022")]
		public override bool CanRead
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x620330", Offset = "0x61E930", VA = "0x180620330", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x17000023")]
		public override bool CanSeek
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x17000024")]
		public override bool CanWrite
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x285A130", Offset = "0x2858730", VA = "0x18285A130", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "21")]
		public override void Flush()
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x17000025")]
		public override long Length
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x285A140", Offset = "0x2858740", VA = "0x18285A140", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00002628 File Offset: 0x00000828
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000026")]
		public override long Position
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x285A180", Offset = "0x2858780", VA = "0x18285A180", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x285A1C0", Offset = "0x28587C0", VA = "0x18285A1C0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x285A200", Offset = "0x2858800", VA = "0x18285A200", Slot = "31")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x285A240", Offset = "0x2858840", VA = "0x18285A240", Slot = "32")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x28")]
		private ZipCrypto _cipher;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x30")]
		private Stream _s;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x38")]
		private CryptoMode _mode;
	}
}
