using System;
using Il2CppDummyDll;

namespace TheForest.TaskSystem
{
	// Token: 0x02000430 RID: 1072
	[Token(Token = "0x2000430")]
	[Serializable]
	public class StoryCondition : ACondition
	{
		// Token: 0x06001C0B RID: 7179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C0B")]
		[Address(RVA = "0x32BF880", Offset = "0x32BDE80", VA = "0x1832BF880", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C0C")]
		[Address(RVA = "0x32BF980", Offset = "0x32BDF80", VA = "0x1832BF980", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C0D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "9")]
		public virtual void OnStoryProgress(object o)
		{
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C0E")]
		[Address(RVA = "0x704F00", Offset = "0x703500", VA = "0x180704F00")]
		public StoryCondition()
		{
		}
	}
}
