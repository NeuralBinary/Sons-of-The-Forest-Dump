using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using NGUI.Tweening;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003E9 RID: 1001
	[Token(Token = "0x20003E9")]
	public class ItemDualActionWidget : MonoBehaviour
	{
		// Token: 0x06001B02 RID: 6914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B02")]
		[Address(RVA = "0x32ACAD0", Offset = "0x32AB0D0", VA = "0x1832ACAD0")]
		public void Show(bool takeIcon, bool craftIcon, [Optional] Transform follow)
		{
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B03")]
		[Address(RVA = "0x32AD310", Offset = "0x32AB910", VA = "0x1832AD310")]
		public void ShutDown()
		{
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B04")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ItemDualActionWidget()
		{
		}

		// Token: 0x04001A25 RID: 6693
		[Token(Token = "0x4001A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UiFollowTarget _follow;

		// Token: 0x04001A26 RID: 6694
		[Token(Token = "0x4001A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ActionIconUISprite _takeActionIcon;

		// Token: 0x04001A27 RID: 6695
		[Token(Token = "0x4001A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UITweener _takeActionTweener;

		// Token: 0x04001A28 RID: 6696
		[Token(Token = "0x4001A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ActionIconUISprite _craftActionIcon;

		// Token: 0x04001A29 RID: 6697
		[Token(Token = "0x4001A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UITweener _craftActionTweener;
	}
}
