using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	internal static class SharedUtilities
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2857360", Offset = "0x2855960", VA = "0x182857360")]
		public static long GetFileLength(string fileName)
		{
			return 0L;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2857490", Offset = "0x2855A90", VA = "0x182857490")]
		[Conditional("NETCF")]
		public static void Workaround_Ladybug318918(Stream s)
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x28574C0", Offset = "0x2855AC0", VA = "0x1828574C0")]
		private static string SimplifyFwdSlashPath(string path)
		{
			return null;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2857630", Offset = "0x2855C30", VA = "0x182857630")]
		public static string NormalizePathForUseInZipFile(string pathName)
		{
			return null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x28578B0", Offset = "0x2855EB0", VA = "0x1828578B0")]
		internal static byte[] StringToByteArray(string value, Encoding encoding)
		{
			return null;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x28578E0", Offset = "0x2855EE0", VA = "0x1828578E0")]
		internal static byte[] StringToByteArray(string value)
		{
			return null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2857960", Offset = "0x2855F60", VA = "0x182857960")]
		internal static string Utf8StringFromBuffer(byte[] buf)
		{
			return null;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x28579F0", Offset = "0x2855FF0", VA = "0x1828579F0")]
		internal static string StringFromBuffer(byte[] buf, Encoding encoding)
		{
			return null;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2857A40", Offset = "0x2856040", VA = "0x182857A40")]
		internal static int ReadSignature(Stream s)
		{
			return 0;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2857AB0", Offset = "0x28560B0", VA = "0x182857AB0")]
		internal static int ReadEntrySignature(Stream s)
		{
			return 0;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2857C30", Offset = "0x2856230", VA = "0x182857C30")]
		internal static int ReadInt(Stream s)
		{
			return 0;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2857C90", Offset = "0x2856290", VA = "0x182857C90")]
		private static int _ReadFourBytes(Stream s, string message)
		{
			return 0;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2857DD0", Offset = "0x28563D0", VA = "0x182857DD0")]
		internal static long FindSignature(Stream stream, int SignatureToFind)
		{
			return 0L;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2858040", Offset = "0x2856640", VA = "0x182858040")]
		internal static DateTime AdjustTime_Reverse(DateTime time)
		{
			return default(DateTime);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2858210", Offset = "0x2856810", VA = "0x182858210")]
		internal static DateTime PackedToDateTime(int packedDateTime)
		{
			return default(DateTime);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2858810", Offset = "0x2856E10", VA = "0x182858810")]
		internal static int DateTimeToPacked(DateTime time)
		{
			return 0;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2858980", Offset = "0x2856F80", VA = "0x182858980")]
		public static void CreateAndOpenUniqueTempFile(string dir, out Stream fs, out string filename)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2858BB0", Offset = "0x28571B0", VA = "0x182858BB0")]
		public static string InternalGetTempFileName()
		{
			return null;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2858C30", Offset = "0x2857230", VA = "0x182858C30")]
		internal static string GenerateRandomStringImpl(int length, int delta)
		{
			return null;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2858DB0", Offset = "0x28573B0", VA = "0x182858DB0")]
		internal static int ReadWithRetry(Stream s, byte[] buffer, int offset, int count, string FileName)
		{
			return 0;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2858E00", Offset = "0x2857400", VA = "0x182858E00")]
		private static uint _HRForException(Exception ex1)
		{
			return 0U;
		}

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x0")]
		private static Regex doubleDotRegex1;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x8")]
		private static Encoding ibm437;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x10")]
		private static Encoding utf8;
	}
}
