using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002BB RID: 699
[Token(Token = "0x20002BB")]
public class VROffsetTransform : MonoBehaviour
{
	// Token: 0x060011F9 RID: 4601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F9")]
	[Address(RVA = "0x2B8A5D0", Offset = "0x2B895D0", VA = "0x182B8A5D0")]
	private void Awake()
	{
	}

	// Token: 0x060011FA RID: 4602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FA")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void OnEnable()
	{
	}

	// Token: 0x060011FB RID: 4603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FB")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void Update()
	{
	}

	// Token: 0x060011FC RID: 4604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FC")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void OnDisable()
	{
	}

	// Token: 0x060011FD RID: 4605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FD")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public VROffsetTransform()
	{
	}

	// Token: 0x040011D7 RID: 4567
	[Token(Token = "0x40011D7")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 rotationOffset;

	// Token: 0x040011D8 RID: 4568
	[Token(Token = "0x40011D8")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 positionOffset;

	// Token: 0x040011D9 RID: 4569
	[Token(Token = "0x40011D9")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 initialEulerRotation;

	// Token: 0x040011DA RID: 4570
	[Token(Token = "0x40011DA")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 initialLocalPosition;
}
