using System;
using Il2CppDummyDll;

namespace TheForest.TaskSystem
{
	// Token: 0x02000427 RID: 1063
	[Token(Token = "0x2000427")]
	[Serializable]
	public class ListAllCondition : ACondition
	{
		// Token: 0x06001BED RID: 7149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BED")]
		[Address(RVA = "0x32BE850", Offset = "0x32BCE50", VA = "0x1832BE850", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BEE")]
		[Address(RVA = "0x32BEA70", Offset = "0x32BD070", VA = "0x1832BEA70")]
		public void CheckCompletion()
		{
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BEF")]
		[Address(RVA = "0x32BEAE0", Offset = "0x32BD0E0", VA = "0x1832BEAE0", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF0")]
		[Address(RVA = "0x704F00", Offset = "0x703500", VA = "0x180704F00")]
		public ListAllCondition()
		{
		}

		// Token: 0x04001AF0 RID: 6896
		[Token(Token = "0x4001AF0")]
		[FieldOffset(Offset = "0x20")]
		public ACondition[] _conditions;
	}
}
