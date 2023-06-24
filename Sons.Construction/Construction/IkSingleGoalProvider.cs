using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000FB RID: 251
	[Token(Token = "0x20000FB")]
	[AddComponentMenu("Sons/Construction/IkSingleGoalProvider")]
	public class IkSingleGoalProvider : MonoBehaviour, IIkSingleGoalProvider
	{
		// Token: 0x0600070C RID: 1804 RVA: 0x000050FC File Offset: 0x000032FC
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x2E38510", Offset = "0x2E36B10", VA = "0x182E38510", Slot = "4")]
		private bool TryGetIkGoal(IkLimbs limb, out Vector3 pos, out Quaternion rot, out Vector3 scale, bool localToRoot)
		{
			return default(bool);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public IkSingleGoalProvider()
		{
		}

		// Token: 0x0400051F RID: 1311
		[Token(Token = "0x400051F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _targetTr;
	}
}
