using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public class AddProgressEventArgs : ZipProgressEventArgs
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x28507F0", Offset = "0x284EDF0", VA = "0x1828507F0")]
		internal AddProgressEventArgs()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2850900", Offset = "0x284EF00", VA = "0x182850900")]
		private AddProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2850C00", Offset = "0x284F200", VA = "0x182850C00")]
		internal static AddProgressEventArgs AfterEntry(string archiveName, ZipEntry entry, int entriesTotal)
		{
			return null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2850CD0", Offset = "0x284F2D0", VA = "0x182850CD0")]
		internal static AddProgressEventArgs Started(string archiveName)
		{
			return null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2850D30", Offset = "0x284F330", VA = "0x182850D30")]
		internal static AddProgressEventArgs Completed(string archiveName)
		{
			return null;
		}
	}
}
