using System;
using Il2CppDummyDll;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x02000450 RID: 1104
	[Token(Token = "0x2000450")]
	[Serializable]
	public class EnemyContactCondition : ACondition
	{
		// Token: 0x06001C24 RID: 7204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C24")]
		[Address(RVA = "0x2CF4530", Offset = "0x2CF3530", VA = "0x182CF4530", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C25")]
		[Address(RVA = "0x2CF4420", Offset = "0x2CF3420", VA = "0x182CF4420", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C26")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void OnEnemyContact(object o)
		{
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C27")]
		[Address(RVA = "0x2CF3FC0", Offset = "0x2CF2FC0", VA = "0x182CF3FC0")]
		public EnemyContactCondition()
		{
		}
	}
}
