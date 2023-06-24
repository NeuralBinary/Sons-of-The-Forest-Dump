using System;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui.DeadScreen
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	public class DeadScreenMenu : MonoBehaviour
	{
		// Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x3060E30", Offset = "0x305F430", VA = "0x183060E30")]
		private void OnValidate()
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x3060F70", Offset = "0x305F570", VA = "0x183060F70")]
		private void OnEnable()
		{
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x3061210", Offset = "0x305F810", VA = "0x183061210")]
		private void LoadSlotSelected(int obj)
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x30612B0", Offset = "0x305F8B0", VA = "0x1830612B0")]
		private void ClearCallbacks()
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x3061530", Offset = "0x305FB30", VA = "0x183061530")]
		private void OnDisable()
		{
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x3061540", Offset = "0x305FB40", VA = "0x183061540")]
		private void Update()
		{
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x3061540", Offset = "0x305FB40", VA = "0x183061540")]
		private void CheckShowContinueDialog()
		{
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x3061680", Offset = "0x305FC80", VA = "0x183061680")]
		private bool GetScreenBackButtonActivated()
		{
			return default(bool);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x3061720", Offset = "0x305FD20", VA = "0x183061720")]
		public void StartNewGame()
		{
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x30618D0", Offset = "0x305FED0", VA = "0x1830618D0")]
		public void ExitToTitle()
		{
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x3061980", Offset = "0x305FF80", VA = "0x183061980")]
		public void ShowLoadMenu()
		{
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x3061AF0", Offset = "0x30600F0", VA = "0x183061AF0")]
		public void HideLoadMenu()
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x3061B70", Offset = "0x3060170", VA = "0x183061B70")]
		public void ShowContinueDialogGroup()
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x3061C30", Offset = "0x3060230", VA = "0x183061C30")]
		public void HideContinueDialogGroup()
		{
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x3061CF0", Offset = "0x30602F0", VA = "0x183061CF0")]
		public DeadScreenMenu()
		{
		}

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _continueDialogGroup;

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _loadMenuGroup;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LoadMenu _loadMenu;

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _gameOverStateObject;

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _continueDialogDelay;

		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x48")]
		private AutoTimer _continueDialogDelayTimer;

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x50")]
		private bool _shownContinueDialog;

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x51")]
		private bool _shownLoadMenu;
	}
}
