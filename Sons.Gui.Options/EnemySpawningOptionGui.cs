using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	[Serializable]
	public class EnemySpawningOptionGui : ToggleMenuGameSettingGui
	{
		// Token: 0x0600007F RID: 127 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x303B420", Offset = "0x3039A20", VA = "0x18303B420", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000017")]
		public override string SettingKey
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x303B450", Offset = "0x3039A50", VA = "0x18303B450", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x303B480", Offset = "0x3039A80", VA = "0x18303B480")]
		public EnemySpawningOptionGui()
		{
		}

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		private const string LabelText = "Enemies";
	}
}
