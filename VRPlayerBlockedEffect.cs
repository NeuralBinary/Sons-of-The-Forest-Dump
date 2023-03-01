using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002BC RID: 700
[Token(Token = "0x20002BC")]
public class VRPlayerBlockedEffect : MonoBehaviour
{
	// Token: 0x060011FE RID: 4606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FE")]
	[Address(RVA = "0x21F6BA0", Offset = "0x21F5BA0", VA = "0x1821F6BA0")]
	private void OnEnable()
	{
	}

	// Token: 0x060011FF RID: 4607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FF")]
	[Address(RVA = "0x2B8AAC0", Offset = "0x2B89AC0", VA = "0x182B8AAC0")]
	public void UpdateGoalPosition(Vector3 goalPosition)
	{
	}

	// Token: 0x06001200 RID: 4608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001200")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void Update()
	{
	}

	// Token: 0x06001201 RID: 4609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001201")]
	[Address(RVA = "0x2B8A990", Offset = "0x2B89990", VA = "0x182B8A990")]
	private void DoShow()
	{
	}

	// Token: 0x06001202 RID: 4610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001202")]
	[Address(RVA = "0x2B8A760", Offset = "0x2B89760", VA = "0x182B8A760")]
	private void DoHide()
	{
	}

	// Token: 0x06001203 RID: 4611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001203")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06001204 RID: 4612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001204")]
	[Address(RVA = "0x2B8A640", Offset = "0x2B89640", VA = "0x182B8A640")]
	public void ClearOffsets()
	{
	}

	// Token: 0x06001205 RID: 4613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001205")]
	[Address(RVA = "0x2B8AAE0", Offset = "0x2B89AE0", VA = "0x182B8AAE0")]
	public VRPlayerBlockedEffect()
	{
	}

	// Token: 0x040011DB RID: 4571
	[Token(Token = "0x40011DB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject EffectObject;

	// Token: 0x040011DC RID: 4572
	[Token(Token = "0x40011DC")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 EffectScale;

	// Token: 0x040011DD RID: 4573
	[Token(Token = "0x40011DD")]
	[FieldOffset(Offset = "0x34")]
	public float ShowSpeed;

	// Token: 0x040011DE RID: 4574
	[Token(Token = "0x40011DE")]
	[FieldOffset(Offset = "0x38")]
	public float HideSpeed;

	// Token: 0x040011DF RID: 4575
	[Token(Token = "0x40011DF")]
	[FieldOffset(Offset = "0x3C")]
	public float HideDelay;

	// Token: 0x040011E0 RID: 4576
	[Token(Token = "0x40011E0")]
	[FieldOffset(Offset = "0x40")]
	public float MinThreshold;

	// Token: 0x040011E1 RID: 4577
	[Token(Token = "0x40011E1")]
	[FieldOffset(Offset = "0x44")]
	public float MaxThreshold;

	// Token: 0x040011E2 RID: 4578
	[Token(Token = "0x40011E2")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 CalculatedOffset;

	// Token: 0x040011E3 RID: 4579
	[Token(Token = "0x40011E3")]
	[FieldOffset(Offset = "0x50")]
	public float CalculatedOffsetMag;

	// Token: 0x040011E4 RID: 4580
	[Token(Token = "0x40011E4")]
	[FieldOffset(Offset = "0x54")]
	public float TrackedMax;

	// Token: 0x040011E5 RID: 4581
	[Token(Token = "0x40011E5")]
	[FieldOffset(Offset = "0x58")]
	public float CalculatedEffectActivator;

	// Token: 0x040011E6 RID: 4582
	[Token(Token = "0x40011E6")]
	[FieldOffset(Offset = "0x5C")]
	private Vector2 _currentGoalPosition;

	// Token: 0x040011E7 RID: 4583
	[Token(Token = "0x40011E7")]
	[FieldOffset(Offset = "0x64")]
	public int Max;

	// Token: 0x040011E8 RID: 4584
	[Token(Token = "0x40011E8")]
	[FieldOffset(Offset = "0x68")]
	public List<Vector2> Offsets;

	// Token: 0x040011E9 RID: 4585
	[Token(Token = "0x40011E9")]
	[FieldOffset(Offset = "0x70")]
	public bool HeadMoved;

	// Token: 0x040011EA RID: 4586
	[Token(Token = "0x40011EA")]
	[FieldOffset(Offset = "0x74")]
	private float _activatedTime;
}
