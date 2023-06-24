using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	public class BufferUtil
	{
		// Token: 0x060001AF RID: 431 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1F37E70", Offset = "0x1F36470", VA = "0x181F37E70")]
		public static void SetVertex3(double[] v, int i, double x, double y, double z)
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1F37EC0", Offset = "0x1F364C0", VA = "0x181F37EC0")]
		public static void SetVertex3(float[] v, int i, float x, float y, float z)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1F37F10", Offset = "0x1F36510", VA = "0x181F37F10")]
		public static void SetVertex2(double[] v, int i, double x, double y)
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1F37F50", Offset = "0x1F36550", VA = "0x181F37F50")]
		public static void SetVertex2(float[] v, int i, float x, float y)
		{
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1F37F90", Offset = "0x1F36590", VA = "0x181F37F90")]
		public static void SetTriangle(int[] v, int i, int a, int b, int c)
		{
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000305C File Offset: 0x0000125C
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1F37FE0", Offset = "0x1F365E0", VA = "0x181F37FE0")]
		public static double Dot(double[] a, double[] b)
		{
			return 0.0;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1F38040", Offset = "0x1F36640", VA = "0x181F38040")]
		public static void MultiplyAdd(double[] dest, double multiply, double[] add)
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1F380A0", Offset = "0x1F366A0", VA = "0x181F380A0")]
		public static void MultiplyAdd(double[] dest, double[] multiply, double[] add)
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00003074 File Offset: 0x00001274
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1F38110", Offset = "0x1F36710", VA = "0x181F38110")]
		public static double MultiplyAdd_GetSqrSum(double[] dest, double multiply, double[] add)
		{
			return 0.0;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000308C File Offset: 0x0000128C
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1F38180", Offset = "0x1F36780", VA = "0x181F38180")]
		public static double DistanceSquared(double[] a, double[] b)
		{
			return 0.0;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1F381E0", Offset = "0x1F367E0", VA = "0x181F381E0")]
		public static void ParallelDot(double[] a, double[][] b, double[][] result)
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1F383C0", Offset = "0x1F369C0", VA = "0x181F383C0")]
		public static double[][] AllocNxM(int N, int M)
		{
			return null;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1F384D0", Offset = "0x1F36AD0", VA = "0x181F384D0")]
		public static double[][] InitNxM(int N, int M, double[][] init)
		{
			return null;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000030A4 File Offset: 0x000012A4
		[Token(Token = "0x60001BC")]
		public static int CountValid<T>(T[] data, Func<T, bool> FilterF, int max_i = -1)
		{
			return 0;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000030BC File Offset: 0x000012BC
		[Token(Token = "0x60001BD")]
		public static int FilterInPlace<T>(T[] data, Func<T, bool> FilterF, int max_i = -1)
		{
			return 0;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001BE")]
		public static T[] Filter<T>(T[] data, Func<T, bool> FilterF, int max_i = -1)
		{
			return null;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001BF")]
		public static Vector3d[] ToVector3d<T>(IEnumerable<T> values)
		{
			return null;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001C0")]
		public static Vector3f[] ToVector3f<T>(IEnumerable<T> values)
		{
			return null;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001C1")]
		public static Index3i[] ToIndex3i<T>(IEnumerable<T> values)
		{
			return null;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1F38680", Offset = "0x1F36C80", VA = "0x181F38680")]
		public static int[] ToInt(byte[] buffer)
		{
			return null;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1F38750", Offset = "0x1F36D50", VA = "0x181F38750")]
		public static short[] ToShort(byte[] buffer)
		{
			return null;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1F38810", Offset = "0x1F36E10", VA = "0x181F38810")]
		public static double[] ToDouble(byte[] buffer)
		{
			return null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1F388E0", Offset = "0x1F36EE0", VA = "0x181F388E0")]
		public static float[] ToFloat(byte[] buffer)
		{
			return null;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1F389B0", Offset = "0x1F36FB0", VA = "0x181F389B0")]
		public static VectorArray3d ToVectorArray3d(byte[] buffer)
		{
			return null;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1F38B70", Offset = "0x1F37170", VA = "0x181F38B70")]
		public static VectorArray2f ToVectorArray2f(byte[] buffer)
		{
			return null;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1F38CC0", Offset = "0x1F372C0", VA = "0x181F38CC0")]
		public static VectorArray3f ToVectorArray3f(byte[] buffer)
		{
			return null;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1F38E70", Offset = "0x1F37470", VA = "0x181F38E70")]
		public static VectorArray3i ToVectorArray3i(byte[] buffer)
		{
			return null;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1F39030", Offset = "0x1F37630", VA = "0x181F39030")]
		public static IndexArray4i ToIndexArray4i(byte[] buffer)
		{
			return null;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1F392B0", Offset = "0x1F378B0", VA = "0x181F392B0")]
		public static byte[] ToBytes(int[] array)
		{
			return null;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1F39330", Offset = "0x1F37930", VA = "0x181F39330")]
		public static byte[] ToBytes(short[] array)
		{
			return null;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1F393B0", Offset = "0x1F379B0", VA = "0x181F393B0")]
		public static byte[] ToBytes(float[] array)
		{
			return null;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1F39430", Offset = "0x1F37A30", VA = "0x181F39430")]
		public static byte[] ToBytes(double[] array)
		{
			return null;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1F394B0", Offset = "0x1F37AB0", VA = "0x181F394B0")]
		public static byte[] CompressZLib(byte[] buffer, bool bFast)
		{
			return null;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1F39780", Offset = "0x1F37D80", VA = "0x181F39780")]
		public static byte[] DecompressZLib(byte[] zBuffer)
		{
			return null;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BufferUtil()
		{
		}
	}
}
