using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000174 RID: 372
[Token(Token = "0x2000174")]
public class simpleIkLegs : MonoBehaviour
{
	// Token: 0x06000B05 RID: 2821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B05")]
	[Address(RVA = "0x2F606D0", Offset = "0x2F5F6D0", VA = "0x182F606D0")]
	private void Start()
	{
	}

	// Token: 0x06000B06 RID: 2822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B06")]
	[Address(RVA = "0x2F606C0", Offset = "0x2F5F6C0", VA = "0x182F606C0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000B07 RID: 2823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B07")]
	[Address(RVA = "0x2F5FF70", Offset = "0x2F5EF70", VA = "0x182F5FF70")]
	private void CalculateFootOffsets()
	{
	}

	// Token: 0x06000B08 RID: 2824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B08")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void CalculateFootRotation()
	{
	}

	// Token: 0x06000B09 RID: 2825 RVA: 0x00004B30 File Offset: 0x00002D30
	[Token(Token = "0x6000B09")]
	[Address(RVA = "0x2F60700", Offset = "0x2F5F700", VA = "0x182F60700")]
	private RaycastHit raycastContacts(Vector3 pos)
	{
		return default(RaycastHit);
	}

	// Token: 0x06000B0A RID: 2826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0A")]
	[Address(RVA = "0x25BEDB0", Offset = "0x25BDDB0", VA = "0x1825BEDB0")]
	public simpleIkLegs()
	{
	}

	// Token: 0x040009B2 RID: 2482
	[Token(Token = "0x40009B2")]
	[FieldOffset(Offset = "0x20")]
	public LayerMask groundMask;

	// Token: 0x040009B3 RID: 2483
	[Token(Token = "0x40009B3")]
	[FieldOffset(Offset = "0x24")]
	public bool IsActive;

	// Token: 0x040009B4 RID: 2484
	[Token(Token = "0x40009B4")]
	[FieldOffset(Offset = "0x28")]
	private Transform baseTr;

	// Token: 0x040009B5 RID: 2485
	[Token(Token = "0x40009B5")]
	[FieldOffset(Offset = "0x30")]
	public Transform hips;

	// Token: 0x040009B6 RID: 2486
	[Token(Token = "0x40009B6")]
	[FieldOffset(Offset = "0x38")]
	public Transform LeftIkTarget;

	// Token: 0x040009B7 RID: 2487
	[Token(Token = "0x40009B7")]
	[FieldOffset(Offset = "0x40")]
	public Transform RightIkTarget;

	// Token: 0x040009B8 RID: 2488
	[Token(Token = "0x40009B8")]
	[FieldOffset(Offset = "0x48")]
	public Transform leftFootTarget;

	// Token: 0x040009B9 RID: 2489
	[Token(Token = "0x40009B9")]
	[FieldOffset(Offset = "0x50")]
	public Transform RightFootTarget;

	// Token: 0x040009BA RID: 2490
	[Token(Token = "0x40009BA")]
	[FieldOffset(Offset = "0x58")]
	public float heightOffset;

	// Token: 0x040009BB RID: 2491
	[Token(Token = "0x40009BB")]
	[FieldOffset(Offset = "0x5C")]
	public float leftFootOffset;

	// Token: 0x040009BC RID: 2492
	[Token(Token = "0x40009BC")]
	[FieldOffset(Offset = "0x60")]
	public float rightFootOffset;

	// Token: 0x040009BD RID: 2493
	[Token(Token = "0x40009BD")]
	[FieldOffset(Offset = "0x64")]
	private float ankleToGroundOffset;

	// Token: 0x040009BE RID: 2494
	[Token(Token = "0x40009BE")]
	[FieldOffset(Offset = "0x68")]
	private RaycastHit hitPoint;

	// Token: 0x040009BF RID: 2495
	[Token(Token = "0x40009BF")]
	[FieldOffset(Offset = "0x98")]
	private RaycastHit[] allHit;

	// Token: 0x040009C0 RID: 2496
	[Token(Token = "0x40009C0")]
	[FieldOffset(Offset = "0xA0")]
	private RaycastHit hit;
}
