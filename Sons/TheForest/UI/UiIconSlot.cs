using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x02000403 RID: 1027
	[Token(Token = "0x2000403")]
	public class UiIconSlot : MonoBehaviour
	{
		// Token: 0x06001B73 RID: 7027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B73")]
		[Address(RVA = "0x32B8710", Offset = "0x32B6D10", VA = "0x1832B8710")]
		public void OnEnable()
		{
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B74")]
		[Address(RVA = "0x32B8810", Offset = "0x32B6E10", VA = "0x1832B8810")]
		public void OnDisable()
		{
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B75")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UiIconSlot()
		{
		}

		// Token: 0x04001AA6 RID: 6822
		[Token(Token = "0x4001AA6")]
		[FieldOffset(Offset = "0x20")]
		public bool _priority;

		// Token: 0x04001AA7 RID: 6823
		[Token(Token = "0x4001AA7")]
		[FieldOffset(Offset = "0x28")]
		public GameObject _filterGo;

		// Token: 0x04001AA8 RID: 6824
		[Token(Token = "0x4001AA8")]
		[FieldOffset(Offset = "0x30")]
		public UiIconSlotToken _token;
	}
}
