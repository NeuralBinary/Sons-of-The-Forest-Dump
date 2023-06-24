using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public enum ZipProgressEventType
	{
		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		Adding_Started,
		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		Adding_AfterAddEntry,
		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		Adding_Completed,
		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		Reading_Started,
		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		Reading_BeforeReadEntry,
		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		Reading_AfterReadEntry,
		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		Reading_Completed,
		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		Reading_ArchiveBytesRead,
		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		Saving_Started,
		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		Saving_BeforeWriteEntry,
		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		Saving_AfterWriteEntry,
		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		Saving_Completed,
		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		Saving_AfterSaveTempArchive,
		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		Saving_BeforeRenameTempArchive,
		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		Saving_AfterRenameTempArchive,
		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		Saving_AfterCompileSelfExtractor,
		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		Saving_EntryBytesRead,
		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		Extracting_BeforeExtractEntry,
		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		Extracting_AfterExtractEntry,
		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		Extracting_ExtractEntryWouldOverwrite,
		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		Extracting_EntryBytesWritten,
		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		Extracting_BeforeExtractAll,
		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		Extracting_AfterExtractAll,
		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		Error_Saving
	}
}
