using System;
using System.IO;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	internal class OffsetStream : Stream, IDisposable
	{
		// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2856ED0", Offset = "0x28554D0", VA = "0x182856ED0")]
		public OffsetStream(Stream s)
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x660460", Offset = "0x65EA60", VA = "0x180660460", Slot = "6")]
		private void Dispose()
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2856FA0", Offset = "0x28555A0", VA = "0x182856FA0", Slot = "33")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2856FD0", Offset = "0x28555D0", VA = "0x182856FD0", Slot = "36")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x17000013")]
		public override bool CanRead
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x22AAC30", Offset = "0x22A9230", VA = "0x1822AAC30", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x17000014")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x2857010", Offset = "0x2855610", VA = "0x182857010", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x17000015")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2857040", Offset = "0x2855640", VA = "0x182857040", Slot = "21")]
		public override void Flush()
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x17000016")]
		public override long Length
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x22AAC00", Offset = "0x22A9200", VA = "0x1822AAC00", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002370 File Offset: 0x00000570
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		public override long Position
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x2857070", Offset = "0x2855670", VA = "0x182857070", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x28570B0", Offset = "0x28556B0", VA = "0x1828570B0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x28570F0", Offset = "0x28556F0", VA = "0x1828570F0", Slot = "31")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2857130", Offset = "0x2855730", VA = "0x182857130", Slot = "32")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2857170", Offset = "0x2855770", VA = "0x182857170", Slot = "19")]
		public override void Close()
		{
		}

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x28")]
		private long _originalPosition;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x30")]
		private Stream _innerStream;
	}
}
