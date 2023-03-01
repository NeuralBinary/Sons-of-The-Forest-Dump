using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.TaskSystem
{
	// Token: 0x02000436 RID: 1078
	[Token(Token = "0x2000436")]
	[Serializable]
	public class ListAnyCondition : ACondition
	{
		// Token: 0x06001BB3 RID: 7091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB3")]
		[Address(RVA = "0x2CE52A0", Offset = "0x2CE42A0", VA = "0x182CE52A0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB4")]
		[Address(RVA = "0x2CE5230", Offset = "0x2CE4230", VA = "0x182CE5230")]
		public void CheckCompletion()
		{
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB5")]
		[Address(RVA = "0x2CE5010", Offset = "0x2CE4010", VA = "0x182CE5010", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB6")]
		[Address(RVA = "0x665E20", Offset = "0x664E20", VA = "0x180665E20")]
		public ListAnyCondition()
		{
		}

		// Token: 0x04001ACD RID: 6861
		[Token(Token = "0x4001ACD")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public ACondition[] _conditions;
	}
}
