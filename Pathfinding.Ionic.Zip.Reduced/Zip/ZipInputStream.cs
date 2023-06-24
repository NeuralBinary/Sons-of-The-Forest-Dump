using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using Pathfinding.Ionic.Crc;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public class ZipInputStream : Stream
	{
		// Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x28790D0", Offset = "0x28776D0", VA = "0x1828790D0")]
		public ZipInputStream(Stream stream)
		{
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x2879140", Offset = "0x2877740", VA = "0x182879140")]
		public ZipInputStream(string fileName)
		{
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x28791D0", Offset = "0x28777D0", VA = "0x1828791D0")]
		public ZipInputStream(Stream stream, bool leaveOpen)
		{
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x2879250", Offset = "0x2877850", VA = "0x182879250")]
		private void _Init(Stream stream, bool leaveOpen, string name)
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x28794B0", Offset = "0x2877AB0", VA = "0x1828794B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000270 RID: 624 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008A")]
		public Encoding ProvisionalAlternateEncoding
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			set
			{
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00002F88 File Offset: 0x00001188
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008B")]
		public int CodecBufferSize
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0xAFF280", Offset = "0xAFD880", VA = "0x180AFF280")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000273")]
			[Address(RVA = "0xAFF290", Offset = "0xAFD890", VA = "0x180AFF290")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700008C RID: 140
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008C")]
		public string Password
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x2879530", Offset = "0x2877B30", VA = "0x182879530")]
			set
			{
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x28795E0", Offset = "0x2877BE0", VA = "0x1828795E0")]
		private void SetupStream()
		{
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000276 RID: 630 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x1700008D")]
		internal Stream ReadStream
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2879690", Offset = "0x2877C90", VA = "0x182879690", Slot = "33")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x2879880", Offset = "0x2877E80", VA = "0x182879880")]
		public ZipEntry GetNextEntry()
		{
			return null;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2879A20", Offset = "0x2878020", VA = "0x182879A20", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x1700008E")]
		public override bool CanRead
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x1700008F")]
		public override bool CanSeek
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x28590E0", Offset = "0x28576E0", VA = "0x1828590E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x17000090")]
		public override bool CanWrite
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x17000091")]
		public override long Length
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x2859170", Offset = "0x2857770", VA = "0x182859170", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00003018 File Offset: 0x00001218
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000092")]
		public override long Position
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x28591B0", Offset = "0x28577B0", VA = "0x1828591B0", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x2879A70", Offset = "0x2878070", VA = "0x182879A70", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2879A90", Offset = "0x2878090", VA = "0x182879A90", Slot = "21")]
		public override void Flush()
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2879AE0", Offset = "0x28780E0", VA = "0x182879AE0", Slot = "36")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2879B30", Offset = "0x2878130", VA = "0x182879B30", Slot = "31")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x2879B60", Offset = "0x2878160", VA = "0x182879B60", Slot = "32")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x28")]
		private Stream _inputStream;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x30")]
		private Encoding _provisionalAlternateEncoding;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x38")]
		private ZipEntry _currentEntry;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x40")]
		private bool _firstEntry;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x41")]
		private bool _needSetup;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x48")]
		private ZipContainer _container;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x50")]
		private CrcCalculatorStream _crcStream;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x58")]
		private long _LeftToRead;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x60")]
		internal string _Password;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x68")]
		private long _endOfEntry;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x70")]
		private string _name;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x78")]
		private bool _leaveUnderlyingStreamOpen;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x79")]
		private bool _closed;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x7A")]
		private bool _findRequired;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x7B")]
		private bool _exceptionPending;
	}
}
