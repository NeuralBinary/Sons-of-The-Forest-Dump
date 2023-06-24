using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.TaskSystem
{
	// Token: 0x02000434 RID: 1076
	[Token(Token = "0x2000434")]
	[Serializable]
	public class AirBreathingCondition : ACondition
	{
		// Token: 0x06001C1E RID: 7198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1E")]
		[Address(RVA = "0x32C0870", Offset = "0x32BEE70", VA = "0x1832C0870", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1F")]
		[Address(RVA = "0x32C09B0", Offset = "0x32BEFB0", VA = "0x1832C09B0", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C20")]
		[Address(RVA = "0x32C0A20", Offset = "0x32BF020", VA = "0x1832C0A20")]
		public IEnumerator CheckProximityRoutine()
		{
			return null;
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x000083E8 File Offset: 0x000065E8
		[Token(Token = "0x6001C21")]
		[Address(RVA = "0x32C0AB0", Offset = "0x32BF0B0", VA = "0x1832C0AB0")]
		private bool IsAirBellowThreshold()
		{
			return default(bool);
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C22")]
		[Address(RVA = "0x704F00", Offset = "0x703500", VA = "0x180704F00")]
		public AirBreathingCondition()
		{
		}

		// Token: 0x04001B01 RID: 6913
		[Token(Token = "0x4001B01")]
		[FieldOffset(Offset = "0x20")]
		[Header("AirBreathing")]
		public float _threshold;

		// Token: 0x04001B02 RID: 6914
		[Token(Token = "0x4001B02")]
		[FieldOffset(Offset = "0x28")]
		private Coroutine _routine;
	}
}
