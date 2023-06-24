using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	[Serializable]
	public class EnemyDamageOptionGui : CustomMenuGameSettingGui
	{
		// Token: 0x06000075 RID: 117 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x303B1E0", Offset = "0x30397E0", VA = "0x18303B1E0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000015")]
		public override string SettingKey
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x303B210", Offset = "0x3039810", VA = "0x18303B210", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x303B240", Offset = "0x3039840", VA = "0x18303B240", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x303B2A0", Offset = "0x30398A0", VA = "0x18303B2A0", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public EnemyDamageOptionGui()
		{
		}

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		private const string LabelText = "Enemy Damage";
	}
}
