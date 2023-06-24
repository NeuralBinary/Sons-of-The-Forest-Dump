using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace TheForest.Utils
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public static class CSVUtils
	{
		// Token: 0x06000043 RID: 67 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000043")]
		[Address(RVA = "0xA61F50", Offset = "0xA60550", VA = "0x180A61F50")]
		public static List<List<string>> SubArea(List<List<string>> source, int startX, int startY, int countX = 2147483647, int countY = 2147483647)
		{
			return null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000044")]
		[Address(RVA = "0xA62100", Offset = "0xA60700", VA = "0x180A62100")]
		public static List<List<string>> SplitCellsAndLines(string source, string newLineSequence, char deliminator, char encapsulate, char escape)
		{
			return null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0xA624B0", Offset = "0xA60AB0", VA = "0x180A624B0")]
		private static void FinalizeCurrentLine(ref List<List<string>> result, ref List<string> currentLine)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[Address(RVA = "0xA625D0", Offset = "0xA60BD0", VA = "0x180A625D0")]
		private static void FinalizeCurrentCell(ref List<string> currentLine, ref StringBuilder currentCell)
		{
		}
	}
}
