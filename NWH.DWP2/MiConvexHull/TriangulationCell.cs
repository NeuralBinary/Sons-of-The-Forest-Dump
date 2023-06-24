using System;
using Il2CppDummyDll;

namespace NWH.DWP2.MiConvexHull
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	public abstract class TriangulationCell<TVertex, TCell> : ConvexFace<TVertex, TCell> where TVertex : IVertex where TCell : ConvexFace<TVertex, TCell>
	{
		// Token: 0x06000219 RID: 537 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000219")]
		protected TriangulationCell()
		{
		}
	}
}
