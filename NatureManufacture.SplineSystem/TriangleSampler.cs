using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Topology;

namespace TriangleNet
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	internal class TriangleSampler : IEnumerable<Triangle>, IEnumerable
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x24A9340", Offset = "0x24A7940", VA = "0x1824A9340")]
		public TriangleSampler(Mesh mesh)
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x24A9450", Offset = "0x24A7A50", VA = "0x1824A9450")]
		public TriangleSampler(Mesh mesh, Random random)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x24A9510", Offset = "0x24A7B10", VA = "0x1824A9510")]
		public void Reset()
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x24A9520", Offset = "0x24A7B20", VA = "0x1824A9520")]
		public void Update()
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x24A95C0", Offset = "0x24A7BC0", VA = "0x1824A95C0", Slot = "4")]
		public IEnumerator<Triangle> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x24A9730", Offset = "0x24A7D30", VA = "0x1824A9730", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		private const int RANDOM_SEED = 110503;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		private const int samplefactor = 11;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x10")]
		private Random random;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x18")]
		private Mesh mesh;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x20")]
		private int samples;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x24")]
		private int triangleCount;
	}
}
