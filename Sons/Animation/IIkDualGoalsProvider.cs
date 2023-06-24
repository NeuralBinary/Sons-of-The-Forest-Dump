using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x02000900 RID: 2304
	[Token(Token = "0x2000900")]
	public interface IIkDualGoalsProvider
	{
		// Token: 0x06004255 RID: 16981
		[Token(Token = "0x6004255")]
		bool TryGetIkGoals(out Vector3 leftPos, out Quaternion leftRot, out Vector3 leftScale, out Vector3 rightPos, out Quaternion rightRot, out Vector3 rightScale, bool localToRoot);
	}
}
