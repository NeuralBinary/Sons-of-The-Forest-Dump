using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	internal static class ZipConstants
	{
		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		public const uint PackedToRemovableMedia = 808471376U;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		public const uint Zip64EndOfCentralDirectoryRecordSignature = 101075792U;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		public const uint Zip64EndOfCentralDirectoryLocatorSignature = 117853008U;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		public const uint EndOfCentralDirectorySignature = 101010256U;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		public const int ZipEntrySignature = 67324752;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		public const int ZipEntryDataDescriptorSignature = 134695760;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		public const int SplitArchiveSignature = 134695760;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		public const int ZipDirEntrySignature = 33639248;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		public const int AesKeySize = 192;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		public const int AesBlockSize = 128;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		public const ushort AesAlgId128 = 26126;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		public const ushort AesAlgId192 = 26127;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		public const ushort AesAlgId256 = 26128;
	}
}
