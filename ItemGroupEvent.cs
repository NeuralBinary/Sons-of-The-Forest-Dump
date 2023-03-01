using System;
using Il2CppDummyDll;
using Sons.Items.Core;

// Token: 0x020000FF RID: 255
[Token(Token = "0x20000FF")]
[Serializable]
public class ItemGroupEvent
{
	// Token: 0x06000765 RID: 1893 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000765")]
	[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
	public ItemGroupEvent()
	{
	}

	// Token: 0x04000608 RID: 1544
	[Token(Token = "0x4000608")]
	[FieldOffset(Offset = "0x10")]
	[ItemIdPicker(1, false)]
	public int[] _itemIds;

	// Token: 0x04000609 RID: 1545
	[Token(Token = "0x4000609")]
	[FieldOffset(Offset = "0x18")]
	public string eventPath;
}
