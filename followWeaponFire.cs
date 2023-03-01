using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200012B RID: 299
[Token(Token = "0x200012B")]
public class followWeaponFire : MonoBehaviour
{
	// Token: 0x06000897 RID: 2199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000897")]
	[Address(RVA = "0x2F48CF0", Offset = "0x2F47CF0", VA = "0x182F48CF0")]
	private void Awake()
	{
	}

	// Token: 0x06000898 RID: 2200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000898")]
	[Address(RVA = "0x2F490D0", Offset = "0x2F480D0", VA = "0x182F490D0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000899 RID: 2201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000899")]
	[Address(RVA = "0x2F48D40", Offset = "0x2F47D40", VA = "0x182F48D40")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600089A RID: 2202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600089A")]
	[Address(RVA = "0x2F49120", Offset = "0x2F48120", VA = "0x182F49120")]
	public followWeaponFire()
	{
	}

	// Token: 0x040006EC RID: 1772
	[Token(Token = "0x40006EC")]
	[FieldOffset(Offset = "0x20")]
	public Transform driftFollowTarget;

	// Token: 0x040006ED RID: 1773
	[Token(Token = "0x40006ED")]
	[FieldOffset(Offset = "0x28")]
	public Transform driftReferenceTarget;

	// Token: 0x040006EE RID: 1774
	[Token(Token = "0x40006EE")]
	[FieldOffset(Offset = "0x30")]
	private Transform tr;

	// Token: 0x040006EF RID: 1775
	[Token(Token = "0x40006EF")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 pos;

	// Token: 0x040006F0 RID: 1776
	[Token(Token = "0x40006F0")]
	[FieldOffset(Offset = "0x44")]
	public float smoothTime;

	// Token: 0x040006F1 RID: 1777
	[Token(Token = "0x40006F1")]
	[FieldOffset(Offset = "0x48")]
	public float followDistance;

	// Token: 0x040006F2 RID: 1778
	[Token(Token = "0x40006F2")]
	[FieldOffset(Offset = "0x4C")]
	public float smoothDrift;

	// Token: 0x040006F3 RID: 1779
	[Token(Token = "0x40006F3")]
	[FieldOffset(Offset = "0x50")]
	public float driftYOffset;

	// Token: 0x040006F4 RID: 1780
	[Token(Token = "0x40006F4")]
	[FieldOffset(Offset = "0x54")]
	public float minY;

	// Token: 0x040006F5 RID: 1781
	[Token(Token = "0x40006F5")]
	[FieldOffset(Offset = "0x58")]
	public float maxY;

	// Token: 0x040006F6 RID: 1782
	[Token(Token = "0x40006F6")]
	[FieldOffset(Offset = "0x5C")]
	private float startX;

	// Token: 0x040006F7 RID: 1783
	[Token(Token = "0x40006F7")]
	[FieldOffset(Offset = "0x60")]
	public bool net;
}
