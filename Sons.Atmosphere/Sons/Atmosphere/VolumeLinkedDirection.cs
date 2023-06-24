using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sons.Atmosphere
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	[AddComponentMenu("Sons/Atmosphere/Volume Linked Direction")]
	public class VolumeLinkedDirection : MonoBehaviour
	{
		// Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2D51F60", Offset = "0x2D50560", VA = "0x182D51F60")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public VolumeLinkedDirection()
		{
		}

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _source;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Volume _volume;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve _curve;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x38")]
		private float _factor;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x3C")]
		private float _result;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _invertFactor;
	}
}
