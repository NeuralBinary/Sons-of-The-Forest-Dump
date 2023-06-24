using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public class ReadProgressEventArgs : ZipProgressEventArgs
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x28507F0", Offset = "0x284EDF0", VA = "0x1828507F0")]
		internal ReadProgressEventArgs()
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2850900", Offset = "0x284EF00", VA = "0x182850900")]
		private ReadProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2850910", Offset = "0x284EF10", VA = "0x182850910")]
		internal static ReadProgressEventArgs Before(string archiveName, int entriesTotal)
		{
			return null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2850990", Offset = "0x284EF90", VA = "0x182850990")]
		internal static ReadProgressEventArgs After(string archiveName, ZipEntry entry, int entriesTotal)
		{
			return null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2850A60", Offset = "0x284F060", VA = "0x182850A60")]
		internal static ReadProgressEventArgs Started(string archiveName)
		{
			return null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2850AC0", Offset = "0x284F0C0", VA = "0x182850AC0")]
		internal static ReadProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesXferred, long totalBytes)
		{
			return null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2850BA0", Offset = "0x284F1A0", VA = "0x182850BA0")]
		internal static ReadProgressEventArgs Completed(string archiveName)
		{
			return null;
		}
	}
}
