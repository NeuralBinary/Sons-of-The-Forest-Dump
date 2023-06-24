using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[Serializable]
	public class BigHeadModeOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x06000026 RID: 38 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x3039DB0", Offset = "0x30383B0", VA = "0x183039DB0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000027 RID: 39 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000004")]
		public override string SettingKey
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x3039DE0", Offset = "0x30383E0", VA = "0x183039DE0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x3039E10", Offset = "0x3038410", VA = "0x183039E10")]
		public BigHeadModeOptionGui()
		{
		}

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		private const string LabelText = "Big Head Mode";
	}
}
