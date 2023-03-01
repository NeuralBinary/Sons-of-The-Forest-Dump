using System;
using Il2CppDummyDll;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x02000451 RID: 1105
	[Token(Token = "0x2000451")]
	[Serializable]
	public class StoryCondition : ACondition
	{
		// Token: 0x06001C28 RID: 7208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C28")]
		[Address(RVA = "0x2D04A60", Offset = "0x2D03A60", VA = "0x182D04A60", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C29")]
		[Address(RVA = "0x2D04950", Offset = "0x2D03950", VA = "0x182D04950", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2A")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "10")]
		public virtual void OnStoryProgress(object o)
		{
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2B")]
		[Address(RVA = "0x2CF3FC0", Offset = "0x2CF2FC0", VA = "0x182CF3FC0")]
		public StoryCondition()
		{
		}
	}
}
