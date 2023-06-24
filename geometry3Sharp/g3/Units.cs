using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000BD RID: 189
	[Token(Token = "0x20000BD")]
	public static class Units
	{
		// Token: 0x06000448 RID: 1096 RVA: 0x0000407C File Offset: 0x0000227C
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1F4DA40", Offset = "0x1F4C040", VA = "0x181F4DA40")]
		public static bool IsMetric(Units.Linear t)
		{
			return default(bool);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00004094 File Offset: 0x00002294
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1F4DA50", Offset = "0x1F4C050", VA = "0x181F4DA50")]
		public static double GetMetricPower(Units.Linear t)
		{
			return 0.0;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x000040AC File Offset: 0x000022AC
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1F4DAD0", Offset = "0x1F4C0D0", VA = "0x181F4DAD0")]
		public static double ToMeters(Units.Linear t)
		{
			return 0.0;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x000040C4 File Offset: 0x000022C4
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1F4DBE0", Offset = "0x1F4C1E0", VA = "0x181F4DBE0")]
		public static double MetersTo(Units.Linear t)
		{
			return 0.0;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000040DC File Offset: 0x000022DC
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1F4DCF0", Offset = "0x1F4C2F0", VA = "0x181F4DCF0")]
		public static double Convert(Units.Linear from, Units.Linear to)
		{
			return 0.0;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000040F4 File Offset: 0x000022F4
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1F4DFF0", Offset = "0x1F4C5F0", VA = "0x181F4DFF0")]
		public static Units.Linear ParseLinear(string units)
		{
			return Units.Linear.UnknownUnits;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1F4E380", Offset = "0x1F4C980", VA = "0x181F4E380")]
		public static string GetShortString(Units.Linear unit)
		{
			return null;
		}

		// Token: 0x020000BE RID: 190
		[Token(Token = "0x20000BE")]
		public enum Angular
		{
			// Token: 0x040002FC RID: 764
			[Token(Token = "0x40002FC")]
			Degrees,
			// Token: 0x040002FD RID: 765
			[Token(Token = "0x40002FD")]
			Radians
		}

		// Token: 0x020000BF RID: 191
		[Token(Token = "0x20000BF")]
		public enum Linear
		{
			// Token: 0x040002FF RID: 767
			[Token(Token = "0x40002FF")]
			UnknownUnits,
			// Token: 0x04000300 RID: 768
			[Token(Token = "0x4000300")]
			Nanometers = 11,
			// Token: 0x04000301 RID: 769
			[Token(Token = "0x4000301")]
			Microns = 14,
			// Token: 0x04000302 RID: 770
			[Token(Token = "0x4000302")]
			Millimeters = 17,
			// Token: 0x04000303 RID: 771
			[Token(Token = "0x4000303")]
			Centimeters,
			// Token: 0x04000304 RID: 772
			[Token(Token = "0x4000304")]
			Meters = 20,
			// Token: 0x04000305 RID: 773
			[Token(Token = "0x4000305")]
			Kilometers = 23,
			// Token: 0x04000306 RID: 774
			[Token(Token = "0x4000306")]
			Inches = 105,
			// Token: 0x04000307 RID: 775
			[Token(Token = "0x4000307")]
			Feet = 109,
			// Token: 0x04000308 RID: 776
			[Token(Token = "0x4000308")]
			Yards,
			// Token: 0x04000309 RID: 777
			[Token(Token = "0x4000309")]
			Miles = 115
		}
	}
}
