using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	public static class Util
	{
		// Token: 0x0600044F RID: 1103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1F4E570", Offset = "0x1F4CB70", VA = "0x181F4E570")]
		public static void gBreakToDebugger()
		{
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1F4E600", Offset = "0x1F4CC00", VA = "0x181F4E600")]
		[Conditional("DEBUG")]
		public static void gDevAssert(bool bValue, string message = "gDevAssert")
		{
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000410C File Offset: 0x0000230C
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1F4E6D0", Offset = "0x1F4CCD0", VA = "0x181F4E6D0")]
		public static bool IsRunningOnMono()
		{
			return default(bool);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00004124 File Offset: 0x00002324
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1F4E750", Offset = "0x1F4CD50", VA = "0x181F4E750")]
		public static bool IsBitSet(byte b, int pos)
		{
			return default(bool);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000413C File Offset: 0x0000233C
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1F4E770", Offset = "0x1F4CD70", VA = "0x181F4E770")]
		public static bool IsBitSet(int n, int pos)
		{
			return default(bool);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00004154 File Offset: 0x00002354
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1F4E790", Offset = "0x1F4CD90", VA = "0x181F4E790")]
		public static bool IsTextString(byte[] array)
		{
			return default(bool);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0000416C File Offset: 0x0000236C
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1F4E800", Offset = "0x1F4CE00", VA = "0x181F4E800")]
		public static bool IsBinaryFile(string path, int max_search_len = -1)
		{
			return default(bool);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00004184 File Offset: 0x00002384
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1F4E900", Offset = "0x1F4CF00", VA = "0x181F4E900")]
		public static bool IsBinaryStream(Stream streamIn, int max_search_len = -1)
		{
			return default(bool);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000419C File Offset: 0x0000239C
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x1F4EA40", Offset = "0x1F4D040", VA = "0x181F4EA40")]
		public static bool IsASCIIControlChar(int ch)
		{
			return default(bool);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1F4EA60", Offset = "0x1F4D060", VA = "0x181F4EA60")]
		public static string ToHexString(byte[] bytes, bool upperCase = false)
		{
			return null;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000041B4 File Offset: 0x000023B4
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1F4EB70", Offset = "0x1F4D170", VA = "0x181F4EB70")]
		public static float ParseInt(string s, int nDefault)
		{
			return 0f;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000041CC File Offset: 0x000023CC
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1F4EBA0", Offset = "0x1F4D1A0", VA = "0x181F4EBA0")]
		public static float ParseFloat(string s, float fDefault)
		{
			return 0f;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x000041E4 File Offset: 0x000023E4
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1F4EBC0", Offset = "0x1F4D1C0", VA = "0x181F4EBC0")]
		public static double ParseDouble(string s, double fDefault)
		{
			return 0.0;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1F4EBE0", Offset = "0x1F4D1E0", VA = "0x181F4EBE0")]
		public static float[] BufferCopy(float[] from, float[] to)
		{
			return null;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1F4EC80", Offset = "0x1F4D280", VA = "0x181F4EC80")]
		public static int[] BufferCopy(int[] from, int[] to)
		{
			return null;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1F4ED20", Offset = "0x1F4D320", VA = "0x181F4ED20")]
		public static string MakeFloatFormatString(int i, int nPrecision)
		{
			return null;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1F4EDB0", Offset = "0x1F4D3B0", VA = "0x181F4EDB0")]
		public static string MakeVec3FormatString(int i0, int i1, int i2, int nPrecision)
		{
			return null;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1F4EFA0", Offset = "0x1F4D5A0", VA = "0x181F4EFA0")]
		public static string ToSecMilli(TimeSpan t)
		{
			return null;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000461")]
		public static T[] AppendArrays<T>(params object[] args)
		{
			return null;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1F4F010", Offset = "0x1F4D610", VA = "0x181F4F010")]
		public static byte[] StructureToByteArray(object obj)
		{
			return null;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1F4F160", Offset = "0x1F4D760", VA = "0x181F4F160")]
		public static void ByteArrayToStructure(byte[] bytearray, ref object obj)
		{
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1F4F2F0", Offset = "0x1F4D8F0", VA = "0x181F4F2F0")]
		public static void WriteDebugMesh(IMesh mesh, string sPath)
		{
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1F4F500", Offset = "0x1F4DB00", VA = "0x181F4F500")]
		public static void WriteDebugMeshAndMarkers(IMesh mesh, List<Vector3d> Markers, string sPath)
		{
		}

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x0")]
		public static bool DebugBreakOnDevAssert;
	}
}
