using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[Serializable]
	public class EnemyAggressionOptionGui : CustomMenuGameSettingGui
	{
		// Token: 0x0600006B RID: 107 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x303AFA0", Offset = "0x30395A0", VA = "0x18303AFA0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000013")]
		public override string SettingKey
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x303AFD0", Offset = "0x30395D0", VA = "0x18303AFD0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x303B000", Offset = "0x3039600", VA = "0x18303B000", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x303B060", Offset = "0x3039660", VA = "0x18303B060", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public EnemyAggressionOptionGui()
		{
		}

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		private const string LabelText = "Enemy Aggression";
	}
}
