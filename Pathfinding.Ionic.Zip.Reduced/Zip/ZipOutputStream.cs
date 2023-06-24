using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using Pathfinding.Ionic.Crc;
using Pathfinding.Ionic.Zlib;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	public class ZipOutputStream : Stream
	{
		// Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x2879BA0", Offset = "0x28781A0", VA = "0x182879BA0")]
		public ZipOutputStream(Stream stream)
		{
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x2879C70", Offset = "0x2878270", VA = "0x182879C70")]
		public ZipOutputStream(string fileName)
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x2879D50", Offset = "0x2878350", VA = "0x182879D50")]
		public ZipOutputStream(Stream stream, bool leaveOpen)
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x2879E30", Offset = "0x2878430", VA = "0x182879E30")]
		private void _Init(Stream stream, bool leaveOpen, string name)
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x287A0D0", Offset = "0x28786D0", VA = "0x18287A0D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x17000093 RID: 147
		// (set) Token: 0x06000289 RID: 649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000093")]
		public string Password
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x287A150", Offset = "0x2878750", VA = "0x18287A150")]
			set
			{
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00003048 File Offset: 0x00001248
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000094")]
		public EncryptionAlgorithm Encryption
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			get
			{
				return EncryptionAlgorithm.None;
			}
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x287A230", Offset = "0x2878830", VA = "0x18287A230")]
			set
			{
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00003060 File Offset: 0x00001260
		// (set) Token: 0x0600028D RID: 653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000095")]
		public int CodecBufferSize
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0xAFF400", Offset = "0xAFDA00", VA = "0x180AFF400")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600028D")]
			[Address(RVA = "0xAFF410", Offset = "0xAFDA10", VA = "0x180AFF410")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00003078 File Offset: 0x00001278
		// (set) Token: 0x0600028F RID: 655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000096")]
		public CompressionStrategy Strategy
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0xAFF420", Offset = "0xAFDA20", VA = "0x180AFF420")]
			[CompilerGenerated]
			get
			{
				return CompressionStrategy.Default;
			}
			[Token(Token = "0x600028F")]
			[Address(RVA = "0xAFF430", Offset = "0xAFDA30", VA = "0x180AFF430")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00003090 File Offset: 0x00001290
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000097")]
		public ZipEntryTimestamp Timestamp
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x674020", Offset = "0x672620", VA = "0x180674020")]
			get
			{
				return ZipEntryTimestamp.None;
			}
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x287A2F0", Offset = "0x28788F0", VA = "0x18287A2F0")]
			set
			{
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000292 RID: 658 RVA: 0x000030A8 File Offset: 0x000012A8
		// (set) Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000098")]
		public CompressionLevel CompressionLevel
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0xAFF440", Offset = "0xAFDA40", VA = "0x180AFF440")]
			[CompilerGenerated]
			get
			{
				return CompressionLevel.None;
			}
			[Token(Token = "0x6000293")]
			[Address(RVA = "0xAFF450", Offset = "0xAFDA50", VA = "0x180AFF450")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000294 RID: 660 RVA: 0x000030C0 File Offset: 0x000012C0
		// (set) Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000099")]
		public CompressionMethod CompressionMethod
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0xAFF460", Offset = "0xAFDA60", VA = "0x180AFF460")]
			[CompilerGenerated]
			get
			{
				return CompressionMethod.None;
			}
			[Token(Token = "0x6000295")]
			[Address(RVA = "0xAFF470", Offset = "0xAFDA70", VA = "0x180AFF470")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000296 RID: 662 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000297 RID: 663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009A")]
		public string Comment
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x287A360", Offset = "0x2878960", VA = "0x18287A360")]
			set
			{
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000298 RID: 664 RVA: 0x000030D8 File Offset: 0x000012D8
		// (set) Token: 0x06000299 RID: 665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009B")]
		public Zip64Option EnableZip64
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x9AF280", Offset = "0x9AD880", VA = "0x1809AF280")]
			get
			{
				return Zip64Option.Default;
			}
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x287A410", Offset = "0x2878A10", VA = "0x18287A410")]
			set
			{
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600029A RID: 666 RVA: 0x000030F0 File Offset: 0x000012F0
		[Token(Token = "0x1700009C")]
		public bool OutputUsedZip64
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x287A480", Offset = "0x2878A80", VA = "0x18287A480")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00003108 File Offset: 0x00001308
		// (set) Token: 0x0600029C RID: 668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009D")]
		public bool IgnoreCase
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x287A4A0", Offset = "0x2878AA0", VA = "0x18287A4A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x287A4B0", Offset = "0x2878AB0", VA = "0x18287A4B0")]
			set
			{
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00003120 File Offset: 0x00001320
		// (set) Token: 0x0600029E RID: 670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009E")]
		[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete. It will be removed in a future version of the library. Use AlternateEncoding and AlternateEncodingUsage instead.")]
		public bool UseUnicodeAsNecessary
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x287A4C0", Offset = "0x2878AC0", VA = "0x18287A4C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x287A500", Offset = "0x2878B00", VA = "0x18287A500")]
			set
			{
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600029F RID: 671 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009F")]
		[Obsolete("use AlternateEncoding and AlternateEncodingUsage instead.")]
		public Encoding ProvisionalAlternateEncoding
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x287A5E0", Offset = "0x2878BE0", VA = "0x18287A5E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x287A5F0", Offset = "0x2878BF0", VA = "0x18287A5F0")]
			set
			{
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A0")]
		public Encoding AlternateEncoding
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x675FB0", Offset = "0x6745B0", VA = "0x180675FB0")]
			set
			{
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00003138 File Offset: 0x00001338
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A1")]
		public ZipOption AlternateEncodingUsage
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x245D8C0", Offset = "0x245BEC0", VA = "0x18245D8C0")]
			get
			{
				return ZipOption.Default;
			}
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x287A660", Offset = "0x2878C60", VA = "0x18287A660")]
			set
			{
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x170000A2")]
		public static Encoding DefaultEncoding
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x8FEB60", Offset = "0x8FD160", VA = "0x1808FEB60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00003150 File Offset: 0x00001350
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A3")]
		public long ParallelDeflateThreshold
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x671190", Offset = "0x66F790", VA = "0x180671190")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x287A670", Offset = "0x2878C70", VA = "0x18287A670")]
			set
			{
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00003168 File Offset: 0x00001368
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A4")]
		public int ParallelDeflateMaxBufferPairs
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0xAFF3E0", Offset = "0xAFD9E0", VA = "0x180AFF3E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x287A6F0", Offset = "0x2878CF0", VA = "0x18287A6F0")]
			set
			{
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x287A780", Offset = "0x2878D80", VA = "0x18287A780")]
		private void InsureUniqueEntry(ZipEntry ze1)
		{
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002AB RID: 683 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x170000A5")]
		internal Stream OutputStream
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002AC RID: 684 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x170000A6")]
		internal string Name
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x737420", Offset = "0x735A20", VA = "0x180737420")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00003180 File Offset: 0x00001380
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x287A870", Offset = "0x2878E70", VA = "0x18287A870")]
		public bool ContainsEntry(string name)
		{
			return default(bool);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x287A910", Offset = "0x2878F10", VA = "0x18287A910", Slot = "36")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x287AAE0", Offset = "0x28790E0", VA = "0x18287AAE0")]
		public ZipEntry PutNextEntry(string entryName)
		{
			return null;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x287AFA0", Offset = "0x28795A0", VA = "0x18287AFA0")]
		private void _InitiateCurrentEntry(bool finishing)
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x287B140", Offset = "0x2879740", VA = "0x18287B140")]
		private void _FinishCurrentEntry()
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x287B3C0", Offset = "0x28799C0", VA = "0x18287B3C0", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00003198 File Offset: 0x00001398
		[Token(Token = "0x170000A7")]
		public override bool CanRead
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x000031B0 File Offset: 0x000013B0
		[Token(Token = "0x170000A8")]
		public override bool CanSeek
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x170000A9")]
		public override bool CanWrite
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x170000AA")]
		public override long Length
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x287B560", Offset = "0x2879B60", VA = "0x18287B560", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x000031F8 File Offset: 0x000013F8
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AB")]
		public override long Position
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x287B5A0", Offset = "0x2879BA0", VA = "0x18287B5A0", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x287B5D0", Offset = "0x2879BD0", VA = "0x18287B5D0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "21")]
		public override void Flush()
		{
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x287B610", Offset = "0x2879C10", VA = "0x18287B610", Slot = "33")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x287B660", Offset = "0x2879C60", VA = "0x18287B660", Slot = "31")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x287B6B0", Offset = "0x2879CB0", VA = "0x18287B6B0", Slot = "32")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x28")]
		private EncryptionAlgorithm _encryption;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x2C")]
		private ZipEntryTimestamp _timestamp;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x30")]
		internal string _password;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x38")]
		private string _comment;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x40")]
		private Stream _outputStream;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x48")]
		private ZipEntry _currentEntry;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x50")]
		internal Zip64Option _zip64;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, ZipEntry> _entriesWritten;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x60")]
		private int _entryCount;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x64")]
		private ZipOption _alternateEncodingUsage;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x68")]
		private Encoding _alternateEncoding;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x70")]
		private bool _leaveUnderlyingStreamOpen;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x71")]
		private bool _disposed;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x72")]
		private bool _exceptionPending;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x73")]
		private bool _anyEntriesUsedZip64;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x74")]
		private bool _directoryNeededZip64;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x78")]
		private CountingStream _outputCounter;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x80")]
		private Stream _encryptor;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x88")]
		private Stream _deflater;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x90")]
		private CrcCalculatorStream _entryOutputStream;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x98")]
		private bool _needToWriteEntryHeader;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0xA0")]
		private string _name;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0xA8")]
		private bool _DontIgnoreCase;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0xB0")]
		internal ParallelDeflateOutputStream ParallelDeflater;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0xB8")]
		private long _ParallelDeflateThreshold;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0xC0")]
		private int _maxBufferPairs;
	}
}
