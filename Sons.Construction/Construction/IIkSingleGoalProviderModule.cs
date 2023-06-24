using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	public interface IIkSingleGoalProviderModule
	{
		// Token: 0x0600069D RID: 1693
		[Token(Token = "0x600069D")]
		bool TryGetIkGoals(StructureElement element, TargetInfo targetInfo, IkLimbs limb, out Vector3 pos, out Quaternion rot, out Vector3 scale);
	}
}
