using System;
using Il2CppDummyDll;
using NGUI.Interaction;
using NGUI.UI;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003DF RID: 991
	[Token(Token = "0x20003DF")]
	public class BannedPlayerListRow : MonoBehaviour
	{
		// Token: 0x06001AE7 RID: 6887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE7")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public BannedPlayerListRow()
		{
		}

		// Token: 0x04001A0A RID: 6666
		[Token(Token = "0x4001A0A")]
		[FieldOffset(Offset = "0x20")]
		public UILabel _nameLabel;

		// Token: 0x04001A0B RID: 6667
		[Token(Token = "0x4001A0B")]
		[FieldOffset(Offset = "0x28")]
		public UILabel _durationLabel;

		// Token: 0x04001A0C RID: 6668
		[Token(Token = "0x4001A0C")]
		[FieldOffset(Offset = "0x30")]
		public UIButton _unbanButton;
	}
}
