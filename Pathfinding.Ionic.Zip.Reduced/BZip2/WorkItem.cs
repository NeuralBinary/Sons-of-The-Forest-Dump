using System;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.BZip2
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	internal class WorkItem
	{
		// Token: 0x06000357 RID: 855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x28885C0", Offset = "0x2886BC0", VA = "0x1828885C0")]
		public WorkItem(int ix, int blockSize)
		{
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000358 RID: 856 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D7")]
		public BZip2Compressor Compressor
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x18")]
		public MemoryStream ms;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x20")]
		public int ordinal;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x28")]
		public BitWriter bw;
	}
}
