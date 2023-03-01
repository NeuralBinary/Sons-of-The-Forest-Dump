using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using UnityEngine;
using UnityEngine.Animations;

// Token: 0x020002FD RID: 765
[Token(Token = "0x20002FD")]
public class ReparentAndConstrainEventStimuli : MonoBehaviour
{
	// Token: 0x0600136E RID: 4974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600136E")]
	[Address(RVA = "0x2C6A140", Offset = "0x2C69140", VA = "0x182C6A140")]
	private void Start()
	{
	}

	// Token: 0x0600136F RID: 4975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600136F")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public ReparentAndConstrainEventStimuli()
	{
	}

	// Token: 0x04001351 RID: 4945
	[Token(Token = "0x4001351")]
	[FieldOffset(Offset = "0x20")]
	private PositionConstraint _positionConstraint;

	// Token: 0x04001352 RID: 4946
	[Token(Token = "0x4001352")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private EventStimuli _stimuli;

	// Token: 0x04001353 RID: 4947
	[Token(Token = "0x4001353")]
	[FieldOffset(Offset = "0x30")]
	private Transform _reparent;

	// Token: 0x04001354 RID: 4948
	[Token(Token = "0x4001354")]
	[FieldOffset(Offset = "0x38")]
	private Transform _target;
}
