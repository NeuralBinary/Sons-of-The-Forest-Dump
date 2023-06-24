using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Sons.Gui.Options
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	[AddComponentMenu("Sons/Gui/Options/CustomGameSetupGuiManager")]
	public class CustomGameSetupGuiManager : OptionsGuiManager
	{
		// Token: 0x06000162 RID: 354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x3041FB0", Offset = "0x30405B0", VA = "0x183041FB0", Slot = "4")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x3042250", Offset = "0x3040850", VA = "0x183042250", Slot = "6")]
		internal override void RegisterEvents()
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x3042310", Offset = "0x3040910", VA = "0x183042310", Slot = "5")]
		internal override void UnregisterEvents()
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x3042390", Offset = "0x3040990", VA = "0x183042390")]
		public void OnStartGame()
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x3042420", Offset = "0x3040A20", VA = "0x183042420")]
		public void CloseMenu()
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x3042450", Offset = "0x3040A50", VA = "0x183042450")]
		public CustomGameSetupGuiManager()
		{
		}

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UnityEvent _onStartSinglePlayerGame;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UnityEvent _onStartMultiPlayerGame;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UnityEvent _onCloseMenu;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Button _singlePlayerStartButton;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Button _multiPlayerHostButton;
	}
}
