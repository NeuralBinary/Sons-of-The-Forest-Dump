using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000FA RID: 250
[Token(Token = "0x20000FA")]
public class alignWeaponFire : MonoBehaviour
{
	// Token: 0x0600074D RID: 1869 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600074D")]
	[Address(RVA = "0x2CEC6F0", Offset = "0x2CEB6F0", VA = "0x182CEC6F0")]
	private void Awake()
	{
	}

	// Token: 0x0600074E RID: 1870 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600074E")]
	[Address(RVA = "0x2E8DA60", Offset = "0x2E8CA60", VA = "0x182E8DA60")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600074F RID: 1871 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600074F")]
	[Address(RVA = "0x2E8DD70", Offset = "0x2E8CD70", VA = "0x182E8DD70")]
	public alignWeaponFire()
	{
	}

	// Token: 0x040005EF RID: 1519
	[Token(Token = "0x40005EF")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	// Token: 0x040005F0 RID: 1520
	[Token(Token = "0x40005F0")]
	[FieldOffset(Offset = "0x28")]
	public Transform camLookAtTarget;

	// Token: 0x040005F1 RID: 1521
	[Token(Token = "0x40005F1")]
	[FieldOffset(Offset = "0x30")]
	public Transform rotateTransform;

	// Token: 0x040005F2 RID: 1522
	[Token(Token = "0x40005F2")]
	[FieldOffset(Offset = "0x38")]
	public float rotOffset;

	// Token: 0x040005F3 RID: 1523
	[Token(Token = "0x40005F3")]
	[FieldOffset(Offset = "0x3C")]
	public float driftYOffset;

	// Token: 0x040005F4 RID: 1524
	[Token(Token = "0x40005F4")]
	[FieldOffset(Offset = "0x40")]
	public bool net;
}
