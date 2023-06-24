using System;
using Assemblies.Sons.Items.Core;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
[Serializable]
public class ItemUiData
{
	// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000004")]
	[Address(RVA = "0xA53180", Offset = "0xA51780", VA = "0x180A53180")]
	public void SetHasDescription(bool value)
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000005 RID: 5 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x17000001")]
	public bool HasDescription
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0xA53170", Offset = "0xA51770", VA = "0x180A53170")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000006 RID: 6 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x30ACFE0", Offset = "0x30AB5E0", VA = "0x1830ACFE0")]
	public string GetTitlePluralTranslationKey()
	{
		return null;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x30AD0A0", Offset = "0x30AB6A0", VA = "0x1830AD0A0")]
	public string GetDescriptionTranslationKey()
	{
		return null;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
	public string GetTranslationKey()
	{
		return null;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x30AD160", Offset = "0x30AB760", VA = "0x1830AD160")]
	public string GetTitleLocalized()
	{
		return null;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x30AD350", Offset = "0x30AB950", VA = "0x1830AD350")]
	public string GetTitlePluralLocalized()
	{
		return null;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x30AD540", Offset = "0x30ABB40", VA = "0x1830AD540")]
	public string GetDescription()
	{
		return null;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x30AD820", Offset = "0x30ABE20", VA = "0x1830AD820")]
	public ItemUiData()
	{
	}

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	private const int labelWidth = 175;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	private const string PluralTranslationKeySuffix = "_PLURAL";

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	private const string DescriptionTranslationKeySuffix = "_DESC";

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	private const string ItemsTableReference = "Items";

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x10")]
	[ItemIdPicker(true)]
	public int _itemId;

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x18")]
	public Texture _icon;

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x20")]
	public Texture _outlineIcon;

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public string _title;

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public string _titlePlural;

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x38")]
	public string _description;

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public ItemUiData.AllowedDifficulties _descriptionShowFor;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("_titleTranslationKey")]
	public string _translationKey;

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x50")]
	public ItemUiData.LeftClickCommands _leftClick;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x54")]
	public ItemUiData.RightClickCommands _rightClick;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x58")]
	public ItemUiData.AmountDisplay _amountDisplay;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x60")]
	public string _amountFormat;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x68")]
	public bool _showVolumeRecipeNameInDescription;

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x69")]
	public bool _showGotItem;

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x6A")]
	public bool _showCollectedItem;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x6B")]
	public bool _showCantCarryMoreItem;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x6C")]
	public bool _hideItemNameOnCollection;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x6D")]
	[SerializeField]
	public bool _applyCustomActionText;

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x70")]
	public string _leftActionCustomText;

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x78")]
	public string _rightActionCustomText;

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x80")]
	public ItemTypeUIColors _uiColors;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x88")]
	private string _cachedTitlePluralTranslationKey;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x90")]
	private string _cachedDescriptionTranslationKey;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private bool _hasDescription;

	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public enum LeftClickCommands
	{
		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		none,
		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		equip,
		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		play,
		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		drink,
		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		read,
		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		take,
		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		Charge_Flashlight,
		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		wear,
		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		eat,
		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		select,
		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		use
	}

	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public enum RightClickCommands
	{
		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		None,
		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		Combine,
		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		Remove,
		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		Unequip,
		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		Drink,
		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		Open,
		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		Eat
	}

	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public enum AmountDisplay
	{
		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		None,
		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		Amount
	}

	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public enum BackgroundSize
	{
		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		Small,
		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		Medium,
		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		Large
	}

	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[Flags]
	public enum AllowedDifficulties
	{
		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		All = -1,
		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		None = 0,
		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		Peaceful = 1,
		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		Normal = 2,
		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		Hard = 4,
		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		HardSurvival = 8
	}
}
