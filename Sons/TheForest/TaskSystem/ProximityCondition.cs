using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.TaskSystem
{
	// Token: 0x02000432 RID: 1074
	[Token(Token = "0x2000432")]
	[Serializable]
	public class ProximityCondition : ACondition
	{
		// Token: 0x06001C13 RID: 7187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C13")]
		[Address(RVA = "0x32BFD20", Offset = "0x32BE320", VA = "0x1832BFD20", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C14")]
		[Address(RVA = "0x32C0100", Offset = "0x32BE700", VA = "0x1832C0100", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C15")]
		[Address(RVA = "0x32C0170", Offset = "0x32BE770", VA = "0x1832C0170")]
		public IEnumerator CheckProximityRoutine()
		{
			return null;
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x000083B8 File Offset: 0x000065B8
		[Token(Token = "0x6001C16")]
		[Address(RVA = "0x32C0200", Offset = "0x32BE800", VA = "0x1832C0200")]
		private bool IsWithinRangeOfTarget()
		{
			return default(bool);
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C17")]
		[Address(RVA = "0x704F00", Offset = "0x703500", VA = "0x180704F00")]
		public ProximityCondition()
		{
		}

		// Token: 0x04001AF7 RID: 6903
		[Token(Token = "0x4001AF7")]
		[FieldOffset(Offset = "0x20")]
		[Header("Proximity")]
		public string _objectTag;

		// Token: 0x04001AF8 RID: 6904
		[Token(Token = "0x4001AF8")]
		[FieldOffset(Offset = "0x28")]
		public bool _isTag;

		// Token: 0x04001AF9 RID: 6905
		[Token(Token = "0x4001AF9")]
		[FieldOffset(Offset = "0x2C")]
		public float _distance;

		// Token: 0x04001AFA RID: 6906
		[Token(Token = "0x4001AFA")]
		[FieldOffset(Offset = "0x30")]
		public bool _use2dDistance;

		// Token: 0x04001AFB RID: 6907
		[Token(Token = "0x4001AFB")]
		[FieldOffset(Offset = "0x31")]
		public bool _inCaveOnly;

		// Token: 0x04001AFC RID: 6908
		[Token(Token = "0x4001AFC")]
		[FieldOffset(Offset = "0x38")]
		private Transform _targetObject;

		// Token: 0x04001AFD RID: 6909
		[Token(Token = "0x4001AFD")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine _routine;
	}
}
