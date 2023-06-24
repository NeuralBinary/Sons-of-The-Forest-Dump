using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace TheForest.Utils
{
	// Token: 0x020003C2 RID: 962
	[Token(Token = "0x20003C2")]
	public class OnDrinkWaterProxy : MonoBehaviour
	{
		// Token: 0x06001A5E RID: 6750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A5E")]
		[Address(RVA = "0xA875A0", Offset = "0xA85BA0", VA = "0x180A875A0")]
		private void OnDrinkWater()
		{
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A5F")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public OnDrinkWaterProxy()
		{
		}

		// Token: 0x0400198E RID: 6542
		[Token(Token = "0x400198E")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent _callback;
	}
}
