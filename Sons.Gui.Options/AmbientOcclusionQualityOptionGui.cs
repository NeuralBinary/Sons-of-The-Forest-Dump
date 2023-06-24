using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[Serializable]
	public class AmbientOcclusionQualityOptionGui : QualityWithOffOptionGuiBase
	{
		// Token: 0x0600000C RID: 12 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x3039230", Offset = "0x3037830", VA = "0x183039230", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000D RID: 13 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000001")]
		public override string SettingKey
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x3039260", Offset = "0x3037860", VA = "0x183039260", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x3039290", Offset = "0x3037890", VA = "0x183039290", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public AmbientOcclusionQualityOptionGui()
		{
		}

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		private const string LabelText = "Ambient Occlusion";
	}
}
