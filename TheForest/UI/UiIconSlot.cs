using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x02000411 RID: 1041
	[Token(Token = "0x2000411")]
	public class UiIconSlot : MonoBehaviour
	{
		// Token: 0x06001B35 RID: 6965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B35")]
		[Address(RVA = "0x2CF3B50", Offset = "0x2CF2B50", VA = "0x182CF3B50")]
		public void OnEnable()
		{
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B36")]
		[Address(RVA = "0x2CF3AC0", Offset = "0x2CF2AC0", VA = "0x182CF3AC0")]
		public void OnDisable()
		{
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B37")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public UiIconSlot()
		{
		}

		// Token: 0x04001A82 RID: 6786
		[Token(Token = "0x4001A82")]
		[FieldOffset(Offset = "0x20")]
		public bool _priority;

		// Token: 0x04001A83 RID: 6787
		[Token(Token = "0x4001A83")]
		[FieldOffset(Offset = "0x28")]
		public GameObject _filterGo;

		// Token: 0x04001A84 RID: 6788
		[Token(Token = "0x4001A84")]
		[FieldOffset(Offset = "0x30")]
		public UiIconSlotToken _token;
	}
}
