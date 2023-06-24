using System;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public class GZipStream : Stream
	{
		// Token: 0x060003C4 RID: 964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x2892430", Offset = "0x2890A30", VA = "0x182892430")]
		public GZipStream(Stream stream, CompressionMode mode)
		{
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x2892460", Offset = "0x2890A60", VA = "0x182892460")]
		public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level)
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x2892480", Offset = "0x2890A80", VA = "0x182892480")]
		public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x28924B0", Offset = "0x2890AB0", VA = "0x1828924B0")]
		public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
		{
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x060003CA RID: 970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EB")]
		public string Comment
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x28926B0", Offset = "0x2890CB0", VA = "0x1828926B0")]
			set
			{
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003CB RID: 971 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EC")]
		public string FileName
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x2892760", Offset = "0x2890D60", VA = "0x182892760")]
			set
			{
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Token(Token = "0x170000ED")]
		public int Crc32
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x75C1D0", Offset = "0x75A7D0", VA = "0x18075C1D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00003AF8 File Offset: 0x00001CF8
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EE")]
		public virtual FlushType FlushMode
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x2892980", Offset = "0x2890F80", VA = "0x182892980", Slot = "39")]
			get
			{
				return FlushType.None;
			}
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x28929A0", Offset = "0x2890FA0", VA = "0x1828929A0", Slot = "40")]
			set
			{
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00003B10 File Offset: 0x00001D10
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EF")]
		public int BufferSize
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x2892A20", Offset = "0x2891020", VA = "0x182892A20")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x2892A40", Offset = "0x2891040", VA = "0x182892A40")]
			set
			{
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00003B28 File Offset: 0x00001D28
		[Token(Token = "0x170000F0")]
		public virtual long TotalIn
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x2892BC0", Offset = "0x28911C0", VA = "0x182892BC0", Slot = "41")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00003B40 File Offset: 0x00001D40
		[Token(Token = "0x170000F1")]
		public virtual long TotalOut
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x2892BF0", Offset = "0x28911F0", VA = "0x182892BF0", Slot = "42")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x2892C20", Offset = "0x2891220", VA = "0x182892C20", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00003B58 File Offset: 0x00001D58
		[Token(Token = "0x170000F2")]
		public override bool CanRead
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x2892CC0", Offset = "0x28912C0", VA = "0x182892CC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x170000F3")]
		public override bool CanSeek
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x170000F4")]
		public override bool CanWrite
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x2892D50", Offset = "0x2891350", VA = "0x182892D50", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x2892DE0", Offset = "0x28913E0", VA = "0x182892DE0", Slot = "21")]
		public override void Flush()
		{
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x170000F5")]
		public override long Length
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x2892E60", Offset = "0x2891460", VA = "0x182892E60", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00003BB8 File Offset: 0x00001DB8
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F6")]
		public override long Position
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x2892EA0", Offset = "0x28914A0", VA = "0x182892EA0", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x2892F00", Offset = "0x2891500", VA = "0x182892F00", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00003BD0 File Offset: 0x00001DD0
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x2892F40", Offset = "0x2891540", VA = "0x182892F40", Slot = "33")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x28930C0", Offset = "0x28916C0", VA = "0x1828930C0", Slot = "31")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x2893100", Offset = "0x2891700", VA = "0x182893100", Slot = "32")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x2893140", Offset = "0x2891740", VA = "0x182893140", Slot = "36")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x2893260", Offset = "0x2891860", VA = "0x182893260")]
		private int EmitHeader()
		{
			return 0;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x2893660", Offset = "0x2891C60", VA = "0x182893660")]
		public static byte[] CompressString(string s)
		{
			return null;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x28937B0", Offset = "0x2891DB0", VA = "0x1828937B0")]
		public static byte[] CompressBuffer(byte[] b)
		{
			return null;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x2893900", Offset = "0x2891F00", VA = "0x182893900")]
		public static string UncompressString(byte[] compressed)
		{
			return null;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x2893A30", Offset = "0x2892030", VA = "0x182893A30")]
		public static byte[] UncompressBuffer(byte[] compressed)
		{
			return null;
		}

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x28")]
		public DateTime? LastModified;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x38")]
		private int _headerByteCount;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x40")]
		internal ZlibBaseStream _baseStream;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x48")]
		private bool _disposed;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x49")]
		private bool _firstReadDone;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x50")]
		private string _FileName;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x58")]
		private string _Comment;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x60")]
		private int _Crc32;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly DateTime _unixEpoch;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly Encoding iso8859dash1;
	}
}
