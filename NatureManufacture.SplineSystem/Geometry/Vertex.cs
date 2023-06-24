using System;
using Il2CppDummyDll;
using TriangleNet.Topology;

namespace TriangleNet.Geometry
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	public class Vertex : Point
	{
		// Token: 0x060003C0 RID: 960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x24EAEE0", Offset = "0x24E94E0", VA = "0x1824EAEE0")]
		public Vertex()
		{
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x24EAF00", Offset = "0x24E9500", VA = "0x1824EAF00")]
		public Vertex(double x, double y)
		{
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x24EAF20", Offset = "0x24E9520", VA = "0x1824EAF20")]
		public Vertex(double x, double y, int mark)
		{
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x170000B4")]
		public VertexType Type
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x716CD0", Offset = "0x7152D0", VA = "0x180716CD0")]
			get
			{
				return VertexType.InputVertex;
			}
		}

		// Token: 0x170000B5 RID: 181
		[Token(Token = "0x170000B5")]
		public double this[int i]
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x24EAF40", Offset = "0x24E9540", VA = "0x1824EAF40")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x30")]
		internal int hash;

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0x34")]
		internal VertexType type;

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x38")]
		internal Otri tri;
	}
}
