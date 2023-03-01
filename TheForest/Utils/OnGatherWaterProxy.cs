using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace TheForest.Utils
{
	// Token: 0x020003D2 RID: 978
	[Token(Token = "0x20003D2")]
	public class OnGatherWaterProxy : MonoBehaviour
	{
		// Token: 0x06001A22 RID: 6690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A22")]
		[Address(RVA = "0x92EFB0", Offset = "0x92DFB0", VA = "0x18092EFB0")]
		private void OnGatherWater()
		{
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A23")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public OnGatherWaterProxy()
		{
		}

		// Token: 0x0400196E RID: 6510
		[Token(Token = "0x400196E")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent _callback;
	}
}
