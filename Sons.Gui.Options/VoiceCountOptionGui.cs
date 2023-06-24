using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	[Serializable]
	public class VoiceCountOptionGui : CustomMenuOptionGui
	{
		// Token: 0x060002DB RID: 731 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x30533E0", Offset = "0x30519E0", VA = "0x1830533E0", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x3053500", Offset = "0x3051B00", VA = "0x183053500", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x1700008C")]
		internal override bool Localize
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700008D")]
		public override string SettingKey
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x3053530", Offset = "0x3051B30", VA = "0x183053530", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x3053560", Offset = "0x3051B60", VA = "0x183053560", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public VoiceCountOptionGui()
		{
		}

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		private const string LabelText = "Voice Count";
	}
}
