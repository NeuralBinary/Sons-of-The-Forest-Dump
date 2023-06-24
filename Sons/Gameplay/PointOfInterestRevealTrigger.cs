using System;
using Il2CppDummyDll;
using Sons.PlayerActions;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007BF RID: 1983
	[Token(Token = "0x20007BF")]
	public class PointOfInterestRevealTrigger : MonoBehaviour
	{
		// Token: 0x0600358F RID: 13711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600358F")]
		[Address(RVA = "0x34E33A0", Offset = "0x34E19A0", VA = "0x1834E33A0")]
		private void OnEnable()
		{
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003590")]
		[Address(RVA = "0x34E3540", Offset = "0x34E1B40", VA = "0x1834E3540")]
		private void OnDisable()
		{
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003591")]
		[Address(RVA = "0x34E3630", Offset = "0x34E1C30", VA = "0x1834E3630")]
		private void OnPostLoad()
		{
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003592")]
		[Address(RVA = "0x34E3880", Offset = "0x34E1E80", VA = "0x1834E3880")]
		private void OnInteraction()
		{
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003593")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PointOfInterestRevealTrigger()
		{
		}

		// Token: 0x04002E43 RID: 11843
		[Token(Token = "0x4002E43")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GenericInteraction _genericInteraction;

		// Token: 0x04002E44 RID: 11844
		[Token(Token = "0x4002E44")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _pointOfInterestName;

		// Token: 0x04002E45 RID: 11845
		[Token(Token = "0x4002E45")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private PointsOfInterestData _pointsOfInterest;

		// Token: 0x04002E46 RID: 11846
		[Token(Token = "0x4002E46")]
		[FieldOffset(Offset = "0x38")]
		private PlayerPointsOfInterest _playerPointsOfInterest;
	}
}
