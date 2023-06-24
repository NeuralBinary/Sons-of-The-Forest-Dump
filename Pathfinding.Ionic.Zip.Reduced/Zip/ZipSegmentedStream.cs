using System;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	internal class ZipSegmentedStream : Stream
	{
		// Token: 0x060002CF RID: 719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x287BE50", Offset = "0x287A450", VA = "0x18287BE50")]
		private ZipSegmentedStream()
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x287BEA0", Offset = "0x287A4A0", VA = "0x18287BEA0")]
		public static ZipSegmentedStream ForReading(string name, uint initialDiskNumber, uint maxDiskNumber)
		{
			return null;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x287C000", Offset = "0x287A600", VA = "0x18287C000")]
		public static ZipSegmentedStream ForWriting(string name, int maxSegmentSize)
		{
			return null;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x287C2B0", Offset = "0x287A8B0", VA = "0x18287C2B0")]
		public static Stream ForUpdate(string name, uint diskNumber)
		{
			return null;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00003300 File Offset: 0x00001500
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BC")]
		public bool ContiguousWrite
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x15771D0", Offset = "0x15757D0", VA = "0x1815771D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x15771E0", Offset = "0x15757E0", VA = "0x1815771E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00003318 File Offset: 0x00001518
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BD")]
		public uint CurrentSegment
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x9AF280", Offset = "0x9AD880", VA = "0x1809AF280")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x287C420", Offset = "0x287AA20", VA = "0x18287C420")]
			private set
			{
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x170000BE")]
		public string CurrentName
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x287C480", Offset = "0x287AA80", VA = "0x18287C480")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x170000BF")]
		public string CurrentTempName
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x287C4F0", Offset = "0x287AAF0", VA = "0x18287C4F0")]
		private string _NameForSegment(uint diskNumber)
		{
			return null;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x287C650", Offset = "0x287AC50", VA = "0x18287C650")]
		public uint ComputeSegment(int length)
		{
			return 0U;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x287C6A0", Offset = "0x287ACA0", VA = "0x18287C6A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x287C8A0", Offset = "0x287AEA0", VA = "0x18287C8A0")]
		private void _SetReadStream()
		{
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x287C9B0", Offset = "0x287AFB0", VA = "0x18287C9B0", Slot = "33")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x287CBA0", Offset = "0x287B1A0", VA = "0x18287CBA0")]
		private void _SetWriteStream(uint increment)
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x287CD60", Offset = "0x287B360", VA = "0x18287CD60", Slot = "36")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x287CF20", Offset = "0x287B520", VA = "0x18287CF20")]
		public long TruncateBackward(uint diskNumber, long offset)
		{
			return 0L;
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x170000C0")]
		public override bool CanRead
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x287D580", Offset = "0x287BB80", VA = "0x18287D580", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x170000C1")]
		public override bool CanSeek
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x287D5C0", Offset = "0x287BBC0", VA = "0x18287D5C0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x000033A8 File Offset: 0x000015A8
		[Token(Token = "0x170000C2")]
		public override bool CanWrite
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x287D600", Offset = "0x287BC00", VA = "0x18287D600", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x287D640", Offset = "0x287BC40", VA = "0x18287D640", Slot = "21")]
		public override void Flush()
		{
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x170000C3")]
		public override long Length
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x287D670", Offset = "0x287BC70", VA = "0x18287D670", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x000033D8 File Offset: 0x000015D8
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C4")]
		public override long Position
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x287D6A0", Offset = "0x287BCA0", VA = "0x18287D6A0", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x287D6D0", Offset = "0x287BCD0", VA = "0x18287D6D0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x287D700", Offset = "0x287BD00", VA = "0x18287D700", Slot = "31")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x287D730", Offset = "0x287BD30", VA = "0x18287D730", Slot = "32")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x287D7B0", Offset = "0x287BDB0", VA = "0x18287D7B0", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x28")]
		private ZipSegmentedStream.RwMode rwMode;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x2C")]
		private bool _exceptionPending;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x30")]
		private string _baseName;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x38")]
		private string _baseDir;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x40")]
		private string _currentName;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x48")]
		private string _currentTempName;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x50")]
		private uint _currentDiskNumber;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x54")]
		private uint _maxDiskNumber;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x58")]
		private int _maxSegmentSize;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x60")]
		private Stream _innerStream;

		// Token: 0x0200003C RID: 60
		[Token(Token = "0x200003C")]
		private enum RwMode
		{
			// Token: 0x04000170 RID: 368
			[Token(Token = "0x4000170")]
			None,
			// Token: 0x04000171 RID: 369
			[Token(Token = "0x4000171")]
			ReadOnly,
			// Token: 0x04000172 RID: 370
			[Token(Token = "0x4000172")]
			Write
		}
	}
}
