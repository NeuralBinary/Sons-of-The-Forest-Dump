using System;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace Ballistics
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[Serializable]
	public class OnSurfaceImpactEvent : UnityEvent<SurfaceImpactInfo>
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x904610", Offset = "0x902C10", VA = "0x180904610")]
		public OnSurfaceImpactEvent()
		{
		}
	}
}
