using System;
using Il2CppDummyDll;
using NGUI.UI;
using UnityEngine;

namespace TheForest.Modding.UI
{
	// Token: 0x0200049C RID: 1180
	[Token(Token = "0x200049C")]
	public class ModRow : MonoBehaviour
	{
		// Token: 0x06001DF3 RID: 7667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF3")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ModRow()
		{
		}

		// Token: 0x04001C32 RID: 7218
		[Token(Token = "0x4001C32")]
		[FieldOffset(Offset = "0x20")]
		public UILabel _name;

		// Token: 0x04001C33 RID: 7219
		[Token(Token = "0x4001C33")]
		[FieldOffset(Offset = "0x28")]
		public UILabel _status;
	}
}
