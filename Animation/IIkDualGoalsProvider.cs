using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x0200088E RID: 2190
	[Token(Token = "0x200088E")]
	public interface IIkDualGoalsProvider
	{
		// Token: 0x06003B29 RID: 15145
		[Token(Token = "0x6003B29")]
		bool TryGetIkGoals(out Vector3 leftPos, out Quaternion leftRot, out Vector3 leftScale, out Vector3 rightPos, out Quaternion rightRot, out Vector3 rightScale, bool localToRoot);
	}
}
