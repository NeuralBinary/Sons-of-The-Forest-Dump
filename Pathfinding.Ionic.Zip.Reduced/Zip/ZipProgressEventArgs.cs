using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public class ZipProgressEventArgs : EventArgs
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x28507F0", Offset = "0x284EDF0", VA = "0x1828507F0")]
		internal ZipProgressEventArgs()
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2850830", Offset = "0x284EE30", VA = "0x182850830")]
		internal ZipProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000020B8 File Offset: 0x000002B8
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public int EntriesTotal
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public ZipEntry CurrentEntry
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public bool Cancel
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x5FD560", Offset = "0x5FBB60", VA = "0x1805FD560")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x28508E0", Offset = "0x284EEE0", VA = "0x1828508E0")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000020E8 File Offset: 0x000002E8
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		public ZipProgressEventType EventType
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return ZipProgressEventType.Adding_Started;
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
			set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		public string ArchiveName
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002100 File Offset: 0x00000300
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		public long BytesTransferred
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x25A71E0", Offset = "0x25A57E0", VA = "0x1825A71E0")]
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002118 File Offset: 0x00000318
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000007")]
		public long TotalBytesToTransfer
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x75C1B0", Offset = "0x75A7B0", VA = "0x18075C1B0")]
			set
			{
			}
		}

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x10")]
		private int _entriesTotal;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x14")]
		private bool _cancel;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x18")]
		private ZipEntry _latestEntry;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x20")]
		private ZipProgressEventType _flavor;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x28")]
		private string _archiveName;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x30")]
		private long _bytesTransferred;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x38")]
		private long _totalBytesToTransfer;
	}
}
