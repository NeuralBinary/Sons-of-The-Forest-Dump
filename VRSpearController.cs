using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002C0 RID: 704
[Token(Token = "0x20002C0")]
public class VRSpearController : MonoBehaviour
{
	// Token: 0x06001215 RID: 4629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001215")]
	[Address(RVA = "0x2B8B970", Offset = "0x2B8A970", VA = "0x182B8B970")]
	private void Awake()
	{
	}

	// Token: 0x06001216 RID: 4630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001216")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void OnDisable()
	{
	}

	// Token: 0x06001217 RID: 4631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001217")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void Update()
	{
	}

	// Token: 0x06001218 RID: 4632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001218")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public VRSpearController()
	{
	}

	// Token: 0x04001208 RID: 4616
	[Token(Token = "0x4001208")]
	[FieldOffset(Offset = "0x20")]
	public float initRotY;

	// Token: 0x04001209 RID: 4617
	[Token(Token = "0x4001209")]
	[FieldOffset(Offset = "0x24")]
	private float ResetAngleTimer;

	// Token: 0x0400120A RID: 4618
	[Token(Token = "0x400120A")]
	[FieldOffset(Offset = "0x28")]
	private float smoothWeaponAngle;
}
