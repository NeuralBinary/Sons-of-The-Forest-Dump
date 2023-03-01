using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002BA RID: 698
[Token(Token = "0x20002BA")]
public class VRLightFire : MonoBehaviour
{
	// Token: 0x060011F3 RID: 4595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F3")]
	[Address(RVA = "0x921FE0", Offset = "0x920FE0", VA = "0x180921FE0")]
	private void Start()
	{
	}

	// Token: 0x060011F4 RID: 4596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F4")]
	[Address(RVA = "0x5F61F0", Offset = "0x5F51F0", VA = "0x1805F61F0")]
	private void OnDisable()
	{
	}

	// Token: 0x060011F5 RID: 4597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F5")]
	[Address(RVA = "0x2B8A440", Offset = "0x2B89440", VA = "0x182B8A440")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060011F6 RID: 4598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F6")]
	[Address(RVA = "0x2B8A4B0", Offset = "0x2B894B0", VA = "0x182B8A4B0")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x060011F7 RID: 4599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F7")]
	[Address(RVA = "0x2B8A520", Offset = "0x2B89520", VA = "0x182B8A520")]
	private void Update()
	{
	}

	// Token: 0x060011F8 RID: 4600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F8")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public VRLightFire()
	{
	}

	// Token: 0x040011D3 RID: 4563
	[Token(Token = "0x40011D3")]
	[FieldOffset(Offset = "0x20")]
	public GameObject targetFire;

	// Token: 0x040011D4 RID: 4564
	[Token(Token = "0x40011D4")]
	[FieldOffset(Offset = "0x28")]
	private bool InFireTrigger;

	// Token: 0x040011D5 RID: 4565
	[Token(Token = "0x40011D5")]
	[FieldOffset(Offset = "0x2C")]
	private float nextFireCheck;

	// Token: 0x040011D6 RID: 4566
	[Token(Token = "0x40011D6")]
	[FieldOffset(Offset = "0x30")]
	public bool ArrowFire;
}
