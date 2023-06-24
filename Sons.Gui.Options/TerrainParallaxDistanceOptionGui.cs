using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	[Serializable]
	public class TerrainParallaxDistanceOptionGui : HighMediumLowOptionGuiBase
	{
		// Token: 0x060002C5 RID: 709 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x3053080", Offset = "0x3051680", VA = "0x183053080", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000086")]
		public override string SettingKey
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x30530B0", Offset = "0x30516B0", VA = "0x1830530B0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x30530E0", Offset = "0x30516E0", VA = "0x1830530E0", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public TerrainParallaxDistanceOptionGui()
		{
		}

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		private const string LabelText = "Parallax Distance";
	}
}
