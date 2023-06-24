using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001F5 RID: 501
	[Token(Token = "0x20001F5")]
	public class QueryTuple2d
	{
		// Token: 0x06001061 RID: 4193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001061")]
		[Address(RVA = "0x1E43780", Offset = "0x1E41D80", VA = "0x181E43780")]
		public QueryTuple2d(Vector2d v0, Vector2d v1, Vector2d v2)
		{
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001062")]
		[Address(RVA = "0x1E437C0", Offset = "0x1E41DC0", VA = "0x181E437C0")]
		public QueryTuple2d(Vector2dTuple3 tuple)
		{
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0000C524 File Offset: 0x0000A724
		[Token(Token = "0x6001063")]
		[Address(RVA = "0x1E437E0", Offset = "0x1E41DE0", VA = "0x181E437E0")]
		public int ToLine(int i, int v0, int v1)
		{
			return 0;
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x0000C53C File Offset: 0x0000A73C
		[Token(Token = "0x6001064")]
		[Address(RVA = "0x1E43820", Offset = "0x1E41E20", VA = "0x181E43820")]
		public int ToLine(Vector2d test, int v0, int v1)
		{
			return 0;
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0000C554 File Offset: 0x0000A754
		[Token(Token = "0x6001065")]
		[Address(RVA = "0x1E43900", Offset = "0x1E41F00", VA = "0x181E43900")]
		public int ToTriangle(int i, int v0, int v1, int v2)
		{
			return 0;
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x0000C56C File Offset: 0x0000A76C
		[Token(Token = "0x6001066")]
		[Address(RVA = "0x1E43950", Offset = "0x1E41F50", VA = "0x181E43950")]
		public int ToTriangle(Vector2d test, int v0, int v1, int v2)
		{
			return 0;
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0000C584 File Offset: 0x0000A784
		[Token(Token = "0x6001067")]
		[Address(RVA = "0x1E43A30", Offset = "0x1E42030", VA = "0x181E43A30")]
		public int ToCircumcircle(int i, int v0, int v1, int v2)
		{
			return 0;
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x0000C59C File Offset: 0x0000A79C
		[Token(Token = "0x6001068")]
		[Address(RVA = "0x1E43A80", Offset = "0x1E42080", VA = "0x181E43A80")]
		public int ToCircumcircle(Vector2d test, int v0, int v1, int v2)
		{
			return 0;
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x0000C5B4 File Offset: 0x0000A7B4
		[Token(Token = "0x6001069")]
		[Address(RVA = "0x1E43D30", Offset = "0x1E42330", VA = "0x181E43D30")]
		public static double Dot(double x0, double y0, double x1, double y1)
		{
			return 0.0;
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0000C5CC File Offset: 0x0000A7CC
		[Token(Token = "0x600106A")]
		[Address(RVA = "0x1E43D40", Offset = "0x1E42340", VA = "0x181E43D40")]
		public static double Det2(double x0, double y0, double x1, double y1)
		{
			return 0.0;
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0000C5E4 File Offset: 0x0000A7E4
		[Token(Token = "0x600106B")]
		[Address(RVA = "0x1E43D50", Offset = "0x1E42350", VA = "0x181E43D50")]
		public static double Det3(double x0, double y0, double z0, double x1, double y1, double z1, double x2, double y2, double z2)
		{
			return 0.0;
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0000C5FC File Offset: 0x0000A7FC
		[Token(Token = "0x600106C")]
		[Address(RVA = "0x1E43E10", Offset = "0x1E42410", VA = "0x181E43E10")]
		public static bool Sort(ref int v0, ref int v1)
		{
			return default(bool);
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x0000C614 File Offset: 0x0000A814
		[Token(Token = "0x600106D")]
		[Address(RVA = "0x1E43E30", Offset = "0x1E42430", VA = "0x181E43E30")]
		public static bool Sort(ref int v0, ref int v1, ref int v2)
		{
			return default(bool);
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x0000C62C File Offset: 0x0000A82C
		[Token(Token = "0x600106E")]
		[Address(RVA = "0x1E43F20", Offset = "0x1E42520", VA = "0x181E43F20")]
		public static bool Sort(ref int v0, ref int v1, ref int v2, ref int v3)
		{
			return default(bool);
		}

		// Token: 0x04000817 RID: 2071
		[Token(Token = "0x4000817")]
		[FieldOffset(Offset = "0x10")]
		private Vector2dTuple3 mVertices;
	}
}
