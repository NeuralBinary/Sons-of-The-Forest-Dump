using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x02000592 RID: 1426
	[Token(Token = "0x2000592")]
	public static class ShaderSettings
	{
		// Token: 0x04002156 RID: 8534
		[Token(Token = "0x4002156")]
		public const string ChromaticAberrationOffKW = "SC_CHROMATIC_ABERRATION_OFF";

		// Token: 0x04002157 RID: 8535
		[Token(Token = "0x4002157")]
		public const string ChromaticAberrationOnKW = "SC_CHROMATIC_ABERRATION_ON";

		// Token: 0x04002158 RID: 8536
		[Token(Token = "0x4002158")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] ChromaticAberrationKeywords;

		// Token: 0x04002159 RID: 8537
		[Token(Token = "0x4002159")]
		[FieldOffset(Offset = "0x8")]
		public static ShaderSettings.IndexOption ChromaticAberrationSettings;

		// Token: 0x0400215A RID: 8538
		[Token(Token = "0x400215A")]
		public const string ColorGradingOffKW = "SC_COLOR_CORRECTION_OFF";

		// Token: 0x0400215B RID: 8539
		[Token(Token = "0x400215B")]
		public const string ColorGradingOn1TexKW = "SC_COLOR_CORRECTION_1_TEX";

		// Token: 0x0400215C RID: 8540
		[Token(Token = "0x400215C")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string[] ColorGradingKeywords;

		// Token: 0x0400215D RID: 8541
		[Token(Token = "0x400215D")]
		[FieldOffset(Offset = "0x18")]
		public static ShaderSettings.IndexOption ColorGradingSettings;

		// Token: 0x02000593 RID: 1427
		[Token(Token = "0x2000593")]
		public class IndexOption
		{
			// Token: 0x06002506 RID: 9478 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002506")]
			[Address(RVA = "0x2D83B10", Offset = "0x2D82B10", VA = "0x182D83B10")]
			public IndexOption(string[] _keywords)
			{
			}

			// Token: 0x06002507 RID: 9479 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002507")]
			[Address(RVA = "0x2D839D0", Offset = "0x2D829D0", VA = "0x182D839D0")]
			public void SetIndex(int index)
			{
			}

			// Token: 0x06002508 RID: 9480 RVA: 0x0000AE30 File Offset: 0x00009030
			[Token(Token = "0x6002508")]
			[Address(RVA = "0x2D839C0", Offset = "0x2D829C0", VA = "0x182D839C0")]
			public bool IsActive(int index)
			{
				return default(bool);
			}

			// Token: 0x06002509 RID: 9481 RVA: 0x0000AE48 File Offset: 0x00009048
			[Token(Token = "0x6002509")]
			[Address(RVA = "0x2D83920", Offset = "0x2D82920", VA = "0x182D83920")]
			public bool IsActive(string keyword)
			{
				return default(bool);
			}

			// Token: 0x0600250A RID: 9482 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600250A")]
			[Address(RVA = "0x2D83A70", Offset = "0x2D82A70", VA = "0x182D83A70")]
			private void SetKeyword(int index)
			{
			}

			// Token: 0x0600250B RID: 9483 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600250B")]
			[Address(RVA = "0x2D838E0", Offset = "0x2D828E0", VA = "0x182D838E0")]
			private void DisableKeyword(int index)
			{
			}

			// Token: 0x0400215E RID: 8542
			[Token(Token = "0x400215E")]
			[FieldOffset(Offset = "0x10")]
			private int curValue;

			// Token: 0x0400215F RID: 8543
			[Token(Token = "0x400215F")]
			[FieldOffset(Offset = "0x18")]
			private string[] keywords;
		}
	}
}
