using System;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Crc
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000C")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	public class CRC32
	{
		// Token: 0x06000488 RID: 1160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x28A2080", Offset = "0x28A0680", VA = "0x1828A2080")]
		public CRC32()
		{
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x28A20A0", Offset = "0x28A06A0", VA = "0x1828A20A0")]
		public CRC32(bool reverseBits)
		{
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x28A20C0", Offset = "0x28A06C0", VA = "0x1828A20C0")]
		public CRC32(int polynomial, bool reverseBits)
		{
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00004338 File Offset: 0x00002538
		[Token(Token = "0x17000115")]
		public long TotalBytesRead
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x17000116")]
		public int Crc32Result
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x28A20E0", Offset = "0x28A06E0", VA = "0x1828A20E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00004368 File Offset: 0x00002568
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x28A20F0", Offset = "0x28A06F0", VA = "0x1828A20F0")]
		public int GetCrc32(Stream input)
		{
			return 0;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00004380 File Offset: 0x00002580
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x28A2100", Offset = "0x28A0700", VA = "0x1828A2100")]
		public int GetCrc32AndCopy(Stream input, Stream output)
		{
			return 0;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00004398 File Offset: 0x00002598
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x28A2370", Offset = "0x28A0970", VA = "0x1828A2370")]
		public int ComputeCrc32(int W, byte B)
		{
			return 0;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x000043B0 File Offset: 0x000025B0
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x28A2370", Offset = "0x28A0970", VA = "0x1828A2370")]
		internal int _InternalComputeCrc32(uint W, byte B)
		{
			return 0;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x28A23B0", Offset = "0x28A09B0", VA = "0x1828A23B0")]
		public void SlurpBlock(byte[] block, int offset, int count)
		{
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x28A24C0", Offset = "0x28A0AC0", VA = "0x1828A24C0")]
		public void UpdateCRC(byte b)
		{
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x28A2540", Offset = "0x28A0B40", VA = "0x1828A2540")]
		public void UpdateCRC(byte b, int n)
		{
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x28A25C0", Offset = "0x28A0BC0", VA = "0x1828A25C0")]
		private static uint ReverseBits(uint data)
		{
			return 0U;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x28A2620", Offset = "0x28A0C20", VA = "0x1828A2620")]
		private static byte ReverseBits(byte data)
		{
			return 0;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x28A2650", Offset = "0x28A0C50", VA = "0x1828A2650")]
		private void GenerateLookupTable()
		{
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x000043F8 File Offset: 0x000025F8
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x28A27E0", Offset = "0x28A0DE0", VA = "0x1828A27E0")]
		private uint gf2_matrix_times(uint[] matrix, uint vec)
		{
			return 0U;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x28A2830", Offset = "0x28A0E30", VA = "0x1828A2830")]
		private void gf2_matrix_square(uint[] square, uint[] mat)
		{
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x28A28B0", Offset = "0x28A0EB0", VA = "0x1828A28B0")]
		public void Combine(int crc, int length)
		{
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x28A2B70", Offset = "0x28A1170", VA = "0x1828A2B70")]
		public void Reset()
		{
		}

		// Token: 0x0400039D RID: 925
		[Token(Token = "0x400039D")]
		private const int BUFFER_SIZE = 8192;

		// Token: 0x0400039E RID: 926
		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private uint dwPolynomial;

		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private long _TotalBytesRead;

		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool reverseBits;

		// Token: 0x040003A1 RID: 929
		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private uint[] crc32Table;

		// Token: 0x040003A2 RID: 930
		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private uint _register;
	}
}
