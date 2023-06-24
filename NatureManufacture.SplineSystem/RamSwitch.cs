using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000006")]
public class RamSwitch : MonoBehaviour
{
	// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x246BB80", Offset = "0x246A180", VA = "0x18246BB80")]
	public void Switch()
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x246BBC0", Offset = "0x246A1C0", VA = "0x18246BBC0")]
	public void SetProfile(SplineProfile splineProfile)
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public RamSwitch()
	{
	}

	// Token: 0x0400007B RID: 123
	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x20")]
	public RamSpline spline;

	// Token: 0x0400007C RID: 124
	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x28")]
	public SplineProfile Profile;
}
