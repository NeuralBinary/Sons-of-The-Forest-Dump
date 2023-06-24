using System;
using FluidSimulation;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000013 RID: 19
[Token(Token = "0x2000013")]
[AddComponentMenu("Sons/FX/Easy Fluid Interaction")]
public class SonsEasyFluidInteraction : MonoBehaviour
{
	// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x5D2180", Offset = "0x5D0780", VA = "0x1805D2180")]
	private void Awake()
	{
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x5D2240", Offset = "0x5D0840", VA = "0x1805D2240")]
	private void OnEnable()
	{
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x5D22F0", Offset = "0x5D08F0", VA = "0x1805D22F0")]
	private void Update()
	{
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x5D29A0", Offset = "0x5D0FA0", VA = "0x1805D29A0")]
	public SonsEasyFluidInteraction()
	{
	}

	// Token: 0x040000B7 RID: 183
	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _rootObject;

	// Token: 0x040000B8 RID: 184
	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x28")]
	public FluidSimulator simulator;

	// Token: 0x040000B9 RID: 185
	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x30")]
	public float radius;

	// Token: 0x040000BA RID: 186
	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x34")]
	public float amount;

	// Token: 0x040000BB RID: 187
	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x38")]
	public float brushDepth;

	// Token: 0x040000BC RID: 188
	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x40")]
	public Texture2D bloodTex;

	// Token: 0x040000BD RID: 189
	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x48")]
	private Camera cam;

	// Token: 0x040000BE RID: 190
	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x50")]
	private int _rayMask;

	// Token: 0x040000BF RID: 191
	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x58")]
	private Collider[] _colliders;
}
