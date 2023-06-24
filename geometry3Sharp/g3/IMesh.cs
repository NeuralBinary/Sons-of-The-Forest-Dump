using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000248 RID: 584
	[Token(Token = "0x2000248")]
	public interface IMesh : IPointSet
	{
		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060014DB RID: 5339
		[Token(Token = "0x1700034C")]
		int TriangleCount { [Token(Token = "0x60014DB")] get; }

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060014DC RID: 5340
		[Token(Token = "0x1700034D")]
		int MaxTriangleID { [Token(Token = "0x60014DC")] get; }

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060014DD RID: 5341
		[Token(Token = "0x1700034E")]
		bool HasVertexUVs { [Token(Token = "0x60014DD")] get; }

		// Token: 0x060014DE RID: 5342
		[Token(Token = "0x60014DE")]
		Vector2f GetVertexUV(int i);

		// Token: 0x060014DF RID: 5343
		[Token(Token = "0x60014DF")]
		NewVertexInfo GetVertexAll(int i);

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060014E0 RID: 5344
		[Token(Token = "0x1700034F")]
		bool HasTriangleGroups { [Token(Token = "0x60014E0")] get; }

		// Token: 0x060014E1 RID: 5345
		[Token(Token = "0x60014E1")]
		Index3i GetTriangle(int i);

		// Token: 0x060014E2 RID: 5346
		[Token(Token = "0x60014E2")]
		int GetTriangleGroup(int i);

		// Token: 0x060014E3 RID: 5347
		[Token(Token = "0x60014E3")]
		bool IsTriangle(int tID);

		// Token: 0x060014E4 RID: 5348
		[Token(Token = "0x60014E4")]
		IEnumerable<int> TriangleIndices();
	}
}
