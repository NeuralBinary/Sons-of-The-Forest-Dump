using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000CE RID: 206
	[Token(Token = "0x20000CE")]
	public interface ISnapPointValidator
	{
		// Token: 0x060005EB RID: 1515
		[Token(Token = "0x60005EB")]
		bool CheckValidTargetPos(PredictedTarget predictedTarget, Vector3 targetPos);
	}
}
