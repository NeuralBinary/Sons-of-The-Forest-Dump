using System;
using Endnight.Utilities.PropertyAttributes;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.Serialization;

namespace Sons.Environment
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[AddComponentMenu("Son/Environment/PostEffectsTimeOfDay")]
	[Obsolete]
	public class PostEffectsTimeOfDay : TimeOfDayBehaviour
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public override void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2D2F910", Offset = "0x2D2DF10", VA = "0x182D2F910")]
		public PostEffectsTimeOfDay()
		{
		}

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x0")]
		private static PostEffectsTimeOfDay _instance;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Volume _volume;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[ReadOnly]
		private string _evaluatedTimeOfDay;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Header("Specular", order = 1)]
		[Header("Indirect Lighting", order = 0)]
		private bool _enableIndirectSpecularControl;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[FormerlySerializedAs("_valueCurve")]
		private AnimationCurve _indirectSpecularIntensityCurve;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _indirectSpecularIntensityMin;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _indirectSpecularIntensityMax;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Header("Diffuse")]
		private bool _enableIndirectDiffuseControl;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AnimationCurve _indirectDiffuseIntensityCurve;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _indirectDiffuseIntensityMin;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _indirectDiffuseIntensityMax;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Header("Exposure")]
		private bool _enableExposureControl;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AnimationCurve _exposureCurve;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x88")]
		[Header("Day")]
		[SerializeField]
		private float _exposureCompensationDay;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float _exposureLimitMinDay;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _exposureLimitMaxDay;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		[Header("Night")]
		private float _exposureCompensationNight;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _exposureLimitMinNight;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _exposureLimitMaxNight;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0xA0")]
		[ReadOnly]
		[SerializeField]
		private float _dayFactor;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0xA8")]
		private VolumeProfile _profile;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0xB0")]
		private Exposure _exposureController;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0xB8")]
		private IndirectLightingController _indirectLightingController;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0xC0")]
		private int _profileVolumeId;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0xC4")]
		private float _indirectSpecFactor;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0xC8")]
		private float _indirectDiffuseFactor;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0xCC")]
		private float _exposureFactor;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0xD0")]
		private float _indirectSpecMultiplierResult;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0xD4")]
		private float _indirectDiffuseMultiplierResult;
	}
}
