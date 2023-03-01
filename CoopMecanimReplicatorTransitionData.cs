using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200006B RID: 107
[Token(Token = "0x200006B")]
[CreateAssetMenu(menuName = "Sons/Animation/Transition Data", fileName = "TransitionData", order = 0)]
public class CoopMecanimReplicatorTransitionData : ScriptableObject
{
	// Token: 0x06000323 RID: 803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000323")]
	[Address(RVA = "0x2B63FC0", Offset = "0x2B62FC0", VA = "0x182B63FC0")]
	public void Init()
	{
	}

	// Token: 0x06000324 RID: 804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000324")]
	[Address(RVA = "0x2B641E0", Offset = "0x2B631E0", VA = "0x182B641E0")]
	public void SortData()
	{
	}

	// Token: 0x06000325 RID: 805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000325")]
	[Address(RVA = "0x539C30", Offset = "0x538C30", VA = "0x180539C30")]
	public CoopMecanimReplicatorTransitionData()
	{
	}

	// Token: 0x040002E5 RID: 741
	[Token(Token = "0x40002E5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public CoopMecanimReplicatorTransitionData.TransitionData[] Data;

	// Token: 0x040002E6 RID: 742
	[Token(Token = "0x40002E6")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<int, Dictionary<bool, float>> Lookup;

	// Token: 0x040002E7 RID: 743
	[Token(Token = "0x40002E7")]
	[FieldOffset(Offset = "0x28")]
	public Dictionary<int, bool> ExitTransitions;

	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	[Serializable]
	public class TransitionData
	{
		// Token: 0x06000326 RID: 806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public TransitionData()
		{
		}

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x10")]
		public int HashFrom;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x14")]
		public int HashTo;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x18")]
		public float Duration;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x1C")]
		public bool fixedDuration;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x1D")]
		public bool noConditions;
	}
}
