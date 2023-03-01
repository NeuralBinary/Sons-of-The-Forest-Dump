using System;
using Il2CppDummyDll;

namespace TheForest.TaskSystem
{
	// Token: 0x02000439 RID: 1081
	[Token(Token = "0x2000439")]
	[Serializable]
	public class ItemCondition : ACondition
	{
		// Token: 0x06001BBC RID: 7100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BBC")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BBD")]
		[Address(RVA = "0x2CE2470", Offset = "0x2CE1470", VA = "0x182CE2470")]
		public void OnItemAdded(object o)
		{
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BBE")]
		[Address(RVA = "0x2CE2330", Offset = "0x2CE1330", VA = "0x182CE2330")]
		public void OnItemAdded(int itemId)
		{
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BBF")]
		[Address(RVA = "0x665E20", Offset = "0x664E20", VA = "0x180665E20")]
		public ItemCondition()
		{
		}

		// Token: 0x04001AD0 RID: 6864
		[Token(Token = "0x4001AD0")]
		[FieldOffset(Offset = "0x20")]
		public ItemIdList[] _items;
	}
}
