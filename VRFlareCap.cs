using System;
using Il2CppDummyDll;
using UnityEngine;
using Valve.VR.InteractionSystem;

// Token: 0x020002B3 RID: 691
[Token(Token = "0x20002B3")]
public class VRFlareCap : MonoBehaviour
{
	// Token: 0x060011D3 RID: 4563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D3")]
	[Address(RVA = "0x2B896B0", Offset = "0x2B886B0", VA = "0x182B896B0")]
	private void OnDisable()
	{
	}

	// Token: 0x060011D4 RID: 4564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D4")]
	[Address(RVA = "0x2B896C0", Offset = "0x2B886C0", VA = "0x182B896C0")]
	private void OnHandHoverBegin(Hand hand)
	{
	}

	// Token: 0x060011D5 RID: 4565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D5")]
	[Address(RVA = "0x2B894A0", Offset = "0x2B884A0", VA = "0x182B894A0")]
	private void HandHoverUpdate(Hand hand)
	{
	}

	// Token: 0x060011D6 RID: 4566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D6")]
	[Address(RVA = "0x2B895C0", Offset = "0x2B885C0", VA = "0x182B895C0")]
	private void OnAttachedToHand(Hand hand)
	{
	}

	// Token: 0x060011D7 RID: 4567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D7")]
	[Address(RVA = "0x2B890F0", Offset = "0x2B880F0", VA = "0x182B890F0")]
	private void HandAttachedUpdate(Hand hand)
	{
	}

	// Token: 0x060011D8 RID: 4568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D8")]
	[Address(RVA = "0x2B897F0", Offset = "0x2B887F0", VA = "0x182B897F0")]
	private void SpawnDynamicCap()
	{
	}

	// Token: 0x060011D9 RID: 4569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D9")]
	[Address(RVA = "0x2B89A20", Offset = "0x2B88A20", VA = "0x182B89A20")]
	public VRFlareCap()
	{
	}

	// Token: 0x040011AD RID: 4525
	[Token(Token = "0x40011AD")]
	[FieldOffset(Offset = "0x20")]
	[EnumFlags]
	[Tooltip("The flags used to attach this object to the hand.")]
	public Hand.AttachmentFlags attachmentFlags;

	// Token: 0x040011AE RID: 4526
	[Token(Token = "0x40011AE")]
	[FieldOffset(Offset = "0x28")]
	[Tooltip("Name of the attachment transform under in the hand's hierarchy which the object should should snap to.")]
	public string attachmentPoint;

	// Token: 0x040011AF RID: 4527
	[Token(Token = "0x40011AF")]
	[FieldOffset(Offset = "0x30")]
	private bool attached;

	// Token: 0x040011B0 RID: 4528
	[Token(Token = "0x40011B0")]
	[FieldOffset(Offset = "0x34")]
	private float attachTime;

	// Token: 0x040011B1 RID: 4529
	[Token(Token = "0x40011B1")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 attachPosition;

	// Token: 0x040011B2 RID: 4530
	[Token(Token = "0x40011B2")]
	[FieldOffset(Offset = "0x44")]
	private Quaternion attachRotation;

	// Token: 0x040011B3 RID: 4531
	[Token(Token = "0x40011B3")]
	[FieldOffset(Offset = "0x58")]
	public GameObject dynamicCap;

	// Token: 0x040011B4 RID: 4532
	[Token(Token = "0x40011B4")]
	[FieldOffset(Offset = "0x60")]
	public VRFlareController controller;

	// Token: 0x040011B5 RID: 4533
	[Token(Token = "0x40011B5")]
	[FieldOffset(Offset = "0x68")]
	public Transform restTransform;

	// Token: 0x040011B6 RID: 4534
	[Token(Token = "0x40011B6")]
	[FieldOffset(Offset = "0x70")]
	public float minPullDistance;

	// Token: 0x040011B7 RID: 4535
	[Token(Token = "0x40011B7")]
	[FieldOffset(Offset = "0x74")]
	public float popForce;

	// Token: 0x040011B8 RID: 4536
	[Token(Token = "0x40011B8")]
	[FieldOffset(Offset = "0x78")]
	public float popTorque;

	// Token: 0x040011B9 RID: 4537
	[Token(Token = "0x40011B9")]
	[FieldOffset(Offset = "0x7C")]
	public bool flarePopped;
}
