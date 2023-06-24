using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200019C RID: 412
	[Token(Token = "0x200019C")]
	public interface IMeshWriter
	{
		// Token: 0x06000B2B RID: 2859
		[Token(Token = "0x6000B2B")]
		IOWriteResult Write(TextWriter writer, List<WriteMesh> vMeshes, WriteOptions options);

		// Token: 0x06000B2C RID: 2860
		[Token(Token = "0x6000B2C")]
		IOWriteResult Write(BinaryWriter writer, List<WriteMesh> vMeshes, WriteOptions options);
	}
}
