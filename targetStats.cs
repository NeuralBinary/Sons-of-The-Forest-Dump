using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200017E RID: 382
[Token(Token = "0x200017E")]
public class targetStats : EntityBehaviour<IPlayerState>
{
	// Token: 0x06000B2E RID: 2862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B2E")]
	[Address(RVA = "0x2F75BD0", Offset = "0x2F74BD0", VA = "0x182F75BD0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000B2F RID: 2863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B2F")]
	[Address(RVA = "0x2F75E40", Offset = "0x2F74E40", VA = "0x182F75E40")]
	private void Update()
	{
	}

	// Token: 0x06000B30 RID: 2864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B30")]
	[Address(RVA = "0x2F760C0", Offset = "0x2F750C0", VA = "0x182F760C0")]
	private void inWaterChanged()
	{
	}

	// Token: 0x06000B31 RID: 2865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B31")]
	[Address(RVA = "0x2F76130", Offset = "0x2F75130", VA = "0x182F76130")]
	private void onRaftChanged()
	{
	}

	// Token: 0x06000B32 RID: 2866 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B32")]
	[Address(RVA = "0x2F76010", Offset = "0x2F75010", VA = "0x182F76010")]
	private void VrChanged()
	{
	}

	// Token: 0x06000B33 RID: 2867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B33")]
	[Address(RVA = "0x2F761A0", Offset = "0x2F751A0", VA = "0x182F761A0")]
	private void rightHandChanged()
	{
	}

	// Token: 0x06000B34 RID: 2868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B34")]
	[Address(RVA = "0x2F76080", Offset = "0x2F75080", VA = "0x182F76080")]
	public targetStats()
	{
	}

	// Token: 0x040009F8 RID: 2552
	[Token(Token = "0x40009F8")]
	[FieldOffset(Offset = "0x28")]
	public bool setPlayerType;

	// Token: 0x040009F9 RID: 2553
	[Token(Token = "0x40009F9")]
	[FieldOffset(Offset = "0x2C")]
	private AnimatorStateInfo state2;

	// Token: 0x040009FA RID: 2554
	[Token(Token = "0x40009FA")]
	[FieldOffset(Offset = "0x50")]
	public bool inWater;

	// Token: 0x040009FB RID: 2555
	[Token(Token = "0x40009FB")]
	[FieldOffset(Offset = "0x51")]
	public bool onRaft;

	// Token: 0x040009FC RID: 2556
	[Token(Token = "0x40009FC")]
	[FieldOffset(Offset = "0x52")]
	public bool VREnabled;

	// Token: 0x040009FD RID: 2557
	[Token(Token = "0x40009FD")]
	[FieldOffset(Offset = "0x53")]
	public bool RightHandActive;
}
