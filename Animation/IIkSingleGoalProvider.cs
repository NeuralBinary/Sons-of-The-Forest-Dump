using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x02000890 RID: 2192
	[Token(Token = "0x2000890")]
	public interface IIkSingleGoalProvider
	{
		// Token: 0x06003B2C RID: 15148
		[Token(Token = "0x6003B2C")]
		bool TryGetIkGoal(IkLimbs limb, out Vector3 pos, out Quaternion rot, out Vector3 scale, bool localToRoot);
	}
}
