using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace NWH.DWP2.MiConvexHull
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public class VoronoiEdge<TVertex, TCell> where TVertex : IVertex where TCell : TriangulationCell<TVertex, TCell>
	{
		// Token: 0x0600021B RID: 539 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021B")]
		public VoronoiEdge()
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021C")]
		public VoronoiEdge(TCell source, TCell target)
		{
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600021D RID: 541 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006A")]
		public TCell Source
		{
			[Token(Token = "0x600021D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600021E")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600021F RID: 543 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006B")]
		public TCell Target
		{
			[Token(Token = "0x600021F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000220")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000302C File Offset: 0x0000122C
		[Token(Token = "0x6000221")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00003044 File Offset: 0x00001244
		[Token(Token = "0x6000222")]
		public override int GetHashCode()
		{
			return 0;
		}
	}
}
