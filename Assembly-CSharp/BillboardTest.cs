using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000006")]
[ExecuteInEditMode]
public class BillboardTest : MonoBehaviour
{
	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x5C7290", Offset = "0x5C5890", VA = "0x1805C7290")]
	private void OnEnable()
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x5C72B0", Offset = "0x5C58B0", VA = "0x1805C72B0")]
	private void Update()
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x5C7360", Offset = "0x5C5960", VA = "0x1805C7360")]
	private void SetBounds()
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x5C7760", Offset = "0x5C5D60", VA = "0x1805C7760")]
	private void SetRotation()
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x5C7A60", Offset = "0x5C6060", VA = "0x1805C7A60")]
	private void SetStippling()
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x5C7AE0", Offset = "0x5C60E0", VA = "0x1805C7AE0")]
	public BillboardTest()
	{
	}

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x20")]
	private float TreeHeight;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x24")]
	private float TreeScale;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x28")]
	public float FadeNearDistance;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x2C")]
	public float FadeFarDistance;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x30")]
	public float FarKillDistance;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x34")]
	[Range(0f, 359.9f)]
	public float Rotation;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x38")]
	private Mesh mesh;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x40")]
	private Material mat;
}
