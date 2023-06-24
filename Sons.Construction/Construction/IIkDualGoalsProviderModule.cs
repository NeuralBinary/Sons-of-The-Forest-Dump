using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000E1 RID: 225
	[Token(Token = "0x20000E1")]
	public interface IIkDualGoalsProviderModule
	{
		// Token: 0x0600069C RID: 1692
		[Token(Token = "0x600069C")]
		bool TryGetIkGoals(StructureElement prefab, TargetInfo targetInfo, out Vector3 leftPos, out Quaternion leftRot, out Vector3 leftScale, out Vector3 rightPos, out Quaternion rightRot, out Vector3 rightScale);
	}
}
