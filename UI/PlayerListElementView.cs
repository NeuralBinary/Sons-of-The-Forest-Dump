using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Sons.UI
{
	// Token: 0x020004FA RID: 1274
	[Token(Token = "0x20004FA")]
	[AddComponentMenu("Sons/UI/PlayerListElementView")]
	public class PlayerListElementView : MonoBehaviour
	{
		// Token: 0x0600208C RID: 8332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600208C")]
		[Address(RVA = "0x2D2C7B0", Offset = "0x2D2B7B0", VA = "0x182D2C7B0")]
		public void Initialize(int connectionId, ulong steamId, string playerName, bool adminControl, string dummy, bool showProfileButton, bool showKickButton, bool showBanButton, bool showRoles, bool enableRoles, string playerRole)
		{
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600208D")]
		[Address(RVA = "0x2D2C700", Offset = "0x2D2B700", VA = "0x182D2C700")]
		public Selectable GetSelectableAt(int index)
		{
			return null;
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x00009648 File Offset: 0x00007848
		[Token(Token = "0x600208E")]
		[Address(RVA = "0x2D2D1A0", Offset = "0x2D2C1A0", VA = "0x182D2D1A0")]
		public bool TryGetSelectableIndex(GameObject currentSelected, out int o)
		{
			return default(bool);
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600208F")]
		[Address(RVA = "0x2D2D2A0", Offset = "0x2D2C2A0", VA = "0x182D2D2A0")]
		public void UpdateNavigation(PlayerListElementView previous, PlayerListElementView next)
		{
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x00009660 File Offset: 0x00007860
		[Token(Token = "0x6002090")]
		[Address(RVA = "0x2D2C630", Offset = "0x2D2B630", VA = "0x182D2C630")]
		private int GetRoleDropdownIndexFromRoleAsStr(string playerRole)
		{
			return default(int);
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002091")]
		[Address(RVA = "0x2D2D040", Offset = "0x2D2C040", VA = "0x182D2D040")]
		private void ShowPlayerRoleIcon(string playerRoleIcon)
		{
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002092")]
		[Address(RVA = "0x2D2C5B0", Offset = "0x2D2B5B0", VA = "0x182D2C5B0")]
		private void AddOnClickListener(Button targetButton, UnityAction targetAction)
		{
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002093")]
		[Address(RVA = "0x2D2C520", Offset = "0x2D2B520", VA = "0x182D2C520")]
		private void AddDropdownListener(TMP_Dropdown targetDropdown, UnityAction<int> targetAction)
		{
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002094")]
		[Address(RVA = "0x2D2CFE0", Offset = "0x2D2BFE0", VA = "0x182D2CFE0")]
		private void OnProfileClick()
		{
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002095")]
		[Address(RVA = "0x2D2CFC0", Offset = "0x2D2BFC0", VA = "0x182D2CFC0")]
		private void OnKickClick()
		{
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002096")]
		[Address(RVA = "0x2D2CFA0", Offset = "0x2D2BFA0", VA = "0x182D2CFA0")]
		private void OnBanClick()
		{
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002097")]
		[Address(RVA = "0x2D2D000", Offset = "0x2D2C000", VA = "0x182D2D000")]
		private void OnRoleChanged(int index)
		{
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002098")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public PlayerListElementView()
		{
		}

		// Token: 0x04001E4E RID: 7758
		[Token(Token = "0x4001E4E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _playerName;

		// Token: 0x04001E4F RID: 7759
		[Token(Token = "0x4001E4F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _playerRoleIcon;

		// Token: 0x04001E50 RID: 7760
		[Token(Token = "0x4001E50")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<NamedObject> _playerRoleIconImages;

		// Token: 0x04001E51 RID: 7761
		[Token(Token = "0x4001E51")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TMP_Dropdown _roleDropdown;

		// Token: 0x04001E52 RID: 7762
		[Token(Token = "0x4001E52")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TMP_Dropdown _disabledRoleDropdown;

		// Token: 0x04001E53 RID: 7763
		[Token(Token = "0x4001E53")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _profileButton;

		// Token: 0x04001E54 RID: 7764
		[Token(Token = "0x4001E54")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _kickButton;

		// Token: 0x04001E55 RID: 7765
		[Token(Token = "0x4001E55")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _banButton;

		// Token: 0x04001E56 RID: 7766
		[Token(Token = "0x4001E56")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LayoutGroup _rightAnchor;

		// Token: 0x04001E57 RID: 7767
		[Token(Token = "0x4001E57")]
		[FieldOffset(Offset = "0x68")]
		[Header("Navigation")]
		[SerializeField]
		private Selectable[] _selectables;

		// Token: 0x04001E58 RID: 7768
		[Token(Token = "0x4001E58")]
		[FieldOffset(Offset = "0x70")]
		private int _connectionId;

		// Token: 0x04001E59 RID: 7769
		[Token(Token = "0x4001E59")]
		[FieldOffset(Offset = "0x78")]
		private ulong _steamId;

		// Token: 0x04001E5A RID: 7770
		[Token(Token = "0x4001E5A")]
		[FieldOffset(Offset = "0x80")]
		public Action<int, ulong> OnProfileClicked;

		// Token: 0x04001E5B RID: 7771
		[Token(Token = "0x4001E5B")]
		[FieldOffset(Offset = "0x88")]
		public Action<int, ulong> OnKickClicked;

		// Token: 0x04001E5C RID: 7772
		[Token(Token = "0x4001E5C")]
		[FieldOffset(Offset = "0x90")]
		public Action<int, ulong> OnBanClicked;

		// Token: 0x04001E5D RID: 7773
		[Token(Token = "0x4001E5D")]
		[FieldOffset(Offset = "0x98")]
		public Action<int, ulong> OnGuestSelected;

		// Token: 0x04001E5E RID: 7774
		[Token(Token = "0x4001E5E")]
		[FieldOffset(Offset = "0xA0")]
		public Action<int, ulong> OnTrustedSelected;

		// Token: 0x04001E5F RID: 7775
		[Token(Token = "0x4001E5F")]
		[FieldOffset(Offset = "0xA8")]
		public Action<int, ulong> OnAdminSelected;
	}
}
