using System;
using Il2CppDummyDll;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x02000447 RID: 1095
	[Token(Token = "0x2000447")]
	[Serializable]
	public class StarLocationCondition : ACondition
	{
		// Token: 0x06001C79 RID: 7289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C79")]
		[Address(RVA = "0x32C3F10", Offset = "0x32C2510", VA = "0x1832C3F10", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7A")]
		[Address(RVA = "0x32C4010", Offset = "0x32C2610", VA = "0x1832C4010", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7B")]
		[Address(RVA = "0x32C4160", Offset = "0x32C2760", VA = "0x1832C4160", Slot = "10")]
		public virtual void OnStarLocationVisited(object o)
		{
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7C")]
		[Address(RVA = "0x32C1170", Offset = "0x32BF770", VA = "0x1832C1170")]
		public StarLocationCondition()
		{
		}

		// Token: 0x04001B1C RID: 6940
		[Token(Token = "0x4001B1C")]
		[FieldOffset(Offset = "0x20")]
		public int _starNumber;
	}
}
