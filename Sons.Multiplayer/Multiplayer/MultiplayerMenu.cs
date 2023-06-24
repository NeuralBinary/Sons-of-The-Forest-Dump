using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Gui;
using Sons.Save;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Sons.Multiplayer
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	public class MultiplayerMenu : MonoBehaviour
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x17000044")]
		private static bool IsSteamRunning
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x30E6830", Offset = "0x30E4E30", VA = "0x1830E6830")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x30E6880", Offset = "0x30E4E80", VA = "0x1830E6880")]
		private void Update()
		{
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x30E6910", Offset = "0x30E4F10", VA = "0x1830E6910")]
		private void OnEnable()
		{
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnDisable()
		{
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x30E69A0", Offset = "0x30E4FA0", VA = "0x1830E69A0")]
		private void LoadSlotSelected(int slotIndex)
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x30E6A40", Offset = "0x30E5040", VA = "0x1830E6A40")]
		public void ShowHostMenu()
		{
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x30E6AC0", Offset = "0x30E50C0", VA = "0x1830E6AC0")]
		private void SetOffline()
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x30E6AF0", Offset = "0x30E50F0", VA = "0x1830E6AF0")]
		private void SetOnline()
		{
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x30E6B20", Offset = "0x30E5120", VA = "0x1830E6B20")]
		private void SetOnlineSelectables(bool value)
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x30E6D10", Offset = "0x30E5310", VA = "0x1830E6D10")]
		public void ShowLobbyMenu()
		{
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x30E6D90", Offset = "0x30E5390", VA = "0x1830E6D90")]
		public void ShowLoadMenu()
		{
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x30E6D90", Offset = "0x30E5390", VA = "0x1830E6D90")]
		private void ShowLoadMenu(int slotIndex, GameStateData saveData)
		{
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x30E6E10", Offset = "0x30E5410", VA = "0x1830E6E10")]
		private void ShowNewSaveSlot()
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x30E7030", Offset = "0x30E5630", VA = "0x1830E7030")]
		private void ShowSaveSlot(int slotIndex, GameStateData saveData)
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public MultiplayerMenu()
		{
		}

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Selectable> _onlineObjects;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent _onlineEvent;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent _offlineEvent;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private NewSlot _newSavedSlot;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SavedSlot _displaySavedSlot;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<GameObject> _loadMenuObjects;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<GameObject> _hostMenuObjects;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<GameObject> _lobbyMenuObjects;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x60")]
		private bool _lastSteamRunningCheck;
	}
}
