using System;
using Il2CppDummyDll;

namespace TheForest.TaskSystem
{
	// Token: 0x0200042B RID: 1067
	[Token(Token = "0x200042B")]
	[Serializable]
	public class ItemCondition : ACondition
	{
		// Token: 0x06001BFA RID: 7162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFB")]
		[Address(RVA = "0x32BF090", Offset = "0x32BD690", VA = "0x1832BF090")]
		public void OnItemAdded(object o)
		{
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFC")]
		[Address(RVA = "0x32BF220", Offset = "0x32BD820", VA = "0x1832BF220")]
		public void OnItemAdded(int itemId)
		{
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFD")]
		[Address(RVA = "0x704F00", Offset = "0x703500", VA = "0x180704F00")]
		public ItemCondition()
		{
		}

		// Token: 0x04001AF4 RID: 6900
		[Token(Token = "0x4001AF4")]
		[FieldOffset(Offset = "0x20")]
		public ItemIdList[] _items;
	}
}
