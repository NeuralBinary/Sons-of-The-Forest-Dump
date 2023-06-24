using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	[Serializable]
	public class ContactShadowsOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x0600004F RID: 79 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x303AA10", Offset = "0x3039010", VA = "0x18303AA10", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700000D")]
		public override string SettingKey
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x303AA40", Offset = "0x3039040", VA = "0x18303AA40", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x303AA70", Offset = "0x3039070", VA = "0x18303AA70")]
		public ContactShadowsOptionGui()
		{
		}

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		private const string LabelText = "Contact Shadows";
	}
}
