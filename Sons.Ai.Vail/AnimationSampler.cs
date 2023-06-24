using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
[AddComponentMenu("Sons/Utilities/AnimationSampler")]
public class AnimationSampler : MonoBehaviour
{
	// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void OnClipChanged()
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2AE3600", Offset = "0x2AE1C00", VA = "0x182AE3600")]
	private void OnSampleTimeChanged()
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void UpdateInformation()
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2AE3650", Offset = "0x2AE1C50", VA = "0x182AE3650")]
	private void UpdatePose()
	{
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2AE3780", Offset = "0x2AE1D80", VA = "0x182AE3780")]
	private void SampleAnimation(float time)
	{
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void UpdateTranslationCurves()
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x28C7AC0", Offset = "0x28C60C0", VA = "0x1828C7AC0")]
	public AnimationSampler()
	{
	}

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AnimationClip _clip;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _normalizedTime;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x2C")]
	private float _length;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform _sampleBone;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AnimationSampler.TranslationType _showTranslationType;

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 _boneTranslation;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x48")]
	private float _pitch;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x4C")]
	private float _speed;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AnimationCurve _curveX;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AnimationCurve _curveY;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private AnimationCurve _curveZ;

	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	private enum TranslationType
	{
		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		World,
		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		Local
	}
}
