using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace NWH.DWP2.MiConvexHull
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	public static class ConvexHull
	{
		// Token: 0x06000198 RID: 408 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x6000198")]
		public static ConvexHull<TVertex, TFace> Create<TVertex, TFace>(IList<TVertex> data, double PlaneDistanceTolerance = 1E-10) where TVertex : IVertex where TFace : ConvexFace<TVertex, TFace>, new()
		{
			return null;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x6000199")]
		public static ConvexHull<TVertex, DefaultConvexFace<TVertex>> Create<TVertex>(IList<TVertex> data, double PlaneDistanceTolerance = 1E-10) where TVertex : IVertex
		{
			return null;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2718910", Offset = "0x2716F10", VA = "0x182718910")]
		public static ConvexHull<DefaultVertex, DefaultConvexFace<DefaultVertex>> Create(IList<double[]> data, double PlaneDistanceTolerance = 1E-10)
		{
			return null;
		}
	}
}
