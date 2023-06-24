using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000247 RID: 583
	[Token(Token = "0x2000247")]
	public interface IPointSet
	{
		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060014D1 RID: 5329
		[Token(Token = "0x17000347")]
		int VertexCount { [Token(Token = "0x60014D1")] get; }

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060014D2 RID: 5330
		[Token(Token = "0x17000348")]
		int MaxVertexID { [Token(Token = "0x60014D2")] get; }

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060014D3 RID: 5331
		[Token(Token = "0x17000349")]
		bool HasVertexNormals { [Token(Token = "0x60014D3")] get; }

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060014D4 RID: 5332
		[Token(Token = "0x1700034A")]
		bool HasVertexColors { [Token(Token = "0x60014D4")] get; }

		// Token: 0x060014D5 RID: 5333
		[Token(Token = "0x60014D5")]
		Vector3d GetVertex(int i);

		// Token: 0x060014D6 RID: 5334
		[Token(Token = "0x60014D6")]
		Vector3f GetVertexNormal(int i);

		// Token: 0x060014D7 RID: 5335
		[Token(Token = "0x60014D7")]
		Vector3f GetVertexColor(int i);

		// Token: 0x060014D8 RID: 5336
		[Token(Token = "0x60014D8")]
		bool IsVertex(int vID);

		// Token: 0x060014D9 RID: 5337
		[Token(Token = "0x60014D9")]
		IEnumerable<int> VertexIndices();

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060014DA RID: 5338
		[Token(Token = "0x1700034B")]
		int Timestamp { [Token(Token = "0x60014DA")] get; }
	}
}
