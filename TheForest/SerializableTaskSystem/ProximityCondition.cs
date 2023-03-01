using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x02000453 RID: 1107
	[Token(Token = "0x2000453")]
	[Serializable]
	public class ProximityCondition : ACondition
	{
		// Token: 0x06001C30 RID: 7216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C30")]
		[Address(RVA = "0x2D03950", Offset = "0x2D02950", VA = "0x182D03950", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C31")]
		[Address(RVA = "0x2D03920", Offset = "0x2D02920", VA = "0x182D03920", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C32")]
		[Address(RVA = "0x2D038B0", Offset = "0x2D028B0", VA = "0x182D038B0")]
		public IEnumerator CheckProximityRoutine()
		{
			return null;
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00008190 File Offset: 0x00006390
		[Token(Token = "0x6001C33")]
		[Address(RVA = "0x2D03AF0", Offset = "0x2D02AF0", VA = "0x182D03AF0")]
		private bool IsWithinRangeOfTarget()
		{
			return default(bool);
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C34")]
		[Address(RVA = "0x2CF3FC0", Offset = "0x2CF2FC0", VA = "0x182CF3FC0")]
		public ProximityCondition()
		{
		}

		// Token: 0x04001AEE RID: 6894
		[Token(Token = "0x4001AEE")]
		[FieldOffset(Offset = "0x20")]
		[Header("Proximity")]
		public string _objectTag;

		// Token: 0x04001AEF RID: 6895
		[Token(Token = "0x4001AEF")]
		[FieldOffset(Offset = "0x28")]
		public bool _isTag;

		// Token: 0x04001AF0 RID: 6896
		[Token(Token = "0x4001AF0")]
		[FieldOffset(Offset = "0x2C")]
		public float _distance;

		// Token: 0x04001AF1 RID: 6897
		[Token(Token = "0x4001AF1")]
		[FieldOffset(Offset = "0x30")]
		public bool _use2dDistance;

		// Token: 0x04001AF2 RID: 6898
		[Token(Token = "0x4001AF2")]
		[FieldOffset(Offset = "0x31")]
		public bool _inCaveOnly;

		// Token: 0x04001AF3 RID: 6899
		[Token(Token = "0x4001AF3")]
		[FieldOffset(Offset = "0x38")]
		private Transform _targetObject;

		// Token: 0x04001AF4 RID: 6900
		[Token(Token = "0x4001AF4")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine _routine;
	}
}
