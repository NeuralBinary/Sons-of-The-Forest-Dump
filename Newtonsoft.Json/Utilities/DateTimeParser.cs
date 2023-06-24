using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000A5 RID: 165
	[Token(Token = "0x20000A5")]
	[NullableContext(1)]
	[Nullable(0)]
	internal struct DateTimeParser
	{
		// Token: 0x0600054E RID: 1358 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x2557C50", Offset = "0x2556250", VA = "0x182557C50")]
		public bool Parse(char[] text, int startIndex, int length)
		{
			return default(bool);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x2557DB0", Offset = "0x25563B0", VA = "0x182557DB0")]
		private bool ParseDate(int start)
		{
			return default(bool);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x2558050", Offset = "0x2556650", VA = "0x182558050")]
		private bool ParseTimeAndZoneAndWhitespace(int start)
		{
			return default(bool);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00003648 File Offset: 0x00001848
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x2558090", Offset = "0x2556690", VA = "0x182558090")]
		private bool ParseTime(ref int start)
		{
			return default(bool);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00003660 File Offset: 0x00001860
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x25584A0", Offset = "0x2556AA0", VA = "0x1825584A0")]
		private bool ParseZone(int start)
		{
			return default(bool);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x2558700", Offset = "0x2556D00", VA = "0x182558700")]
		private bool Parse4Digit(int start, out int num)
		{
			return default(bool);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x25587C0", Offset = "0x2556DC0", VA = "0x1825587C0")]
		private bool Parse2Digit(int start, out int num)
		{
			return default(bool);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x2558830", Offset = "0x2556E30", VA = "0x182558830")]
		private bool ParseChar(int start, char ch)
		{
			return default(bool);
		}

		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0x0")]
		public int Year;

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0x4")]
		public int Month;

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x8")]
		public int Day;

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0xC")]
		public int Hour;

		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x10")]
		public int Minute;

		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x14")]
		public int Second;

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x18")]
		public int Fraction;

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x1C")]
		public int ZoneHour;

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0x20")]
		public int ZoneMinute;

		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		[FieldOffset(Offset = "0x24")]
		public ParserTimeZone Zone;

		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		[FieldOffset(Offset = "0x28")]
		private char[] _text;

		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x40003EC")]
		[FieldOffset(Offset = "0x30")]
		private int _end;

		// Token: 0x040003ED RID: 1005
		[Token(Token = "0x40003ED")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] Power10;

		// Token: 0x040003EE RID: 1006
		[Token(Token = "0x40003EE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int Lzyyyy;

		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int Lzyyyy_;

		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int Lzyyyy_MM;

		// Token: 0x040003F1 RID: 1009
		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int Lzyyyy_MM_;

		// Token: 0x040003F2 RID: 1010
		[Token(Token = "0x40003F2")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int Lzyyyy_MM_dd;

		// Token: 0x040003F3 RID: 1011
		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int Lzyyyy_MM_ddT;

		// Token: 0x040003F4 RID: 1012
		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int LzHH;

		// Token: 0x040003F5 RID: 1013
		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int LzHH_;

		// Token: 0x040003F6 RID: 1014
		[Token(Token = "0x40003F6")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int LzHH_mm;

		// Token: 0x040003F7 RID: 1015
		[Token(Token = "0x40003F7")]
		[FieldOffset(Offset = "0x2C")]
		private static readonly int LzHH_mm_;

		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x30")]
		private static readonly int LzHH_mm_ss;

		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x34")]
		private static readonly int Lz_;

		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x38")]
		private static readonly int Lz_zz;

		// Token: 0x040003FB RID: 1019
		[Token(Token = "0x40003FB")]
		private const short MaxFractionDigits = 7;
	}
}
