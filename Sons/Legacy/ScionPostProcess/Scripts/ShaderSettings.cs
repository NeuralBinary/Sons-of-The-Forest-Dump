using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x020005A2 RID: 1442
	[Token(Token = "0x20005A2")]
	public static class ShaderSettings
	{
		// Token: 0x0400222A RID: 8746
		[Token(Token = "0x400222A")]
		public const string ChromaticAberrationOffKW = "SC_CHROMATIC_ABERRATION_OFF";

		// Token: 0x0400222B RID: 8747
		[Token(Token = "0x400222B")]
		public const string ChromaticAberrationOnKW = "SC_CHROMATIC_ABERRATION_ON";

		// Token: 0x0400222C RID: 8748
		[Token(Token = "0x400222C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] ChromaticAberrationKeywords;

		// Token: 0x0400222D RID: 8749
		[Token(Token = "0x400222D")]
		[FieldOffset(Offset = "0x8")]
		public static ShaderSettings.IndexOption ChromaticAberrationSettings;

		// Token: 0x0400222E RID: 8750
		[Token(Token = "0x400222E")]
		public const string ColorGradingOffKW = "SC_COLOR_CORRECTION_OFF";

		// Token: 0x0400222F RID: 8751
		[Token(Token = "0x400222F")]
		public const string ColorGradingOn1TexKW = "SC_COLOR_CORRECTION_1_TEX";

		// Token: 0x04002230 RID: 8752
		[Token(Token = "0x4002230")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string[] ColorGradingKeywords;

		// Token: 0x04002231 RID: 8753
		[Token(Token = "0x4002231")]
		[FieldOffset(Offset = "0x18")]
		public static ShaderSettings.IndexOption ColorGradingSettings;

		// Token: 0x020005A3 RID: 1443
		[Token(Token = "0x20005A3")]
		public class IndexOption
		{
			// Token: 0x06002605 RID: 9733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002605")]
			[Address(RVA = "0x33A50E0", Offset = "0x33A36E0", VA = "0x1833A50E0")]
			public IndexOption(string[] _keywords)
			{
			}

			// Token: 0x06002606 RID: 9734 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002606")]
			[Address(RVA = "0x33A5150", Offset = "0x33A3750", VA = "0x1833A5150")]
			public void SetIndex(int index)
			{
			}

			// Token: 0x06002607 RID: 9735 RVA: 0x0000B4F0 File Offset: 0x000096F0
			[Token(Token = "0x6002607")]
			[Address(RVA = "0x33A51F0", Offset = "0x33A37F0", VA = "0x1833A51F0")]
			public bool IsActive(int index)
			{
				return default(bool);
			}

			// Token: 0x06002608 RID: 9736 RVA: 0x0000B508 File Offset: 0x00009708
			[Token(Token = "0x6002608")]
			[Address(RVA = "0x33A5200", Offset = "0x33A3800", VA = "0x1833A5200")]
			public bool IsActive(string keyword)
			{
				return default(bool);
			}

			// Token: 0x06002609 RID: 9737 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002609")]
			[Address(RVA = "0x33A52C0", Offset = "0x33A38C0", VA = "0x1833A52C0")]
			private void SetKeyword(int index)
			{
			}

			// Token: 0x0600260A RID: 9738 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600260A")]
			[Address(RVA = "0x33A5360", Offset = "0x33A3960", VA = "0x1833A5360")]
			private void DisableKeyword(int index)
			{
			}

			// Token: 0x04002232 RID: 8754
			[Token(Token = "0x4002232")]
			[FieldOffset(Offset = "0x10")]
			private int curValue;

			// Token: 0x04002233 RID: 8755
			[Token(Token = "0x4002233")]
			[FieldOffset(Offset = "0x18")]
			private string[] keywords;
		}
	}
}
