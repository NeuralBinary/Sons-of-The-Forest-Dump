using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace NWH.DWP2.MiConvexHull
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	public interface ITriangulation<TVertex, TCell> where TVertex : IVertex where TCell : TriangulationCell<TVertex, TCell>, new()
	{
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000209 RID: 521
		[Token(Token = "0x17000068")]
		IEnumerable<TCell> Cells { [Token(Token = "0x6000209")] get; }
	}
}
