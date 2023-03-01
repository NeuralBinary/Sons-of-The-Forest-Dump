using System;
using Bolt;
using Il2CppDummyDll;
using Sons.Gui;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000699 RID: 1689
	[Token(Token = "0x2000699")]
	[AddComponentMenu("Sons/Gameplay/PlayerRobbyInteraction")]
	public class PlayerRobbyInteraction : EntityBehaviour<IPlayerState>
	{
		// Token: 0x06002B38 RID: 11064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B38")]
		[Address(RVA = "0x2DE25B0", Offset = "0x2DE15B0", VA = "0x182DE25B0")]
		public void ShowPadAndPen(bool show)
		{
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B39")]
		[Address(RVA = "0x2DE2700", Offset = "0x2DE1700", VA = "0x182DE2700")]
		public void ShowPad(bool show = true)
		{
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B3A")]
		[Address(RVA = "0x2DE2470", Offset = "0x2DE1470", VA = "0x182DE2470")]
		private void SetPadHeldState(bool show)
		{
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B3B")]
		[Address(RVA = "0x2DE27F0", Offset = "0x2DE17F0", VA = "0x182DE27F0")]
		public void ShowPen(bool show = true)
		{
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B3C")]
		[Address(RVA = "0x2DE2510", Offset = "0x2DE1510", VA = "0x182DE2510")]
		private void SetPenHeldState(bool show)
		{
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B3D")]
		[Address(RVA = "0x2DE2370", Offset = "0x2DE1370", VA = "0x182DE2370")]
		private void SetItemParent(Transform child, Transform newParent, Quaternion rotation)
		{
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B3E")]
		[Address(RVA = "0x2DE1CD0", Offset = "0x2DE0CD0", VA = "0x182DE1CD0")]
		public RobbyWorldUi CreatePadAndPenIfNeeded()
		{
			return null;
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		[Token(Token = "0x6002B3F")]
		[Address(RVA = "0x2DE20F0", Offset = "0x2DE10F0", VA = "0x182DE20F0")]
		private bool IsRobbyInteractionHash(int animStateHash)
		{
			return default(bool);
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x0000C708 File Offset: 0x0000A908
		[Token(Token = "0x6002B40")]
		[Address(RVA = "0x2DE21F0", Offset = "0x2DE11F0", VA = "0x182DE21F0")]
		public bool PlayerInPadAnimation()
		{
			return default(bool);
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x0000C720 File Offset: 0x0000A920
		[Token(Token = "0x6002B41")]
		[Address(RVA = "0x2DE18B0", Offset = "0x2DE08B0", VA = "0x182DE18B0")]
		public bool CheckHelpUpFinished()
		{
			return default(bool);
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B42")]
		[Address(RVA = "0x2DE19D0", Offset = "0x2DE09D0", VA = "0x182DE19D0")]
		public void CheckPadTransferAndHide(Transform robbyRightHand, bool isGivingNote)
		{
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B43")]
		[Address(RVA = "0x2DE2930", Offset = "0x2DE1930", VA = "0x182DE2930")]
		public PlayerRobbyInteraction()
		{
		}

		// Token: 0x040026C9 RID: 9929
		[Token(Token = "0x40026C9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RobbyWorldUi _guiPrefab;

		// Token: 0x040026CA RID: 9930
		[Token(Token = "0x40026CA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _penPrefab;

		// Token: 0x040026CB RID: 9931
		[Token(Token = "0x40026CB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _rightHandHeld;

		// Token: 0x040026CC RID: 9932
		[Token(Token = "0x40026CC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _leftHandHeld;

		// Token: 0x040026CD RID: 9933
		[Token(Token = "0x40026CD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x040026CE RID: 9934
		[Token(Token = "0x40026CE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _isRemote;

		// Token: 0x040026CF RID: 9935
		[Token(Token = "0x40026CF")]
		[FieldOffset(Offset = "0x58")]
		private RobbyWorldUi _tactiPad;

		// Token: 0x040026D0 RID: 9936
		[Token(Token = "0x40026D0")]
		[FieldOffset(Offset = "0x60")]
		private GameObject _tactiPen;
	}
}
