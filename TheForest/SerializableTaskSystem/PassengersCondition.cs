using System;
using Il2CppDummyDll;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x02000452 RID: 1106
	[Token(Token = "0x2000452")]
	[Serializable]
	public class PassengersCondition : ACondition
	{
		// Token: 0x06001C2C RID: 7212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2C")]
		[Address(RVA = "0x2CF5A00", Offset = "0x2CF4A00", VA = "0x182CF5A00", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2D")]
		[Address(RVA = "0x2CF58F0", Offset = "0x2CF48F0", VA = "0x182CF58F0", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2E")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void OnPassengerFound(object o)
		{
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2F")]
		[Address(RVA = "0x2CF3FC0", Offset = "0x2CF2FC0", VA = "0x182CF3FC0")]
		public PassengersCondition()
		{
		}
	}
}
