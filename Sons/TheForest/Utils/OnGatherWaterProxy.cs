using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace TheForest.Utils
{
	// Token: 0x020003C4 RID: 964
	[Token(Token = "0x20003C4")]
	public class OnGatherWaterProxy : MonoBehaviour
	{
		// Token: 0x06001A63 RID: 6755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A63")]
		[Address(RVA = "0xA875A0", Offset = "0xA85BA0", VA = "0x180A875A0")]
		private void OnGatherWater()
		{
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A64")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public OnGatherWaterProxy()
		{
		}

		// Token: 0x04001992 RID: 6546
		[Token(Token = "0x4001992")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent _callback;
	}
}
