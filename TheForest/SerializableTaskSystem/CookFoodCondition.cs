using System;
using Il2CppDummyDll;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x0200044E RID: 1102
	[Token(Token = "0x200044E")]
	[Serializable]
	public class CookFoodCondition : ACondition
	{
		// Token: 0x06001C1C RID: 7196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1C")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1D")]
		[Address(RVA = "0x2CF4380", Offset = "0x2CF3380", VA = "0x182CF4380", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1E")]
		[Address(RVA = "0x2CF4390", Offset = "0x2CF3390", VA = "0x182CF4390")]
		public void OnFoodCooked()
		{
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1F")]
		[Address(RVA = "0x2CF3FC0", Offset = "0x2CF2FC0", VA = "0x182CF3FC0")]
		public CookFoodCondition()
		{
		}
	}
}
