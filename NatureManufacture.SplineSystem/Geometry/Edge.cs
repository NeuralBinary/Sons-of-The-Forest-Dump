using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace TriangleNet.Geometry
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	public class Edge : IEdge
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000347 RID: 839 RVA: 0x000030C0 File Offset: 0x000012C0
		// (set) Token: 0x06000348 RID: 840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008F")]
		public int P0
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000349 RID: 841 RVA: 0x000030D8 File Offset: 0x000012D8
		// (set) Token: 0x0600034A RID: 842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000090")]
		public int P1
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x66F510", Offset = "0x66DB10", VA = "0x18066F510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600034B RID: 843 RVA: 0x000030F0 File Offset: 0x000012F0
		// (set) Token: 0x0600034C RID: 844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000091")]
		public int Label
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x24E8F20", Offset = "0x24E7520", VA = "0x1824E8F20")]
		public Edge(int p0, int p1)
		{
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x2142F70", Offset = "0x2141570", VA = "0x182142F70")]
		public Edge(int p0, int p1, int label)
		{
		}
	}
}
