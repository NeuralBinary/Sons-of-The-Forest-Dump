using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	[Serializable]
	public class TextureResolutionOptionGui : CustomMenuOptionGui
	{
		// Token: 0x060002CD RID: 717 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x30531A0", Offset = "0x30517A0", VA = "0x1830531A0", Slot = "31")]
		public override List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x30531F0", Offset = "0x30517F0", VA = "0x1830531F0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000088")]
		public override string SettingKey
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x3053220", Offset = "0x3051820", VA = "0x183053220", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x3053250", Offset = "0x3051850", VA = "0x183053250", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public TextureResolutionOptionGui()
		{
		}

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		private const string LabelText = "Texture Resolution";
	}
}
