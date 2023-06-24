using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Lighting
{
	// Token: 0x02000588 RID: 1416
	[Token(Token = "0x2000588")]
	public abstract class LightFlickerBase : MonoBehaviour
	{
		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		// (set) Token: 0x06002548 RID: 9544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E4")]
		public float IntensityMultiplier
		{
			[Token(Token = "0x6002547")]
			[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002548")]
			[Address(RVA = "0x781580", Offset = "0x77FB80", VA = "0x180781580")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x0000ADD0 File Offset: 0x00008FD0
		[Token(Token = "0x170004E5")]
		public float MaxIntensity
		{
			[Token(Token = "0x6002549")]
			[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254A")]
		[Address(RVA = "0x339B090", Offset = "0x3399690", VA = "0x18339B090")]
		private void Update()
		{
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254B")]
		[Address(RVA = "0x339B2E0", Offset = "0x33998E0", VA = "0x18339B2E0")]
		private void SetFromLinked(float factor)
		{
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254C")]
		[Address(RVA = "0x339B340", Offset = "0x3399940", VA = "0x18339B340")]
		private void UpdateFromFactor(float factor)
		{
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254D")]
		[Address(RVA = "0x339B390", Offset = "0x3399990", VA = "0x18339B390")]
		private void OnEnable()
		{
		}

		// Token: 0x0600254E RID: 9550
		[Token(Token = "0x600254E")]
		public abstract void SetLightIntensity(float intensity);

		// Token: 0x0600254F RID: 9551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254F")]
		[Address(RVA = "0x339B030", Offset = "0x3399630", VA = "0x18339B030")]
		protected LightFlickerBase()
		{
		}

		// Token: 0x04002184 RID: 8580
		[Token(Token = "0x4002184")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("minIntensity")]
		protected float _minIntensity;

		// Token: 0x04002185 RID: 8581
		[Token(Token = "0x4002185")]
		[FieldOffset(Offset = "0x24")]
		[FormerlySerializedAs("maxIntensity")]
		[SerializeField]
		private float _maxIntensity;

		// Token: 0x04002186 RID: 8582
		[Token(Token = "0x4002186")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("timeMult")]
		private float _flickerSpeed;

		// Token: 0x04002187 RID: 8583
		[Token(Token = "0x4002187")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<LightFlickerBase> _linkedFlickers;

		// Token: 0x04002188 RID: 8584
		[Token(Token = "0x4002188")]
		[FieldOffset(Offset = "0x38")]
		private float _random;

		// Token: 0x04002189 RID: 8585
		[Token(Token = "0x4002189")]
		[FieldOffset(Offset = "0x3C")]
		private bool _linkedControlled;
	}
}
