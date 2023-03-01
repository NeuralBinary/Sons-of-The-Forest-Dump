using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace TheForest.Utils.Proxies
{
	// Token: 0x020003E1 RID: 993
	[Token(Token = "0x20003E1")]
	public class OnFireBurnableChecker : MonoBehaviour
	{
		// Token: 0x06001A91 RID: 6801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A91")]
		[Address(RVA = "0x2CE7590", Offset = "0x2CE6590", VA = "0x182CE7590")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A92")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public OnFireBurnableChecker()
		{
		}

		// Token: 0x040019D0 RID: 6608
		[Token(Token = "0x40019D0")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent _callback;
	}
}
