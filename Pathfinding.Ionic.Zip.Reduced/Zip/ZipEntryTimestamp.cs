using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	[Flags]
	public enum ZipEntryTimestamp
	{
		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		None = 0,
		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		DOS = 1,
		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		Windows = 2,
		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		Unix = 4,
		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		InfoZip1 = 8
	}
}
