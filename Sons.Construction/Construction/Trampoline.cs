using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000101 RID: 257
	[Token(Token = "0x2000101")]
	public class Trampoline : MonoBehaviour
	{
		// Token: 0x06000732 RID: 1842 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x2E3A460", Offset = "0x2E38A60", VA = "0x182E3A460")]
		private void OnTriggerEnter(Collider col)
		{
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x2E3A8F0", Offset = "0x2E38EF0", VA = "0x182E3A8F0")]
		public Trampoline()
		{
		}

		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _velocityMin;

		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _velocityMax;

		// Token: 0x0400052A RID: 1322
		[Token(Token = "0x400052A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _velocityMinMultiplier;

		// Token: 0x0400052B RID: 1323
		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _velocityMaxMultiplier;

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ElementPlaceAnimationClip _anim;

		// Token: 0x0400052D RID: 1325
		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0x0")]
		public static float VelocityMultiplier;

		// Token: 0x0400052E RID: 1326
		[Token(Token = "0x400052E")]
		[FieldOffset(Offset = "0x4")]
		public static float MaxVelocity;
	}
}
