using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Atmosphere
{
	// Token: 0x020005D0 RID: 1488
	[Token(Token = "0x20005D0")]
	public class LightningTarget : MonoBehaviour, ILightningTarget
	{
		// Token: 0x0600260A RID: 9738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260A")]
		[Address(RVA = "0x2DA5C60", Offset = "0x2DA4C60", VA = "0x182DA5C60", Slot = "6")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260B")]
		[Address(RVA = "0x2DA5C50", Offset = "0x2DA4C50", VA = "0x182DA5C50", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260C")]
		[Address(RVA = "0x92EFB0", Offset = "0x92DFB0", VA = "0x18092EFB0", Slot = "8")]
		public virtual void LightningHit()
		{
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x0000B3D0 File Offset: 0x000095D0
		[Token(Token = "0x600260D")]
		[Address(RVA = "0x2294B70", Offset = "0x2293B70", VA = "0x182294B70", Slot = "9")]
		public virtual Vector3 GetLightningStrikePosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260E")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public LightningTarget()
		{
		}

		// Token: 0x04002259 RID: 8793
		[Token(Token = "0x4002259")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent OnLightningHitEvent;
	}
}
