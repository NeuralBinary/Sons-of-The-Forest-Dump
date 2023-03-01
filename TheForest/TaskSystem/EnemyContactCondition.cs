using System;
using Il2CppDummyDll;

namespace TheForest.TaskSystem
{
	// Token: 0x0200043D RID: 1085
	[Token(Token = "0x200043D")]
	[Serializable]
	public class EnemyContactCondition : ACondition
	{
		// Token: 0x06001BC9 RID: 7113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC9")]
		[Address(RVA = "0x2CE07C0", Offset = "0x2CDF7C0", VA = "0x182CE07C0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BCA")]
		[Address(RVA = "0x2CE06A0", Offset = "0x2CDF6A0", VA = "0x182CE06A0", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BCB")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void OnEnemyContact(object o)
		{
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BCC")]
		[Address(RVA = "0x665E20", Offset = "0x664E20", VA = "0x180665E20")]
		public EnemyContactCondition()
		{
		}
	}
}
