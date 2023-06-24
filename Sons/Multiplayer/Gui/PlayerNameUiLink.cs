using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Gameplay.GPS;
using TheForest.Items.Inventory;
using UnityEngine;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x0200056C RID: 1388
	[Token(Token = "0x200056C")]
	[AddComponentMenu("Sons/Multiplayer/Gui/PlayerNameUiLink")]
	public class PlayerNameUiLink : MonoBehaviour
	{
		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060024C9 RID: 9417 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		// (set) Token: 0x060024CA RID: 9418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E0")]
		public bool IsActive
		{
			[Token(Token = "0x60024C9")]
			[Address(RVA = "0x31A3F60", Offset = "0x31A2560", VA = "0x1831A3F60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60024CA")]
			[Address(RVA = "0x31A3F70", Offset = "0x31A2570", VA = "0x1831A3F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CB")]
		[Address(RVA = "0x338F0D0", Offset = "0x338D6D0", VA = "0x18338F0D0")]
		public void SetPlayerName(string playerName)
		{
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CC")]
		[Address(RVA = "0x338F130", Offset = "0x338D730", VA = "0x18338F130")]
		private void Update()
		{
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CD")]
		[Address(RVA = "0x338F7A0", Offset = "0x338DDA0", VA = "0x18338F7A0")]
		private void RemoveElement()
		{
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x0000AC08 File Offset: 0x00008E08
		[Token(Token = "0x60024CE")]
		[Address(RVA = "0x338F920", Offset = "0x338DF20", VA = "0x18338F920")]
		private bool IsInFront(Transform viewTransform, Vector3 targetPosition)
		{
			return default(bool);
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CF")]
		[Address(RVA = "0x338FA10", Offset = "0x338E010", VA = "0x18338FA10")]
		private void RefreshPlayerNameLinkedUi()
		{
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D0")]
		[Address(RVA = "0x338FC00", Offset = "0x338E200", VA = "0x18338FC00")]
		private void RefreshGpsProperties()
		{
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D1")]
		[Address(RVA = "0x338FE00", Offset = "0x338E400", VA = "0x18338FE00")]
		private void OnDisable()
		{
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D2")]
		[Address(RVA = "0x338FE10", Offset = "0x338E410", VA = "0x18338FE10")]
		public void SetPlayerColor(Color playerColor)
		{
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D3")]
		[Address(RVA = "0x338FE20", Offset = "0x338E420", VA = "0x18338FE20")]
		private void ShowElement(Vector3 position, Transform targetTransform)
		{
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x0000AC20 File Offset: 0x00008E20
		[Token(Token = "0x60024D4")]
		[Address(RVA = "0x338FFF0", Offset = "0x338E5F0", VA = "0x18338FFF0")]
		private bool RequestUiElement()
		{
			return default(bool);
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D5")]
		[Address(RVA = "0x33902D0", Offset = "0x338E8D0", VA = "0x1833902D0")]
		public void OnCurrentViewChanged(PlayerInventory.PlayerViews stateCurrentView)
		{
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D6")]
		[Address(RVA = "0x33902E0", Offset = "0x338E8E0", VA = "0x1833902E0")]
		public PlayerNameUiLink()
		{
		}

		// Token: 0x040020F0 RID: 8432
		[Token(Token = "0x40020F0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PlayerName _playerNameLinkedUi;

		// Token: 0x040020F1 RID: 8433
		[Token(Token = "0x40020F1")]
		[FieldOffset(Offset = "0x28")]
		private string _playerName;

		// Token: 0x040020F2 RID: 8434
		[Token(Token = "0x40020F2")]
		[FieldOffset(Offset = "0x30")]
		private Color _playerColor;

		// Token: 0x040020F3 RID: 8435
		[Token(Token = "0x40020F3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GPSLocator _gpsLocator;

		// Token: 0x040020F4 RID: 8436
		[Token(Token = "0x40020F4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _uiElementId;

		// Token: 0x040020F5 RID: 8437
		[Token(Token = "0x40020F5")]
		[FieldOffset(Offset = "0x50")]
		private GameObject _uiGameObject;

		// Token: 0x040020F6 RID: 8438
		[Token(Token = "0x40020F6")]
		[FieldOffset(Offset = "0x58")]
		private int _uiElementIdHash;

		// Token: 0x040020F7 RID: 8439
		[Token(Token = "0x40020F7")]
		[FieldOffset(Offset = "0x5C")]
		private bool _newUiElement;

		// Token: 0x040020F8 RID: 8440
		[Token(Token = "0x40020F8")]
		[FieldOffset(Offset = "0x60")]
		private PlayerInventory.PlayerViews _currentState;

		// Token: 0x040020F9 RID: 8441
		[Token(Token = "0x40020F9")]
		[FieldOffset(Offset = "0x68")]
		private string _cachedUiElementId;

		// Token: 0x040020FA RID: 8442
		[Token(Token = "0x40020FA")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 _offset;

		// Token: 0x040020FB RID: 8443
		[Token(Token = "0x40020FB")]
		[FieldOffset(Offset = "0x7C")]
		private bool _isDirty;
	}
}
