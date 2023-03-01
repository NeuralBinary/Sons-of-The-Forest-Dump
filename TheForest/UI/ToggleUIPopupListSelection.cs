using System;
using Il2CppDummyDll;
using NGUI.Interaction;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x0200040D RID: 1037
	[Token(Token = "0x200040D")]
	public class ToggleUIPopupListSelection : MonoBehaviour
	{
		// Token: 0x06001B29 RID: 6953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B29")]
		[Address(RVA = "0x2CEF800", Offset = "0x2CEE800", VA = "0x182CEF800")]
		private void Awake()
		{
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B2A")]
		[Address(RVA = "0x2CEF9F0", Offset = "0x2CEE9F0", VA = "0x182CEF9F0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B2B")]
		[Address(RVA = "0x2CEF8C0", Offset = "0x2CEE8C0", VA = "0x182CEF8C0")]
		private void OnClick()
		{
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B2C")]
		[Address(RVA = "0x2CEFCB0", Offset = "0x2CEECB0", VA = "0x182CEFCB0")]
		private void RefreshState()
		{
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B2D")]
		[Address(RVA = "0x2CEFA60", Offset = "0x2CEEA60", VA = "0x182CEFA60")]
		private void RefreshSiblingsState()
		{
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B2E")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ToggleUIPopupListSelection()
		{
		}

		// Token: 0x04001A76 RID: 6774
		[Token(Token = "0x4001A76")]
		[FieldOffset(Offset = "0x20")]
		public UIPopupList _target;

		// Token: 0x04001A77 RID: 6775
		[Token(Token = "0x4001A77")]
		[FieldOffset(Offset = "0x28")]
		public ToggleUIPopupListSelection.Directions _direction;

		// Token: 0x04001A78 RID: 6776
		[Token(Token = "0x4001A78")]
		[FieldOffset(Offset = "0x2C")]
		private bool _active;

		// Token: 0x0200040E RID: 1038
		[Token(Token = "0x200040E")]
		public enum Directions
		{
			// Token: 0x04001A7A RID: 6778
			[Token(Token = "0x4001A7A")]
			Previous,
			// Token: 0x04001A7B RID: 6779
			[Token(Token = "0x4001A7B")]
			Next
		}
	}
}
