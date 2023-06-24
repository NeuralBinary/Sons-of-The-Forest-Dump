using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public class SaveProgressEventArgs : ZipProgressEventArgs
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2850D90", Offset = "0x284F390", VA = "0x182850D90")]
		internal SaveProgressEventArgs(string archiveName, bool before, int entriesTotal, int entriesSaved, ZipEntry entry)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x28507F0", Offset = "0x284EDF0", VA = "0x1828507F0")]
		internal SaveProgressEventArgs()
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2850900", Offset = "0x284EF00", VA = "0x182850900")]
		internal SaveProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2850E20", Offset = "0x284F420", VA = "0x182850E20")]
		internal static SaveProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesXferred, long totalBytes)
		{
			return null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2850F70", Offset = "0x284F570", VA = "0x182850F70")]
		internal static SaveProgressEventArgs Started(string archiveName)
		{
			return null;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2850FD0", Offset = "0x284F5D0", VA = "0x182850FD0")]
		internal static SaveProgressEventArgs Completed(string archiveName)
		{
			return null;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x17000008")]
		public int EntriesSaved
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x670F40", Offset = "0x66F540", VA = "0x180670F40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x40")]
		private int _entriesSaved;
	}
}
