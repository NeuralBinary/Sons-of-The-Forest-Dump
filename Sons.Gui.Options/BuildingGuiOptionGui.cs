using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[Serializable]
	public class BuildingGuiOptionGui : ToggleMenuOptionGui
	{
		// Token: 0x06000036 RID: 54 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x303A060", Offset = "0x3038660", VA = "0x18303A060", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000008")]
		public override string SettingKey
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x303A090", Offset = "0x3038690", VA = "0x18303A090", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x303A0C0", Offset = "0x30386C0", VA = "0x18303A0C0")]
		public BuildingGuiOptionGui()
		{
		}
	}
}
