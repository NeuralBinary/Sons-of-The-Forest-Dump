﻿using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000013 RID: 19
[Token(Token = "0x2000013")]
public class HelicopterRotateController : MonoBehaviour
{
	// Token: 0x06000053 RID: 83 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000053")]
	[Address(RVA = "0x2F68B50", Offset = "0x2F67150", VA = "0x182F68B50")]
	private void Start()
	{
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x2F68D50", Offset = "0x2F67350", VA = "0x182F68D50")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public HelicopterRotateController()
	{
	}

	// Token: 0x04000060 RID: 96
	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 spin;

	// Token: 0x04000061 RID: 97
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 spinAmount;

	// Token: 0x04000062 RID: 98
	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x38")]
	public bool randomizeStartRotation;

	// Token: 0x04000063 RID: 99
	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x39")]
	public bool OffsetPositionToMountain;

	// Token: 0x04000064 RID: 100
	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x3C")]
	public float OffsetAmountZ;

	// Token: 0x04000065 RID: 101
	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x40")]
	public float OffsetAmountX;

	// Token: 0x04000066 RID: 102
	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x44")]
	public float lerpRotationTime;

	// Token: 0x04000067 RID: 103
	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 spinLerped;

	// Token: 0x04000068 RID: 104
	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 offsetPosition;

	// Token: 0x04000069 RID: 105
	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 startLocalPos;

	// Token: 0x0400006A RID: 106
	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 _dir;
}
