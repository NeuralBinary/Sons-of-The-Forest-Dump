using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.Serialization;

namespace Sons.Atmosphere
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	public class RainFogController : MonoBehaviour
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000184 RID: 388 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		public event Action OnFadeInComplete
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x2D43B10", Offset = "0x2D42110", VA = "0x182D43B10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x2D43C00", Offset = "0x2D42200", VA = "0x182D43C00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000187 RID: 391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		public event Action OnFadeOutComplete
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x2D43CF0", Offset = "0x2D422F0", VA = "0x182D43CF0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x2D43DE0", Offset = "0x2D423E0", VA = "0x182D43DE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2D43ED0", Offset = "0x2D424D0", VA = "0x182D43ED0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2D43ED0", Offset = "0x2D424D0", VA = "0x182D43ED0")]
		private void ResetParams()
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2D44050", Offset = "0x2D42650", VA = "0x182D44050")]
		public void FadeIn()
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2D44310", Offset = "0x2D42910", VA = "0x182D44310")]
		private IEnumerator FadeInRoutine()
		{
			return null;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2D443A0", Offset = "0x2D429A0", VA = "0x182D443A0")]
		public void FadeOut()
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2D44660", Offset = "0x2D42C60", VA = "0x182D44660")]
		private bool CanStartCoroutine()
		{
			return default(bool);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2D447F0", Offset = "0x2D42DF0", VA = "0x182D447F0")]
		private IEnumerator FadeOutRoutine()
		{
			return null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2D44880", Offset = "0x2D42E80", VA = "0x182D44880")]
		private IEnumerator DoGeneralFadeWorker(float startTime, float fadeTime, AnimationCurve fadeCurve, float fromValue, float toValue, Action onComplete)
		{
			return null;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2D44A20", Offset = "0x2D43020", VA = "0x182D44A20")]
		private void Finalize(float toValue, Action onComplete)
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2D44C10", Offset = "0x2D43210", VA = "0x182D44C10")]
		private float FindCurveTimeIncreasing(float searchFactor, AnimationCurve sourceCurve, float step = 0.001f)
		{
			return 0f;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2D44CD0", Offset = "0x2D432D0", VA = "0x182D44CD0")]
		public RainFogController()
		{
		}

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LocalVolumetricFog _localFogTarget;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _baseFogDistance;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve _fadeInCurve;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _fadeInTime;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationCurve _fadeOutCurve;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _fadeOutTime;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[FormerlySerializedAs("_fadeMultiplier")]
		private float _fadeDistance;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x60")]
		private float _currentFogDistance;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x64")]
		private float _lastCurveFactor;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x68")]
		private float _lastCurveTime;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x70")]
		private Coroutine _fadeCurveWorker;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int _WeatherLocalizedInverseFogFactor;
	}
}
