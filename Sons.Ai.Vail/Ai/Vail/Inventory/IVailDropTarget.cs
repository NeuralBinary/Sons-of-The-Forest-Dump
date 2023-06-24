using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.Inventory
{
	// Token: 0x0200021C RID: 540
	[Token(Token = "0x200021C")]
	public interface IVailDropTarget
	{
		// Token: 0x06000F61 RID: 3937
		[Token(Token = "0x6000F61")]
		string GetItemType();

		// Token: 0x06000F62 RID: 3938
		[Token(Token = "0x6000F62")]
		int TryAddItem(int itemId, int itemCount);

		// Token: 0x06000F63 RID: 3939
		[Token(Token = "0x6000F63")]
		bool IsFull();

		// Token: 0x06000F64 RID: 3940 RVA: 0x000086A0 File Offset: 0x000068A0
		[Token(Token = "0x6000F64")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "3")]
		bool IsHolder()
		{
			return default(bool);
		}
	}
}
