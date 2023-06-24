using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000F8 RID: 248
[Token(Token = "0x20000F8")]
public class animateMeat : MonoBehaviour
{
	// Token: 0x06000798 RID: 1944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000798")]
	[Address(RVA = "0x367A380", Offset = "0x3678980", VA = "0x18367A380")]
	private void Start()
	{
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000799")]
	[Address(RVA = "0x367A5C0", Offset = "0x3678BC0", VA = "0x18367A5C0")]
	internal void playMeat(float t)
	{
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079A")]
	[Address(RVA = "0x367A630", Offset = "0x3678C30", VA = "0x18367A630")]
	private void setMeatMaterial(bool burnt)
	{
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079B")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public animateMeat()
	{
	}

	// Token: 0x04000612 RID: 1554
	[Token(Token = "0x4000612")]
	[FieldOffset(Offset = "0x20")]
	public Animator animator;

	// Token: 0x04000613 RID: 1555
	[Token(Token = "0x4000613")]
	[FieldOffset(Offset = "0x28")]
	private SkinnedMeshRenderer skin;

	// Token: 0x04000614 RID: 1556
	[Token(Token = "0x4000614")]
	[FieldOffset(Offset = "0x30")]
	public Material meatMat;

	// Token: 0x04000615 RID: 1557
	[Token(Token = "0x4000615")]
	[FieldOffset(Offset = "0x38")]
	public Material burntMat;
}
