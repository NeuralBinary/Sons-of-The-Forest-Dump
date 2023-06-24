using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace NWH.DWP2.MiConvexHull
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	public class DelaunayTriangulation<TVertex, TCell> : ITriangulation<TVertex, TCell> where TVertex : IVertex where TCell : TriangulationCell<TVertex, TCell>, new()
	{
		// Token: 0x06000215 RID: 533 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000215")]
		private DelaunayTriangulation()
		{
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000216 RID: 534 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000069")]
		public IEnumerable<TCell> Cells
		{
			[Token(Token = "0x6000216")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000217")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x6000218")]
		public static DelaunayTriangulation<TVertex, TCell> Create(IList<TVertex> data)
		{
			return null;
		}
	}
}
