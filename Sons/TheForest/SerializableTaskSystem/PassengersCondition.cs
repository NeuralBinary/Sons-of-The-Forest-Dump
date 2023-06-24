using System;
using Il2CppDummyDll;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x02000444 RID: 1092
	[Token(Token = "0x2000444")]
	[Serializable]
	public class PassengersCondition : ACondition
	{
		// Token: 0x06001C6A RID: 7274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6A")]
		[Address(RVA = "0x32C3110", Offset = "0x32C1710", VA = "0x1832C3110", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6B")]
		[Address(RVA = "0x32C3210", Offset = "0x32C1810", VA = "0x1832C3210", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void OnPassengerFound(object o)
		{
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6D")]
		[Address(RVA = "0x32C1170", Offset = "0x32BF770", VA = "0x1832C1170")]
		public PassengersCondition()
		{
		}
	}
}
