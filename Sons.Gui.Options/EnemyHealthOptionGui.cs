using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	[Serializable]
	public class EnemyHealthOptionGui : CustomMenuGameSettingGui
	{
		// Token: 0x0600007A RID: 122 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x303B300", Offset = "0x3039900", VA = "0x18303B300", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000016")]
		public override string SettingKey
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x303B330", Offset = "0x3039930", VA = "0x18303B330", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x303B360", Offset = "0x3039960", VA = "0x18303B360", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x303B3C0", Offset = "0x30399C0", VA = "0x18303B3C0", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public EnemyHealthOptionGui()
		{
		}

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		private const string LabelText = "Enemy Health";
	}
}
