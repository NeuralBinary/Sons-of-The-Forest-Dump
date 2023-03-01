using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;

namespace TheForest.Player.Actions
{
	// Token: 0x02000485 RID: 1157
	[Token(Token = "0x2000485")]
	public class PlayerRefillContainerAction : MonoBehaviour
	{
		// Token: 0x06001D3D RID: 7485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D3D")]
		[Address(RVA = "0x2CFF5A0", Offset = "0x2CFE5A0", VA = "0x182CFF5A0")]
		public void RefillContainer(InteractableWaterNode waterNode, bool animateOnly = false)
		{
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D3E")]
		[Address(RVA = "0x2CFF6D0", Offset = "0x2CFE6D0", VA = "0x182CFF6D0")]
		private IEnumerator WaterInteractionWorker(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, bool animateOnly)
		{
			return null;
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D3F")]
		[Address(RVA = "0x2CFEFE0", Offset = "0x2CFDFE0", VA = "0x182CFEFE0")]
		private void DoFillContainer(ItemInstance itemInstance, bool animateOnly)
		{
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D40")]
		[Address(RVA = "0x2CFF0E0", Offset = "0x2CFE0E0", VA = "0x182CFF0E0")]
		private void Finalize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl)
		{
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D41")]
		[Address(RVA = "0x2CFF350", Offset = "0x2CFE350", VA = "0x182CFF350")]
		private void Initialize(PlayerAnimatorControl playerAnimatorControl)
		{
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D42")]
		[Address(RVA = "0x2CFF790", Offset = "0x2CFE790", VA = "0x182CFF790")]
		public PlayerRefillContainerAction()
		{
		}

		// Token: 0x04001BB9 RID: 7097
		[Token(Token = "0x4001BB9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _drinkDepthRange;

		// Token: 0x04001BBA RID: 7098
		[Token(Token = "0x4001BBA")]
		[FieldOffset(Offset = "0x28")]
		private InteractableWaterNode _waterNode;

		// Token: 0x04001BBB RID: 7099
		[Token(Token = "0x4001BBB")]
		[FieldOffset(Offset = "0x30")]
		private bool _stashedLeftItemToRefill;
	}
}
