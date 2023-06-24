using System;
using Il2CppDummyDll;

namespace TriangleNet.IO
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	public interface IFileFormat
	{
		// Token: 0x06000302 RID: 770
		[Token(Token = "0x6000302")]
		bool IsSupported(string file);
	}
}
