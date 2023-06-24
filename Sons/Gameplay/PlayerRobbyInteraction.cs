using System;
using Bolt;
using Il2CppDummyDll;
using Sons.Gui;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007CE RID: 1998
	[Token(Token = "0x20007CE")]
	[AddComponentMenu("Sons/Gameplay/PlayerRobbyInteraction")]
	public class PlayerRobbyInteraction : EntityBehaviour<IPlayerState>
	{
		// Token: 0x060035E9 RID: 13801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E9")]
		[Address(RVA = "0x34EBCC0", Offset = "0x34EA2C0", VA = "0x1834EBCC0")]
		public void ShowPadAndPen(bool show)
		{
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035EA")]
		[Address(RVA = "0x34EBDB0", Offset = "0x34EA3B0", VA = "0x1834EBDB0")]
		public void ShowPad(bool show = true)
		{
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035EB")]
		[Address(RVA = "0x34EBFC0", Offset = "0x34EA5C0", VA = "0x1834EBFC0")]
		private void SetPadHeldState(bool show)
		{
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035EC")]
		[Address(RVA = "0x34EC080", Offset = "0x34EA680", VA = "0x1834EC080")]
		public void ShowPen(bool show = true)
		{
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035ED")]
		[Address(RVA = "0x34EC280", Offset = "0x34EA880", VA = "0x1834EC280")]
		private void SetPenHeldState(bool show)
		{
		}

		// Token: 0x060035EE RID: 13806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035EE")]
		[Address(RVA = "0x34EC340", Offset = "0x34EA940", VA = "0x1834EC340")]
		private void SetItemParent(Transform child, Transform newParent, Quaternion rotation)
		{
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035EF")]
		[Address(RVA = "0x34EC530", Offset = "0x34EAB30", VA = "0x1834EC530")]
		public RobbyWorldUi CreatePadAndPenIfNeeded()
		{
			return null;
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x000101B8 File Offset: 0x0000E3B8
		[Token(Token = "0x60035F0")]
		[Address(RVA = "0x34ECC70", Offset = "0x34EB270", VA = "0x1834ECC70")]
		private bool IsRobbyInteractionHash(int animStateHash)
		{
			return default(bool);
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x000101D0 File Offset: 0x0000E3D0
		[Token(Token = "0x60035F1")]
		[Address(RVA = "0x34ECD70", Offset = "0x34EB370", VA = "0x1834ECD70")]
		public bool PlayerInPadAnimation()
		{
			return default(bool);
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x000101E8 File Offset: 0x0000E3E8
		[Token(Token = "0x60035F2")]
		[Address(RVA = "0x34ECF70", Offset = "0x34EB570", VA = "0x1834ECF70")]
		public bool CheckHelpUpFinished()
		{
			return default(bool);
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035F3")]
		[Address(RVA = "0x34ED120", Offset = "0x34EB720", VA = "0x1834ED120")]
		public void CheckPadTransferAndHide(Transform robbyRightHand, bool isGivingNote)
		{
		}

		// Token: 0x060035F4 RID: 13812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035F4")]
		[Address(RVA = "0x34ED590", Offset = "0x34EBB90", VA = "0x1834ED590")]
		public PlayerRobbyInteraction()
		{
		}

		// Token: 0x04002E92 RID: 11922
		[Token(Token = "0x4002E92")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RobbyWorldUi _guiPrefab;

		// Token: 0x04002E93 RID: 11923
		[Token(Token = "0x4002E93")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _penPrefab;

		// Token: 0x04002E94 RID: 11924
		[Token(Token = "0x4002E94")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _rightHandHeld;

		// Token: 0x04002E95 RID: 11925
		[Token(Token = "0x4002E95")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _leftHandHeld;

		// Token: 0x04002E96 RID: 11926
		[Token(Token = "0x4002E96")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04002E97 RID: 11927
		[Token(Token = "0x4002E97")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _isRemote;

		// Token: 0x04002E98 RID: 11928
		[Token(Token = "0x4002E98")]
		[FieldOffset(Offset = "0x58")]
		private RobbyWorldUi _tactiPad;

		// Token: 0x04002E99 RID: 11929
		[Token(Token = "0x4002E99")]
		[FieldOffset(Offset = "0x60")]
		private GameObject _tactiPen;
	}
}
