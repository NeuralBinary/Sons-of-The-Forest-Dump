using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace TheForest.Utils
{
	// Token: 0x020003BE RID: 958
	[Token(Token = "0x20003BE")]
	public class BurnProxy : MonoBehaviour
	{
		// Token: 0x06001A55 RID: 6741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A55")]
		[Address(RVA = "0xA875A0", Offset = "0xA85BA0", VA = "0x180A875A0")]
		private void Burn()
		{
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A56")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public BurnProxy()
		{
		}

		// Token: 0x04001987 RID: 6535
		[Token(Token = "0x4001987")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent _callback;
	}
}
