using System;
using Il2CppDummyDll;
using NGUI.Interaction;
using NGUI.UI;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003F6 RID: 1014
	[Token(Token = "0x20003F6")]
	public class InputDeviceRow : MonoBehaviour
	{
		// Token: 0x06001AC3 RID: 6851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC3")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public InputDeviceRow()
		{
		}

		// Token: 0x040019FE RID: 6654
		[Token(Token = "0x40019FE")]
		[FieldOffset(Offset = "0x20")]
		public UILabel _label;

		// Token: 0x040019FF RID: 6655
		[Token(Token = "0x40019FF")]
		[FieldOffset(Offset = "0x28")]
		public UIToggle _checkbox;

		// Token: 0x04001A00 RID: 6656
		[Token(Token = "0x4001A00")]
		[FieldOffset(Offset = "0x30")]
		public UIButton _button;
	}
}
