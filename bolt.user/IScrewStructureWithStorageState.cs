using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000030 RID: 48
[Token(Token = "0x2000030")]
public interface IScrewStructureWithStorageState : IScrewStructureState, IState, IDisposable
{
	// Token: 0x17000067 RID: 103
	// (get) Token: 0x060000FE RID: 254
	[Token(Token = "0x17000067")]
	NetworkArray_Objects<StoredItemsData> StorageSlots { [Token(Token = "0x60000FE")] get; }

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x060000FF RID: 255
	[Token(Token = "0x17000068")]
	NetworkArray_Integer SlotAvailability { [Token(Token = "0x60000FF")] get; }
}
