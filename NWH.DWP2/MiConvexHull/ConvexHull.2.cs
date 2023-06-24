using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace NWH.DWP2.MiConvexHull
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public class ConvexHull<TVertex, TFace> where TVertex : IVertex where TFace : ConvexFace<TVertex, TFace>, new()
	{
		// Token: 0x0600019E RID: 414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019E")]
		internal ConvexHull()
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600019F RID: 415 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005E")]
		public IEnumerable<TVertex> Points
		{
			[Token(Token = "0x600019F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005F")]
		public IEnumerable<TFace> Faces
		{
			[Token(Token = "0x60001A1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A2")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x60001A3")]
		public static ConvexHull<TVertex, TFace> Create(IList<TVertex> data, double PlaneDistanceTolerance)
		{
			return null;
		}
	}
}
