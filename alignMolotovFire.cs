using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000F9 RID: 249
[Token(Token = "0x20000F9")]
public class alignMolotovFire : MonoBehaviour
{
	// Token: 0x06000749 RID: 1865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000749")]
	[Address(RVA = "0x2E8D360", Offset = "0x2E8C360", VA = "0x182E8D360")]
	private void Awake()
	{
	}

	// Token: 0x0600074A RID: 1866 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600074A")]
	[Address(RVA = "0x2DC8FF0", Offset = "0x2DC7FF0", VA = "0x182DC8FF0")]
	private void Start()
	{
	}

	// Token: 0x0600074B RID: 1867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600074B")]
	[Address(RVA = "0x2E8D3E0", Offset = "0x2E8C3E0", VA = "0x182E8D3E0")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600074C RID: 1868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600074C")]
	[Address(RVA = "0x2E8DA40", Offset = "0x2E8CA40", VA = "0x182E8DA40")]
	public alignMolotovFire()
	{
	}

	// Token: 0x040005E6 RID: 1510
	[Token(Token = "0x40005E6")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	// Token: 0x040005E7 RID: 1511
	[Token(Token = "0x40005E7")]
	[FieldOffset(Offset = "0x28")]
	public Transform followTarget;

	// Token: 0x040005E8 RID: 1512
	[Token(Token = "0x40005E8")]
	[FieldOffset(Offset = "0x30")]
	public Transform dummyTarget;

	// Token: 0x040005E9 RID: 1513
	[Token(Token = "0x40005E9")]
	[FieldOffset(Offset = "0x38")]
	public float xOffset;

	// Token: 0x040005EA RID: 1514
	[Token(Token = "0x40005EA")]
	[FieldOffset(Offset = "0x40")]
	private Transform origParent;

	// Token: 0x040005EB RID: 1515
	[Token(Token = "0x40005EB")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 pos;

	// Token: 0x040005EC RID: 1516
	[Token(Token = "0x40005EC")]
	[FieldOffset(Offset = "0x54")]
	public float smoothTime;

	// Token: 0x040005ED RID: 1517
	[Token(Token = "0x40005ED")]
	[FieldOffset(Offset = "0x58")]
	public float followDistance;

	// Token: 0x040005EE RID: 1518
	[Token(Token = "0x40005EE")]
	[FieldOffset(Offset = "0x5C")]
	public bool net;
}
