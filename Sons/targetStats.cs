using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200017D RID: 381
[Token(Token = "0x200017D")]
public class targetStats : EntityBehaviour<IPlayerState>
{
	// Token: 0x06000B87 RID: 2951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B87")]
	[Address(RVA = "0x36D31E0", Offset = "0x36D17E0", VA = "0x1836D31E0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000B88 RID: 2952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B88")]
	[Address(RVA = "0x36D34A0", Offset = "0x36D1AA0", VA = "0x1836D34A0")]
	private void Update()
	{
	}

	// Token: 0x06000B89 RID: 2953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B89")]
	[Address(RVA = "0x36D3750", Offset = "0x36D1D50", VA = "0x1836D3750")]
	private void inWaterChanged()
	{
	}

	// Token: 0x06000B8A RID: 2954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B8A")]
	[Address(RVA = "0x36D37F0", Offset = "0x36D1DF0", VA = "0x1836D37F0")]
	private void onRaftChanged()
	{
	}

	// Token: 0x06000B8B RID: 2955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B8B")]
	[Address(RVA = "0x36D3890", Offset = "0x36D1E90", VA = "0x1836D3890")]
	private void VrChanged()
	{
	}

	// Token: 0x06000B8C RID: 2956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B8C")]
	[Address(RVA = "0x36D3930", Offset = "0x36D1F30", VA = "0x1836D3930")]
	private void rightHandChanged()
	{
	}

	// Token: 0x06000B8D RID: 2957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B8D")]
	[Address(RVA = "0x36D39D0", Offset = "0x36D1FD0", VA = "0x1836D39D0")]
	public targetStats()
	{
	}

	// Token: 0x04000A21 RID: 2593
	[Token(Token = "0x4000A21")]
	[FieldOffset(Offset = "0x28")]
	public bool setPlayerType;

	// Token: 0x04000A22 RID: 2594
	[Token(Token = "0x4000A22")]
	[FieldOffset(Offset = "0x2C")]
	private AnimatorStateInfo state2;

	// Token: 0x04000A23 RID: 2595
	[Token(Token = "0x4000A23")]
	[FieldOffset(Offset = "0x50")]
	public bool inWater;

	// Token: 0x04000A24 RID: 2596
	[Token(Token = "0x4000A24")]
	[FieldOffset(Offset = "0x51")]
	public bool onRaft;

	// Token: 0x04000A25 RID: 2597
	[Token(Token = "0x4000A25")]
	[FieldOffset(Offset = "0x52")]
	public bool VREnabled;

	// Token: 0x04000A26 RID: 2598
	[Token(Token = "0x4000A26")]
	[FieldOffset(Offset = "0x53")]
	public bool RightHandActive;
}
