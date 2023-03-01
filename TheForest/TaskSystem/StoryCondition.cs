using System;
using Il2CppDummyDll;

namespace TheForest.TaskSystem
{
	// Token: 0x0200043E RID: 1086
	[Token(Token = "0x200043E")]
	[Serializable]
	public class StoryCondition : ACondition
	{
		// Token: 0x06001BCD RID: 7117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BCD")]
		[Address(RVA = "0x2CED730", Offset = "0x2CEC730", VA = "0x182CED730", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BCE")]
		[Address(RVA = "0x2CED620", Offset = "0x2CEC620", VA = "0x182CED620", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BCF")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "9")]
		public virtual void OnStoryProgress(object o)
		{
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD0")]
		[Address(RVA = "0x665E20", Offset = "0x664E20", VA = "0x180665E20")]
		public StoryCondition()
		{
		}
	}
}
