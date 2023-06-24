using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000283 RID: 643
[Token(Token = "0x2000283")]
[Serializable]
public class TurnOffLeaves : MonoBehaviour
{
	// Token: 0x0600110D RID: 4365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110D")]
	[Address(RVA = "0x3743090", Offset = "0x3741690", VA = "0x183743090", Slot = "4")]
	public virtual void Awake()
	{
	}

	// Token: 0x0600110E RID: 4366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110E")]
	[Address(RVA = "0x328AA40", Offset = "0x3289040", VA = "0x18328AA40", Slot = "5")]
	public virtual void doDelayStart()
	{
	}

	// Token: 0x0600110F RID: 4367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110F")]
	[Address(RVA = "0x37431C0", Offset = "0x37417C0", VA = "0x1837431C0", Slot = "6")]
	public virtual void Update()
	{
	}

	// Token: 0x06001110 RID: 4368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001110")]
	[Address(RVA = "0x3743400", Offset = "0x3741A00", VA = "0x183743400", Slot = "7")]
	public virtual void TurnOff()
	{
	}

	// Token: 0x06001111 RID: 4369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001111")]
	[Address(RVA = "0x3743C90", Offset = "0x3742290", VA = "0x183743C90", Slot = "8")]
	public virtual void ActivateLeafParticles()
	{
	}

	// Token: 0x06001112 RID: 4370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001112")]
	[Address(RVA = "0x3743E00", Offset = "0x3742400", VA = "0x183743E00")]
	public TurnOffLeaves()
	{
	}

	// Token: 0x04001076 RID: 4214
	[Token(Token = "0x4001076")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Leaves;

	// Token: 0x04001077 RID: 4215
	[Token(Token = "0x4001077")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Rig;

	// Token: 0x04001078 RID: 4216
	[Token(Token = "0x4001078")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Lower;

	// Token: 0x04001079 RID: 4217
	[Token(Token = "0x4001079")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Upper;

	// Token: 0x0400107A RID: 4218
	[Token(Token = "0x400107A")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Particles;

	// Token: 0x0400107B RID: 4219
	[Token(Token = "0x400107B")]
	[FieldOffset(Offset = "0x48")]
	public Transform PosChecker;

	// Token: 0x0400107C RID: 4220
	[Token(Token = "0x400107C")]
	[FieldOffset(Offset = "0x50")]
	public GameObject destroyMe;

	// Token: 0x0400107D RID: 4221
	[Token(Token = "0x400107D")]
	[FieldOffset(Offset = "0x58")]
	public float logSwitchHeightOffset;

	// Token: 0x0400107E RID: 4222
	[Token(Token = "0x400107E")]
	[FieldOffset(Offset = "0x5C")]
	public float logSwitchDelay;

	// Token: 0x0400107F RID: 4223
	[Token(Token = "0x400107F")]
	[FieldOffset(Offset = "0x60")]
	public float posCheckHeight;

	// Token: 0x04001080 RID: 4224
	[Token(Token = "0x4001080")]
	[FieldOffset(Offset = "0x64")]
	public float terrainHeight;

	// Token: 0x04001081 RID: 4225
	[Token(Token = "0x4001081")]
	[FieldOffset(Offset = "0x68")]
	private bool delayStart;

	// Token: 0x04001082 RID: 4226
	[Token(Token = "0x4001082")]
	[FieldOffset(Offset = "0x69")]
	private bool Off;
}
