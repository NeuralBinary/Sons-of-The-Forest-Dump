using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000007")]
public class MeshColoringRam : MonoBehaviour
{
	// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x246C9B0", Offset = "0x246AFB0", VA = "0x18246C9B0")]
	private void Start()
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x246CC70", Offset = "0x246B270", VA = "0x18246CC70")]
	private void Update()
	{
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x246CC80", Offset = "0x246B280", VA = "0x18246CC80")]
	public void ColorMeshLive()
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x246D9E0", Offset = "0x246BFE0", VA = "0x18246D9E0")]
	public MeshColoringRam()
	{
	}

	// Token: 0x0400007D RID: 125
	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x20")]
	public float height;

	// Token: 0x0400007E RID: 126
	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x24")]
	public float threshold;

	// Token: 0x0400007F RID: 127
	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x28")]
	public bool autoColor;

	// Token: 0x04000080 RID: 128
	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x29")]
	public bool newMesh;

	// Token: 0x04000081 RID: 129
	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 oldPosition;

	// Token: 0x04000082 RID: 130
	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x38")]
	public bool colorMeshLive;

	// Token: 0x04000083 RID: 131
	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x3C")]
	public LayerMask layer;

	// Token: 0x04000084 RID: 132
	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x40")]
	private MeshFilter[] meshFilters;

	// Token: 0x04000085 RID: 133
	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x48")]
	private bool colored;

	// Token: 0x04000086 RID: 134
	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x0")]
	private static RamSpline[] ramSplines;

	// Token: 0x04000087 RID: 135
	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x8")]
	private static LakePolygon[] lakePolygons;
}
