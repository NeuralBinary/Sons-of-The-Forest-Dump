using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using g3;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public class MeshSpatialSort
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1E06070", Offset = "0x1E04670", VA = "0x181E06070")]
		public MeshSpatialSort()
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1E06130", Offset = "0x1E04730", VA = "0x181E06130")]
		public void AddMesh(DMesh3 mesh, object identifier, [Optional] DMeshAABBTree3 spatial)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1E062B0", Offset = "0x1E048B0", VA = "0x181E062B0")]
		public void Sort()
		{
		}

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<MeshSpatialSort.ComponentMesh> Components;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<MeshSpatialSort.MeshSolid> Solids;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool AllowOpenContainers;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public double FastWindingIso;

		// Token: 0x0200001E RID: 30
		[Token(Token = "0x200001E")]
		public class ComponentMesh
		{
			// Token: 0x06000088 RID: 136 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x1E07730", Offset = "0x1E05D30", VA = "0x181E07730")]
			public ComponentMesh(DMesh3 mesh, object identifier, DMeshAABBTree3 spatial)
			{
			}

			// Token: 0x06000089 RID: 137 RVA: 0x000024A4 File Offset: 0x000006A4
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x1E079E0", Offset = "0x1E05FE0", VA = "0x181E079E0")]
			public bool Contains(MeshSpatialSort.ComponentMesh mesh2, double fIso = 0.5)
			{
				return default(bool);
			}

			// Token: 0x0400007E RID: 126
			[Token(Token = "0x400007E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object Identifier;

			// Token: 0x0400007F RID: 127
			[Token(Token = "0x400007F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DMesh3 Mesh;

			// Token: 0x04000080 RID: 128
			[Token(Token = "0x4000080")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool IsClosed;

			// Token: 0x04000081 RID: 129
			[Token(Token = "0x4000081")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DMeshAABBTree3 Spatial;

			// Token: 0x04000082 RID: 130
			[Token(Token = "0x4000082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AxisAlignedBox3d Bounds;

			// Token: 0x04000083 RID: 131
			[Token(Token = "0x4000083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public List<MeshSpatialSort.ComponentMesh> InsideOf;

			// Token: 0x04000084 RID: 132
			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public List<MeshSpatialSort.ComponentMesh> InsideSet;
		}

		// Token: 0x02000020 RID: 32
		[Token(Token = "0x2000020")]
		public class MeshSolid
		{
			// Token: 0x0600008C RID: 140 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x1E07D50", Offset = "0x1E06350", VA = "0x181E07D50")]
			public MeshSolid()
			{
			}

			// Token: 0x04000089 RID: 137
			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MeshSpatialSort.ComponentMesh Outer;

			// Token: 0x0400008A RID: 138
			[Token(Token = "0x400008A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<MeshSpatialSort.ComponentMesh> Cavities;
		}
	}
}
