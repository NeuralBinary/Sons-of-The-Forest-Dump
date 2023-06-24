using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using NGUI.Interaction;
using NGUI.Tweening;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003EA RID: 1002
	[Token(Token = "0x20003EA")]
	public class ItemListWidget : MonoBehaviour
	{
		// Token: 0x06001B05 RID: 6917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B05")]
		[Address(RVA = "0x32AD330", Offset = "0x32AB930", VA = "0x1832AD330")]
		public void ShowSingle(int itemId, [Optional] Transform follow, SideIcons sideIcon = SideIcons.None)
		{
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B06")]
		[Address(RVA = "0x32AD360", Offset = "0x32AB960", VA = "0x1832AD360")]
		public void ShowSingle(int itemId, int amountItemId, [Optional] Transform follow, SideIcons sideIcon = SideIcons.None)
		{
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B07")]
		[Address(RVA = "0x32ADFD0", Offset = "0x32AC5D0", VA = "0x1832ADFD0")]
		public void ShowList(int itemId, [Optional] Transform follow, SideIcons sideIcon = SideIcons.None)
		{
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B08")]
		[Address(RVA = "0x32AE000", Offset = "0x32AC600", VA = "0x1832AE000")]
		public void ShowList(int itemId, int amountItemId = -1, [Optional] Transform follow, SideIcons sideIcon = SideIcons.None)
		{
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x00008190 File Offset: 0x00006390
		[Token(Token = "0x6001B09")]
		[Address(RVA = "0x32AF840", Offset = "0x32ADE40", VA = "0x1832AF840")]
		private int GetNextValidIndexOffset()
		{
			return 0;
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x000081A8 File Offset: 0x000063A8
		[Token(Token = "0x6001B0A")]
		[Address(RVA = "0x32AF8D0", Offset = "0x32ADED0", VA = "0x1832AF8D0")]
		private int FindItemIndex(int itemId)
		{
			return 0;
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B0B")]
		[Address(RVA = "0x32AFB70", Offset = "0x32AE170", VA = "0x1832AFB70")]
		private void UpdateLabel(int amountItemId, ItemListWidgetEntry target)
		{
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B0C")]
		[Address(RVA = "0x32AFC90", Offset = "0x32AE290", VA = "0x1832AFC90")]
		public void Shutdown()
		{
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B0D")]
		[Address(RVA = "0x32AFFC0", Offset = "0x32AE5C0", VA = "0x1832AFFC0")]
		public void ShowNoValidOption([Optional] Transform follow)
		{
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B0E")]
		[Address(RVA = "0x32B0580", Offset = "0x32AEB80", VA = "0x1832B0580")]
		private void UpdateMasterActionIcon(SideIcons sideIcon, bool useFillSprite)
		{
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B0F")]
		[Address(RVA = "0x32B07F0", Offset = "0x32AEDF0", VA = "0x1832B07F0")]
		public ItemListWidget()
		{
		}

		// Token: 0x04001A2A RID: 6698
		[Token(Token = "0x4001A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UiFollowTarget _follow;

		// Token: 0x04001A2B RID: 6699
		[Token(Token = "0x4001A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UIGrid _grid;

		// Token: 0x04001A2C RID: 6700
		[Token(Token = "0x4001A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject _rotateIcon;

		// Token: 0x04001A2D RID: 6701
		[Token(Token = "0x4001A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject _noValidOptionfallbackIcon;

		// Token: 0x04001A2E RID: 6702
		[Token(Token = "0x4001A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ItemListWidgetEntry[] _singleItems;

		// Token: 0x04001A2F RID: 6703
		[Token(Token = "0x4001A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ItemListWidgetEntry[] _rotationItems;

		// Token: 0x04001A30 RID: 6704
		[Token(Token = "0x4001A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ActionIconUISprite _masterActionIcon;

		// Token: 0x04001A31 RID: 6705
		[Token(Token = "0x4001A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UITweener[] _tweeners;

		// Token: 0x04001A32 RID: 6706
		[Token(Token = "0x4001A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 _leavingEntryLerpTo;

		// Token: 0x04001A33 RID: 6707
		[Token(Token = "0x4001A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float _leavingDuration;

		// Token: 0x04001A34 RID: 6708
		[Token(Token = "0x4001A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool _showLeavingEntry;

		// Token: 0x04001A35 RID: 6709
		[Token(Token = "0x4001A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		public bool _scaleWithDistanceToTargetEntry;

		// Token: 0x04001A36 RID: 6710
		[Token(Token = "0x4001A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		public bool _checkOwnership;

		// Token: 0x04001A37 RID: 6711
		[Token(Token = "0x4001A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
		public bool _labelShowsAmount;

		// Token: 0x04001A38 RID: 6712
		[Token(Token = "0x4001A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private bool _disableLabel;

		// Token: 0x04001A39 RID: 6713
		[Token(Token = "0x4001A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _maxDisplayed;

		// Token: 0x04001A3A RID: 6714
		[Token(Token = "0x4001A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int _lastAmountDisplayed;

		// Token: 0x04001A3B RID: 6715
		[Token(Token = "0x4001A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float _lastTargetChangeTime;

		// Token: 0x04001A3C RID: 6716
		[Token(Token = "0x4001A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int _prevTargetedListEntry;

		// Token: 0x04001A3D RID: 6717
		[Token(Token = "0x4001A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _lastTargetedListEntry;

		// Token: 0x04001A3E RID: 6718
		[Token(Token = "0x4001A3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _fixPrevTargetedEntryPosition;

		// Token: 0x04001A3F RID: 6719
		[Token(Token = "0x4001A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<int> _missingItems;
	}
}
