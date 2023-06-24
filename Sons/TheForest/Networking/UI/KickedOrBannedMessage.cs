using System;
using Il2CppDummyDll;
using NGUI.UI;
using UnityEngine;

namespace TheForest.Networking.UI
{
	// Token: 0x0200048E RID: 1166
	[Token(Token = "0x200048E")]
	public class KickedOrBannedMessage : MonoBehaviour
	{
		// Token: 0x06001E3B RID: 7739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E3B")]
		[Address(RVA = "0x32EF080", Offset = "0x32ED680", VA = "0x1832EF080")]
		private void Awake()
		{
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E3C")]
		[Address(RVA = "0x32EF1B0", Offset = "0x32ED7B0", VA = "0x1832EF1B0")]
		public void Open()
		{
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E3D")]
		[Address(RVA = "0x32EF210", Offset = "0x32ED810", VA = "0x1832EF210")]
		public void Close()
		{
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E3E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public KickedOrBannedMessage()
		{
		}

		// Token: 0x04001C5C RID: 7260
		[Token(Token = "0x4001C5C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject _root;

		// Token: 0x04001C5D RID: 7261
		[Token(Token = "0x4001C5D")]
		[FieldOffset(Offset = "0x28")]
		public UILabel _label;
	}
}
