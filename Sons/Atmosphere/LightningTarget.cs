using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Atmosphere
{
	// Token: 0x020005E1 RID: 1505
	[Token(Token = "0x20005E1")]
	public class LightningTarget : MonoBehaviour, ILightningTarget
	{
		// Token: 0x06002713 RID: 10003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002713")]
		[Address(RVA = "0x33BB570", Offset = "0x33B9B70", VA = "0x1833BB570", Slot = "6")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002714")]
		[Address(RVA = "0x31AB110", Offset = "0x31A9710", VA = "0x1831AB110", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002715")]
		[Address(RVA = "0xA875A0", Offset = "0xA85BA0", VA = "0x180A875A0", Slot = "8")]
		public virtual void LightningHit()
		{
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x0000BAC0 File Offset: 0x00009CC0
		[Token(Token = "0x6002716")]
		[Address(RVA = "0x26E86D0", Offset = "0x26E6CD0", VA = "0x1826E86D0", Slot = "9")]
		public virtual Vector3 GetLightningStrikePosition()
		{
			return default(Vector3);
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002717")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public LightningTarget()
		{
		}

		// Token: 0x04002337 RID: 9015
		[Token(Token = "0x4002337")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent OnLightningHitEvent;
	}
}
