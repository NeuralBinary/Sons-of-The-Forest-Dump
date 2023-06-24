using System;
using Il2CppDummyDll;
using Sons.Items.Core;

// Token: 0x020000FC RID: 252
[Token(Token = "0x20000FC")]
[Serializable]
public class ItemGroupEvent
{
	// Token: 0x060007AD RID: 1965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007AD")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public ItemGroupEvent()
	{
	}

	// Token: 0x04000625 RID: 1573
	[Token(Token = "0x4000625")]
	[FieldOffset(Offset = "0x10")]
	[ItemIdPicker(Types.Equippable, false)]
	public int[] _itemIds;

	// Token: 0x04000626 RID: 1574
	[Token(Token = "0x4000626")]
	[FieldOffset(Offset = "0x18")]
	public string eventPath;
}
