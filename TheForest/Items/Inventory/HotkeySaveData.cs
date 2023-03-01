using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TheForest.Items.Inventory
{
	// Token: 0x020004B1 RID: 1201
	[Token(Token = "0x20004B1")]
	[Serializable]
	public class HotkeySaveData
	{
		// Token: 0x06001E98 RID: 7832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E98")]
		[Address(RVA = "0x2D0EEA0", Offset = "0x2D0DEA0", VA = "0x182D0EEA0")]
		public void Sanitize()
		{
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E99")]
		[Address(RVA = "0x2D0ED50", Offset = "0x2D0DD50", VA = "0x182D0ED50")]
		private void SanitizeItemArray(ref List<int> itemIds)
		{
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E9A")]
		[Address(RVA = "0x2D0EED0", Offset = "0x2D0DED0", VA = "0x182D0EED0")]
		public HotkeySaveData()
		{
		}

		// Token: 0x04001C81 RID: 7297
		[Token(Token = "0x4001C81")]
		[FieldOffset(Offset = "0x10")]
		public string Version;

		// Token: 0x04001C82 RID: 7298
		[Token(Token = "0x4001C82")]
		[FieldOffset(Offset = "0x18")]
		public List<int> RightHandItemIds;

		// Token: 0x04001C83 RID: 7299
		[Token(Token = "0x4001C83")]
		[FieldOffset(Offset = "0x20")]
		public List<int> LeftHandItemIds;
	}
}
