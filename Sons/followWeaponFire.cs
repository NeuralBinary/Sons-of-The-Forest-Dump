using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000128 RID: 296
[Token(Token = "0x2000128")]
public class followWeaponFire : MonoBehaviour
{
	// Token: 0x060008DE RID: 2270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008DE")]
	[Address(RVA = "0x368D070", Offset = "0x368B670", VA = "0x18368D070")]
	private void Awake()
	{
	}

	// Token: 0x060008DF RID: 2271 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008DF")]
	[Address(RVA = "0x368D180", Offset = "0x368B780", VA = "0x18368D180")]
	private void OnEnable()
	{
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E0")]
	[Address(RVA = "0x368D260", Offset = "0x368B860", VA = "0x18368D260")]
	private void LateUpdate()
	{
	}

	// Token: 0x060008E1 RID: 2273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E1")]
	[Address(RVA = "0x368D880", Offset = "0x368BE80", VA = "0x18368D880")]
	public followWeaponFire()
	{
	}

	// Token: 0x04000708 RID: 1800
	[Token(Token = "0x4000708")]
	[FieldOffset(Offset = "0x20")]
	public Transform driftFollowTarget;

	// Token: 0x04000709 RID: 1801
	[Token(Token = "0x4000709")]
	[FieldOffset(Offset = "0x28")]
	public Transform driftReferenceTarget;

	// Token: 0x0400070A RID: 1802
	[Token(Token = "0x400070A")]
	[FieldOffset(Offset = "0x30")]
	private Transform tr;

	// Token: 0x0400070B RID: 1803
	[Token(Token = "0x400070B")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 pos;

	// Token: 0x0400070C RID: 1804
	[Token(Token = "0x400070C")]
	[FieldOffset(Offset = "0x44")]
	public float smoothTime;

	// Token: 0x0400070D RID: 1805
	[Token(Token = "0x400070D")]
	[FieldOffset(Offset = "0x48")]
	public float followDistance;

	// Token: 0x0400070E RID: 1806
	[Token(Token = "0x400070E")]
	[FieldOffset(Offset = "0x4C")]
	public float smoothDrift;

	// Token: 0x0400070F RID: 1807
	[Token(Token = "0x400070F")]
	[FieldOffset(Offset = "0x50")]
	public float driftYOffset;

	// Token: 0x04000710 RID: 1808
	[Token(Token = "0x4000710")]
	[FieldOffset(Offset = "0x54")]
	public float minY;

	// Token: 0x04000711 RID: 1809
	[Token(Token = "0x4000711")]
	[FieldOffset(Offset = "0x58")]
	public float maxY;

	// Token: 0x04000712 RID: 1810
	[Token(Token = "0x4000712")]
	[FieldOffset(Offset = "0x5C")]
	private float startX;

	// Token: 0x04000713 RID: 1811
	[Token(Token = "0x4000713")]
	[FieldOffset(Offset = "0x60")]
	public bool net;
}
