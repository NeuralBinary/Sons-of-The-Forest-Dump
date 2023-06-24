using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x020000FF RID: 255
	[Token(Token = "0x20000FF")]
	public class AstarProfiler
	{
		// Token: 0x06000886 RID: 2182 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private AstarProfiler()
		{
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x6DEA60", Offset = "0x6DD060", VA = "0x1806DEA60")]
		[Conditional("ProfileAstar")]
		public static void InitializeFastProfile(string[] profileNames)
		{
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x6DEF60", Offset = "0x6DD560", VA = "0x1806DEF60")]
		[Conditional("ProfileAstar")]
		public static void StartFastProfile(int tag)
		{
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x6DF030", Offset = "0x6DD630", VA = "0x1806DF030")]
		[Conditional("ProfileAstar")]
		public static void EndFastProfile(int tag)
		{
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("ASTAR_UNITY_PRO_PROFILER")]
		public static void EndProfile()
		{
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x6DF0C0", Offset = "0x6DD6C0", VA = "0x1806DF0C0")]
		[Conditional("ProfileAstar")]
		public static void StartProfile(string tag)
		{
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x6DF2A0", Offset = "0x6DD8A0", VA = "0x1806DF2A0")]
		[Conditional("ProfileAstar")]
		public static void EndProfile(string tag)
		{
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600088D")]
		[Address(RVA = "0x6DF460", Offset = "0x6DDA60", VA = "0x1806DF460")]
		[Conditional("ProfileAstar")]
		public static void Reset()
		{
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600088E")]
		[Address(RVA = "0x6DF760", Offset = "0x6DDD60", VA = "0x1806DF760")]
		[Conditional("ProfileAstar")]
		public static void PrintFastResults()
		{
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600088F")]
		[Address(RVA = "0x6DFF70", Offset = "0x6DE570", VA = "0x1806DFF70")]
		[Conditional("ProfileAstar")]
		public static void PrintResults()
		{
		}

		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x40005C7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, AstarProfiler.ProfilePoint> profiles;

		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x40005C8")]
		[FieldOffset(Offset = "0x8")]
		private static DateTime startTime;

		// Token: 0x040005C9 RID: 1481
		[Token(Token = "0x40005C9")]
		[FieldOffset(Offset = "0x10")]
		public static AstarProfiler.ProfilePoint[] fastProfiles;

		// Token: 0x040005CA RID: 1482
		[Token(Token = "0x40005CA")]
		[FieldOffset(Offset = "0x18")]
		public static string[] fastProfileNames;

		// Token: 0x02000100 RID: 256
		[Token(Token = "0x2000100")]
		public class ProfilePoint
		{
			// Token: 0x06000891 RID: 2193 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000891")]
			[Address(RVA = "0x6E0B80", Offset = "0x6DF180", VA = "0x1806E0B80")]
			public ProfilePoint()
			{
			}

			// Token: 0x040005CB RID: 1483
			[Token(Token = "0x40005CB")]
			[FieldOffset(Offset = "0x10")]
			public Stopwatch watch;

			// Token: 0x040005CC RID: 1484
			[Token(Token = "0x40005CC")]
			[FieldOffset(Offset = "0x18")]
			public int totalCalls;

			// Token: 0x040005CD RID: 1485
			[Token(Token = "0x40005CD")]
			[FieldOffset(Offset = "0x20")]
			public long tmpBytes;

			// Token: 0x040005CE RID: 1486
			[Token(Token = "0x40005CE")]
			[FieldOffset(Offset = "0x28")]
			public long totalBytes;
		}
	}
}
