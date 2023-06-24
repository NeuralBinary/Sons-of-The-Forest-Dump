using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000173 RID: 371
[Token(Token = "0x2000173")]
public class simpleIkLegs : MonoBehaviour
{
	// Token: 0x06000B5E RID: 2910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B5E")]
	[Address(RVA = "0x36CD070", Offset = "0x36CB670", VA = "0x1836CD070")]
	private void Start()
	{
	}

	// Token: 0x06000B5F RID: 2911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B5F")]
	[Address(RVA = "0x36CD120", Offset = "0x36CB720", VA = "0x1836CD120")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000B60 RID: 2912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B60")]
	[Address(RVA = "0x36CD130", Offset = "0x36CB730", VA = "0x1836CD130")]
	private void CalculateFootOffsets()
	{
	}

	// Token: 0x06000B61 RID: 2913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B61")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void CalculateFootRotation()
	{
	}

	// Token: 0x06000B62 RID: 2914 RVA: 0x00004D58 File Offset: 0x00002F58
	[Token(Token = "0x6000B62")]
	[Address(RVA = "0x36CDDA0", Offset = "0x36CC3A0", VA = "0x1836CDDA0")]
	private RaycastHit raycastContacts(Vector3 pos)
	{
		return default(RaycastHit);
	}

	// Token: 0x06000B63 RID: 2915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B63")]
	[Address(RVA = "0x2A96EC0", Offset = "0x2A954C0", VA = "0x182A96EC0")]
	public simpleIkLegs()
	{
	}

	// Token: 0x040009DB RID: 2523
	[Token(Token = "0x40009DB")]
	[FieldOffset(Offset = "0x20")]
	public LayerMask groundMask;

	// Token: 0x040009DC RID: 2524
	[Token(Token = "0x40009DC")]
	[FieldOffset(Offset = "0x24")]
	public bool IsActive;

	// Token: 0x040009DD RID: 2525
	[Token(Token = "0x40009DD")]
	[FieldOffset(Offset = "0x28")]
	private Transform baseTr;

	// Token: 0x040009DE RID: 2526
	[Token(Token = "0x40009DE")]
	[FieldOffset(Offset = "0x30")]
	public Transform hips;

	// Token: 0x040009DF RID: 2527
	[Token(Token = "0x40009DF")]
	[FieldOffset(Offset = "0x38")]
	public Transform LeftIkTarget;

	// Token: 0x040009E0 RID: 2528
	[Token(Token = "0x40009E0")]
	[FieldOffset(Offset = "0x40")]
	public Transform RightIkTarget;

	// Token: 0x040009E1 RID: 2529
	[Token(Token = "0x40009E1")]
	[FieldOffset(Offset = "0x48")]
	public Transform leftFootTarget;

	// Token: 0x040009E2 RID: 2530
	[Token(Token = "0x40009E2")]
	[FieldOffset(Offset = "0x50")]
	public Transform RightFootTarget;

	// Token: 0x040009E3 RID: 2531
	[Token(Token = "0x40009E3")]
	[FieldOffset(Offset = "0x58")]
	public float heightOffset;

	// Token: 0x040009E4 RID: 2532
	[Token(Token = "0x40009E4")]
	[FieldOffset(Offset = "0x5C")]
	public float leftFootOffset;

	// Token: 0x040009E5 RID: 2533
	[Token(Token = "0x40009E5")]
	[FieldOffset(Offset = "0x60")]
	public float rightFootOffset;

	// Token: 0x040009E6 RID: 2534
	[Token(Token = "0x40009E6")]
	[FieldOffset(Offset = "0x64")]
	private float ankleToGroundOffset;

	// Token: 0x040009E7 RID: 2535
	[Token(Token = "0x40009E7")]
	[FieldOffset(Offset = "0x68")]
	private RaycastHit hitPoint;

	// Token: 0x040009E8 RID: 2536
	[Token(Token = "0x40009E8")]
	[FieldOffset(Offset = "0x98")]
	private RaycastHit[] allHit;

	// Token: 0x040009E9 RID: 2537
	[Token(Token = "0x40009E9")]
	[FieldOffset(Offset = "0xA0")]
	private RaycastHit hit;
}
