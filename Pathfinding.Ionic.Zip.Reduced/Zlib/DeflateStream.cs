using System;
using System.IO;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	public class DeflateStream : Stream
	{
		// Token: 0x060003A8 RID: 936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x2891590", Offset = "0x288FB90", VA = "0x182891590")]
		public DeflateStream(Stream stream, CompressionMode mode)
		{
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x28915C0", Offset = "0x288FBC0", VA = "0x1828915C0")]
		public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level)
		{
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x28915E0", Offset = "0x288FBE0", VA = "0x1828915E0")]
		public DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x2891610", Offset = "0x288FC10", VA = "0x182891610")]
		public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
		{
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060003AC RID: 940 RVA: 0x000039C0 File Offset: 0x00001BC0
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E1")]
		public virtual FlushType FlushMode
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x2083910", Offset = "0x2081F10", VA = "0x182083910", Slot = "39")]
			get
			{
				return FlushType.None;
			}
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x2891780", Offset = "0x288FD80", VA = "0x182891780", Slot = "40")]
			set
			{
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003AE RID: 942 RVA: 0x000039D8 File Offset: 0x00001BD8
		// (set) Token: 0x060003AF RID: 943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E2")]
		public int BufferSize
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x2891800", Offset = "0x288FE00", VA = "0x182891800")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x2891820", Offset = "0x288FE20", VA = "0x182891820")]
			set
			{
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x000039F0 File Offset: 0x00001BF0
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E3")]
		public CompressionStrategy Strategy
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x28919A0", Offset = "0x288FFA0", VA = "0x1828919A0")]
			get
			{
				return CompressionStrategy.Default;
			}
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x28919C0", Offset = "0x288FFC0", VA = "0x1828919C0")]
			set
			{
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00003A08 File Offset: 0x00001C08
		[Token(Token = "0x170000E4")]
		public virtual long TotalIn
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x2891A40", Offset = "0x2890040", VA = "0x182891A40", Slot = "41")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00003A20 File Offset: 0x00001C20
		[Token(Token = "0x170000E5")]
		public virtual long TotalOut
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x2891A70", Offset = "0x2890070", VA = "0x182891A70", Slot = "42")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x2891AA0", Offset = "0x28900A0", VA = "0x182891AA0", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00003A38 File Offset: 0x00001C38
		[Token(Token = "0x170000E6")]
		public override bool CanRead
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x2891B20", Offset = "0x2890120", VA = "0x182891B20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x170000E7")]
		public override bool CanSeek
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x170000E8")]
		public override bool CanWrite
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x2891BB0", Offset = "0x28901B0", VA = "0x182891BB0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x2891C40", Offset = "0x2890240", VA = "0x182891C40", Slot = "21")]
		public override void Flush()
		{
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x170000E9")]
		public override long Length
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x2891CC0", Offset = "0x28902C0", VA = "0x182891CC0", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00003A98 File Offset: 0x00001C98
		// (set) Token: 0x060003BB RID: 955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EA")]
		public override long Position
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x2891D00", Offset = "0x2890300", VA = "0x182891D00", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x2891D50", Offset = "0x2890350", VA = "0x182891D50", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x2891D90", Offset = "0x2890390", VA = "0x182891D90", Slot = "33")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x2891E20", Offset = "0x2890420", VA = "0x182891E20", Slot = "31")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x2891E60", Offset = "0x2890460", VA = "0x182891E60", Slot = "32")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x2891EA0", Offset = "0x28904A0", VA = "0x182891EA0", Slot = "36")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x2891F30", Offset = "0x2890530", VA = "0x182891F30")]
		public static byte[] CompressString(string s)
		{
			return null;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x2892080", Offset = "0x2890680", VA = "0x182892080")]
		public static byte[] CompressBuffer(byte[] b)
		{
			return null;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x28921D0", Offset = "0x28907D0", VA = "0x1828921D0")]
		public static string UncompressString(byte[] compressed)
		{
			return null;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x2892300", Offset = "0x2890900", VA = "0x182892300")]
		public static byte[] UncompressBuffer(byte[] compressed)
		{
			return null;
		}

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x28")]
		internal ZlibBaseStream _baseStream;

		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x30")]
		internal Stream _innerStream;

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x38")]
		private bool _disposed;
	}
}
