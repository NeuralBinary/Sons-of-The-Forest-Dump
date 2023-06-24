using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x02000445 RID: 1093
	[Token(Token = "0x2000445")]
	[Serializable]
	public class ProximityCondition : ACondition
	{
		// Token: 0x06001C6E RID: 7278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6E")]
		[Address(RVA = "0x32C3360", Offset = "0x32C1960", VA = "0x1832C3360", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6F")]
		[Address(RVA = "0x32C0100", Offset = "0x32BE700", VA = "0x1832C0100", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C70")]
		[Address(RVA = "0x32C3740", Offset = "0x32C1D40", VA = "0x1832C3740")]
		public IEnumerator CheckProximityRoutine()
		{
			return null;
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x00008418 File Offset: 0x00006618
		[Token(Token = "0x6001C71")]
		[Address(RVA = "0x32C37D0", Offset = "0x32C1DD0", VA = "0x1832C37D0")]
		private bool IsWithinRangeOfTarget()
		{
			return default(bool);
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C72")]
		[Address(RVA = "0x32C1170", Offset = "0x32BF770", VA = "0x1832C1170")]
		public ProximityCondition()
		{
		}

		// Token: 0x04001B12 RID: 6930
		[Token(Token = "0x4001B12")]
		[FieldOffset(Offset = "0x20")]
		[Header("Proximity")]
		public string _objectTag;

		// Token: 0x04001B13 RID: 6931
		[Token(Token = "0x4001B13")]
		[FieldOffset(Offset = "0x28")]
		public bool _isTag;

		// Token: 0x04001B14 RID: 6932
		[Token(Token = "0x4001B14")]
		[FieldOffset(Offset = "0x2C")]
		public float _distance;

		// Token: 0x04001B15 RID: 6933
		[Token(Token = "0x4001B15")]
		[FieldOffset(Offset = "0x30")]
		public bool _use2dDistance;

		// Token: 0x04001B16 RID: 6934
		[Token(Token = "0x4001B16")]
		[FieldOffset(Offset = "0x31")]
		public bool _inCaveOnly;

		// Token: 0x04001B17 RID: 6935
		[Token(Token = "0x4001B17")]
		[FieldOffset(Offset = "0x38")]
		private Transform _targetObject;

		// Token: 0x04001B18 RID: 6936
		[Token(Token = "0x4001B18")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine _routine;
	}
}
