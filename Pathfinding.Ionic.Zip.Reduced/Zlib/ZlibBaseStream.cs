using System;
using System.IO;
using Il2CppDummyDll;
using Pathfinding.Ionic.Crc;

namespace Pathfinding.Ionic.Zlib
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	internal class ZlibBaseStream : Stream
	{
		// Token: 0x0600043E RID: 1086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x289DDC0", Offset = "0x289C3C0", VA = "0x18289DDC0")]
		public ZlibBaseStream(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen)
		{
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00003F78 File Offset: 0x00002178
		[Token(Token = "0x17000102")]
		internal int Crc32
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x289DFB0", Offset = "0x289C5B0", VA = "0x18289DFB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00003F90 File Offset: 0x00002190
		[Token(Token = "0x17000103")]
		protected internal bool _wantCompress
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x289DFC0", Offset = "0x289C5C0", VA = "0x18289DFC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000104")]
		private ZlibCodec z
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x289DFD0", Offset = "0x289C5D0", VA = "0x18289DFD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000105")]
		private byte[] workingBuffer
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x289E0F0", Offset = "0x289C6F0", VA = "0x18289E0F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x289E190", Offset = "0x289C790", VA = "0x18289E190", Slot = "36")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x289E590", Offset = "0x289CB90", VA = "0x18289E590")]
		private void finish()
		{
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x289EDD0", Offset = "0x289D3D0", VA = "0x18289EDD0")]
		private void end()
		{
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x289EF40", Offset = "0x289D540", VA = "0x18289EF40", Slot = "19")]
		public override void Close()
		{
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x287D640", Offset = "0x287BC40", VA = "0x18287D640", Slot = "21")]
		public override void Flush()
		{
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00003FA8 File Offset: 0x000021A8
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x289F1B0", Offset = "0x289D7B0", VA = "0x18289F1B0", Slot = "31")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x289F1F0", Offset = "0x289D7F0", VA = "0x18289F1F0", Slot = "32")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x289F220", Offset = "0x289D820", VA = "0x18289F220")]
		private string ReadZeroTerminatedString()
		{
			return null;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00003FC0 File Offset: 0x000021C0
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x289F430", Offset = "0x289DA30", VA = "0x18289F430")]
		private int _ReadAndValidateGzipHeader()
		{
			return 0;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00003FD8 File Offset: 0x000021D8
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x289F7D0", Offset = "0x289DDD0", VA = "0x18289F7D0", Slot = "33")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00003FF0 File Offset: 0x000021F0
		[Token(Token = "0x17000106")]
		public override bool CanRead
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x289FDE0", Offset = "0x289E3E0", VA = "0x18289FDE0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00004008 File Offset: 0x00002208
		[Token(Token = "0x17000107")]
		public override bool CanSeek
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x289FE10", Offset = "0x289E410", VA = "0x18289FE10", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00004020 File Offset: 0x00002220
		[Token(Token = "0x17000108")]
		public override bool CanWrite
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x289FE40", Offset = "0x289E440", VA = "0x18289FE40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00004038 File Offset: 0x00002238
		[Token(Token = "0x17000109")]
		public override long Length
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x287D670", Offset = "0x287BC70", VA = "0x18287D670", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00004050 File Offset: 0x00002250
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010A")]
		public override long Position
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x289FE70", Offset = "0x289E470", VA = "0x18289FE70", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x289FEB0", Offset = "0x289E4B0", VA = "0x18289FEB0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x289FEF0", Offset = "0x289E4F0", VA = "0x18289FEF0")]
		public static void CompressString(string s, Stream compressor)
		{
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x289FFF0", Offset = "0x289E5F0", VA = "0x18289FFF0")]
		public static void CompressBuffer(byte[] b, Stream compressor)
		{
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x28A00C0", Offset = "0x289E6C0", VA = "0x1828A00C0")]
		public static string UncompressString(byte[] compressed, Stream decompressor)
		{
			return null;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x28A0370", Offset = "0x289E970", VA = "0x1828A0370")]
		public static byte[] UncompressBuffer(byte[] compressed, Stream decompressor)
		{
			return null;
		}

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x28")]
		protected internal ZlibCodec _z;

		// Token: 0x0400036D RID: 877
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x30")]
		protected internal ZlibBaseStream.StreamMode _streamMode;

		// Token: 0x0400036E RID: 878
		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x34")]
		protected internal FlushType _flushMode;

		// Token: 0x0400036F RID: 879
		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x38")]
		protected internal ZlibStreamFlavor _flavor;

		// Token: 0x04000370 RID: 880
		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x3C")]
		protected internal CompressionMode _compressionMode;

		// Token: 0x04000371 RID: 881
		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x40")]
		protected internal CompressionLevel _level;

		// Token: 0x04000372 RID: 882
		[Token(Token = "0x4000372")]
		[FieldOffset(Offset = "0x44")]
		protected internal bool _leaveOpen;

		// Token: 0x04000373 RID: 883
		[Token(Token = "0x4000373")]
		[FieldOffset(Offset = "0x48")]
		protected internal byte[] _workingBuffer;

		// Token: 0x04000374 RID: 884
		[Token(Token = "0x4000374")]
		[FieldOffset(Offset = "0x50")]
		protected internal int _bufferSize;

		// Token: 0x04000375 RID: 885
		[Token(Token = "0x4000375")]
		[FieldOffset(Offset = "0x58")]
		protected internal byte[] _buf1;

		// Token: 0x04000376 RID: 886
		[Token(Token = "0x4000376")]
		[FieldOffset(Offset = "0x60")]
		protected internal Stream _stream;

		// Token: 0x04000377 RID: 887
		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x68")]
		protected internal CompressionStrategy Strategy;

		// Token: 0x04000378 RID: 888
		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x70")]
		private CRC32 crc;

		// Token: 0x04000379 RID: 889
		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x78")]
		protected internal string _GzipFileName;

		// Token: 0x0400037A RID: 890
		[Token(Token = "0x400037A")]
		[FieldOffset(Offset = "0x80")]
		protected internal string _GzipComment;

		// Token: 0x0400037B RID: 891
		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x88")]
		protected internal DateTime _GzipMtime;

		// Token: 0x0400037C RID: 892
		[Token(Token = "0x400037C")]
		[FieldOffset(Offset = "0x90")]
		protected internal int _gzipHeaderByteCount;

		// Token: 0x0400037D RID: 893
		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x94")]
		private bool nomoreinput;

		// Token: 0x02000067 RID: 103
		[Token(Token = "0x2000067")]
		internal enum StreamMode
		{
			// Token: 0x0400037F RID: 895
			[Token(Token = "0x400037F")]
			Writer,
			// Token: 0x04000380 RID: 896
			[Token(Token = "0x4000380")]
			Reader,
			// Token: 0x04000381 RID: 897
			[Token(Token = "0x4000381")]
			Undefined
		}
	}
}
