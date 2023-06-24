using System;
using Il2CppDummyDll;

namespace TriangleNet.Geometry
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	public interface IEdge
	{
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000358 RID: 856
		[Token(Token = "0x17000092")]
		int P0 { [Token(Token = "0x6000358")] get; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000359 RID: 857
		[Token(Token = "0x17000093")]
		int P1 { [Token(Token = "0x6000359")] get; }

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600035A RID: 858
		[Token(Token = "0x17000094")]
		int Label { [Token(Token = "0x600035A")] get; }
	}
}
