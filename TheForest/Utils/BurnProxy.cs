using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace TheForest.Utils
{
	// Token: 0x020003CC RID: 972
	[Token(Token = "0x20003CC")]
	public class BurnProxy : MonoBehaviour
	{
		// Token: 0x06001A14 RID: 6676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A14")]
		[Address(RVA = "0x92EFB0", Offset = "0x92DFB0", VA = "0x18092EFB0")]
		private void Burn()
		{
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A15")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public BurnProxy()
		{
		}

		// Token: 0x04001963 RID: 6499
		[Token(Token = "0x4001963")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent _callback;
	}
}
