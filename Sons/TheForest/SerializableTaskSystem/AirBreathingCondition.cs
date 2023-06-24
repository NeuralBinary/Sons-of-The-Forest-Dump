using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x02000449 RID: 1097
	[Token(Token = "0x2000449")]
	[Serializable]
	public class AirBreathingCondition : ACondition
	{
		// Token: 0x06001C80 RID: 7296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C80")]
		[Address(RVA = "0x32C4210", Offset = "0x32C2810", VA = "0x1832C4210", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C81")]
		[Address(RVA = "0x32C09B0", Offset = "0x32BEFB0", VA = "0x1832C09B0", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C82")]
		[Address(RVA = "0x32C4350", Offset = "0x32C2950", VA = "0x1832C4350")]
		public IEnumerator CheckProximityRoutine()
		{
			return null;
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x00008448 File Offset: 0x00006648
		[Token(Token = "0x6001C83")]
		[Address(RVA = "0x32C43E0", Offset = "0x32C29E0", VA = "0x1832C43E0")]
		private bool IsAirBellowThreshold()
		{
			return default(bool);
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C84")]
		[Address(RVA = "0x32C1170", Offset = "0x32BF770", VA = "0x1832C1170")]
		public AirBreathingCondition()
		{
		}

		// Token: 0x04001B1E RID: 6942
		[Token(Token = "0x4001B1E")]
		[FieldOffset(Offset = "0x20")]
		[Header("AirBreathing")]
		public float _threshold;

		// Token: 0x04001B1F RID: 6943
		[Token(Token = "0x4001B1F")]
		[FieldOffset(Offset = "0x28")]
		private Coroutine _routine;
	}
}
