using System;
using Il2CppDummyDll;

namespace Sons.Gui.Options
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	[Serializable]
	public class TerrainTessellationQualityOptionGui : HighMediumLowOptionGuiBase
	{
		// Token: 0x060002C9 RID: 713 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x3053110", Offset = "0x3051710", VA = "0x183053110", Slot = "34")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000087")]
		public override string SettingKey
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x3053140", Offset = "0x3051740", VA = "0x183053140", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x3053170", Offset = "0x3051770", VA = "0x183053170", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x30392C0", Offset = "0x30378C0", VA = "0x1830392C0")]
		public TerrainTessellationQualityOptionGui()
		{
		}

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		private const string LabelText = "Terrain Tessellation";
	}
}
