using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[Serializable]
	public class AnisotropicQualityOptionGui : OnOffOptionGuiBase
	{
		// Token: 0x06000010 RID: 16 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x30392D0", Offset = "0x30378D0", VA = "0x1830392D0", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000002")]
		public override string SettingKey
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x3039300", Offset = "0x3037900", VA = "0x183039300", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x3039330", Offset = "0x3037930", VA = "0x183039330", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public AnisotropicQualityOptionGui()
		{
		}

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		private const string LabelText = "Anisotropic Textures";
	}
}
