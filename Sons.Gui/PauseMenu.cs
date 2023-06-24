using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Gui
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	[AddComponentMenu("Sons/Gui/PauseMenu")]
	public class PauseMenu : MonoBehaviour
	{
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000009")]
		private static event Action OnQuitEvent
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x3009A50", Offset = "0x3008050", VA = "0x183009A50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x3009B60", Offset = "0x3008160", VA = "0x183009B60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x1700000B")]
		public static bool IsActive
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x3009C70", Offset = "0x3008270", VA = "0x183009C70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x3009D70", Offset = "0x3008370", VA = "0x183009D70")]
		private void Start()
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x3009DC0", Offset = "0x30083C0", VA = "0x183009DC0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x3009DD0", Offset = "0x30083D0", VA = "0x183009DD0")]
		private void OnEnable()
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x300A010", Offset = "0x3008610", VA = "0x18300A010")]
		private void UnregisterEvents()
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x300A0B0", Offset = "0x30086B0", VA = "0x18300A0B0")]
		private void OnBack()
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x300A1D0", Offset = "0x30087D0", VA = "0x18300A1D0")]
		private void RegisterEvents()
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x300A280", Offset = "0x3008880", VA = "0x18300A280")]
		private void OnDisable()
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x300A5B0", Offset = "0x3008BB0", VA = "0x18300A5B0")]
		private void Update()
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x300A670", Offset = "0x3008C70", VA = "0x18300A670")]
		private bool CanBeOpened()
		{
			return default(bool);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x300A790", Offset = "0x3008D90", VA = "0x18300A790")]
		public void OnSteamGameOverlayActivated(bool overlayActivated)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x300A7C0", Offset = "0x3008DC0", VA = "0x18300A7C0")]
		private void OnActiveDeviceRemoved()
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x300A970", Offset = "0x3008F70", VA = "0x18300A970")]
		public void Open()
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x300AA80", Offset = "0x3009080", VA = "0x18300AA80")]
		public void Close()
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x300ABA0", Offset = "0x30091A0", VA = "0x18300ABA0")]
		public static void QuitToTitleSkipConfirm()
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x300AD00", Offset = "0x3009300", VA = "0x18300AD00")]
		public static void QuitToTitle()
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x300AE30", Offset = "0x3009430", VA = "0x18300AE30")]
		public void TriggerQuitToTitle()
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x300AE40", Offset = "0x3009440", VA = "0x18300AE40")]
		private void TriggerQuitToTitleInternal(bool instant = false)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x300AF40", Offset = "0x3009540", VA = "0x18300AF40")]
		private void SetupMenuButtonsSinglePlayerOrMultiPlayer()
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x300B3A0", Offset = "0x30099A0", VA = "0x18300B3A0")]
		private IEnumerator DelayReturnToTitle()
		{
			return null;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x300B3E0", Offset = "0x30099E0", VA = "0x18300B3E0")]
		public void SetOptionsActive(bool value)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x300B440", Offset = "0x3009A40", VA = "0x18300B440")]
		public void SetPlayersActive(bool value)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x300B4A0", Offset = "0x3009AA0", VA = "0x18300B4A0")]
		public void SetSaveMenuActive(bool value)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x300B500", Offset = "0x3009B00", VA = "0x18300B500")]
		public void SetLoadMenuActive(bool value)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x300B560", Offset = "0x3009B60", VA = "0x18300B560")]
		private static void SetActiveObjects(List<GameObject> targets, bool value)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x8DD0B0", Offset = "0x8DB6B0", VA = "0x1808DD0B0")]
		public void SetActivateCallback(Action<bool> sourceAction)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x300B740", Offset = "0x3009D40", VA = "0x18300B740")]
		private void SetActiveInternal(bool value)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x300B790", Offset = "0x3009D90", VA = "0x18300B790")]
		private void ManageInputEvents(bool value)
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x300B860", Offset = "0x3009E60", VA = "0x18300B860")]
		public static void SetActive(bool value)
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x3009A50", Offset = "0x3008050", VA = "0x183009A50")]
		public static void RegisterOnQuitAction(Action action)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x3009B60", Offset = "0x3008160", VA = "0x183009B60")]
		public static void UnregisterOnQuitAction(Action action)
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x300B990", Offset = "0x3009F90", VA = "0x18300B990")]
		public PauseMenu()
		{
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x300B9E0", Offset = "0x3009FE0", VA = "0x18300B9E0")]
		[CompilerGenerated]
		private void <TriggerQuitToTitleInternal>g__OnConfirmed|42_0()
		{
		}

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> _activateForMenu;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Button> _singlePlayerMenuButtons;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Button> _multiPlayerMenuButtons;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _activateForOptions;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<GameObject> _deactivateForOptions;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<GameObject> _activateForPlayers;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<GameObject> _deactivateForPlayers;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SaveMenu _saveMenu;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<GameObject> _activateForSave;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<GameObject> _deactivateForSave;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private LoadMenu _loadMenu;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<GameObject> _activateForLoad;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<GameObject> _deactivateForLoad;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x88")]
		private Action<bool> _pauseMenuActiveAction;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x90")]
		private bool _isActive;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x0")]
		private static PauseMenu _instance;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x91")]
		private bool _registeredEvents;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x92")]
		private bool _saveMenuActive;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x93")]
		private bool _loadMenuActive;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x94")]
		private bool _optionsMenuActive;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x95")]
		private bool _playersMenuActive;
	}
}
