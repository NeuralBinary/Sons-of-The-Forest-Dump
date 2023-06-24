using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000068 RID: 104
[Token(Token = "0x2000068")]
[CreateAssetMenu(menuName = "Sons/Animation/Transition Data", fileName = "TransitionData", order = 0)]
public class CoopMecanimReplicatorTransitionData : ScriptableObject
{
	// Token: 0x06000326 RID: 806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000326")]
	[Address(RVA = "0x31C0A60", Offset = "0x31BF060", VA = "0x1831C0A60")]
	public void Init()
	{
	}

	// Token: 0x06000327 RID: 807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000327")]
	[Address(RVA = "0x31C0D70", Offset = "0x31BF370", VA = "0x1831C0D70")]
	public void SortData()
	{
	}

	// Token: 0x06000328 RID: 808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000328")]
	[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
	public CoopMecanimReplicatorTransitionData()
	{
	}

	// Token: 0x040002E7 RID: 743
	[Token(Token = "0x40002E7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public CoopMecanimReplicatorTransitionData.TransitionData[] Data;

	// Token: 0x040002E8 RID: 744
	[Token(Token = "0x40002E8")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<int, Dictionary<bool, float>> Lookup;

	// Token: 0x040002E9 RID: 745
	[Token(Token = "0x40002E9")]
	[FieldOffset(Offset = "0x28")]
	public Dictionary<int, bool> ExitTransitions;

	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	[Serializable]
	public class TransitionData
	{
		// Token: 0x06000329 RID: 809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public TransitionData()
		{
		}

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x10")]
		public int HashFrom;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x14")]
		public int HashTo;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x18")]
		public float Duration;

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x1C")]
		public bool fixedDuration;

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x1D")]
		public bool noConditions;
	}
}
