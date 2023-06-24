using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.TaskSystem
{
	// Token: 0x02000428 RID: 1064
	[Token(Token = "0x2000428")]
	[Serializable]
	public class ListAnyCondition : ACondition
	{
		// Token: 0x06001BF1 RID: 7153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF1")]
		[Address(RVA = "0x32BEBB0", Offset = "0x32BD1B0", VA = "0x1832BEBB0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF2")]
		[Address(RVA = "0x32BEDD0", Offset = "0x32BD3D0", VA = "0x1832BEDD0")]
		public void CheckCompletion()
		{
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF3")]
		[Address(RVA = "0x32BEAE0", Offset = "0x32BD0E0", VA = "0x1832BEAE0", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF4")]
		[Address(RVA = "0x704F00", Offset = "0x703500", VA = "0x180704F00")]
		public ListAnyCondition()
		{
		}

		// Token: 0x04001AF1 RID: 6897
		[Token(Token = "0x4001AF1")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public ACondition[] _conditions;
	}
}
