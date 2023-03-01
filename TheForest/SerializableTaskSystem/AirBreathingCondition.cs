using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x02000457 RID: 1111
	[Token(Token = "0x2000457")]
	[Serializable]
	public class AirBreathingCondition : ACondition
	{
		// Token: 0x06001C42 RID: 7234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C42")]
		[Address(RVA = "0x2CF3ED0", Offset = "0x2CF2ED0", VA = "0x182CF3ED0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C43")]
		[Address(RVA = "0x2CF3EA0", Offset = "0x2CF2EA0", VA = "0x182CF3EA0", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C44")]
		[Address(RVA = "0x2CF3E30", Offset = "0x2CF2E30", VA = "0x182CF3E30")]
		public IEnumerator CheckProximityRoutine()
		{
			return null;
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x000081C0 File Offset: 0x000063C0
		[Token(Token = "0x6001C45")]
		[Address(RVA = "0x2CF3F50", Offset = "0x2CF2F50", VA = "0x182CF3F50")]
		private bool IsAirBellowThreshold()
		{
			return default(bool);
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C46")]
		[Address(RVA = "0x2CF3FC0", Offset = "0x2CF2FC0", VA = "0x182CF3FC0")]
		public AirBreathingCondition()
		{
		}

		// Token: 0x04001AFA RID: 6906
		[Token(Token = "0x4001AFA")]
		[FieldOffset(Offset = "0x20")]
		[Header("AirBreathing")]
		public float _threshold;

		// Token: 0x04001AFB RID: 6907
		[Token(Token = "0x4001AFB")]
		[FieldOffset(Offset = "0x28")]
		private Coroutine _routine;
	}
}
