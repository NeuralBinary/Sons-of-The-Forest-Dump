using System;
using Il2CppDummyDll;
using TheForest.World;
using UnityEngine;
using UnityEngine.Events;

namespace TheForest.Utils.Proxies
{
	// Token: 0x020003D4 RID: 980
	[Token(Token = "0x20003D4")]
	public class OnLocalizedHitProxy : MonoBehaviour
	{
		// Token: 0x06001AD1 RID: 6865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD1")]
		[Address(RVA = "0x32A8B60", Offset = "0x32A7160", VA = "0x1832A8B60")]
		public void LocalizedHit(LocalizedHitData data)
		{
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD2")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public OnLocalizedHitProxy()
		{
		}

		// Token: 0x040019F5 RID: 6645
		[Token(Token = "0x40019F5")]
		[FieldOffset(Offset = "0x20")]
		public OnLocalizedHitProxy.PositionEvent _positionEvent;

		// Token: 0x020003D5 RID: 981
		[Token(Token = "0x20003D5")]
		[Serializable]
		public class PositionEvent : UnityEvent<Vector3>
		{
			// Token: 0x06001AD3 RID: 6867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001AD3")]
			[Address(RVA = "0x32A8BE0", Offset = "0x32A71E0", VA = "0x1832A8BE0")]
			public PositionEvent()
			{
			}
		}
	}
}
