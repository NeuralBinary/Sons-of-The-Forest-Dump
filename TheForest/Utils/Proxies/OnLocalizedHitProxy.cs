using System;
using Il2CppDummyDll;
using TheForest.World;
using UnityEngine;
using UnityEngine.Events;

namespace TheForest.Utils.Proxies
{
	// Token: 0x020003E2 RID: 994
	[Token(Token = "0x20003E2")]
	public class OnLocalizedHitProxy : MonoBehaviour
	{
		// Token: 0x06001A93 RID: 6803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A93")]
		[Address(RVA = "0x2CE7620", Offset = "0x2CE6620", VA = "0x182CE7620")]
		public void LocalizedHit(LocalizedHitData data)
		{
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A94")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public OnLocalizedHitProxy()
		{
		}

		// Token: 0x040019D1 RID: 6609
		[Token(Token = "0x40019D1")]
		[FieldOffset(Offset = "0x20")]
		public OnLocalizedHitProxy.PositionEvent _positionEvent;

		// Token: 0x020003E3 RID: 995
		[Token(Token = "0x20003E3")]
		[Serializable]
		public class PositionEvent : UnityEvent<Vector3>
		{
			// Token: 0x06001A95 RID: 6805 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001A95")]
			[Address(RVA = "0x2CE9E70", Offset = "0x2CE8E70", VA = "0x182CE9E70")]
			public PositionEvent()
			{
			}
		}
	}
}
