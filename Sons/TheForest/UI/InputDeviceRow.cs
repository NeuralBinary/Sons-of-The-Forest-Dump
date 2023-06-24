using System;
using Il2CppDummyDll;
using NGUI.Interaction;
using NGUI.UI;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003E8 RID: 1000
	[Token(Token = "0x20003E8")]
	public class InputDeviceRow : MonoBehaviour
	{
		// Token: 0x06001B01 RID: 6913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B01")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public InputDeviceRow()
		{
		}

		// Token: 0x04001A22 RID: 6690
		[Token(Token = "0x4001A22")]
		[FieldOffset(Offset = "0x20")]
		public UILabel _label;

		// Token: 0x04001A23 RID: 6691
		[Token(Token = "0x4001A23")]
		[FieldOffset(Offset = "0x28")]
		public UIToggle _checkbox;

		// Token: 0x04001A24 RID: 6692
		[Token(Token = "0x4001A24")]
		[FieldOffset(Offset = "0x30")]
		public UIButton _button;
	}
}
