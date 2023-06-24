using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000008 RID: 8
[Token(Token = "0x2000008")]
public class BFX_DecalSettings : MonoBehaviour
{
	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x4B07B40", Offset = "0x4B06140", VA = "0x184B07B40")]
	private void Awake()
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x4B07FC0", Offset = "0x4B065C0", VA = "0x184B07FC0")]
	private void ShaderCurve_OnAnimationFinished()
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x4B08050", Offset = "0x4B06650", VA = "0x184B08050")]
	private void Update()
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x4B08070", Offset = "0x4B06670", VA = "0x184B08070")]
	private void InitializePosition()
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x4B08CA0", Offset = "0x4B072A0", VA = "0x184B08CA0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x4B08D40", Offset = "0x4B07340", VA = "0x184B08D40")]
	private Vector3 GetAverageRay(Vector3 start, Vector3 forward)
	{
		return default(Vector3);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x4B09000", Offset = "0x4B07600", VA = "0x184B09000")]
	private void EnableDecalAnimation()
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x4B09060", Offset = "0x4B07660", VA = "0x184B09060")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x4B09640", Offset = "0x4B07C40", VA = "0x184B09640")]
	public BFX_DecalSettings()
	{
	}

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x20")]
	public BFX_BloodSettings BloodSettings;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x28")]
	public Transform parent;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x30")]
	public float TimeHeightMax;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x34")]
	public float TimeHeightMin;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x38")]
	[Space]
	public Vector3 TimeScaleMax;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 TimeScaleMin;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x50")]
	[Space]
	public Vector3 TimeOffsetMax;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x5C")]
	public Vector3 TimeOffsetMin;

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x68")]
	[Space]
	public AnimationCurve TimeByHeight;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 startOffset;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3 startScale;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x88")]
	private float timeDelay;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x90")]
	private Transform t;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x98")]
	private Transform tParent;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0xA0")]
	private BFX_ShaderProperies shaderProperies;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0xA8")]
	private Vector3 averageRay;

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0xB4")]
	private bool isPositionInitialized;
}
