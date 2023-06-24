using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TheForest.Items.Inventory
{
	// Token: 0x020004A7 RID: 1191
	[Token(Token = "0x20004A7")]
	[Serializable]
	public class HotkeySaveData
	{
		// Token: 0x06001EEC RID: 7916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EEC")]
		[Address(RVA = "0x32F9500", Offset = "0x32F7B00", VA = "0x1832F9500")]
		public void Sanitize()
		{
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EED")]
		[Address(RVA = "0x32F9530", Offset = "0x32F7B30", VA = "0x1832F9530")]
		private void SanitizeItemArray(ref List<int> itemIds)
		{
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EEE")]
		[Address(RVA = "0x32F96C0", Offset = "0x32F7CC0", VA = "0x1832F96C0")]
		public HotkeySaveData()
		{
		}

		// Token: 0x04001CB7 RID: 7351
		[Token(Token = "0x4001CB7")]
		[FieldOffset(Offset = "0x10")]
		public string Version;

		// Token: 0x04001CB8 RID: 7352
		[Token(Token = "0x4001CB8")]
		[FieldOffset(Offset = "0x18")]
		public List<int> RightHandItemIds;

		// Token: 0x04001CB9 RID: 7353
		[Token(Token = "0x4001CB9")]
		[FieldOffset(Offset = "0x20")]
		public List<int> LeftHandItemIds;
	}
}
