using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	[Nullable(0)]
	[NullableContext(1)]
	internal static class DateTimeUtils
	{
		// Token: 0x06000557 RID: 1367 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x2558A10", Offset = "0x2557010", VA = "0x182558A10")]
		public static TimeSpan GetUtcOffset(this DateTime d)
		{
			return default(TimeSpan);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x000036D8 File Offset: 0x000018D8
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x2558A70", Offset = "0x2557070", VA = "0x182558A70")]
		public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind)
		{
			return XmlDateTimeSerializationMode.Local;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x2558B20", Offset = "0x2557120", VA = "0x182558B20")]
		internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone)
		{
			return default(DateTime);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x2558CE0", Offset = "0x25572E0", VA = "0x182558CE0")]
		private static DateTime SwitchToLocalTime(DateTime value)
		{
			return default(DateTime);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00003720 File Offset: 0x00001920
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x2558D60", Offset = "0x2557360", VA = "0x182558D60")]
		private static DateTime SwitchToUtcTime(DateTime value)
		{
			return default(DateTime);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x2558DE0", Offset = "0x25573E0", VA = "0x182558DE0")]
		private static long ToUniversalTicks(DateTime dateTime)
		{
			return 0L;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00003750 File Offset: 0x00001950
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x2558E70", Offset = "0x2557470", VA = "0x182558E70")]
		private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset)
		{
			return 0L;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00003768 File Offset: 0x00001968
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x2558F70", Offset = "0x2557570", VA = "0x182558F70")]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset)
		{
			return 0L;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00003780 File Offset: 0x00001980
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x2558FE0", Offset = "0x25575E0", VA = "0x182558FE0")]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime)
		{
			return 0L;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00003798 File Offset: 0x00001998
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x2559030", Offset = "0x2557630", VA = "0x182559030")]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc)
		{
			return 0L;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x000037B0 File Offset: 0x000019B0
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x2559120", Offset = "0x2557720", VA = "0x182559120")]
		private static long UniversalTicksToJavaScriptTicks(long universalTicks)
		{
			return 0L;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x000037C8 File Offset: 0x000019C8
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x2559190", Offset = "0x2557790", VA = "0x182559190")]
		internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks)
		{
			return default(DateTime);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x000037E0 File Offset: 0x000019E0
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x2559210", Offset = "0x2557810", VA = "0x182559210")]
		internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt)
		{
			return default(bool);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x2559600", Offset = "0x2557C00", VA = "0x182559600")]
		internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt)
		{
			return default(bool);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x2559860", Offset = "0x2557E60", VA = "0x182559860")]
		private static DateTime CreateDateTime(DateTimeParser dateTimeParser)
		{
			return default(DateTime);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00003828 File Offset: 0x00001A28
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x2559A40", Offset = "0x2558040", VA = "0x182559A40")]
		internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, [Nullable(2)] string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			return default(bool);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00003840 File Offset: 0x00001A40
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x2559D70", Offset = "0x2558370", VA = "0x182559D70")]
		internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, [Nullable(2)] string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			return default(bool);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x255A1D0", Offset = "0x25587D0", VA = "0x18255A1D0")]
		internal static bool TryParseDateTimeOffset(StringReference s, [Nullable(2)] string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			return default(bool);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00003870 File Offset: 0x00001A70
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x255A4E0", Offset = "0x2558AE0", VA = "0x18255A4E0")]
		internal static bool TryParseDateTimeOffset(string s, [Nullable(2)] string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			return default(bool);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00003888 File Offset: 0x00001A88
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x255A9C0", Offset = "0x2558FC0", VA = "0x18255A9C0")]
		private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind)
		{
			return default(bool);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x000038A0 File Offset: 0x00001AA0
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x255ABC0", Offset = "0x25591C0", VA = "0x18255ABC0")]
		private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt)
		{
			return default(bool);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x000038B8 File Offset: 0x00001AB8
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x255AD30", Offset = "0x2559330", VA = "0x18255AD30")]
		private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			return default(bool);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x255AE20", Offset = "0x2559420", VA = "0x18255AE20")]
		private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt)
		{
			return default(bool);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000038E8 File Offset: 0x00001AE8
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x255AF60", Offset = "0x2559560", VA = "0x18255AF60")]
		private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			return default(bool);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00003900 File Offset: 0x00001B00
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x255B010", Offset = "0x2559610", VA = "0x18255B010")]
		private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset)
		{
			return default(bool);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x255B330", Offset = "0x2559930", VA = "0x18255B330")]
		internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, [Nullable(2)] string formatString, CultureInfo culture)
		{
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x255B4E0", Offset = "0x2559AE0", VA = "0x18255B4E0")]
		internal static int WriteDateTimeString(char[] chars, int start, DateTime value, TimeSpan? offset, DateTimeKind kind, DateFormatHandling format)
		{
			return 0;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x255B8E0", Offset = "0x2559EE0", VA = "0x18255B8E0")]
		internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt)
		{
			return 0;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x255BDC0", Offset = "0x255A3C0", VA = "0x18255BDC0")]
		private static void CopyIntToCharArray(char[] chars, int start, int value, int digits)
		{
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00003948 File Offset: 0x00001B48
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x255BE40", Offset = "0x255A440", VA = "0x18255BE40")]
		internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format)
		{
			return 0;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x255C080", Offset = "0x255A680", VA = "0x18255C080")]
		internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, [Nullable(2)] string formatString, CultureInfo culture)
		{
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x255C230", Offset = "0x255A830", VA = "0x18255C230")]
		private static void GetDateValues(DateTime td, out int year, out int month, out int day)
		{
		}

		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly long InitialJavaScriptDateTicks;

		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		private const string IsoDateFormat = "yyyy-MM-ddTHH:mm:ss.FFFFFFFK";

		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		private const int DaysPer100Years = 36524;

		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		private const int DaysPer400Years = 146097;

		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		private const int DaysPer4Years = 1461;

		// Token: 0x04000401 RID: 1025
		[Token(Token = "0x4000401")]
		private const int DaysPerYear = 365;

		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		private const long TicksPerDay = 864000000000L;

		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] DaysToMonth365;

		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int[] DaysToMonth366;
	}
}
