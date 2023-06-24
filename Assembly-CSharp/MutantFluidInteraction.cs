using System;
using FluidSimulation;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000012 RID: 18
[Token(Token = "0x2000012")]
public class MutantFluidInteraction : MonoBehaviour
{
	// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004B")]
	[Address(RVA = "0x5D1820", Offset = "0x5CFE20", VA = "0x1805D1820")]
	private void OnEnable()
	{
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004C")]
	[Address(RVA = "0x5D1A50", Offset = "0x5D0050", VA = "0x1805D1A50")]
	private void GetFluidHitParams(Vector3 hitPos)
	{
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x5D1A60", Offset = "0x5D0060", VA = "0x1805D1A60")]
	private void ProcessFluid(Collider hitCollider)
	{
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x5D2130", Offset = "0x5D0730", VA = "0x1805D2130")]
	public MutantFluidInteraction()
	{
	}

	// Token: 0x040000B0 RID: 176
	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x20")]
	private Camera cam;

	// Token: 0x040000B1 RID: 177
	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x28")]
	public FluidSimulator simulator;

	// Token: 0x040000B2 RID: 178
	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x30")]
	public float radius;

	// Token: 0x040000B3 RID: 179
	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x34")]
	public float amount;

	// Token: 0x040000B4 RID: 180
	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x38")]
	public Texture2D bloodTex;

	// Token: 0x040000B5 RID: 181
	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x40")]
	private int _rayMask;

	// Token: 0x040000B6 RID: 182
	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 lastHitPos;
}
