using System;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace Ballistics
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[Serializable]
	public class OnImpactEvent : UnityEvent<ImpactInfo>
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x904650", Offset = "0x902C50", VA = "0x180904650")]
		public OnImpactEvent()
		{
		}
	}
}
