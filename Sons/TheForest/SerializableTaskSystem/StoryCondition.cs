using System;
using Il2CppDummyDll;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x02000443 RID: 1091
	[Token(Token = "0x2000443")]
	[Serializable]
	public class StoryCondition : ACondition
	{
		// Token: 0x06001C66 RID: 7270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C66")]
		[Address(RVA = "0x32C2EC0", Offset = "0x32C14C0", VA = "0x1832C2EC0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C67")]
		[Address(RVA = "0x32C2FC0", Offset = "0x32C15C0", VA = "0x1832C2FC0", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C68")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
		public virtual void OnStoryProgress(object o)
		{
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C69")]
		[Address(RVA = "0x32C1170", Offset = "0x32BF770", VA = "0x1832C1170")]
		public StoryCondition()
		{
		}
	}
}
