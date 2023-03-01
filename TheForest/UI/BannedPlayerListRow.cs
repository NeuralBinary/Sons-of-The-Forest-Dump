using System;
using Il2CppDummyDll;
using NGUI.Interaction;
using NGUI.UI;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003ED RID: 1005
	[Token(Token = "0x20003ED")]
	public class BannedPlayerListRow : MonoBehaviour
	{
		// Token: 0x06001AA9 RID: 6825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA9")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public BannedPlayerListRow()
		{
		}

		// Token: 0x040019E6 RID: 6630
		[Token(Token = "0x40019E6")]
		[FieldOffset(Offset = "0x20")]
		public UILabel _nameLabel;

		// Token: 0x040019E7 RID: 6631
		[Token(Token = "0x40019E7")]
		[FieldOffset(Offset = "0x28")]
		public UILabel _durationLabel;

		// Token: 0x040019E8 RID: 6632
		[Token(Token = "0x40019E8")]
		[FieldOffset(Offset = "0x30")]
		public UIButton _unbanButton;
	}
}
