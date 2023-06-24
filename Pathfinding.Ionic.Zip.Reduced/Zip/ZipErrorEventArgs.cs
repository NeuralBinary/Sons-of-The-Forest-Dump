using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public class ZipErrorEventArgs : ZipProgressEventArgs
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x28507F0", Offset = "0x284EDF0", VA = "0x1828507F0")]
		private ZipErrorEventArgs()
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2851910", Offset = "0x284FF10", VA = "0x182851910")]
		internal static ZipErrorEventArgs Saving(string archiveName, ZipEntry entry, Exception exception)
		{
			return null;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x1700000B")]
		public Exception Exception
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x1700000C")]
		public string FileName
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x2851AB0", Offset = "0x28500B0", VA = "0x182851AB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x40")]
		private Exception _exc;
	}
}
