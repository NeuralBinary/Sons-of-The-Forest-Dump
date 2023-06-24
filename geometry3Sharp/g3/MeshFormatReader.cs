using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001A6 RID: 422
	[Token(Token = "0x20001A6")]
	public interface MeshFormatReader
	{
		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000B6A RID: 2922
		[Token(Token = "0x17000203")]
		List<string> SupportedExtensions { [Token(Token = "0x6000B6A")] get; }

		// Token: 0x06000B6B RID: 2923
		[Token(Token = "0x6000B6B")]
		IOReadResult ReadFile(string sFilename, IMeshBuilder builder, ReadOptions options, ParsingMessagesHandler warnings);

		// Token: 0x06000B6C RID: 2924
		[Token(Token = "0x6000B6C")]
		IOReadResult ReadFile(Stream stream, IMeshBuilder builder, ReadOptions options, ParsingMessagesHandler warnings);
	}
}
