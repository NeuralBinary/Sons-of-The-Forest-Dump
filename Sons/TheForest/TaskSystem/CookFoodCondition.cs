using System;
using Il2CppDummyDll;

namespace TheForest.TaskSystem
{
	// Token: 0x0200042D RID: 1069
	[Token(Token = "0x200042D")]
	[Serializable]
	public class CookFoodCondition : ACondition
	{
		// Token: 0x06001BFF RID: 7167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C00")]
		[Address(RVA = "0xFC5D60", Offset = "0xFC4360", VA = "0x180FC5D60", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C01")]
		[Address(RVA = "0x32BF360", Offset = "0x32BD960", VA = "0x1832BF360")]
		public void OnFoodCooked()
		{
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C02")]
		[Address(RVA = "0x704F00", Offset = "0x703500", VA = "0x180704F00")]
		public CookFoodCondition()
		{
		}
	}
}
