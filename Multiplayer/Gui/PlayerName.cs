using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TheForest.Items.Inventory;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x0200055B RID: 1371
	[Token(Token = "0x200055B")]
	[AddComponentMenu("Sons/Multiplayer/Gui/PlayerName")]
	public class PlayerName : MonoBehaviour
	{
		// Token: 0x060023C0 RID: 9152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C0")]
		[Address(RVA = "0x2D63EF0", Offset = "0x2D62EF0", VA = "0x182D63EF0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C1")]
		[Address(RVA = "0x2D64AB0", Offset = "0x2D63AB0", VA = "0x182D64AB0")]
		private void Update()
		{
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C2")]
		[Address(RVA = "0x2D649B0", Offset = "0x2D639B0", VA = "0x182D649B0")]
		private void UpdateDistanceSwitch()
		{
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x0000A518 File Offset: 0x00008718
		[Token(Token = "0x60023C3")]
		[Address(RVA = "0x2D63B70", Offset = "0x2D62B70", VA = "0x182D63B70")]
		private float CalculateFarScale(float distance)
		{
			return default(float);
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C4")]
		[Address(RVA = "0x2D63BA0", Offset = "0x2D62BA0", VA = "0x182D63BA0")]
		private void EnableFarMarker(bool value, float scale = 0f)
		{
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C5")]
		[Address(RVA = "0x2D64300", Offset = "0x2D63300", VA = "0x182D64300")]
		public void SetPlayerColor(Color statePlayerColor)
		{
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C6")]
		[Address(RVA = "0x2D64620", Offset = "0x2D63620", VA = "0x182D64620")]
		public void SetPlayerName(string playerName)
		{
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C7")]
		[Address(RVA = "0x2D63E60", Offset = "0x2D62E60", VA = "0x182D63E60")]
		private static string GetFirstLetters(string name)
		{
			return null;
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C8")]
		[Address(RVA = "0x2D63EE0", Offset = "0x2D62EE0", VA = "0x182D63EE0")]
		public void OnCurrentViewChanged(PlayerInventory.PlayerViews newView)
		{
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C9")]
		[Address(RVA = "0x2D63F90", Offset = "0x2D62F90", VA = "0x182D63F90")]
		private void RefreshPlayerView(PlayerInventory.PlayerViews newView)
		{
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CA")]
		[Address(RVA = "0x2D64920", Offset = "0x2D63920", VA = "0x182D64920")]
		private static void ShowIcon(GameObject iconGroup, bool inventoryIcon)
		{
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CB")]
		[Address(RVA = "0x2D641F0", Offset = "0x2D631F0", VA = "0x182D641F0")]
		public void SetOffset(Vector3 offset)
		{
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CC")]
		[Address(RVA = "0x2D64AE0", Offset = "0x2D63AE0", VA = "0x182D64AE0")]
		public PlayerName()
		{
		}

		// Token: 0x04002003 RID: 8195
		[Token(Token = "0x4002003")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BoltEntity _entity;

		// Token: 0x04002004 RID: 8196
		[Token(Token = "0x4002004")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _showing;

		// Token: 0x04002005 RID: 8197
		[Token(Token = "0x4002005")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _nearRange;

		// Token: 0x04002006 RID: 8198
		[Token(Token = "0x4002006")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _farRange;

		// Token: 0x04002007 RID: 8199
		[Token(Token = "0x4002007")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _nearRangeTextSize;

		// Token: 0x04002008 RID: 8200
		[Token(Token = "0x4002008")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _farRangeTextSize;

		// Token: 0x04002009 RID: 8201
		[Token(Token = "0x4002009")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _inventoryIconGroup;

		// Token: 0x0400200A RID: 8202
		[Token(Token = "0x400200A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _deathIconGroup;

		// Token: 0x0400200B RID: 8203
		[Token(Token = "0x400200B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _sleepIconGroup;

		// Token: 0x0400200C RID: 8204
		[Token(Token = "0x400200C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _grabBagIconGroup;

		// Token: 0x0400200D RID: 8205
		[Token(Token = "0x400200D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<TMP_Text> _targetText;

		// Token: 0x0400200E RID: 8206
		[Token(Token = "0x400200E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<TMP_Text> _firstCharacterText;

		// Token: 0x0400200F RID: 8207
		[Token(Token = "0x400200F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _uiName;

		// Token: 0x04002010 RID: 8208
		[Token(Token = "0x4002010")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _badgeName;

		// Token: 0x04002011 RID: 8209
		[Token(Token = "0x4002011")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _playerDarkColorScale;

		// Token: 0x04002012 RID: 8210
		[Token(Token = "0x4002012")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private List<Image> _playerColorImages;

		// Token: 0x04002013 RID: 8211
		[Token(Token = "0x4002013")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private List<Image> _darkPlayerColorImages;

		// Token: 0x04002014 RID: 8212
		[Token(Token = "0x4002014")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private List<GameObject> _nearMarkerObjects;

		// Token: 0x04002015 RID: 8213
		[Token(Token = "0x4002015")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private List<GameObject> _farMarkerObjects;

		// Token: 0x04002016 RID: 8214
		[Token(Token = "0x4002016")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AnimationCurve _distanceScaleCurve;

		// Token: 0x04002017 RID: 8215
		[Token(Token = "0x4002017")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float _farMarkerSwitchDistance;

		// Token: 0x04002018 RID: 8216
		[Token(Token = "0x4002018")]
		[FieldOffset(Offset = "0xB8")]
		private IPlayerState _playerState;

		// Token: 0x04002019 RID: 8217
		[Token(Token = "0x4002019")]
		[FieldOffset(Offset = "0xC0")]
		private PlayerOverlay _overlay;

		// Token: 0x0400201A RID: 8218
		[Token(Token = "0x400201A")]
		[FieldOffset(Offset = "0xC8")]
		private Transform _overlayTr;

		// Token: 0x0400201B RID: 8219
		[Token(Token = "0x400201B")]
		[FieldOffset(Offset = "0xD0")]
		private PlayerName.Modes _mode;

		// Token: 0x0400201C RID: 8220
		[Token(Token = "0x400201C")]
		[FieldOffset(Offset = "0xD4")]
		private Vector3 _offset;

		// Token: 0x0200055C RID: 1372
		[Token(Token = "0x200055C")]
		public enum Modes
		{
			// Token: 0x0400201E RID: 8222
			[Token(Token = "0x400201E")]
			Hidden,
			// Token: 0x0400201F RID: 8223
			[Token(Token = "0x400201F")]
			Shown
		}
	}
}
