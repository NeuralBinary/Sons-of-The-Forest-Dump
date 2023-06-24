using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace NWH.DWP2.MiConvexHull
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	public abstract class ConvexFace<TVertex, TFace> where TVertex : IVertex where TFace : ConvexFace<TVertex, TFace>
	{
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000063")]
		public TFace[] Adjacency
		{
			[Token(Token = "0x60001B9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BA")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001BB RID: 443 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000064")]
		public TVertex[] Vertices
		{
			[Token(Token = "0x60001BB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BC")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001BD RID: 445 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000065")]
		public double[] Normal
		{
			[Token(Token = "0x60001BD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BE")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001BF")]
		protected ConvexFace()
		{
		}
	}
}
