using System;
using System.IO;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000198 RID: 408
	[Token(Token = "0x2000198")]
	public interface IMeshReader
	{
		// Token: 0x06000B21 RID: 2849
		[Token(Token = "0x6000B21")]
		IOReadResult Read(TextReader reader, ReadOptions options, IMeshBuilder builder);

		// Token: 0x06000B22 RID: 2850
		[Token(Token = "0x6000B22")]
		IOReadResult Read(BinaryReader reader, ReadOptions options, IMeshBuilder builder);
	}
}
