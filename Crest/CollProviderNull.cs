using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class CollProviderNull : ICollProvider
	{
		// Token: 0x06000010 RID: 16 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x9C6CE0", Offset = "0x9C52E0", VA = "0x1809C6CE0", Slot = "5")]
		public int Query(int i_ownerHash, float i_minSpatialLength, Vector3[] i_queryPoints, Vector3[] o_resultDisps, Vector3[] o_resultNorms, Vector3[] o_resultVels)
		{
			return 0;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x9C6E40", Offset = "0x9C5440", VA = "0x1809C6E40", Slot = "4")]
		public int Query(int i_ownerHash, float i_minSpatialLength, Vector3[] i_queryPoints, float[] o_resultHeights, Vector3[] o_resultNorms, Vector3[] o_resultVels)
		{
			return 0;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "6")]
		public bool RetrieveSucceeded(int queryStatus)
		{
			return default(bool);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		public void UpdateQueries()
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public void CleanUp()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CollProviderNull()
		{
		}

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CollProviderNull Instance;
	}
}
