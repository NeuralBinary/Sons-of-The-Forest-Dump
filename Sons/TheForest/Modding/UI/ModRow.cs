using System;
using Il2CppDummyDll;
using NGUI.UI;
using UnityEngine;

namespace TheForest.Modding.UI
{
	// Token: 0x02000491 RID: 1169
	[Token(Token = "0x2000491")]
	public class ModRow : MonoBehaviour
	{
		// Token: 0x06001E43 RID: 7747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E43")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ModRow()
		{
		}

		// Token: 0x04001C62 RID: 7266
		[Token(Token = "0x4001C62")]
		[FieldOffset(Offset = "0x20")]
		public UILabel _name;

		// Token: 0x04001C63 RID: 7267
		[Token(Token = "0x4001C63")]
		[FieldOffset(Offset = "0x28")]
		public UILabel _status;
	}
}
