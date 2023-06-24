using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Voxels
{
	// Token: 0x02000110 RID: 272
	[Token(Token = "0x2000110")]
	public class VoxelContourSet
	{
		// Token: 0x060008DD RID: 2269 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public VoxelContourSet()
		{
		}

		// Token: 0x0400061E RID: 1566
		[Token(Token = "0x400061E")]
		[FieldOffset(Offset = "0x10")]
		public List<VoxelContour> conts;

		// Token: 0x0400061F RID: 1567
		[Token(Token = "0x400061F")]
		[FieldOffset(Offset = "0x18")]
		public Bounds bounds;
	}
}
