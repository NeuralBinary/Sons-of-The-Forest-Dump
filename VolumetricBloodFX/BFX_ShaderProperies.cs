using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000C RID: 12
[Token(Token = "0x200000C")]
public class BFX_ShaderProperies : MonoBehaviour
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000001")]
	public event Action OnAnimationFinished
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x4B0B880", Offset = "0x4B09E80", VA = "0x184B0B880")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x4B0B970", Offset = "0x4B09F70", VA = "0x184B0B970")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x4B0BA60", Offset = "0x4B0A060", VA = "0x184B0BA60")]
	private void Awake()
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x4B0BC70", Offset = "0x4B0A270", VA = "0x184B0BC70")]
	private void OnEnable()
	{
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x4B0BFD0", Offset = "0x4B0A5D0", VA = "0x184B0BFD0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x4B0C160", Offset = "0x4B0A760", VA = "0x184B0C160")]
	private void Update()
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x4B0C680", Offset = "0x4B0AC80", VA = "0x184B0C680")]
	public BFX_ShaderProperies()
	{
	}

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x20")]
	public BFX_BloodSettings BloodSettings;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve FloatCurve;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x30")]
	public float GraphTimeMultiplier;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x34")]
	public float GraphIntensityMultiplier;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x38")]
	public float TimeDelay;

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x3C")]
	private bool canUpdate;

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x3D")]
	private bool isFrized;

	// Token: 0x04000047 RID: 71
	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x40")]
	private float startTime;

	// Token: 0x04000048 RID: 72
	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x44")]
	private int cutoutPropertyID;

	// Token: 0x04000049 RID: 73
	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x48")]
	private int forwardDirPropertyID;

	// Token: 0x0400004A RID: 74
	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x4C")]
	private float timeLapsed;

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x50")]
	private MaterialPropertyBlock props;

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x58")]
	private Renderer rend;
}
