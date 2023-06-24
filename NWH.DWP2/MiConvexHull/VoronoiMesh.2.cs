using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace NWH.DWP2.MiConvexHull
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	public class VoronoiMesh<TVertex, TCell, TEdge> where TVertex : IVertex where TCell : TriangulationCell<TVertex, TCell>, new() where TEdge : VoronoiEdge<TVertex, TCell>, new()
	{
		// Token: 0x0600022A RID: 554 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600022A")]
		private VoronoiMesh()
		{
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600022B RID: 555 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006C")]
		public IEnumerable<TCell> Vertices
		{
			[Token(Token = "0x600022B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600022C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600022D RID: 557 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006D")]
		public IEnumerable<TEdge> Edges
		{
			[Token(Token = "0x600022D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600022E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x600022F")]
		public static VoronoiMesh<TVertex, TCell, TEdge> Create(IList<TVertex> data)
		{
			return null;
		}

		// Token: 0x0200004E RID: 78
		[Token(Token = "0x200004E")]
		private class EdgeComparer : IEqualityComparer<TEdge>
		{
			// Token: 0x06000230 RID: 560 RVA: 0x0000305C File Offset: 0x0000125C
			[Token(Token = "0x6000230")]
			public bool Equals(TEdge x, TEdge y)
			{
				return default(bool);
			}

			// Token: 0x06000231 RID: 561 RVA: 0x00003074 File Offset: 0x00001274
			[Token(Token = "0x6000231")]
			public int GetHashCode(TEdge obj)
			{
				return 0;
			}

			// Token: 0x06000232 RID: 562 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000232")]
			public EdgeComparer()
			{
			}
		}
	}
}
