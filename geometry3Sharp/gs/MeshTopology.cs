using System;
using System.Collections.Generic;
using g3;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	public class MeshTopology
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00002534 File Offset: 0x00000734
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000004")]
		public double CreaseAngle
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x5FD5E0", Offset = "0x5FBBE0", VA = "0x1805FD5E0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x1E09350", Offset = "0x1E07950", VA = "0x181E09350")]
			set
			{
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1E09360", Offset = "0x1E07960", VA = "0x181E09360")]
		public MeshTopology(DMesh3 mesh)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1E093D0", Offset = "0x1E079D0", VA = "0x181E093D0")]
		public void Compute()
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1E09430", Offset = "0x1E07A30", VA = "0x181E09430")]
		public void AddRemeshConstraints(MeshConstraints constraints)
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1E09A60", Offset = "0x1E08060", VA = "0x181E09A60")]
		private void invalidate_topology()
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1E093D0", Offset = "0x1E079D0", VA = "0x181E093D0")]
		private void validate_topology()
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1E09A70", Offset = "0x1E08070", VA = "0x181E09A70")]
		private void find_crease_edges(double angle_tol)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1E0A270", Offset = "0x1E08870", VA = "0x181E0A270")]
		private void extract_topology()
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1E0AFD0", Offset = "0x1E095D0", VA = "0x181E0AFD0")]
		public DMesh3 MakeElementsMesh(Polygon2d spanProfile, Polygon2d loopProfile)
		{
			return null;
		}

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x18")]
		private double crease_angle;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x20")]
		public HashSet<int> BoundaryEdges;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x28")]
		public HashSet<int> CreaseEdges;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x30")]
		public HashSet<int> AllEdges;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x38")]
		public HashSet<int> AllVertices;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x40")]
		public HashSet<int> JunctionVertices;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x48")]
		public EdgeLoop[] Loops;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x50")]
		public EdgeSpan[] Spans;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x58")]
		private int topo_timestamp;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x5C")]
		public bool IgnoreTimestamp;
	}
}
