using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x0200096D RID: 2413
	[Token(Token = "0x200096D")]
	public class BreakableObjectStimuli : MonoBehaviour
	{
		// Token: 0x060045EB RID: 17899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045EB")]
		[Address(RVA = "0x366DD80", Offset = "0x366C380", VA = "0x18366DD80")]
		private void OnImpact()
		{
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045EC")]
		[Address(RVA = "0x366DF50", Offset = "0x366C550", VA = "0x18366DF50")]
		private void OnBreak()
		{
		}

		// Token: 0x060045ED RID: 17901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045ED")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public BreakableObjectStimuli()
		{
		}

		// Token: 0x0400487A RID: 18554
		[Token(Token = "0x400487A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("If not set, plays medium noise event on hit")]
		public EventStimuli _onHitStimuli;

		// Token: 0x0400487B RID: 18555
		[Token(Token = "0x400487B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public EventStimuli _onBreakStimuli;
	}
}
