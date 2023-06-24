using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using UnityEngine;
using UnityEngine.Animations;

// Token: 0x020002F0 RID: 752
[Token(Token = "0x20002F0")]
public class ReparentAndConstrainEventStimuli : MonoBehaviour
{
	// Token: 0x0600139A RID: 5018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600139A")]
	[Address(RVA = "0x31F7BC0", Offset = "0x31F61C0", VA = "0x1831F7BC0")]
	private void Start()
	{
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600139B")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public ReparentAndConstrainEventStimuli()
	{
	}

	// Token: 0x0400136F RID: 4975
	[Token(Token = "0x400136F")]
	[FieldOffset(Offset = "0x20")]
	private PositionConstraint _positionConstraint;

	// Token: 0x04001370 RID: 4976
	[Token(Token = "0x4001370")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private EventStimuli _stimuli;

	// Token: 0x04001371 RID: 4977
	[Token(Token = "0x4001371")]
	[FieldOffset(Offset = "0x30")]
	private Transform _reparent;

	// Token: 0x04001372 RID: 4978
	[Token(Token = "0x4001372")]
	[FieldOffset(Offset = "0x38")]
	private Transform _target;
}
