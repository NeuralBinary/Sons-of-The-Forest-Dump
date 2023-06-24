using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public class ExtractProgressEventArgs : ZipProgressEventArgs
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2851030", Offset = "0x284F630", VA = "0x182851030")]
		internal ExtractProgressEventArgs(string archiveName, bool before, int entriesTotal, int entriesExtracted, ZipEntry entry, string extractLocation)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2850900", Offset = "0x284EF00", VA = "0x182850900")]
		internal ExtractProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x28507F0", Offset = "0x284EDF0", VA = "0x1828507F0")]
		internal ExtractProgressEventArgs()
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2851130", Offset = "0x284F730", VA = "0x182851130")]
		internal static ExtractProgressEventArgs BeforeExtractEntry(string archiveName, ZipEntry entry, string extractLocation)
		{
			return null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x28512E0", Offset = "0x284F8E0", VA = "0x1828512E0")]
		internal static ExtractProgressEventArgs ExtractExisting(string archiveName, ZipEntry entry, string extractLocation)
		{
			return null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2851490", Offset = "0x284FA90", VA = "0x182851490")]
		internal static ExtractProgressEventArgs AfterExtractEntry(string archiveName, ZipEntry entry, string extractLocation)
		{
			return null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2851640", Offset = "0x284FC40", VA = "0x182851640")]
		internal static ExtractProgressEventArgs ExtractAllStarted(string archiveName, string extractLocation)
		{
			return null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2851700", Offset = "0x284FD00", VA = "0x182851700")]
		internal static ExtractProgressEventArgs ExtractAllCompleted(string archiveName, string extractLocation)
		{
			return null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x28517C0", Offset = "0x284FDC0", VA = "0x1828517C0")]
		internal static ExtractProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesWritten, long totalBytes)
		{
			return null;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x17000009")]
		public int EntriesExtracted
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x670F40", Offset = "0x66F540", VA = "0x180670F40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x1700000A")]
		public string ExtractLocation
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x40")]
		private int _entriesExtracted;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x48")]
		private string _target;
	}
}
