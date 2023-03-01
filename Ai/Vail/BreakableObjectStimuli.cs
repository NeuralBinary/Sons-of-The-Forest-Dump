using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020008EC RID: 2284
	[Token(Token = "0x20008EC")]
	public class BreakableObjectStimuli : MonoBehaviour
	{
		// Token: 0x06003E17 RID: 15895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E17")]
		[Address(RVA = "0x2F0E360", Offset = "0x2F0D360", VA = "0x182F0E360")]
		private void OnImpact()
		{
		}

		// Token: 0x06003E18 RID: 15896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E18")]
		[Address(RVA = "0x2F0E280", Offset = "0x2F0D280", VA = "0x182F0E280")]
		private void OnBreak()
		{
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E19")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public BreakableObjectStimuli()
		{
		}

		// Token: 0x040041F3 RID: 16883
		[Token(Token = "0x40041F3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("If not set, plays medium noise event on hit")]
		public EventStimuli _onHitStimuli;

		// Token: 0x040041F4 RID: 16884
		[Token(Token = "0x40041F4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public EventStimuli _onBreakStimuli;
	}
}
