using System;
using Il2CppDummyDll;
using NGUI.Interaction;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003FF RID: 1023
	[Token(Token = "0x20003FF")]
	public class ToggleUIPopupListSelection : MonoBehaviour
	{
		// Token: 0x06001B67 RID: 7015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B67")]
		[Address(RVA = "0x32B7310", Offset = "0x32B5910", VA = "0x1832B7310")]
		private void Awake()
		{
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B68")]
		[Address(RVA = "0x32B7400", Offset = "0x32B5A00", VA = "0x1832B7400")]
		private void OnEnable()
		{
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B69")]
		[Address(RVA = "0x32B7470", Offset = "0x32B5A70", VA = "0x1832B7470")]
		private void OnClick()
		{
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6A")]
		[Address(RVA = "0x32B75A0", Offset = "0x32B5BA0", VA = "0x1832B75A0")]
		private void RefreshState()
		{
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6B")]
		[Address(RVA = "0x32B76E0", Offset = "0x32B5CE0", VA = "0x1832B76E0")]
		private void RefreshSiblingsState()
		{
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ToggleUIPopupListSelection()
		{
		}

		// Token: 0x04001A9A RID: 6810
		[Token(Token = "0x4001A9A")]
		[FieldOffset(Offset = "0x20")]
		public UIPopupList _target;

		// Token: 0x04001A9B RID: 6811
		[Token(Token = "0x4001A9B")]
		[FieldOffset(Offset = "0x28")]
		public ToggleUIPopupListSelection.Directions _direction;

		// Token: 0x04001A9C RID: 6812
		[Token(Token = "0x4001A9C")]
		[FieldOffset(Offset = "0x2C")]
		private bool _active;

		// Token: 0x02000400 RID: 1024
		[Token(Token = "0x2000400")]
		public enum Directions
		{
			// Token: 0x04001A9E RID: 6814
			[Token(Token = "0x4001A9E")]
			Previous,
			// Token: 0x04001A9F RID: 6815
			[Token(Token = "0x4001A9F")]
			Next
		}
	}
}
