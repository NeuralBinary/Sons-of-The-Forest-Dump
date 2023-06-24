using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	[Serializable]
	public class ReducedFoodInContainersOptionGui : ToggleMenuGameSettingGui
	{
		// Token: 0x06000091 RID: 145 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x303B730", Offset = "0x3039D30", VA = "0x18303B730", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700001B")]
		public override string SettingKey
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x303B760", Offset = "0x3039D60", VA = "0x18303B760", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "46")]
		public override bool GetDefaultBoolValue()
		{
			return default(bool);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x303B480", Offset = "0x3039A80", VA = "0x18303B480")]
		public ReducedFoodInContainersOptionGui()
		{
		}

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		private const string LabelText = "Reduced Food In Containers";
	}
}
