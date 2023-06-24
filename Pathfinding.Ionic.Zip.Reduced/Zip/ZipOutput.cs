using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	internal static class ZipOutput
	{
		// Token: 0x06000266 RID: 614 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x2877B00", Offset = "0x2876100", VA = "0x182877B00")]
		public static bool WriteCentralDirectoryStructure(Stream s, ICollection<ZipEntry> entries, uint numSegments, Zip64Option zip64, string comment, ZipContainer container)
		{
			return default(bool);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x28784B0", Offset = "0x2876AB0", VA = "0x1828784B0")]
		private static Encoding GetEncoding(ZipContainer container, string t)
		{
			return null;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2878640", Offset = "0x2876C40", VA = "0x182878640")]
		private static byte[] GenCentralDirectoryFooter(long StartOfCentralDirectory, long EndOfCentralDirectory, Zip64Option zip64, int entryCount, string comment, ZipContainer container)
		{
			return null;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x2878A10", Offset = "0x2877010", VA = "0x182878A10")]
		private static byte[] GenZip64EndOfCentralDirectory(long StartOfCentralDirectory, long EndOfCentralDirectory, int entryCount, uint numSegments)
		{
			return null;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2878F00", Offset = "0x2877500", VA = "0x182878F00")]
		private static int CountEntries(ICollection<ZipEntry> _entries)
		{
			return 0;
		}
	}
}
