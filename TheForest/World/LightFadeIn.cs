using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace TheForest.World
{
	// Token: 0x02000389 RID: 905
	[Token(Token = "0x2000389")]
	public class LightFadeIn : MonoBehaviour
	{
		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060017A0 RID: 6048 RVA: 0x00007410 File Offset: 0x00005610
		// (set) Token: 0x060017A1 RID: 6049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700032A")]
		public bool ControllingLight
		{
			[Token(Token = "0x60017A0")]
			[Address(RVA = "0x576470", Offset = "0x575470", VA = "0x180576470")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60017A1")]
			[Address(RVA = "0x5768A0", Offset = "0x5758A0", VA = "0x1805768A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060017A2 RID: 6050 RVA: 0x00007428 File Offset: 0x00005628
		// (set) Token: 0x060017A3 RID: 6051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700032B")]
		public float IntensityMultiplier
		{
			[Token(Token = "0x60017A2")]
			[Address(RVA = "0x2004010", Offset = "0x2003010", VA = "0x182004010")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60017A3")]
			[Address(RVA = "0x2874C50", Offset = "0x2873C50", VA = "0x182874C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060017A4 RID: 6052 RVA: 0x00007440 File Offset: 0x00005640
		[Token(Token = "0x1700032C")]
		private float TargetIntensity
		{
			[Token(Token = "0x60017A4")]
			[Address(RVA = "0x2CB4660", Offset = "0x2CB3660", VA = "0x182CB4660")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017A5")]
		[Address(RVA = "0x2CB4620", Offset = "0x2CB3620", VA = "0x182CB4620")]
		private void Start()
		{
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x00007458 File Offset: 0x00005658
		[Token(Token = "0x60017A6")]
		[Address(RVA = "0x2CB41E0", Offset = "0x2CB31E0", VA = "0x182CB41E0")]
		private float CollectIntensity()
		{
			return default(float);
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017A7")]
		[Address(RVA = "0x2CB4400", Offset = "0x2CB3400", VA = "0x182CB4400")]
		private void OnEnable()
		{
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017A8")]
		[Address(RVA = "0x2CB4540", Offset = "0x2CB3540", VA = "0x182CB4540")]
		private void SetIntensity(float targetLightIntensity)
		{
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017A9")]
		[Address(RVA = "0x2CB4390", Offset = "0x2CB3390", VA = "0x182CB4390")]
		private void OnDisable()
		{
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017AA")]
		[Address(RVA = "0x2CB42B0", Offset = "0x2CB32B0", VA = "0x182CB42B0")]
		private IEnumerator FadeInRoutine()
		{
			return null;
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017AB")]
		[Address(RVA = "0x2CB4320", Offset = "0x2CB3320", VA = "0x182CB4320")]
		private IEnumerator FadeOutRoutine()
		{
			return null;
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017AC")]
		[Address(RVA = "0x2CB4640", Offset = "0x2CB3640", VA = "0x182CB4640")]
		public LightFadeIn()
		{
		}

		// Token: 0x040016B7 RID: 5815
		[Token(Token = "0x40016B7")]
		[FieldOffset(Offset = "0x20")]
		public Light _targetLight;

		// Token: 0x040016B8 RID: 5816
		[Token(Token = "0x40016B8")]
		[FieldOffset(Offset = "0x28")]
		public float _fadeInDuration;

		// Token: 0x040016B9 RID: 5817
		[Token(Token = "0x40016B9")]
		[FieldOffset(Offset = "0x2C")]
		private float _startIntensity;

		// Token: 0x040016BA RID: 5818
		[Token(Token = "0x40016BA")]
		[FieldOffset(Offset = "0x30")]
		private HDAdditionalLightData _lightData;
	}
}
