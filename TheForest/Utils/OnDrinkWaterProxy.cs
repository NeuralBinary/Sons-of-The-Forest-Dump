using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace TheForest.Utils
{
	// Token: 0x020003D0 RID: 976
	[Token(Token = "0x20003D0")]
	public class OnDrinkWaterProxy : MonoBehaviour
	{
		// Token: 0x06001A1D RID: 6685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A1D")]
		[Address(RVA = "0x92EFB0", Offset = "0x92DFB0", VA = "0x18092EFB0")]
		private void OnDrinkWater()
		{
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A1E")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public OnDrinkWaterProxy()
		{
		}

		// Token: 0x0400196A RID: 6506
		[Token(Token = "0x400196A")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent _callback;
	}
}
