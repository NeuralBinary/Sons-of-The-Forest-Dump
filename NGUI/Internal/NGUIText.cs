using System;
using System.Diagnostics;
using System.Text;
using Il2CppDummyDll;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Internal
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	public static class NGUIText
	{
		// Token: 0x06000429 RID: 1065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x2676770", Offset = "0x2674D70", VA = "0x182676770")]
		public static void Update()
		{
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x26767C0", Offset = "0x2674DC0", VA = "0x1826767C0")]
		public static void Update(bool request)
		{
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x2676CE0", Offset = "0x26752E0", VA = "0x182676CE0")]
		public static void Prepare(string text)
		{
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x2676E20", Offset = "0x2675420", VA = "0x182676E20")]
		public static BMSymbol GetSymbol(string text, int index, int textLength)
		{
			return null;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x2676F70", Offset = "0x2675570", VA = "0x182676F70")]
		public static float GetGlyphWidth(int ch, int prev)
		{
			return 0f;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x26772D0", Offset = "0x26758D0", VA = "0x1826772D0")]
		public static NGUIText.GlyphInfo GetGlyph(int ch, int prev)
		{
			return null;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00003B10 File Offset: 0x00001D10
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x2677D30", Offset = "0x2676330", VA = "0x182677D30")]
		[DebuggerStepThrough]
		[DebuggerHidden]
		public static float ParseAlpha(string text, int index)
		{
			return 0f;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00003B28 File Offset: 0x00001D28
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x2677DE0", Offset = "0x26763E0", VA = "0x182677DE0")]
		[DebuggerHidden]
		[DebuggerStepThrough]
		public static Color ParseColor(string text, int offset)
		{
			return default(Color);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00003B40 File Offset: 0x00001D40
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x2677E60", Offset = "0x2676460", VA = "0x182677E60")]
		[DebuggerHidden]
		[DebuggerStepThrough]
		public static Color ParseColor24(string text, int offset)
		{
			return default(Color);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00003B58 File Offset: 0x00001D58
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x2677FA0", Offset = "0x26765A0", VA = "0x182677FA0")]
		[DebuggerHidden]
		[DebuggerStepThrough]
		public static Color ParseColor32(string text, int offset)
		{
			return default(Color);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x2678130", Offset = "0x2676730", VA = "0x182678130")]
		[DebuggerStepThrough]
		[DebuggerHidden]
		public static string EncodeColor(Color c)
		{
			return null;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x2678190", Offset = "0x2676790", VA = "0x182678190")]
		[DebuggerHidden]
		[DebuggerStepThrough]
		public static string EncodeColor(string text, Color c)
		{
			return null;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x26782B0", Offset = "0x26768B0", VA = "0x1826782B0")]
		[DebuggerStepThrough]
		[DebuggerHidden]
		public static string EncodeAlpha(float a)
		{
			return null;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x26783B0", Offset = "0x26769B0", VA = "0x1826783B0")]
		[DebuggerHidden]
		[DebuggerStepThrough]
		public static string EncodeColor24(Color c)
		{
			return null;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x2678500", Offset = "0x2676B00", VA = "0x182678500")]
		[DebuggerHidden]
		[DebuggerStepThrough]
		public static string EncodeColor32(Color c)
		{
			return null;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x2678650", Offset = "0x2676C50", VA = "0x182678650")]
		public static bool ParseSymbol(string text, ref int index)
		{
			return default(bool);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x2678730", Offset = "0x2676D30", VA = "0x182678730")]
		[DebuggerStepThrough]
		[DebuggerHidden]
		public static bool IsHex(char ch)
		{
			return default(bool);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x2678760", Offset = "0x2676D60", VA = "0x182678760")]
		public static bool ParseSymbol(string text, ref int index, BetterList<Color> colors, bool premultiply, ref int sub, ref bool bold, ref bool italic, ref bool underline, ref bool strike, ref bool ignoreColor)
		{
			return default(bool);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x26797A0", Offset = "0x2677DA0", VA = "0x1826797A0")]
		public static string StripSymbols(string text)
		{
			return null;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x2679950", Offset = "0x2677F50", VA = "0x182679950")]
		public static void Align(BetterList<Vector3> verts, int indexOffset, float printedWidth, int elements = 4)
		{
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x2679FC0", Offset = "0x26785C0", VA = "0x182679FC0")]
		public static int GetExactCharacterIndex(BetterList<Vector3> verts, BetterList<int> indices, Vector2 pos)
		{
			return 0;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00003BD0 File Offset: 0x00001DD0
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x267A0F0", Offset = "0x26786F0", VA = "0x18267A0F0")]
		public static int GetApproximateCharacterIndex(BetterList<Vector3> verts, BetterList<int> indices, Vector2 pos)
		{
			return 0;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x267A230", Offset = "0x2678830", VA = "0x18267A230")]
		[DebuggerHidden]
		[DebuggerStepThrough]
		private static bool IsSpace(int ch)
		{
			return default(bool);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x267A250", Offset = "0x2678850", VA = "0x18267A250")]
		[DebuggerHidden]
		[DebuggerStepThrough]
		public static void EndLine(ref StringBuilder s)
		{
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x267A370", Offset = "0x2678970", VA = "0x18267A370")]
		[DebuggerHidden]
		[DebuggerStepThrough]
		private static void ReplaceSpaceWithNewline(ref StringBuilder s)
		{
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x267A420", Offset = "0x2678A20", VA = "0x18267A420")]
		public static Vector2 CalculatePrintedSize(string text)
		{
			return default(Vector2);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00003C18 File Offset: 0x00001E18
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x267A8E0", Offset = "0x2678EE0", VA = "0x18267A8E0")]
		public static int CalculateOffsetToFit(string text)
		{
			return 0;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x267ACA0", Offset = "0x26792A0", VA = "0x18267ACA0")]
		public static string GetEndOfLineThatFits(string text)
		{
			return null;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00003C30 File Offset: 0x00001E30
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x267AD20", Offset = "0x2679320", VA = "0x18267AD20")]
		public static bool WrapText(string text, out string finalText, bool wrapLineColors = false)
		{
			return default(bool);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00003C48 File Offset: 0x00001E48
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x267ADA0", Offset = "0x26793A0", VA = "0x18267ADA0")]
		public static bool WrapText(string text, out string finalText, bool keepCharCount, bool wrapLineColors)
		{
			return default(bool);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x267C010", Offset = "0x267A610", VA = "0x18267C010")]
		public static void Print(string text, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
		{
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x267E430", Offset = "0x267CA30", VA = "0x18267E430")]
		public static void PrintApproximateCharacterPositions(string text, BetterList<Vector3> verts, BetterList<int> indices)
		{
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x267EBD0", Offset = "0x267D1D0", VA = "0x18267EBD0")]
		public static void PrintExactCharacterPositions(string text, BetterList<Vector3> verts, BetterList<int> indices)
		{
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x267F2A0", Offset = "0x267D8A0", VA = "0x18267F2A0")]
		public static void PrintCaretAndSelection(string text, int start, int end, BetterList<Vector3> caret, BetterList<Vector3> highlight)
		{
		}

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x0")]
		public static UIFont bitmapFont;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x8")]
		public static Font dynamicFont;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x10")]
		public static NGUIText.GlyphInfo glyph;

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x18")]
		public static int fontSize;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x1C")]
		public static float fontScale;

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x20")]
		public static float pixelDensity;

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x24")]
		public static FontStyle fontStyle;

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x28")]
		public static NGUIText.Alignment alignment;

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x2C")]
		public static Color tint;

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x3C")]
		public static int rectWidth;

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x40")]
		public static int rectHeight;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x44")]
		public static int regionWidth;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x48")]
		public static int regionHeight;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x4C")]
		public static int maxLines;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x50")]
		public static bool gradient;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x54")]
		public static Color gradientBottom;

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x64")]
		public static Color gradientTop;

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x74")]
		public static bool encoding;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x78")]
		public static float spacingX;

		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x7C")]
		public static float spacingY;

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x80")]
		public static bool premultiply;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x84")]
		public static NGUIText.SymbolStyle symbolStyle;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x88")]
		public static int finalSize;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x8C")]
		public static float finalSpacingX;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x90")]
		public static float finalLineHeight;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x94")]
		public static float baseline;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x98")]
		public static bool useSymbols;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x9C")]
		private static Color mInvisible;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0xB0")]
		private static BetterList<Color> mColors;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0xB8")]
		private static float mAlpha;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0xBC")]
		private static CharacterInfo mTempChar;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0xF0")]
		private static BetterList<float> mSizes;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0xF8")]
		private static Color32 s_c0;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0xFC")]
		private static Color32 s_c1;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x100")]
		private static float[] mBoldOffset;

		// Token: 0x02000071 RID: 113
		[Token(Token = "0x2000071")]
		public enum Alignment
		{
			// Token: 0x04000301 RID: 769
			[Token(Token = "0x4000301")]
			Automatic,
			// Token: 0x04000302 RID: 770
			[Token(Token = "0x4000302")]
			Left,
			// Token: 0x04000303 RID: 771
			[Token(Token = "0x4000303")]
			Center,
			// Token: 0x04000304 RID: 772
			[Token(Token = "0x4000304")]
			Right,
			// Token: 0x04000305 RID: 773
			[Token(Token = "0x4000305")]
			Justified
		}

		// Token: 0x02000072 RID: 114
		[Token(Token = "0x2000072")]
		public enum SymbolStyle
		{
			// Token: 0x04000307 RID: 775
			[Token(Token = "0x4000307")]
			None,
			// Token: 0x04000308 RID: 776
			[Token(Token = "0x4000308")]
			Normal,
			// Token: 0x04000309 RID: 777
			[Token(Token = "0x4000309")]
			Colored
		}

		// Token: 0x02000073 RID: 115
		[Token(Token = "0x2000073")]
		public class GlyphInfo
		{
			// Token: 0x0600044C RID: 1100 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public GlyphInfo()
			{
			}

			// Token: 0x0400030A RID: 778
			[Token(Token = "0x400030A")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 v0;

			// Token: 0x0400030B RID: 779
			[Token(Token = "0x400030B")]
			[FieldOffset(Offset = "0x18")]
			public Vector2 v1;

			// Token: 0x0400030C RID: 780
			[Token(Token = "0x400030C")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 u0;

			// Token: 0x0400030D RID: 781
			[Token(Token = "0x400030D")]
			[FieldOffset(Offset = "0x28")]
			public Vector2 u1;

			// Token: 0x0400030E RID: 782
			[Token(Token = "0x400030E")]
			[FieldOffset(Offset = "0x30")]
			public Vector2 u2;

			// Token: 0x0400030F RID: 783
			[Token(Token = "0x400030F")]
			[FieldOffset(Offset = "0x38")]
			public Vector2 u3;

			// Token: 0x04000310 RID: 784
			[Token(Token = "0x4000310")]
			[FieldOffset(Offset = "0x40")]
			public float advance;

			// Token: 0x04000311 RID: 785
			[Token(Token = "0x4000311")]
			[FieldOffset(Offset = "0x44")]
			public int channel;
		}
	}
}
