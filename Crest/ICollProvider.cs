using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public interface ICollProvider
	{
		// Token: 0x0600000B RID: 11
		[Token(Token = "0x600000B")]
		int Query(int i_ownerHash, float i_minSpatialLength, Vector3[] i_queryPoints, float[] o_resultHeights, Vector3[] o_resultNorms, Vector3[] o_resultVels);

		// Token: 0x0600000C RID: 12
		[Token(Token = "0x600000C")]
		int Query(int i_ownerHash, float i_minSpatialLength, Vector3[] i_queryPoints, Vector3[] o_resultDisps, Vector3[] o_resultNorms, Vector3[] o_resultVels);

		// Token: 0x0600000D RID: 13
		[Token(Token = "0x600000D")]
		bool RetrieveSucceeded(int queryStatus);

		// Token: 0x0600000E RID: 14
		[Token(Token = "0x600000E")]
		void UpdateQueries();

		// Token: 0x0600000F RID: 15
		[Token(Token = "0x600000F")]
		void CleanUp();
	}
}
