using System;
using System.IO;
using Il2CppDummyDll;
using TriangleNet.Meshing;

namespace TriangleNet.IO
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	public interface IMeshFormat : IFileFormat
	{
		// Token: 0x06000303 RID: 771
		[Token(Token = "0x6000303")]
		IMesh Import(string filename);

		// Token: 0x06000304 RID: 772
		[Token(Token = "0x6000304")]
		void Write(IMesh mesh, string filename);

		// Token: 0x06000305 RID: 773
		[Token(Token = "0x6000305")]
		void Write(IMesh mesh, Stream stream);
	}
}
