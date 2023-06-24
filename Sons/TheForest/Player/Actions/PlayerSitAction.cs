using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Gameplay;
using UnityEngine;
using UnityEngine.InputSystem;

namespace TheForest.Player.Actions
{
	// Token: 0x0200047D RID: 1149
	[Token(Token = "0x200047D")]
	public class PlayerSitAction : MonoBehaviour
	{
		// Token: 0x06001DAA RID: 7594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DAA")]
		[Address(RVA = "0x32DF010", Offset = "0x32DD610", VA = "0x1832DF010")]
		public void SitDown(SeatTrigger seatTrigger, PlayerSitAction.OnSitComplete onSitCompleteCallback)
		{
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DAB")]
		[Address(RVA = "0x32DF1F0", Offset = "0x32DD7F0", VA = "0x1832DF1F0")]
		private IEnumerator SitRoutine()
		{
			return null;
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DAC")]
		[Address(RVA = "0x71EE50", Offset = "0x71D450", VA = "0x18071EE50")]
		private void OnInterruptSit(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DAD")]
		[Address(RVA = "0x32DF280", Offset = "0x32DD880", VA = "0x1832DF280")]
		private void ClearPlayerState()
		{
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DAE")]
		[Address(RVA = "0x32DF730", Offset = "0x32DDD30", VA = "0x1832DF730")]
		private void OnInterruptedByAnimControl()
		{
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DAF")]
		[Address(RVA = "0x32DFBB0", Offset = "0x32DE1B0", VA = "0x1832DFBB0")]
		private void Update()
		{
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DB0")]
		[Address(RVA = "0x32DFCA0", Offset = "0x32DE2A0", VA = "0x1832DFCA0")]
		public PlayerSitAction()
		{
		}

		// Token: 0x04001C06 RID: 7174
		[Token(Token = "0x4001C06")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _restRegainedPerTick;

		// Token: 0x04001C07 RID: 7175
		[Token(Token = "0x4001C07")]
		[FieldOffset(Offset = "0x28")]
		private SeatTrigger _activeSitTrigger;

		// Token: 0x04001C08 RID: 7176
		[Token(Token = "0x4001C08")]
		[FieldOffset(Offset = "0x30")]
		private PlayerSitAction.OnSitComplete _onSitComplete;

		// Token: 0x04001C09 RID: 7177
		[Token(Token = "0x4001C09")]
		[FieldOffset(Offset = "0x38")]
		private Animator _playerAnimator;

		// Token: 0x04001C0A RID: 7178
		[Token(Token = "0x4001C0A")]
		[FieldOffset(Offset = "0x40")]
		private bool _wasInterrupted;

		// Token: 0x0200047E RID: 1150
		// (Invoke) Token: 0x06001DB2 RID: 7602
		[Token(Token = "0x200047E")]
		public delegate void OnSitComplete();
	}
}
