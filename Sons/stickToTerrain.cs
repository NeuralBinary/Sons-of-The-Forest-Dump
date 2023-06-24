using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200017C RID: 380
[Token(Token = "0x200017C")]
public class stickToTerrain : MonoBehaviour
{
	// Token: 0x06000B83 RID: 2947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B83")]
	[Address(RVA = "0x36D2020", Offset = "0x36D0620", VA = "0x1836D2020")]
	private void Start()
	{
	}

	// Token: 0x06000B84 RID: 2948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B84")]
	[Address(RVA = "0x36D26E0", Offset = "0x36D0CE0", VA = "0x1836D26E0")]
	public void doAlignForEncounter()
	{
	}

	// Token: 0x06000B85 RID: 2949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B85")]
	[Address(RVA = "0x36D2C70", Offset = "0x36D1270", VA = "0x1836D2C70")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000B86 RID: 2950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B86")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public stickToTerrain()
	{
	}

	// Token: 0x04000A17 RID: 2583
	[Token(Token = "0x4000A17")]
	[FieldOffset(Offset = "0x20")]
	private Transform Tr;

	// Token: 0x04000A18 RID: 2584
	[Token(Token = "0x4000A18")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 pos;

	// Token: 0x04000A19 RID: 2585
	[Token(Token = "0x4000A19")]
	[FieldOffset(Offset = "0x34")]
	private int layer;

	// Token: 0x04000A1A RID: 2586
	[Token(Token = "0x4000A1A")]
	[FieldOffset(Offset = "0x38")]
	private int layerMask;

	// Token: 0x04000A1B RID: 2587
	[Token(Token = "0x4000A1B")]
	[FieldOffset(Offset = "0x3C")]
	public bool onStart;

	// Token: 0x04000A1C RID: 2588
	[Token(Token = "0x4000A1C")]
	[FieldOffset(Offset = "0x3D")]
	public bool onPlane;

	// Token: 0x04000A1D RID: 2589
	[Token(Token = "0x4000A1D")]
	[FieldOffset(Offset = "0x3E")]
	public bool inCave;

	// Token: 0x04000A1E RID: 2590
	[Token(Token = "0x4000A1E")]
	[FieldOffset(Offset = "0x3F")]
	public bool rotateToTerrain;

	// Token: 0x04000A1F RID: 2591
	[Token(Token = "0x4000A1F")]
	[FieldOffset(Offset = "0x40")]
	public bool parentToWorld;

	// Token: 0x04000A20 RID: 2592
	[Token(Token = "0x4000A20")]
	[FieldOffset(Offset = "0x44")]
	private RaycastHit hit;
}
