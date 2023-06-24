using System;
using Il2CppDummyDll;

namespace TheForest.TaskSystem
{
	// Token: 0x0200042E RID: 1070
	[Token(Token = "0x200042E")]
	[Serializable]
	public class EnemyInSightCondition : ACondition
	{
		// Token: 0x06001C03 RID: 7171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C03")]
		[Address(RVA = "0x32BF3A0", Offset = "0x32BD9A0", VA = "0x1832BF3A0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C04")]
		[Address(RVA = "0x32BF4A0", Offset = "0x32BDAA0", VA = "0x1832BF4A0", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C05")]
		[Address(RVA = "0x32BF5F0", Offset = "0x32BDBF0", VA = "0x1832BF5F0")]
		public void OnEnemyInSight(object enemy)
		{
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C06")]
		[Address(RVA = "0x704F00", Offset = "0x703500", VA = "0x180704F00")]
		public EnemyInSightCondition()
		{
		}
	}
}
