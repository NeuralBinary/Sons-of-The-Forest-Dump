using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Gameplay;
using UnityEngine;
using UnityEngine.InputSystem;

namespace TheForest.Player.Actions
{
	// Token: 0x0200048B RID: 1163
	[Token(Token = "0x200048B")]
	public class PlayerSitAction : MonoBehaviour
	{
		// Token: 0x06001D66 RID: 7526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D66")]
		[Address(RVA = "0x2D01390", Offset = "0x2D00390", VA = "0x182D01390")]
		public void SitDown(SeatTrigger seatTrigger, PlayerSitAction.OnSitComplete onSitCompleteCallback)
		{
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D67")]
		[Address(RVA = "0x2D01460", Offset = "0x2D00460", VA = "0x182D01460")]
		private IEnumerator SitRoutine()
		{
			return null;
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D68")]
		[Address(RVA = "0x683D30", Offset = "0x682D30", VA = "0x180683D30")]
		private void OnInterruptSit(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D69")]
		[Address(RVA = "0x2D00CB0", Offset = "0x2CFFCB0", VA = "0x182D00CB0")]
		private void ClearPlayerState()
		{
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D6A")]
		[Address(RVA = "0x2D010B0", Offset = "0x2D000B0", VA = "0x182D010B0")]
		private void OnInterruptedByAnimControl()
		{
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D6B")]
		[Address(RVA = "0x2D014D0", Offset = "0x2D004D0", VA = "0x182D014D0")]
		private void Update()
		{
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D6C")]
		[Address(RVA = "0x2D01580", Offset = "0x2D00580", VA = "0x182D01580")]
		public PlayerSitAction()
		{
		}

		// Token: 0x04001BDC RID: 7132
		[Token(Token = "0x4001BDC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _restRegainedPerTick;

		// Token: 0x04001BDD RID: 7133
		[Token(Token = "0x4001BDD")]
		[FieldOffset(Offset = "0x28")]
		private SeatTrigger _activeSitTrigger;

		// Token: 0x04001BDE RID: 7134
		[Token(Token = "0x4001BDE")]
		[FieldOffset(Offset = "0x30")]
		private PlayerSitAction.OnSitComplete _onSitComplete;

		// Token: 0x04001BDF RID: 7135
		[Token(Token = "0x4001BDF")]
		[FieldOffset(Offset = "0x38")]
		private Animator _playerAnimator;

		// Token: 0x04001BE0 RID: 7136
		[Token(Token = "0x4001BE0")]
		[FieldOffset(Offset = "0x40")]
		private bool _wasInterrupted;

		// Token: 0x0200048C RID: 1164
		// (Invoke) Token: 0x06001D6E RID: 7534
		[Token(Token = "0x200048C")]
		public delegate void OnSitComplete();
	}
}
