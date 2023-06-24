using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	[Serializable]
	public class EnemyArmourOptionGui : CustomMenuGameSettingGui
	{
		// Token: 0x06000070 RID: 112 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x303B0C0", Offset = "0x30396C0", VA = "0x18303B0C0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000014")]
		public override string SettingKey
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x303B0F0", Offset = "0x30396F0", VA = "0x18303B0F0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x303B120", Offset = "0x3039720", VA = "0x18303B120", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x303B180", Offset = "0x3039780", VA = "0x18303B180", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public EnemyArmourOptionGui()
		{
		}

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		public const string LabelText = "Enemy Armour";
	}
}
