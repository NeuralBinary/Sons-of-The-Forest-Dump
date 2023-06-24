using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Animations;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public class RandomSelector : StateMachineBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0xA5CD30", Offset = "0xA5B330", VA = "0x180A5CD30")]
	private void OnValidate()
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000002")]
	[Address(RVA = "0xA5CDA0", Offset = "0xA5B3A0", VA = "0x180A5CDA0")]
	private void UpdateHash()
	{
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	[Address(RVA = "0xA5CE00", Offset = "0xA5B400", VA = "0x180A5CE00")]
	private void RandomizeParameter(Animator animator)
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x6000004")]
	[Address(RVA = "0xA5CFC0", Offset = "0xA5B5C0", VA = "0x180A5CFC0")]
	private int GetNextRandom()
	{
		return 0;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000005")]
	[Address(RVA = "0xA5D0B0", Offset = "0xA5B6B0", VA = "0x180A5D0B0", Slot = "16")]
	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller)
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000006")]
	[Address(RVA = "0xA5D0C0", Offset = "0xA5B6C0", VA = "0x180A5D0C0", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000007")]
	[Address(RVA = "0xA5D140", Offset = "0xA5B740", VA = "0x180A5D140")]
	private void RegenerateRandom()
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000008")]
	[Address(RVA = "0xA5D2F0", Offset = "0xA5B8F0", VA = "0x180A5D2F0")]
	public RandomSelector()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string _paramName;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _min;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int _max;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int _randomizeTick;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private bool _useTrueRandom;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x2D")]
	[SerializeField]
	private bool _blockUpdate;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int _hash;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<int> _randomCache;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int _randomIndex;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x44")]
	private int _lastUpdate;
}
