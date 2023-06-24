using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003E5 RID: 997
	[Token(Token = "0x20003E5")]
	public class GamepadInputIconPosition : MonoBehaviour
	{
		// Token: 0x06001AF7 RID: 6903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF7")]
		[Address(RVA = "0xAB5B60", Offset = "0xAB4160", VA = "0x180AB5B60")]
		public GamepadInputIconPosition()
		{
		}

		// Token: 0x04001A1E RID: 6686
		[Token(Token = "0x4001A1E")]
		[FieldOffset(Offset = "0x20")]
		public Transform _positionTarget;

		// Token: 0x04001A1F RID: 6687
		[Token(Token = "0x4001A1F")]
		[FieldOffset(Offset = "0x28")]
		public bool _showIcon;
	}
}
