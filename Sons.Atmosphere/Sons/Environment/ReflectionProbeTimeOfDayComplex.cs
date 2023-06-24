using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.Serialization;

namespace Sons.Environment
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[AddComponentMenu("Sons/Environment/Reflection Probe (Time Of Day) Complex")]
	public class ReflectionProbeTimeOfDayComplex : TimeOfDayBehaviour, ICloudReceiver
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2D30DD0", Offset = "0x2D2F3D0", VA = "0x182D30DD0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2D30EE0", Offset = "0x2D2F4E0", VA = "0x182D30EE0")]
		public void SetTreeOcclusion(float value)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2D30F40", Offset = "0x2D2F540", VA = "0x182D30F40")]
		private void OnDisable()
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2D31120", Offset = "0x2D2F720", VA = "0x182D31120")]
		private void OnValidate()
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2D31280", Offset = "0x2D2F880", VA = "0x182D31280")]
		private void SetupBlendProbes()
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2D317A0", Offset = "0x2D2FDA0", VA = "0x182D317A0")]
		private void SetupProbe(ReflectionProbe eachProbe, HDAdditionalReflectionData eachProbeData)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2D319A0", Offset = "0x2D2FFA0", VA = "0x182D319A0")]
		private void UpdateReflectionData()
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2D31F80", Offset = "0x2D30580", VA = "0x182D31F80", Slot = "8")]
		public override void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2D32000", Offset = "0x2D30600", VA = "0x182D32000")]
		private void UpdateBlendProbes(float hours)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2D32620", Offset = "0x2D30C20", VA = "0x182D32620", Slot = "11")]
		public void UpdateCloud(float density)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2D326F0", Offset = "0x2D30CF0", VA = "0x182D326F0")]
		public ReflectionProbeTimeOfDayComplex()
		{
		}

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static float _treeOcclusion;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x38")]
		[Header("Tree occlusion")]
		[SerializeField]
		private bool _applyTreeOcclusion;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x3C")]
		[Header("Clouds")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _minIntensityWhenCloudy;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("_autoFindProbe")]
		[Header("Probe settings")]
		[SerializeField]
		private bool _autoFindProbesInChildren;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<ReflectionProbe> _reflectionProbes;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x50")]
		private float[] _skyBlendMinWeights;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x58")]
		[Header("Blend probes")]
		[SerializeField]
		private bool _enableBlendProbes;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x60")]
		[Space(8f)]
		[SerializeField]
		private AnimationCurve _blendSunrise;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AnimationCurve _blendSunset;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x70")]
		[Space(8f)]
		[SerializeField]
		private Texture[] _probes;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private int _renderTextureResolution;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x7C")]
		[Header("Debug")]
		private float _dayFactor;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x80")]
		[Header("Debug")]
		private float _hours;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x84")]
		private float _blendValue;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x88")]
		private int _blendFrom;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x8C")]
		private int _blendTo;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x90")]
		private List<HDAdditionalReflectionData> _reflectionData;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x98")]
		private RenderTexture _finalProbe;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x8")]
		private static ReflectionProbeTimeOfDay _masterInstance;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0xA0")]
		private ProbeSettings _reflectionDataSettingsBuffer;
	}
}
