using System;
using Il2CppDummyDll;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x0200044F RID: 1103
	[Token(Token = "0x200044F")]
	[Serializable]
	public class EnemyInSightCondition : ACondition
	{
		// Token: 0x06001C20 RID: 7200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C20")]
		[Address(RVA = "0x2CF4740", Offset = "0x2CF3740", VA = "0x182CF4740", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C21")]
		[Address(RVA = "0x2CF4630", Offset = "0x2CF3630", VA = "0x182CF4630", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C22")]
		[Address(RVA = "0x2CF4840", Offset = "0x2CF3840", VA = "0x182CF4840")]
		public void OnEnemyInSight(object enemy)
		{
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C23")]
		[Address(RVA = "0x2CF3FC0", Offset = "0x2CF2FC0", VA = "0x182CF3FC0")]
		public EnemyInSightCondition()
		{
		}
	}
}
