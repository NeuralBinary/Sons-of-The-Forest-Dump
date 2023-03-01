using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

// Token: 0x020002EE RID: 750
[Token(Token = "0x20002EE")]
public class DemoTurret : MonoBehaviour
{
	// Token: 0x0600132A RID: 4906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132A")]
	[Address(RVA = "0x2C63350", Offset = "0x2C62350", VA = "0x182C63350")]
	private void Awake()
	{
	}

	// Token: 0x0600132B RID: 4907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132B")]
	[Address(RVA = "0x2C63490", Offset = "0x2C62490", VA = "0x182C63490")]
	private void OnTargetUpdateDel(List<Target> targets)
	{
	}

	// Token: 0x0600132C RID: 4908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132C")]
	[Address(RVA = "0x2C63440", Offset = "0x2C62440", VA = "0x182C63440")]
	private void OnTargetIdleUpdateDel()
	{
	}

	// Token: 0x0600132D RID: 4909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132D")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public DemoTurret()
	{
	}

	// Token: 0x04001314 RID: 4884
	[Token(Token = "0x4001314")]
	[FieldOffset(Offset = "0x20")]
	public SmoothLookAtConstraint turretY;

	// Token: 0x04001315 RID: 4885
	[Token(Token = "0x4001315")]
	[FieldOffset(Offset = "0x28")]
	public SmoothLookAtConstraint turretX;
}
