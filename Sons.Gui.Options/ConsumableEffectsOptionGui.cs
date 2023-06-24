using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	[Serializable]
	public class ConsumableEffectsOptionGui : CustomMenuGameSettingGui
	{
		// Token: 0x06000061 RID: 97 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x303ADA0", Offset = "0x30393A0", VA = "0x18303ADA0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000011")]
		public override string SettingKey
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x303ADD0", Offset = "0x30393D0", VA = "0x18303ADD0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x303AE00", Offset = "0x3039400", VA = "0x18303AE00", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x303AE50", Offset = "0x3039450", VA = "0x18303AE50", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public ConsumableEffectsOptionGui()
		{
		}

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		private const string LabelText = "Consumable Effects";
	}
}
