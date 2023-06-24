using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	[Serializable]
	public class ResolutionOptionGui : CustomMenuOptionGui
	{
		// Token: 0x06000297 RID: 663 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x3052550", Offset = "0x3050B50", VA = "0x183052550", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x3052580", Offset = "0x3050B80", VA = "0x183052580", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700007B")]
		public override string SettingKey
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x30525C0", Offset = "0x3050BC0", VA = "0x1830525C0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x1700007C")]
		internal override bool Localize
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x30525F0", Offset = "0x3050BF0", VA = "0x1830525F0", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public ResolutionOptionGui()
		{
		}

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		private const string LabelText = "Resolution";
	}
}
