using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;

namespace TheForest.Player.Actions
{
	// Token: 0x02000477 RID: 1143
	[Token(Token = "0x2000477")]
	public class PlayerRefillContainerAction : MonoBehaviour
	{
		// Token: 0x06001D7F RID: 7551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D7F")]
		[Address(RVA = "0x32DACB0", Offset = "0x32D92B0", VA = "0x1832DACB0")]
		public void RefillContainer(InteractableWaterNode waterNode, bool animateOnly = false)
		{
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D80")]
		[Address(RVA = "0x32DAEE0", Offset = "0x32D94E0", VA = "0x1832DAEE0")]
		private void Update()
		{
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D81")]
		[Address(RVA = "0x32DB000", Offset = "0x32D9600", VA = "0x1832DB000")]
		private void CancelRefill()
		{
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D82")]
		[Address(RVA = "0x32DB0E0", Offset = "0x32D96E0", VA = "0x1832DB0E0")]
		private IEnumerator WaterInteractionWorker(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, bool animateOnly)
		{
			return null;
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D83")]
		[Address(RVA = "0x32DB250", Offset = "0x32D9850", VA = "0x1832DB250")]
		private void DoFillContainer(ItemInstance itemInstance, bool animateOnly)
		{
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D84")]
		[Address(RVA = "0x32DB3B0", Offset = "0x32D99B0", VA = "0x1832DB3B0")]
		private void Finalize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl)
		{
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D85")]
		[Address(RVA = "0x32DB6E0", Offset = "0x32D9CE0", VA = "0x1832DB6E0")]
		private void Initialize(PlayerAnimatorControl playerAnimatorControl)
		{
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D86")]
		[Address(RVA = "0x32DB9F0", Offset = "0x32D9FF0", VA = "0x1832DB9F0")]
		public PlayerRefillContainerAction()
		{
		}

		// Token: 0x04001BE2 RID: 7138
		[Token(Token = "0x4001BE2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _drinkDepthRange;

		// Token: 0x04001BE3 RID: 7139
		[Token(Token = "0x4001BE3")]
		[FieldOffset(Offset = "0x28")]
		private InteractableWaterNode _waterNode;

		// Token: 0x04001BE4 RID: 7140
		[Token(Token = "0x4001BE4")]
		[FieldOffset(Offset = "0x30")]
		private bool _stashedLeftItemToRefill;

		// Token: 0x04001BE5 RID: 7141
		[Token(Token = "0x4001BE5")]
		[FieldOffset(Offset = "0x31")]
		private bool _refillInProgress;
	}
}
