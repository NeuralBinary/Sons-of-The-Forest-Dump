using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000008 RID: 8
[Token(Token = "0x2000008")]
[RequireComponent(typeof(Rigidbody))]
public class RamBuoyancy : MonoBehaviour
{
	// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x246DA80", Offset = "0x246C080", VA = "0x18246DA80")]
	private void Start()
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x246E390", Offset = "0x246C990", VA = "0x18246E390")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x246E3A0", Offset = "0x246C9A0", VA = "0x18246E3A0")]
	public void WaterPhysics()
	{
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2470860", Offset = "0x246EE60", VA = "0x182470860")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2470C50", Offset = "0x246F250", VA = "0x182470C50")]
	public RamBuoyancy()
	{
	}

	// Token: 0x04000088 RID: 136
	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x20")]
	public float buoyancy;

	// Token: 0x04000089 RID: 137
	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x24")]
	public float viscosity;

	// Token: 0x0400008A RID: 138
	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x28")]
	public float viscosityAngular;

	// Token: 0x0400008B RID: 139
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x2C")]
	public LayerMask layer;

	// Token: 0x0400008C RID: 140
	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x30")]
	public Collider collider;

	// Token: 0x0400008D RID: 141
	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x38")]
	[Range(2f, 10f)]
	public int pointsInAxis;

	// Token: 0x0400008E RID: 142
	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody rigidbody;

	// Token: 0x0400008F RID: 143
	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x0")]
	private static RamSpline[] ramSplines;

	// Token: 0x04000090 RID: 144
	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x8")]
	private static LakePolygon[] lakePolygons;

	// Token: 0x04000091 RID: 145
	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x48")]
	public List<Vector3> volumePoints;

	// Token: 0x04000092 RID: 146
	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x50")]
	public bool autoGenerateVolumePoints;

	// Token: 0x04000093 RID: 147
	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x58")]
	private Vector3[] volumePointsMatrix;

	// Token: 0x04000094 RID: 148
	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 lowestPoint;

	// Token: 0x04000095 RID: 149
	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 center;

	// Token: 0x04000096 RID: 150
	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x78")]
	public bool debug;
}
