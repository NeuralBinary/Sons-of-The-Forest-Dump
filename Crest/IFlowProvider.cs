using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public interface IFlowProvider
	{
		// Token: 0x06000017 RID: 23
		[Token(Token = "0x6000017")]
		int Query(int i_ownerHash, float i_minSpatialLength, Vector3[] i_queryPoints, Vector3[] o_resultFlows);

		// Token: 0x06000018 RID: 24
		[Token(Token = "0x6000018")]
		bool RetrieveSucceeded(int queryStatus);

		// Token: 0x06000019 RID: 25
		[Token(Token = "0x6000019")]
		void UpdateQueries();

		// Token: 0x0600001A RID: 26
		[Token(Token = "0x600001A")]
		void CleanUp();
	}
}
