using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[Serializable]
	public class AntiAliasOptionGui : CustomMenuOptionGui
	{
		// Token: 0x06000014 RID: 20 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x3039360", Offset = "0x3037960", VA = "0x183039360", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x3039390", Offset = "0x3037990", VA = "0x183039390", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000016 RID: 22 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000003")]
		public override string SettingKey
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x30393E0", Offset = "0x30379E0", VA = "0x1830393E0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x3039410", Offset = "0x3037A10", VA = "0x183039410", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x3039460", Offset = "0x3037A60", VA = "0x183039460")]
		public void SetValueOff()
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public AntiAliasOptionGui()
		{
		}

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		private const string LabelText = "Anti Aliasing";
	}
}
