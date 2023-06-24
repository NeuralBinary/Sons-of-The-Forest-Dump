using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using g3;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	public class MeshRepairOrientation
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000003")]
		protected DMeshAABBTree3 Spatial
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x1E04B40", Offset = "0x1E03140", VA = "0x181E04B40")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1E04C00", Offset = "0x1E03200", VA = "0x181E04C00")]
		public MeshRepairOrientation(DMesh3 mesh3, [Optional] DMeshAABBTree3 spatial)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1E04D70", Offset = "0x1E03370", VA = "0x181E04D70")]
		public void OrientComponents()
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1E053A0", Offset = "0x1E039A0", VA = "0x181E053A0")]
		public void ComputeStatistics()
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1E055A0", Offset = "0x1E03BA0", VA = "0x181E055A0")]
		private void compute_statistics(MeshRepairOrientation.Component c)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1E05980", Offset = "0x1E03F80", VA = "0x181E05980")]
		public void SolveGlobalOrientation()
		{
		}

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DMeshAABBTree3 spatial;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<MeshRepairOrientation.Component> Components;

		// Token: 0x0200001B RID: 27
		[Token(Token = "0x200001B")]
		private class Component
		{
			// Token: 0x06000082 RID: 130 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Component()
			{
			}

			// Token: 0x04000073 RID: 115
			[Token(Token = "0x4000073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<int> triangles;

			// Token: 0x04000074 RID: 116
			[Token(Token = "0x4000074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public double outFacing;

			// Token: 0x04000075 RID: 117
			[Token(Token = "0x4000075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public double inFacing;
		}
	}
}
