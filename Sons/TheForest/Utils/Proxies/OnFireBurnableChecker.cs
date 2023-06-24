using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace TheForest.Utils.Proxies
{
	// Token: 0x020003D3 RID: 979
	[Token(Token = "0x20003D3")]
	public class OnFireBurnableChecker : MonoBehaviour
	{
		// Token: 0x06001ACF RID: 6863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ACF")]
		[Address(RVA = "0x32A8AD0", Offset = "0x32A70D0", VA = "0x1832A8AD0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD0")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public OnFireBurnableChecker()
		{
		}

		// Token: 0x040019F4 RID: 6644
		[Token(Token = "0x40019F4")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent _callback;
	}
}
