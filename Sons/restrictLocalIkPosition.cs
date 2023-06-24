using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000159 RID: 345
[Token(Token = "0x2000159")]
[ExecuteInEditMode]
public class restrictLocalIkPosition : MonoBehaviour
{
	// Token: 0x06000A7E RID: 2686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7E")]
	[Address(RVA = "0x36B5710", Offset = "0x36B3D10", VA = "0x1836B5710")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000A7F RID: 2687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7F")]
	[Address(RVA = "0x36B57A0", Offset = "0x36B3DA0", VA = "0x1836B57A0")]
	public void SolveLimits()
	{
	}

	// Token: 0x06000A80 RID: 2688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A80")]
	[Address(RVA = "0x36B6080", Offset = "0x36B4680", VA = "0x1836B6080")]
	public restrictLocalIkPosition()
	{
	}

	// Token: 0x040008C9 RID: 2249
	[Token(Token = "0x40008C9")]
	[FieldOffset(Offset = "0x20")]
	public Transform[] Blockers;

	// Token: 0x040008CA RID: 2250
	[Token(Token = "0x40008CA")]
	[FieldOffset(Offset = "0x28")]
	public Transform LimitPosTr1;

	// Token: 0x040008CB RID: 2251
	[Token(Token = "0x40008CB")]
	[FieldOffset(Offset = "0x30")]
	public Transform Shoulder;

	// Token: 0x040008CC RID: 2252
	[Token(Token = "0x40008CC")]
	[FieldOffset(Offset = "0x38")]
	public float MaxArmDistance;

	// Token: 0x040008CD RID: 2253
	[Token(Token = "0x40008CD")]
	[FieldOffset(Offset = "0x3C")]
	private float limitAngle;

	// Token: 0x040008CE RID: 2254
	[Token(Token = "0x40008CE")]
	[FieldOffset(Offset = "0x40")]
	private float armDistance;

	// Token: 0x040008CF RID: 2255
	[Token(Token = "0x40008CF")]
	[FieldOffset(Offset = "0x44")]
	public bool RightHand;
}
