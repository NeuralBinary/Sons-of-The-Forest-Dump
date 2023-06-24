using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TheForest.Items.Inventory;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x0200056A RID: 1386
	[Token(Token = "0x200056A")]
	[AddComponentMenu("Sons/Multiplayer/Gui/PlayerName")]
	public class PlayerName : MonoBehaviour
	{
		// Token: 0x060024BC RID: 9404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024BC")]
		[Address(RVA = "0x338DB60", Offset = "0x338C160", VA = "0x18338DB60")]
		private void OnDestroy()
		{
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024BD")]
		[Address(RVA = "0x338DCA0", Offset = "0x338C2A0", VA = "0x18338DCA0")]
		private void Update()
		{
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024BE")]
		[Address(RVA = "0x338DD50", Offset = "0x338C350", VA = "0x18338DD50")]
		private void UpdateDistanceSwitch()
		{
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x0000ABD8 File Offset: 0x00008DD8
		[Token(Token = "0x60024BF")]
		[Address(RVA = "0x338DE50", Offset = "0x338C450", VA = "0x18338DE50")]
		private float CalculateFarScale(float distance)
		{
			return 0f;
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C0")]
		[Address(RVA = "0x338DEC0", Offset = "0x338C4C0", VA = "0x18338DEC0")]
		private void EnableFarMarker(bool value, float scale = 0f)
		{
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C1")]
		[Address(RVA = "0x338E320", Offset = "0x338C920", VA = "0x18338E320")]
		public void SetPlayerColor(Color statePlayerColor)
		{
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C2")]
		[Address(RVA = "0x338E7C0", Offset = "0x338CDC0", VA = "0x18338E7C0")]
		public void SetPlayerName(string playerName)
		{
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C3")]
		[Address(RVA = "0x338ECB0", Offset = "0x338D2B0", VA = "0x18338ECB0")]
		private static string GetFirstLetters(string name)
		{
			return null;
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C4")]
		[Address(RVA = "0x338ED60", Offset = "0x338D360", VA = "0x18338ED60")]
		public void OnCurrentViewChanged(PlayerInventory.PlayerViews newView)
		{
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C5")]
		[Address(RVA = "0x338ED60", Offset = "0x338D360", VA = "0x18338ED60")]
		private void RefreshPlayerView(PlayerInventory.PlayerViews newView)
		{
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C6")]
		[Address(RVA = "0x338EE30", Offset = "0x338D430", VA = "0x18338EE30")]
		private static void ShowIcon(GameObject iconGroup, bool inventoryIcon)
		{
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C7")]
		[Address(RVA = "0x338EF40", Offset = "0x338D540", VA = "0x18338EF40")]
		public void SetOffset(Vector3 offset)
		{
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C8")]
		[Address(RVA = "0x338F050", Offset = "0x338D650", VA = "0x18338F050")]
		public PlayerName()
		{
		}

		// Token: 0x040020D3 RID: 8403
		[Token(Token = "0x40020D3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BoltEntity _entity;

		// Token: 0x040020D4 RID: 8404
		[Token(Token = "0x40020D4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _showing;

		// Token: 0x040020D5 RID: 8405
		[Token(Token = "0x40020D5")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _nearRange;

		// Token: 0x040020D6 RID: 8406
		[Token(Token = "0x40020D6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _farRange;

		// Token: 0x040020D7 RID: 8407
		[Token(Token = "0x40020D7")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _nearRangeTextSize;

		// Token: 0x040020D8 RID: 8408
		[Token(Token = "0x40020D8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _farRangeTextSize;

		// Token: 0x040020D9 RID: 8409
		[Token(Token = "0x40020D9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _inventoryIconGroup;

		// Token: 0x040020DA RID: 8410
		[Token(Token = "0x40020DA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _deathIconGroup;

		// Token: 0x040020DB RID: 8411
		[Token(Token = "0x40020DB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _sleepIconGroup;

		// Token: 0x040020DC RID: 8412
		[Token(Token = "0x40020DC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _grabBagIconGroup;

		// Token: 0x040020DD RID: 8413
		[Token(Token = "0x40020DD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<TMP_Text> _targetText;

		// Token: 0x040020DE RID: 8414
		[Token(Token = "0x40020DE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<TMP_Text> _firstCharacterText;

		// Token: 0x040020DF RID: 8415
		[Token(Token = "0x40020DF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _uiName;

		// Token: 0x040020E0 RID: 8416
		[Token(Token = "0x40020E0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _badgeName;

		// Token: 0x040020E1 RID: 8417
		[Token(Token = "0x40020E1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _playerDarkColorScale;

		// Token: 0x040020E2 RID: 8418
		[Token(Token = "0x40020E2")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private List<Image> _playerColorImages;

		// Token: 0x040020E3 RID: 8419
		[Token(Token = "0x40020E3")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private List<Image> _darkPlayerColorImages;

		// Token: 0x040020E4 RID: 8420
		[Token(Token = "0x40020E4")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private List<GameObject> _nearMarkerObjects;

		// Token: 0x040020E5 RID: 8421
		[Token(Token = "0x40020E5")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private List<GameObject> _farMarkerObjects;

		// Token: 0x040020E6 RID: 8422
		[Token(Token = "0x40020E6")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AnimationCurve _distanceScaleCurve;

		// Token: 0x040020E7 RID: 8423
		[Token(Token = "0x40020E7")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float _farMarkerSwitchDistance;

		// Token: 0x040020E8 RID: 8424
		[Token(Token = "0x40020E8")]
		[FieldOffset(Offset = "0xB8")]
		private IPlayerState _playerState;

		// Token: 0x040020E9 RID: 8425
		[Token(Token = "0x40020E9")]
		[FieldOffset(Offset = "0xC0")]
		private PlayerOverlay _overlay;

		// Token: 0x040020EA RID: 8426
		[Token(Token = "0x40020EA")]
		[FieldOffset(Offset = "0xC8")]
		private Transform _overlayTr;

		// Token: 0x040020EB RID: 8427
		[Token(Token = "0x40020EB")]
		[FieldOffset(Offset = "0xD0")]
		private PlayerName.Modes _mode;

		// Token: 0x040020EC RID: 8428
		[Token(Token = "0x40020EC")]
		[FieldOffset(Offset = "0xD4")]
		private Vector3 _offset;

		// Token: 0x0200056B RID: 1387
		[Token(Token = "0x200056B")]
		public enum Modes
		{
			// Token: 0x040020EE RID: 8430
			[Token(Token = "0x40020EE")]
			Hidden,
			// Token: 0x040020EF RID: 8431
			[Token(Token = "0x40020EF")]
			Shown
		}
	}
}
