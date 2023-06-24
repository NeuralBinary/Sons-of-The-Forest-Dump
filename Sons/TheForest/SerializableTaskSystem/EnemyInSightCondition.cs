using System;
using Il2CppDummyDll;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x02000441 RID: 1089
	[Token(Token = "0x2000441")]
	[Serializable]
	public class EnemyInSightCondition : ACondition
	{
		// Token: 0x06001C5E RID: 7262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C5E")]
		[Address(RVA = "0x32C29E0", Offset = "0x32C0FE0", VA = "0x1832C29E0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C5F")]
		[Address(RVA = "0x32C2AE0", Offset = "0x32C10E0", VA = "0x1832C2AE0", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C60")]
		[Address(RVA = "0x32C2C30", Offset = "0x32C1230", VA = "0x1832C2C30")]
		public void OnEnemyInSight(object enemy)
		{
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C61")]
		[Address(RVA = "0x32C1170", Offset = "0x32BF770", VA = "0x1832C1170")]
		public EnemyInSightCondition()
		{
		}
	}
}
