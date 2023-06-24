using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000230 RID: 560
[Token(Token = "0x2000230")]
[AddComponentMenu("TheForest/Player Crane Climb Action")]
public class playerCraneClimbAction : MonoBehaviour
{
	// Token: 0x06000FD2 RID: 4050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FD2")]
	[Address(RVA = "0x372F020", Offset = "0x372D620", VA = "0x18372F020")]
	private void Start()
	{
	}

	// Token: 0x06000FD3 RID: 4051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FD3")]
	[Address(RVA = "0x372F030", Offset = "0x372D630", VA = "0x18372F030")]
	private void EnterCraneClimb(Transform trn)
	{
	}

	// Token: 0x06000FD4 RID: 4052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FD4")]
	[Address(RVA = "0x37300A0", Offset = "0x372E6A0", VA = "0x1837300A0")]
	private void ExitCraneClimb()
	{
	}

	// Token: 0x06000FD5 RID: 4053 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FD5")]
	[Address(RVA = "0x3730730", Offset = "0x372ED30", VA = "0x183730730")]
	private IEnumerator RefreshPlayerCollisionRoutine()
	{
		return null;
	}

	// Token: 0x06000FD6 RID: 4054 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FD6")]
	[Address(RVA = "0x3730770", Offset = "0x372ED70", VA = "0x183730770")]
	private IEnumerator StickToCrane(Vector3 pos, Vector3 dir)
	{
		return null;
	}

	// Token: 0x06000FD7 RID: 4055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FD7")]
	[Address(RVA = "0x3730840", Offset = "0x372EE40", VA = "0x183730840")]
	private void ForceCraneReset()
	{
	}

	// Token: 0x06000FD8 RID: 4056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FD8")]
	[Address(RVA = "0x3730940", Offset = "0x372EF40", VA = "0x183730940")]
	public playerCraneClimbAction()
	{
	}

	// Token: 0x04000EA8 RID: 3752
	[Token(Token = "0x4000EA8")]
	[FieldOffset(Offset = "0x20")]
	private float _speedDamp;

	// Token: 0x04000EA9 RID: 3753
	[Token(Token = "0x4000EA9")]
	[FieldOffset(Offset = "0x24")]
	private float _attachOffset;

	// Token: 0x04000EAA RID: 3754
	[Token(Token = "0x4000EAA")]
	[FieldOffset(Offset = "0x28")]
	private Transform _triggerTr;

	// Token: 0x04000EAB RID: 3755
	[Token(Token = "0x4000EAB")]
	[FieldOffset(Offset = "0x30")]
	private int _pullCraneLoopHash;

	// Token: 0x04000EAC RID: 3756
	[Token(Token = "0x4000EAC")]
	[FieldOffset(Offset = "0x34")]
	private bool _onCrane;

	// Token: 0x04000EAD RID: 3757
	[Token(Token = "0x4000EAD")]
	[FieldOffset(Offset = "0x38")]
	private float _input;
}
