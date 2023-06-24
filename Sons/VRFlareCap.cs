using System;
using Il2CppDummyDll;
using UnityEngine;
using Valve.VR.InteractionSystem;

// Token: 0x020002A7 RID: 679
[Token(Token = "0x20002A7")]
public class VRFlareCap : MonoBehaviour
{
	// Token: 0x06001208 RID: 4616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001208")]
	[Address(RVA = "0x31D36E0", Offset = "0x31D1CE0", VA = "0x1831D36E0")]
	private void OnDisable()
	{
	}

	// Token: 0x06001209 RID: 4617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001209")]
	[Address(RVA = "0x31D36F0", Offset = "0x31D1CF0", VA = "0x1831D36F0")]
	private void OnHandHoverBegin(Hand hand)
	{
	}

	// Token: 0x0600120A RID: 4618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120A")]
	[Address(RVA = "0x31D3850", Offset = "0x31D1E50", VA = "0x1831D3850")]
	private void HandHoverUpdate(Hand hand)
	{
	}

	// Token: 0x0600120B RID: 4619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120B")]
	[Address(RVA = "0x31D39B0", Offset = "0x31D1FB0", VA = "0x1831D39B0")]
	private void OnAttachedToHand(Hand hand)
	{
	}

	// Token: 0x0600120C RID: 4620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120C")]
	[Address(RVA = "0x31D3CA0", Offset = "0x31D22A0", VA = "0x1831D3CA0")]
	private void HandAttachedUpdate(Hand hand)
	{
	}

	// Token: 0x0600120D RID: 4621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120D")]
	[Address(RVA = "0x31D40D0", Offset = "0x31D26D0", VA = "0x1831D40D0")]
	private void SpawnDynamicCap()
	{
	}

	// Token: 0x0600120E RID: 4622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120E")]
	[Address(RVA = "0x31D44E0", Offset = "0x31D2AE0", VA = "0x1831D44E0")]
	public VRFlareCap()
	{
	}

	// Token: 0x040011D4 RID: 4564
	[Token(Token = "0x40011D4")]
	[FieldOffset(Offset = "0x20")]
	[EnumFlags]
	[Tooltip("The flags used to attach this object to the hand.")]
	public Hand.AttachmentFlags attachmentFlags;

	// Token: 0x040011D5 RID: 4565
	[Token(Token = "0x40011D5")]
	[FieldOffset(Offset = "0x28")]
	[Tooltip("Name of the attachment transform under in the hand's hierarchy which the object should should snap to.")]
	public string attachmentPoint;

	// Token: 0x040011D6 RID: 4566
	[Token(Token = "0x40011D6")]
	[FieldOffset(Offset = "0x30")]
	private bool attached;

	// Token: 0x040011D7 RID: 4567
	[Token(Token = "0x40011D7")]
	[FieldOffset(Offset = "0x34")]
	private float attachTime;

	// Token: 0x040011D8 RID: 4568
	[Token(Token = "0x40011D8")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 attachPosition;

	// Token: 0x040011D9 RID: 4569
	[Token(Token = "0x40011D9")]
	[FieldOffset(Offset = "0x44")]
	private Quaternion attachRotation;

	// Token: 0x040011DA RID: 4570
	[Token(Token = "0x40011DA")]
	[FieldOffset(Offset = "0x58")]
	public GameObject dynamicCap;

	// Token: 0x040011DB RID: 4571
	[Token(Token = "0x40011DB")]
	[FieldOffset(Offset = "0x60")]
	public VRFlareController controller;

	// Token: 0x040011DC RID: 4572
	[Token(Token = "0x40011DC")]
	[FieldOffset(Offset = "0x68")]
	public Transform restTransform;

	// Token: 0x040011DD RID: 4573
	[Token(Token = "0x40011DD")]
	[FieldOffset(Offset = "0x70")]
	public float minPullDistance;

	// Token: 0x040011DE RID: 4574
	[Token(Token = "0x40011DE")]
	[FieldOffset(Offset = "0x74")]
	public float popForce;

	// Token: 0x040011DF RID: 4575
	[Token(Token = "0x40011DF")]
	[FieldOffset(Offset = "0x78")]
	public float popTorque;

	// Token: 0x040011E0 RID: 4576
	[Token(Token = "0x40011E0")]
	[FieldOffset(Offset = "0x7C")]
	public bool flarePopped;
}
