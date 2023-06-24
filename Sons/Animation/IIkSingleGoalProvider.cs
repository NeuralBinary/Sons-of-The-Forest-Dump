using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x02000902 RID: 2306
	[Token(Token = "0x2000902")]
	public interface IIkSingleGoalProvider
	{
		// Token: 0x06004258 RID: 16984
		[Token(Token = "0x6004258")]
		bool TryGetIkGoal(IkLimbs limb, out Vector3 pos, out Quaternion rot, out Vector3 scale, bool localToRoot);
	}
}
