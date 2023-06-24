using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x02000108 RID: 264
	[Token(Token = "0x2000108")]
	public class Profile
	{
		// Token: 0x060008B1 RID: 2225 RVA: 0x00005E64 File Offset: 0x00004064
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x6E6C40", Offset = "0x6E5240", VA = "0x1806E6C40")]
		public int ControlValue()
		{
			return 0;
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x6E6C50", Offset = "0x6E5250", VA = "0x1806E6C50")]
		public Profile(string name)
		{
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void WriteCSV(string path, params Profile[] profiles)
		{
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x6E6D50", Offset = "0x6E5350", VA = "0x1806E6D50")]
		public void Run(Action action)
		{
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x6E6D80", Offset = "0x6E5380", VA = "0x1806E6D80")]
		[Conditional("PROFILE")]
		public void Start()
		{
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x6E6DE0", Offset = "0x6E53E0", VA = "0x1806E6DE0")]
		[Conditional("PROFILE")]
		public void Stop()
		{
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x6E6E10", Offset = "0x6E5410", VA = "0x1806E6E10")]
		[Conditional("PROFILE")]
		public void Log()
		{
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x6E6E80", Offset = "0x6E5480", VA = "0x1806E6E80")]
		[Conditional("PROFILE")]
		public void ConsoleLog()
		{
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x6E6EF0", Offset = "0x6E54F0", VA = "0x1806E6EF0")]
		[Conditional("PROFILE")]
		public void Stop(int control)
		{
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x6E6FE0", Offset = "0x6E55E0", VA = "0x1806E6FE0")]
		[Conditional("PROFILE")]
		public void Control(Profile other)
		{
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x6E71D0", Offset = "0x6E57D0", VA = "0x1806E71D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040005E3 RID: 1507
		[Token(Token = "0x40005E3")]
		private const bool PROFILE_MEM = false;

		// Token: 0x040005E4 RID: 1508
		[Token(Token = "0x40005E4")]
		[FieldOffset(Offset = "0x10")]
		public readonly string name;

		// Token: 0x040005E5 RID: 1509
		[Token(Token = "0x40005E5")]
		[FieldOffset(Offset = "0x18")]
		private readonly Stopwatch watch;

		// Token: 0x040005E6 RID: 1510
		[Token(Token = "0x40005E6")]
		[FieldOffset(Offset = "0x20")]
		private int counter;

		// Token: 0x040005E7 RID: 1511
		[Token(Token = "0x40005E7")]
		[FieldOffset(Offset = "0x28")]
		private long mem;

		// Token: 0x040005E8 RID: 1512
		[Token(Token = "0x40005E8")]
		[FieldOffset(Offset = "0x30")]
		private long smem;

		// Token: 0x040005E9 RID: 1513
		[Token(Token = "0x40005E9")]
		[FieldOffset(Offset = "0x38")]
		private int control;

		// Token: 0x040005EA RID: 1514
		[Token(Token = "0x40005EA")]
		private const bool dontCountFirst = false;
	}
}
