using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Input;
using Sons.Save;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Gui
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	public abstract class SaveLoadMenuBase : MonoBehaviour
	{
		// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x3012310", Offset = "0x3010910", VA = "0x183012310")]
		private void OnEnable()
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x3012340", Offset = "0x3010940", VA = "0x183012340")]
		internal void EnableBackButton()
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		protected virtual void SetupSlots()
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x30124B0", Offset = "0x3010AB0", VA = "0x1830124B0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x30124D0", Offset = "0x3010AD0", VA = "0x1830124D0")]
		private void UnregisterEvents()
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x3012570", Offset = "0x3010B70", VA = "0x183012570")]
		internal void DisableBackButton()
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x3012650", Offset = "0x3010C50", VA = "0x183012650")]
		private void OnBackButton()
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x3012860", Offset = "0x3010E60", VA = "0x183012860")]
		private void RegisterEvents()
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x3012910", Offset = "0x3010F10", VA = "0x183012910")]
		internal NewSlot CreateNewSlotInstance()
		{
			return null;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x3012AC0", Offset = "0x30110C0", VA = "0x183012AC0")]
		protected void SortSaveSlots()
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x3013D40", Offset = "0x3012340", VA = "0x183013D40")]
		private SaveSlotBase GetNewSlotButtonInstance()
		{
			return null;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x3013EB0", Offset = "0x30124B0", VA = "0x183013EB0")]
		protected void RefreshInstances()
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x3013EE0", Offset = "0x30124E0", VA = "0x183013EE0")]
		private void ClearInstances()
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x3013F90", Offset = "0x3012590", VA = "0x183013F90", Slot = "5")]
		internal virtual void Awake()
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x3013FC0", Offset = "0x30125C0", VA = "0x183013FC0")]
		private void InitializeSlot(SaveSlotBase eachSlot)
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x3014070", Offset = "0x3012670", VA = "0x183014070")]
		internal void ClearInstances(List<GameObject> targetInstances)
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x3014250", Offset = "0x3012850", VA = "0x183014250")]
		internal SavedSlot CreateSavedSlotInstance()
		{
			return null;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x3014400", Offset = "0x3012A00", VA = "0x183014400")]
		private static void SetInactive(GameObject target)
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x3014500", Offset = "0x3012B00", VA = "0x183014500")]
		public void CloseMenu()
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x3014510", Offset = "0x3012B10", VA = "0x183014510")]
		protected void SlotDeleted(int saveId, GameStateData data)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x3014670", Offset = "0x3012C70", VA = "0x183014670")]
		private void SaveDeleteWithConfirmation(int saveId)
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x30147D0", Offset = "0x3012DD0", VA = "0x1830147D0")]
		protected SaveLoadMenuBase()
		{
		}

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _backButton;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal GameObject _emptySlot;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		internal GameObject _newSlot;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		internal GameObject _savedSlot;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private InputGamepadMenuHelper _helper;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x48")]
		private List<GameObject> _savedSlotInstances;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x50")]
		private List<GameObject> _newSlotInstances;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x58")]
		private List<Button> _buttons;
	}
}
