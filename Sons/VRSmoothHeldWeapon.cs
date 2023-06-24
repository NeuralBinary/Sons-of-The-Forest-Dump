using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B3 RID: 691
[Token(Token = "0x20002B3")]
public class VRSmoothHeldWeapon : MonoBehaviour
{
	// Token: 0x06001246 RID: 4678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001246")]
	[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
	private void OnEnable()
	{
	}

	// Token: 0x06001247 RID: 4679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001247")]
	[Address(RVA = "0x31D7730", Offset = "0x31D5D30", VA = "0x1831D7730")]
	private void OnDisable()
	{
	}

	// Token: 0x06001248 RID: 4680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001248")]
	[Address(RVA = "0x31D7A50", Offset = "0x31D6050", VA = "0x1831D7A50")]
	private void LateUpdate()
	{
	}

	// Token: 0x06001249 RID: 4681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001249")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public VRSmoothHeldWeapon()
	{
	}

	// Token: 0x04001229 RID: 4649
	[Token(Token = "0x4001229")]
	[FieldOffset(Offset = "0x20")]
	public Transform followTransform;

	// Token: 0x0400122A RID: 4650
	[Token(Token = "0x400122A")]
	[FieldOffset(Offset = "0x28")]
	public Transform offsetTransform;

	// Token: 0x0400122B RID: 4651
	[Token(Token = "0x400122B")]
	[FieldOffset(Offset = "0x30")]
	private Transform aimTransform;

	// Token: 0x0400122C RID: 4652
	[Token(Token = "0x400122C")]
	[FieldOffset(Offset = "0x38")]
	private Quaternion smoothRot;

	// Token: 0x0400122D RID: 4653
	[Token(Token = "0x400122D")]
	[FieldOffset(Offset = "0x48")]
	public float smoothTime;

	// Token: 0x0400122E RID: 4654
	[Token(Token = "0x400122E")]
	[FieldOffset(Offset = "0x4C")]
	private int skipFrameCount;
}
