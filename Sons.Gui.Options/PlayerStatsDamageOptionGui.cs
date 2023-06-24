using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	[Serializable]
	public class PlayerStatsDamageOptionGui : CustomMenuGameSettingGui
	{
		// Token: 0x06000087 RID: 135 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x303B530", Offset = "0x3039B30", VA = "0x18303B530", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000019")]
		public override string SettingKey
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x303B560", Offset = "0x3039B60", VA = "0x18303B560", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x303B590", Offset = "0x3039B90", VA = "0x18303B590", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x303B5E0", Offset = "0x3039BE0", VA = "0x18303B5E0", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public PlayerStatsDamageOptionGui()
		{
		}

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		private const string LabelText = "Survival Damage";
	}
}
