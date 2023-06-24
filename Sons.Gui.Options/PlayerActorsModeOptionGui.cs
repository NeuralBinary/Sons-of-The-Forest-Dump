using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	[Serializable]
	public class PlayerActorsModeOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000278 RID: 632 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x17000075")]
		public override bool IsSettingVisible
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000279 RID: 633 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x17000076")]
		public override bool IsSettingEnabled
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x30512C0", Offset = "0x304F8C0", VA = "0x1830512C0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000077")]
		public override string SettingKey
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x30512F0", Offset = "0x304F8F0", VA = "0x1830512F0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x3051320", Offset = "0x304F920", VA = "0x183051320")]
		public PlayerActorsModeOptionGui()
		{
		}

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		private const string LabelText = "Player Actors";
	}
}
