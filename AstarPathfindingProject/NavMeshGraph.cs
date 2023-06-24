using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000A5 RID: 165
	[Token(Token = "0x20000A5")]
	[JsonOptIn]
	[Preserve]
	public class NavMeshGraph : NavmeshBase, IUpdatableGraph
	{
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x00004DE4 File Offset: 0x00002FE4
		[Token(Token = "0x17000106")]
		protected override bool RecalculateNormals
		{
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x69B260", Offset = "0x699860", VA = "0x18069B260", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x00004DFC File Offset: 0x00002FFC
		[Token(Token = "0x17000107")]
		public override float TileWorldSizeX
		{
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x69B270", Offset = "0x699870", VA = "0x18069B270", Slot = "37")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00004E14 File Offset: 0x00003014
		[Token(Token = "0x17000108")]
		public override float TileWorldSizeZ
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x69B280", Offset = "0x699880", VA = "0x18069B280", Slot = "38")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x00004E2C File Offset: 0x0000302C
		[Token(Token = "0x17000109")]
		protected override float MaxTileConnectionEdgeDistance
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "39")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x69B290", Offset = "0x699890", VA = "0x18069B290", Slot = "41")]
		public override GraphTransform CalculateTransform()
		{
			return null;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00004E44 File Offset: 0x00003044
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "45")]
		private GraphUpdateThreading CanUpdateAsync(GraphUpdateObject o)
		{
			return GraphUpdateThreading.UnityThread;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "43")]
		private void UpdateAreaInit(GraphUpdateObject o)
		{
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "44")]
		private void UpdateAreaPost(GraphUpdateObject o)
		{
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x69B7A0", Offset = "0x699DA0", VA = "0x18069B7A0", Slot = "42")]
		private void UpdateArea(GraphUpdateObject o)
		{
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x69B7C0", Offset = "0x699DC0", VA = "0x18069B7C0")]
		public static void UpdateArea(GraphUpdateObject o, INavmeshHolder graph)
		{
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x69BBD0", Offset = "0x69A1D0", VA = "0x18069BBD0", Slot = "20")]
		protected override IEnumerable<Progress> ScanInternal()
		{
			return null;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x69BC70", Offset = "0x69A270", VA = "0x18069BC70", Slot = "24")]
		protected override void DeserializeSettingsCompatibility(GraphSerializationContext ctx)
		{
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x69BEA0", Offset = "0x69A4A0", VA = "0x18069BEA0")]
		public NavMeshGraph()
		{
		}

		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x130")]
		[JsonMember]
		public Mesh sourceMesh;

		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x138")]
		[JsonMember]
		public Vector3 offset;

		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x144")]
		[JsonMember]
		public Vector3 rotation;

		// Token: 0x040003FB RID: 1019
		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0x150")]
		[JsonMember]
		public float scale;

		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x154")]
		[JsonMember]
		public bool recalculateNormals;

		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x158")]
		[JsonMember]
		private Vector3 cachedSourceMeshBoundsMin;
	}
}
