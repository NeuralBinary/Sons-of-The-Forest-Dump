using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using NGUI.Tweening;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003F7 RID: 1015
	[Token(Token = "0x20003F7")]
	public class ItemDualActionWidget : MonoBehaviour
	{
		// Token: 0x06001AC4 RID: 6852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC4")]
		[Address(RVA = "0x2CE2600", Offset = "0x2CE1600", VA = "0x182CE2600")]
		public void Show(bool takeIcon, bool craftIcon, [Optional] Transform follow)
		{
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC5")]
		[Address(RVA = "0x2CE2900", Offset = "0x2CE1900", VA = "0x182CE2900")]
		public void ShutDown()
		{
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC6")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ItemDualActionWidget()
		{
		}

		// Token: 0x04001A01 RID: 6657
		[Token(Token = "0x4001A01")]
		[FieldOffset(Offset = "0x20")]
		public UiFollowTarget _follow;

		// Token: 0x04001A02 RID: 6658
		[Token(Token = "0x4001A02")]
		[FieldOffset(Offset = "0x28")]
		public ActionIconUISprite _takeActionIcon;

		// Token: 0x04001A03 RID: 6659
		[Token(Token = "0x4001A03")]
		[FieldOffset(Offset = "0x30")]
		public UITweener _takeActionTweener;

		// Token: 0x04001A04 RID: 6660
		[Token(Token = "0x4001A04")]
		[FieldOffset(Offset = "0x38")]
		public ActionIconUISprite _craftActionIcon;

		// Token: 0x04001A05 RID: 6661
		[Token(Token = "0x4001A05")]
		[FieldOffset(Offset = "0x40")]
		public UITweener _craftActionTweener;
	}
}
