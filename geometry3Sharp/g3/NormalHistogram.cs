using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000392 RID: 914
	[Token(Token = "0x2000392")]
	public class NormalHistogram
	{
		// Token: 0x06001DAF RID: 7599 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DAF")]
		[Address(RVA = "0x1F84B30", Offset = "0x1F83130", VA = "0x181F84B30")]
		public NormalHistogram(int bins, bool bTrackUsed = false)
		{
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DB0")]
		[Address(RVA = "0x1F84CF0", Offset = "0x1F832F0", VA = "0x181F84CF0")]
		public NormalHistogram(DMesh3 mesh, bool bWeightByArea = true, int bins = 1024)
		{
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DB1")]
		[Address(RVA = "0x1F84D40", Offset = "0x1F83340", VA = "0x181F84D40")]
		public void Count(Vector3d pt, double weight = 1.0, bool bIsNormalized = false)
		{
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DB2")]
		[Address(RVA = "0x1F84F60", Offset = "0x1F83560", VA = "0x181F84F60")]
		public void CountFaceNormals(DMesh3 mesh, bool bWeightByArea = true)
		{
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00014D8C File Offset: 0x00012F8C
		[Token(Token = "0x6001DB3")]
		[Address(RVA = "0x1F85220", Offset = "0x1F83820", VA = "0x181F85220")]
		public Vector3d FindMaxNormal()
		{
			return default(Vector3d);
		}

		// Token: 0x0400101C RID: 4124
		[Token(Token = "0x400101C")]
		[FieldOffset(Offset = "0x10")]
		public int Bins;

		// Token: 0x0400101D RID: 4125
		[Token(Token = "0x400101D")]
		[FieldOffset(Offset = "0x18")]
		public SphericalFibonacciPointSet Points;

		// Token: 0x0400101E RID: 4126
		[Token(Token = "0x400101E")]
		[FieldOffset(Offset = "0x20")]
		public double[] Counts;

		// Token: 0x0400101F RID: 4127
		[Token(Token = "0x400101F")]
		[FieldOffset(Offset = "0x28")]
		public HashSet<int> UsedBins;
	}
}
