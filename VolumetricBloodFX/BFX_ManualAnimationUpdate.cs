using System;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
public class BFX_ManualAnimationUpdate : MonoBehaviour
{
	// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x4B097E0", Offset = "0x4B07DE0", VA = "0x184B097E0")]
	private void OnValidate()
	{
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x4B09A00", Offset = "0x4B08000", VA = "0x184B09A00")]
	private void OnEnable()
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x4B09A10", Offset = "0x4B08010", VA = "0x184B09A10")]
	public void Reset()
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x4B09E30", Offset = "0x4B08430", VA = "0x184B09E30")]
	private void Update()
	{
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x4B0A140", Offset = "0x4B08740", VA = "0x184B0A140")]
	public BFX_ManualAnimationUpdate()
	{
	}

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x20")]
	public BFX_BloodSettings BloodSettings;

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve AnimationSpeed;

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x30")]
	public float FramesCount;

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x34")]
	public float TimeLimit;

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x38")]
	public float OffsetFrames;

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private bool _doDisable;

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x3D")]
	[SerializeField]
	private bool _loop;

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _loopTime;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _timeDelay;

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _TimeViz;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x4C")]
	private float currentTime;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x50")]
	[ReadOnly]
	[SerializeField]
	private Renderer rend;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x58")]
	private MaterialPropertyBlock propertyBlock;
}
