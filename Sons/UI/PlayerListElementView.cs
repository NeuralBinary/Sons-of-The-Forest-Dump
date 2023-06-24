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
	// Token: 0x020004F9 RID: 1273
	[Token(Token = "0x20004F9")]
	[AddComponentMenu("Sons/UI/PlayerListElementView")]
	public class PlayerListElementView : MonoBehaviour
	{
		// Token: 0x0600213F RID: 8511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600213F")]
		[Address(RVA = "0x33254A0", Offset = "0x3323AA0", VA = "0x1833254A0")]
		public void Initialize(ulong steamId, string playerName, bool adminControl, string dummy, bool showProfileButton, bool showKickButton, bool showBanButton, bool showRoles, bool enableRoles, string playerRole)
		{
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002140")]
		[Address(RVA = "0x33260D0", Offset = "0x33246D0", VA = "0x1833260D0")]
		public Selectable GetSelectableAt(int index)
		{
			return null;
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x00009B40 File Offset: 0x00007D40
		[Token(Token = "0x6002141")]
		[Address(RVA = "0x3326220", Offset = "0x3324820", VA = "0x183326220")]
		public bool TryGetSelectableIndex(GameObject currentSelected, out int o)
		{
			return default(bool);
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002142")]
		[Address(RVA = "0x3326400", Offset = "0x3324A00", VA = "0x183326400")]
		public void UpdateNavigation(PlayerListElementView previous, PlayerListElementView next)
		{
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x00009B58 File Offset: 0x00007D58
		[Token(Token = "0x6002143")]
		[Address(RVA = "0x3326BB0", Offset = "0x33251B0", VA = "0x183326BB0")]
		private int GetRoleDropdownIndexFromRoleAsStr(string playerRole)
		{
			return 0;
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002144")]
		[Address(RVA = "0x3326D70", Offset = "0x3325370", VA = "0x183326D70")]
		private void ShowPlayerRoleIcon(string playerRoleIcon)
		{
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002145")]
		[Address(RVA = "0x3326F60", Offset = "0x3325560", VA = "0x183326F60")]
		private void AddOnClickListener(Button targetButton, UnityAction targetAction)
		{
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002146")]
		[Address(RVA = "0x3327040", Offset = "0x3325640", VA = "0x183327040")]
		private void AddDropdownListener(TMP_Dropdown targetDropdown, UnityAction<int> targetAction)
		{
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002147")]
		[Address(RVA = "0x3327120", Offset = "0x3325720", VA = "0x183327120")]
		private void OnProfileClick()
		{
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002148")]
		[Address(RVA = "0x3327140", Offset = "0x3325740", VA = "0x183327140")]
		private void OnKickClick()
		{
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002149")]
		[Address(RVA = "0x3327160", Offset = "0x3325760", VA = "0x183327160")]
		private void OnBanClick()
		{
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600214A")]
		[Address(RVA = "0x3327180", Offset = "0x3325780", VA = "0x183327180")]
		private void OnRoleChanged(int index)
		{
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600214B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PlayerListElementView()
		{
		}

		// Token: 0x04001EDE RID: 7902
		[Token(Token = "0x4001EDE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _playerName;

		// Token: 0x04001EDF RID: 7903
		[Token(Token = "0x4001EDF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _playerRoleIcon;

		// Token: 0x04001EE0 RID: 7904
		[Token(Token = "0x4001EE0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<NamedObject> _playerRoleIconImages;

		// Token: 0x04001EE1 RID: 7905
		[Token(Token = "0x4001EE1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TMP_Dropdown _roleDropdown;

		// Token: 0x04001EE2 RID: 7906
		[Token(Token = "0x4001EE2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TMP_Dropdown _disabledRoleDropdown;

		// Token: 0x04001EE3 RID: 7907
		[Token(Token = "0x4001EE3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _profileButton;

		// Token: 0x04001EE4 RID: 7908
		[Token(Token = "0x4001EE4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _kickButton;

		// Token: 0x04001EE5 RID: 7909
		[Token(Token = "0x4001EE5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _banButton;

		// Token: 0x04001EE6 RID: 7910
		[Token(Token = "0x4001EE6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LayoutGroup _rightAnchor;

		// Token: 0x04001EE7 RID: 7911
		[Token(Token = "0x4001EE7")]
		[FieldOffset(Offset = "0x68")]
		[Header("Navigation")]
		[SerializeField]
		private Selectable[] _selectables;

		// Token: 0x04001EE8 RID: 7912
		[Token(Token = "0x4001EE8")]
		[FieldOffset(Offset = "0x70")]
		private ulong _steamId;

		// Token: 0x04001EE9 RID: 7913
		[Token(Token = "0x4001EE9")]
		[FieldOffset(Offset = "0x78")]
		public Action<ulong> OnProfileClicked;

		// Token: 0x04001EEA RID: 7914
		[Token(Token = "0x4001EEA")]
		[FieldOffset(Offset = "0x80")]
		public Action<ulong> OnKickClicked;

		// Token: 0x04001EEB RID: 7915
		[Token(Token = "0x4001EEB")]
		[FieldOffset(Offset = "0x88")]
		public Action<ulong> OnBanClicked;

		// Token: 0x04001EEC RID: 7916
		[Token(Token = "0x4001EEC")]
		[FieldOffset(Offset = "0x90")]
		public Action<ulong> OnGuestSelected;

		// Token: 0x04001EED RID: 7917
		[Token(Token = "0x4001EED")]
		[FieldOffset(Offset = "0x98")]
		public Action<ulong> OnTrustedSelected;

		// Token: 0x04001EEE RID: 7918
		[Token(Token = "0x4001EEE")]
		[FieldOffset(Offset = "0xA0")]
		public Action<ulong> OnAdminSelected;
	}
}
