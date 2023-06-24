using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B0 RID: 688
[Token(Token = "0x20002B0")]
public class VRPlayerBlockedEffect : MonoBehaviour
{
	// Token: 0x06001233 RID: 4659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001233")]
	[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
	private void OnEnable()
	{
	}

	// Token: 0x06001234 RID: 4660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001234")]
	[Address(RVA = "0x31D5E10", Offset = "0x31D4410", VA = "0x1831D5E10")]
	public void UpdateGoalPosition(Vector3 goalPosition)
	{
	}

	// Token: 0x06001235 RID: 4661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001235")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void Update()
	{
	}

	// Token: 0x06001236 RID: 4662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001236")]
	[Address(RVA = "0x31D5E30", Offset = "0x31D4430", VA = "0x1831D5E30")]
	private void DoShow()
	{
	}

	// Token: 0x06001237 RID: 4663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001237")]
	[Address(RVA = "0x31D6090", Offset = "0x31D4690", VA = "0x1831D6090")]
	private void DoHide()
	{
	}

	// Token: 0x06001238 RID: 4664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001238")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06001239 RID: 4665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001239")]
	[Address(RVA = "0x31D64E0", Offset = "0x31D4AE0", VA = "0x1831D64E0")]
	public void ClearOffsets()
	{
	}

	// Token: 0x0600123A RID: 4666 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600123A")]
	[Address(RVA = "0x31D6610", Offset = "0x31D4C10", VA = "0x1831D6610")]
	public VRPlayerBlockedEffect()
	{
	}

	// Token: 0x04001202 RID: 4610
	[Token(Token = "0x4001202")]
	[FieldOffset(Offset = "0x20")]
	public GameObject EffectObject;

	// Token: 0x04001203 RID: 4611
	[Token(Token = "0x4001203")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 EffectScale;

	// Token: 0x04001204 RID: 4612
	[Token(Token = "0x4001204")]
	[FieldOffset(Offset = "0x34")]
	public float ShowSpeed;

	// Token: 0x04001205 RID: 4613
	[Token(Token = "0x4001205")]
	[FieldOffset(Offset = "0x38")]
	public float HideSpeed;

	// Token: 0x04001206 RID: 4614
	[Token(Token = "0x4001206")]
	[FieldOffset(Offset = "0x3C")]
	public float HideDelay;

	// Token: 0x04001207 RID: 4615
	[Token(Token = "0x4001207")]
	[FieldOffset(Offset = "0x40")]
	public float MinThreshold;

	// Token: 0x04001208 RID: 4616
	[Token(Token = "0x4001208")]
	[FieldOffset(Offset = "0x44")]
	public float MaxThreshold;

	// Token: 0x04001209 RID: 4617
	[Token(Token = "0x4001209")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 CalculatedOffset;

	// Token: 0x0400120A RID: 4618
	[Token(Token = "0x400120A")]
	[FieldOffset(Offset = "0x50")]
	public float CalculatedOffsetMag;

	// Token: 0x0400120B RID: 4619
	[Token(Token = "0x400120B")]
	[FieldOffset(Offset = "0x54")]
	public float TrackedMax;

	// Token: 0x0400120C RID: 4620
	[Token(Token = "0x400120C")]
	[FieldOffset(Offset = "0x58")]
	public float CalculatedEffectActivator;

	// Token: 0x0400120D RID: 4621
	[Token(Token = "0x400120D")]
	[FieldOffset(Offset = "0x5C")]
	private Vector2 _currentGoalPosition;

	// Token: 0x0400120E RID: 4622
	[Token(Token = "0x400120E")]
	[FieldOffset(Offset = "0x64")]
	public int Max;

	// Token: 0x0400120F RID: 4623
	[Token(Token = "0x400120F")]
	[FieldOffset(Offset = "0x68")]
	public List<Vector2> Offsets;

	// Token: 0x04001210 RID: 4624
	[Token(Token = "0x4001210")]
	[FieldOffset(Offset = "0x70")]
	public bool HeadMoved;

	// Token: 0x04001211 RID: 4625
	[Token(Token = "0x4001211")]
	[FieldOffset(Offset = "0x74")]
	private float _activatedTime;
}
