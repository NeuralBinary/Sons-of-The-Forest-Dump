using System;
using Il2CppDummyDll;
using NGUI.UI;
using UnityEngine;

namespace TheForest.Networking.UI
{
	// Token: 0x02000499 RID: 1177
	[Token(Token = "0x2000499")]
	public class KickedOrBannedMessage : MonoBehaviour
	{
		// Token: 0x06001DEB RID: 7659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DEB")]
		[Address(RVA = "0x2D122B0", Offset = "0x2D112B0", VA = "0x182D122B0")]
		private void Awake()
		{
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DEC")]
		[Address(RVA = "0x2D12490", Offset = "0x2D11490", VA = "0x182D12490")]
		public void Open()
		{
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DED")]
		[Address(RVA = "0x2D123F0", Offset = "0x2D113F0", VA = "0x182D123F0")]
		public void Close()
		{
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DEE")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public KickedOrBannedMessage()
		{
		}

		// Token: 0x04001C2C RID: 7212
		[Token(Token = "0x4001C2C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject _root;

		// Token: 0x04001C2D RID: 7213
		[Token(Token = "0x4001C2D")]
		[FieldOffset(Offset = "0x28")]
		public UILabel _label;
	}
}
