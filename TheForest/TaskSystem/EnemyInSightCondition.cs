using System;
using Il2CppDummyDll;

namespace TheForest.TaskSystem
{
	// Token: 0x0200043C RID: 1084
	[Token(Token = "0x200043C")]
	[Serializable]
	public class EnemyInSightCondition : ACondition
	{
		// Token: 0x06001BC5 RID: 7109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC5")]
		[Address(RVA = "0x2CE09E0", Offset = "0x2CDF9E0", VA = "0x182CE09E0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC6")]
		[Address(RVA = "0x2CE08C0", Offset = "0x2CDF8C0", VA = "0x182CE08C0", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC7")]
		[Address(RVA = "0x2CE0AE0", Offset = "0x2CDFAE0", VA = "0x182CE0AE0")]
		public void OnEnemyInSight(object enemy)
		{
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC8")]
		[Address(RVA = "0x665E20", Offset = "0x664E20", VA = "0x180665E20")]
		public EnemyInSightCondition()
		{
		}
	}
}
