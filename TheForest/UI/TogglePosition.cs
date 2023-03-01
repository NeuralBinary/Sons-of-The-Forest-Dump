using System;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x0200040C RID: 1036
	[Token(Token = "0x200040C")]
	public class TogglePosition : MonoBehaviour
	{
		// Token: 0x06001B26 RID: 6950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B26")]
		[Address(RVA = "0x2CEF6F0", Offset = "0x2CEE6F0", VA = "0x182CEF6F0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B27")]
		[Address(RVA = "0x2CEF690", Offset = "0x2CEE690", VA = "0x182CEF690")]
		private void OnDisable()
		{
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B28")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public TogglePosition()
		{
		}

		// Token: 0x04001A73 RID: 6771
		[Token(Token = "0x4001A73")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget _target;

		// Token: 0x04001A74 RID: 6772
		[Token(Token = "0x4001A74")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 _originalPosition;

		// Token: 0x04001A75 RID: 6773
		[Token(Token = "0x4001A75")]
		[FieldOffset(Offset = "0x34")]
		private UIRect.AnchorUpdate _anchorUpdate;
	}
}
