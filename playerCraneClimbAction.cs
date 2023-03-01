using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000231 RID: 561
[Token(Token = "0x2000231")]
[AddComponentMenu("TheForest/Player Crane Climb Action")]
public class playerCraneClimbAction : MonoBehaviour
{
	// Token: 0x06000F6C RID: 3948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F6C")]
	[Address(RVA = "0x2FA9770", Offset = "0x2FA8770", VA = "0x182FA9770")]
	private void Start()
	{
	}

	// Token: 0x06000F6D RID: 3949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F6D")]
	[Address(RVA = "0x2FA87E0", Offset = "0x2FA77E0", VA = "0x182FA87E0")]
	private void EnterCraneClimb(Transform trn)
	{
	}

	// Token: 0x06000F6E RID: 3950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F6E")]
	[Address(RVA = "0x2FA9230", Offset = "0x2FA8230", VA = "0x182FA9230")]
	private void ExitCraneClimb()
	{
	}

	// Token: 0x06000F6F RID: 3951 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F6F")]
	[Address(RVA = "0x2FA9720", Offset = "0x2FA8720", VA = "0x182FA9720")]
	private IEnumerator RefreshPlayerCollisionRoutine()
	{
		return null;
	}

	// Token: 0x06000F70 RID: 3952 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F70")]
	[Address(RVA = "0x2FA9780", Offset = "0x2FA8780", VA = "0x182FA9780")]
	private IEnumerator StickToCrane(Vector3 pos, Vector3 dir)
	{
		return null;
	}

	// Token: 0x06000F71 RID: 3953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F71")]
	[Address(RVA = "0x2FA9690", Offset = "0x2FA8690", VA = "0x182FA9690")]
	private void ForceCraneReset()
	{
	}

	// Token: 0x06000F72 RID: 3954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F72")]
	[Address(RVA = "0x2FA9820", Offset = "0x2FA8820", VA = "0x182FA9820")]
	public playerCraneClimbAction()
	{
	}

	// Token: 0x04000E73 RID: 3699
	[Token(Token = "0x4000E73")]
	[FieldOffset(Offset = "0x20")]
	private float _speedDamp;

	// Token: 0x04000E74 RID: 3700
	[Token(Token = "0x4000E74")]
	[FieldOffset(Offset = "0x24")]
	private float _attachOffset;

	// Token: 0x04000E75 RID: 3701
	[Token(Token = "0x4000E75")]
	[FieldOffset(Offset = "0x28")]
	private Transform _triggerTr;

	// Token: 0x04000E76 RID: 3702
	[Token(Token = "0x4000E76")]
	[FieldOffset(Offset = "0x30")]
	private int _pullCraneLoopHash;

	// Token: 0x04000E77 RID: 3703
	[Token(Token = "0x4000E77")]
	[FieldOffset(Offset = "0x34")]
	private bool _onCrane;

	// Token: 0x04000E78 RID: 3704
	[Token(Token = "0x4000E78")]
	[FieldOffset(Offset = "0x38")]
	private float _input;
}
