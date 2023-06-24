using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sons.Atmosphere
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	[AddComponentMenu("Sons/Atmosphere/LensFlareFader")]
	public class LensFlareFader : MonoBehaviour
	{
		// Token: 0x06000173 RID: 371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x2D42260", Offset = "0x2D40860", VA = "0x182D42260")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2D42270", Offset = "0x2D40870", VA = "0x182D42270")]
		private void Update()
		{
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2D425E0", Offset = "0x2D40BE0", VA = "0x182D425E0")]
		private bool HasFadeRequestObject()
		{
			return default(bool);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2D42760", Offset = "0x2D40D60", VA = "0x182D42760")]
		private void UpdateTransformAngle()
		{
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2D42890", Offset = "0x2D40E90", VA = "0x182D42890")]
		public void RegisterFadeRequest(UnityEngine.Object obj)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2D42900", Offset = "0x2D40F00", VA = "0x182D42900")]
		public void UnregisterFadeRequest(UnityEngine.Object obj)
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2D42980", Offset = "0x2D40F80", VA = "0x182D42980")]
		public LensFlareFader()
		{
		}

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LensFlareComponentSRP _target;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x28")]
		private float _transformAngle;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve _fadeCurve;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _forcedFadeSpeed;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x3C")]
		private float _baseIntensity;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x40")]
		private List<UnityEngine.Object> _fadeRequestObjects;
	}
}
