using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Gameplay.GPS;
using TheForest.Items.Inventory;
using UnityEngine;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x0200055D RID: 1373
	[Token(Token = "0x200055D")]
	[AddComponentMenu("Sons/Multiplayer/Gui/PlayerNameUiLink")]
	public class PlayerNameUiLink : MonoBehaviour
	{
		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x060023CD RID: 9165 RVA: 0x0000A530 File Offset: 0x00008730
		// (set) Token: 0x060023CE RID: 9166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004CC")]
		public bool IsActive
		{
			[Token(Token = "0x60023CD")]
			[Address(RVA = "0x2B5E100", Offset = "0x2B5D100", VA = "0x182B5E100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60023CE")]
			[Address(RVA = "0x2B5E150", Offset = "0x2B5D150", VA = "0x182B5E150")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CF")]
		[Address(RVA = "0x2D63560", Offset = "0x2D62560", VA = "0x182D63560")]
		public void SetPlayerName(string playerName)
		{
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D0")]
		[Address(RVA = "0x2D63780", Offset = "0x2D62780", VA = "0x182D63780")]
		private void Update()
		{
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D1")]
		[Address(RVA = "0x2D63390", Offset = "0x2D62390", VA = "0x182D63390")]
		private void RemoveElement()
		{
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x0000A548 File Offset: 0x00008748
		[Token(Token = "0x60023D2")]
		[Address(RVA = "0x2D62FD0", Offset = "0x2D61FD0", VA = "0x182D62FD0")]
		private bool IsInFront(Transform viewTransform, Vector3 targetPosition)
		{
			return default(bool);
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D3")]
		[Address(RVA = "0x2D631C0", Offset = "0x2D621C0", VA = "0x182D631C0")]
		private void RefreshPlayerNameLinkedUi()
		{
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D4")]
		[Address(RVA = "0x2D630B0", Offset = "0x2D620B0", VA = "0x182D630B0")]
		private void RefreshGpsProperties()
		{
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D5")]
		[Address(RVA = "0x2D630A0", Offset = "0x2D620A0", VA = "0x182D630A0")]
		private void OnDisable()
		{
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D6")]
		[Address(RVA = "0x2D63550", Offset = "0x2D62550", VA = "0x182D63550")]
		public void SetPlayerColor(Color playerColor)
		{
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D7")]
		[Address(RVA = "0x2D63580", Offset = "0x2D62580", VA = "0x182D63580")]
		private void ShowElement(Vector3 position, Transform targetTransform)
		{
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x0000A560 File Offset: 0x00008760
		[Token(Token = "0x60023D8")]
		[Address(RVA = "0x2D63430", Offset = "0x2D62430", VA = "0x182D63430")]
		private bool RequestUiElement()
		{
			return default(bool);
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D9")]
		[Address(RVA = "0x2D63090", Offset = "0x2D62090", VA = "0x182D63090")]
		public void OnCurrentViewChanged(PlayerInventory.PlayerViews stateCurrentView)
		{
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DA")]
		[Address(RVA = "0x2D63B20", Offset = "0x2D62B20", VA = "0x182D63B20")]
		public PlayerNameUiLink()
		{
		}

		// Token: 0x04002020 RID: 8224
		[Token(Token = "0x4002020")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PlayerName _playerNameLinkedUi;

		// Token: 0x04002021 RID: 8225
		[Token(Token = "0x4002021")]
		[FieldOffset(Offset = "0x28")]
		private string _playerName;

		// Token: 0x04002022 RID: 8226
		[Token(Token = "0x4002022")]
		[FieldOffset(Offset = "0x30")]
		private Color _playerColor;

		// Token: 0x04002023 RID: 8227
		[Token(Token = "0x4002023")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GPSLocator _gpsLocator;

		// Token: 0x04002024 RID: 8228
		[Token(Token = "0x4002024")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _uiElementId;

		// Token: 0x04002025 RID: 8229
		[Token(Token = "0x4002025")]
		[FieldOffset(Offset = "0x50")]
		private GameObject _uiGameObject;

		// Token: 0x04002026 RID: 8230
		[Token(Token = "0x4002026")]
		[FieldOffset(Offset = "0x58")]
		private int _uiElementIdHash;

		// Token: 0x04002027 RID: 8231
		[Token(Token = "0x4002027")]
		[FieldOffset(Offset = "0x5C")]
		private bool _newUiElement;

		// Token: 0x04002028 RID: 8232
		[Token(Token = "0x4002028")]
		[FieldOffset(Offset = "0x60")]
		private PlayerInventory.PlayerViews _currentState;

		// Token: 0x04002029 RID: 8233
		[Token(Token = "0x4002029")]
		[FieldOffset(Offset = "0x68")]
		private string _cachedUiElementId;

		// Token: 0x0400202A RID: 8234
		[Token(Token = "0x400202A")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 _offset;

		// Token: 0x0400202B RID: 8235
		[Token(Token = "0x400202B")]
		[FieldOffset(Offset = "0x7C")]
		private bool _isDirty;
	}
}
