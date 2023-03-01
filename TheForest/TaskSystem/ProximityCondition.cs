using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.TaskSystem
{
	// Token: 0x02000440 RID: 1088
	[Token(Token = "0x2000440")]
	[Serializable]
	public class ProximityCondition : ACondition
	{
		// Token: 0x06001BD5 RID: 7125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD5")]
		[Address(RVA = "0x2CE9FA0", Offset = "0x2CE8FA0", VA = "0x182CE9FA0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD6")]
		[Address(RVA = "0x2CE9F70", Offset = "0x2CE8F70", VA = "0x182CE9F70", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD7")]
		[Address(RVA = "0x2CE9F00", Offset = "0x2CE8F00", VA = "0x182CE9F00")]
		public IEnumerator CheckProximityRoutine()
		{
			return null;
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x00008130 File Offset: 0x00006330
		[Token(Token = "0x6001BD8")]
		[Address(RVA = "0x2CEA140", Offset = "0x2CE9140", VA = "0x182CEA140")]
		private bool IsWithinRangeOfTarget()
		{
			return default(bool);
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD9")]
		[Address(RVA = "0x665E20", Offset = "0x664E20", VA = "0x180665E20")]
		public ProximityCondition()
		{
		}

		// Token: 0x04001AD3 RID: 6867
		[Token(Token = "0x4001AD3")]
		[FieldOffset(Offset = "0x20")]
		[Header("Proximity")]
		public string _objectTag;

		// Token: 0x04001AD4 RID: 6868
		[Token(Token = "0x4001AD4")]
		[FieldOffset(Offset = "0x28")]
		public bool _isTag;

		// Token: 0x04001AD5 RID: 6869
		[Token(Token = "0x4001AD5")]
		[FieldOffset(Offset = "0x2C")]
		public float _distance;

		// Token: 0x04001AD6 RID: 6870
		[Token(Token = "0x4001AD6")]
		[FieldOffset(Offset = "0x30")]
		public bool _use2dDistance;

		// Token: 0x04001AD7 RID: 6871
		[Token(Token = "0x4001AD7")]
		[FieldOffset(Offset = "0x31")]
		public bool _inCaveOnly;

		// Token: 0x04001AD8 RID: 6872
		[Token(Token = "0x4001AD8")]
		[FieldOffset(Offset = "0x38")]
		private Transform _targetObject;

		// Token: 0x04001AD9 RID: 6873
		[Token(Token = "0x4001AD9")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine _routine;
	}
}
