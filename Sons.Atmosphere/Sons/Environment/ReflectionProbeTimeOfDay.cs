using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.Serialization;

namespace Sons.Environment
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[AddComponentMenu("Sons/Environment/Reflection Probe (Time Of Day)")]
	public class ReflectionProbeTimeOfDay : TimeOfDayBehaviour
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2D2F9E0", Offset = "0x2D2DFE0", VA = "0x182D2F9E0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2D2FA10", Offset = "0x2D2E010", VA = "0x182D2FA10")]
		private void OnDisable()
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2D2FB20", Offset = "0x2D2E120", VA = "0x182D2FB20")]
		private void OnValidate()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2D2FC80", Offset = "0x2D2E280", VA = "0x182D2FC80")]
		private void SetupBlendProbes()
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2D301B0", Offset = "0x2D2E7B0", VA = "0x182D301B0")]
		private int GetFinalRenderTextureRes()
		{
			return 0;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2D301C0", Offset = "0x2D2E7C0", VA = "0x182D301C0")]
		private void SetupProbe(ReflectionProbe eachProbe, HDAdditionalReflectionData eachProbeData)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2D303C0", Offset = "0x2D2E9C0", VA = "0x182D303C0")]
		private void UpdateReflectionData()
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2D30790", Offset = "0x2D2ED90", VA = "0x182D30790", Slot = "8")]
		public override void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2D30810", Offset = "0x2D2EE10", VA = "0x182D30810")]
		private void UpdateBlendProbes(float hours)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2D30D70", Offset = "0x2D2F370", VA = "0x182D30D70")]
		public ReflectionProbeTimeOfDay()
		{
		}

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		public const int DefaultRenderTextureRes = 128;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Header("Probe settings")]
		[FormerlySerializedAs("_autoFindProbe")]
		private bool _autoFindProbesInChildren;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<ReflectionProbe> _reflectionProbes;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Header("Blend probes")]
		private bool _enableBlendProbes;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Space(8f)]
		[FormerlySerializedAs("AnimBlend")]
		private AnimationCurve _animBlend;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Space(8f)]
		private Texture _probeMidnight;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Texture _probeSunrise;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Texture _probeMidday;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Texture _probeSunset;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _overrideFinalRenderTextureRes;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private int _finalRenderTextureRes;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x80")]
		[Header("Debug")]
		private float _dayFactor;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x84")]
		[Header("Debug")]
		private float _hours;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x88")]
		private float _blendValue;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x90")]
		private string _blendTo;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x98")]
		private List<HDAdditionalReflectionData> _reflectionData;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0xA0")]
		private RenderTexture _finalProbe;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x0")]
		private static ReflectionProbeTimeOfDay _masterInstance;
	}
}
