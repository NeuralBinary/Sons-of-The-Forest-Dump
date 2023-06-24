using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000010 RID: 16
[Token(Token = "0x2000010")]
public class VirginiaWrinkleController : MonoBehaviour
{
	// Token: 0x0600003C RID: 60 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x2F66180", Offset = "0x2F64780", VA = "0x182F66180")]
	private void Start()
	{
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x2F66230", Offset = "0x2F64830", VA = "0x182F66230")]
	private void Update()
	{
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003E")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public VirginiaWrinkleController()
	{
	}

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x20")]
	public Transform driver1;

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x28")]
	public Transform driver2;

	// Token: 0x0400004D RID: 77
	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x30")]
	public SkinnedMeshRenderer TargetRenderer;

	// Token: 0x0400004E RID: 78
	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x38")]
	public float BlendAmount;

	// Token: 0x0400004F RID: 79
	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x40")]
	private Material _targetMat;
}
