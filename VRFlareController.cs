using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B4 RID: 692
[Token(Token = "0x20002B4")]
public class VRFlareController : MonoBehaviour
{
	// Token: 0x060011DA RID: 4570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011DA")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void OnEnable()
	{
	}

	// Token: 0x060011DB RID: 4571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011DB")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void OnDisable()
	{
	}

	// Token: 0x060011DC RID: 4572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011DC")]
	[Address(RVA = "0x2B89A50", Offset = "0x2B88A50", VA = "0x182B89A50")]
	public void setLit()
	{
	}

	// Token: 0x060011DD RID: 4573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011DD")]
	[Address(RVA = "0x2B89AF0", Offset = "0x2B88AF0", VA = "0x182B89AF0")]
	public void setUnlit()
	{
	}

	// Token: 0x060011DE RID: 4574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011DE")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public VRFlareController()
	{
	}

	// Token: 0x040011BA RID: 4538
	[Token(Token = "0x40011BA")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CapVR;

	// Token: 0x040011BB RID: 4539
	[Token(Token = "0x40011BB")]
	[FieldOffset(Offset = "0x28")]
	public GameObject CapRegular;

	// Token: 0x040011BC RID: 4540
	[Token(Token = "0x40011BC")]
	[FieldOffset(Offset = "0x30")]
	public Renderer _flareBody;

	// Token: 0x040011BD RID: 4541
	[Token(Token = "0x40011BD")]
	[FieldOffset(Offset = "0x38")]
	public Transform restTransform;

	// Token: 0x040011BE RID: 4542
	[Token(Token = "0x40011BE")]
	[FieldOffset(Offset = "0x40")]
	public GameObject _flareLight;

	// Token: 0x040011BF RID: 4543
	[Token(Token = "0x40011BF")]
	[FieldOffset(Offset = "0x48")]
	public Material _litMat;

	// Token: 0x040011C0 RID: 4544
	[Token(Token = "0x40011C0")]
	[FieldOffset(Offset = "0x50")]
	public Material _unlitMat;

	// Token: 0x040011C1 RID: 4545
	[Token(Token = "0x40011C1")]
	[FieldOffset(Offset = "0x58")]
	private float prevHoverRadius;
}
