using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	[Serializable]
	public class SingleUseContainersOptionGui : ToggleMenuGameSettingGui
	{
		// Token: 0x0600009A RID: 154 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x303B890", Offset = "0x3039E90", VA = "0x18303B890", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700001D")]
		public override string SettingKey
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x303B8C0", Offset = "0x3039EC0", VA = "0x18303B8C0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x303B480", Offset = "0x3039A80", VA = "0x18303B480")]
		public SingleUseContainersOptionGui()
		{
		}

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		private const string LabelText = "Single Use Containers";
	}
}
