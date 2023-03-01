using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using NGUI.Interaction;
using NGUI.Tweening;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003F8 RID: 1016
	[Token(Token = "0x20003F8")]
	public class ItemListWidget : MonoBehaviour
	{
		// Token: 0x06001AC7 RID: 6855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC7")]
		[Address(RVA = "0x2CE4B20", Offset = "0x2CE3B20", VA = "0x182CE4B20")]
		public void ShowSingle(int itemId, [Optional] Transform follow, SideIcons sideIcon = SideIcons.None)
		{
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC8")]
		[Address(RVA = "0x2CE4320", Offset = "0x2CE3320", VA = "0x182CE4320")]
		public void ShowSingle(int itemId, int amountItemId, [Optional] Transform follow, SideIcons sideIcon = SideIcons.None)
		{
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC9")]
		[Address(RVA = "0x2CE3FC0", Offset = "0x2CE2FC0", VA = "0x182CE3FC0")]
		public void ShowList(int itemId, [Optional] Transform follow, SideIcons sideIcon = SideIcons.None)
		{
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ACA")]
		[Address(RVA = "0x2CE2EF0", Offset = "0x2CE1EF0", VA = "0x182CE2EF0")]
		public void ShowList(int itemId, int amountItemId = -1, [Optional] Transform follow, SideIcons sideIcon = SideIcons.None)
		{
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x00007F08 File Offset: 0x00006108
		[Token(Token = "0x6001ACB")]
		[Address(RVA = "0x2CE2E60", Offset = "0x2CE1E60", VA = "0x182CE2E60")]
		private int GetNextValidIndexOffset()
		{
			return default(int);
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x00007F20 File Offset: 0x00006120
		[Token(Token = "0x6001ACC")]
		[Address(RVA = "0x2CE2B50", Offset = "0x2CE1B50", VA = "0x182CE2B50")]
		private int FindItemIndex(int itemId)
		{
			return default(int);
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ACD")]
		[Address(RVA = "0x2CE4CB0", Offset = "0x2CE3CB0", VA = "0x182CE4CB0")]
		private void UpdateLabel(int amountItemId, ItemListWidgetEntry target)
		{
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ACE")]
		[Address(RVA = "0x2CE4B50", Offset = "0x2CE3B50", VA = "0x182CE4B50")]
		public void Shutdown()
		{
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ACF")]
		[Address(RVA = "0x2CE3FF0", Offset = "0x2CE2FF0", VA = "0x182CE3FF0")]
		public void ShowNoValidOption([Optional] Transform follow)
		{
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD0")]
		[Address(RVA = "0x2CE4E70", Offset = "0x2CE3E70", VA = "0x182CE4E70")]
		private void UpdateMasterActionIcon(SideIcons sideIcon, bool useFillSprite)
		{
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD1")]
		[Address(RVA = "0x2CE4F70", Offset = "0x2CE3F70", VA = "0x182CE4F70")]
		public ItemListWidget()
		{
		}

		// Token: 0x04001A06 RID: 6662
		[Token(Token = "0x4001A06")]
		[FieldOffset(Offset = "0x20")]
		public UiFollowTarget _follow;

		// Token: 0x04001A07 RID: 6663
		[Token(Token = "0x4001A07")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid _grid;

		// Token: 0x04001A08 RID: 6664
		[Token(Token = "0x4001A08")]
		[FieldOffset(Offset = "0x30")]
		public GameObject _rotateIcon;

		// Token: 0x04001A09 RID: 6665
		[Token(Token = "0x4001A09")]
		[FieldOffset(Offset = "0x38")]
		public GameObject _noValidOptionfallbackIcon;

		// Token: 0x04001A0A RID: 6666
		[Token(Token = "0x4001A0A")]
		[FieldOffset(Offset = "0x40")]
		public ItemListWidgetEntry[] _singleItems;

		// Token: 0x04001A0B RID: 6667
		[Token(Token = "0x4001A0B")]
		[FieldOffset(Offset = "0x48")]
		public ItemListWidgetEntry[] _rotationItems;

		// Token: 0x04001A0C RID: 6668
		[Token(Token = "0x4001A0C")]
		[FieldOffset(Offset = "0x50")]
		public ActionIconUISprite _masterActionIcon;

		// Token: 0x04001A0D RID: 6669
		[Token(Token = "0x4001A0D")]
		[FieldOffset(Offset = "0x58")]
		public UITweener[] _tweeners;

		// Token: 0x04001A0E RID: 6670
		[Token(Token = "0x4001A0E")]
		[FieldOffset(Offset = "0x60")]
		public Vector3 _leavingEntryLerpTo;

		// Token: 0x04001A0F RID: 6671
		[Token(Token = "0x4001A0F")]
		[FieldOffset(Offset = "0x6C")]
		public float _leavingDuration;

		// Token: 0x04001A10 RID: 6672
		[Token(Token = "0x4001A10")]
		[FieldOffset(Offset = "0x70")]
		public bool _showLeavingEntry;

		// Token: 0x04001A11 RID: 6673
		[Token(Token = "0x4001A11")]
		[FieldOffset(Offset = "0x71")]
		public bool _scaleWithDistanceToTargetEntry;

		// Token: 0x04001A12 RID: 6674
		[Token(Token = "0x4001A12")]
		[FieldOffset(Offset = "0x72")]
		public bool _checkOwnership;

		// Token: 0x04001A13 RID: 6675
		[Token(Token = "0x4001A13")]
		[FieldOffset(Offset = "0x73")]
		public bool _labelShowsAmount;

		// Token: 0x04001A14 RID: 6676
		[Token(Token = "0x4001A14")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private bool _disableLabel;

		// Token: 0x04001A15 RID: 6677
		[Token(Token = "0x4001A15")]
		[FieldOffset(Offset = "0x78")]
		private int _maxDisplayed;

		// Token: 0x04001A16 RID: 6678
		[Token(Token = "0x4001A16")]
		[FieldOffset(Offset = "0x7C")]
		private int _lastAmountDisplayed;

		// Token: 0x04001A17 RID: 6679
		[Token(Token = "0x4001A17")]
		[FieldOffset(Offset = "0x80")]
		private float _lastTargetChangeTime;

		// Token: 0x04001A18 RID: 6680
		[Token(Token = "0x4001A18")]
		[FieldOffset(Offset = "0x84")]
		private int _prevTargetedListEntry;

		// Token: 0x04001A19 RID: 6681
		[Token(Token = "0x4001A19")]
		[FieldOffset(Offset = "0x88")]
		private int _lastTargetedListEntry;

		// Token: 0x04001A1A RID: 6682
		[Token(Token = "0x4001A1A")]
		[FieldOffset(Offset = "0x8C")]
		private bool _fixPrevTargetedEntryPosition;

		// Token: 0x04001A1B RID: 6683
		[Token(Token = "0x4001A1B")]
		[FieldOffset(Offset = "0x90")]
		private List<int> _missingItems;
	}
}
