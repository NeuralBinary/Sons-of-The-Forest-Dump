using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	[AddComponentMenu("Pathfinding/Navmesh/RecastTileUpdateHandler")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_recast_tile_update_handler.php")]
	public class RecastTileUpdateHandler : MonoBehaviour
	{
		// Token: 0x060004CF RID: 1231 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x6791E0", Offset = "0x6777E0", VA = "0x1806791E0")]
		public void SetGraph(RecastGraph graph)
		{
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x6792F0", Offset = "0x6778F0", VA = "0x1806792F0")]
		public void ScheduleUpdate(Bounds bounds)
		{
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x679640", Offset = "0x677C40", VA = "0x180679640")]
		private void OnEnable()
		{
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x6796B0", Offset = "0x677CB0", VA = "0x1806796B0")]
		private void OnDisable()
		{
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x679720", Offset = "0x677D20", VA = "0x180679720")]
		private void Update()
		{
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x6797A0", Offset = "0x677DA0", VA = "0x1806797A0")]
		public void UpdateDirtyTiles()
		{
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x679B00", Offset = "0x678100", VA = "0x180679B00")]
		public RecastTileUpdateHandler()
		{
		}

		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x20")]
		private RecastGraph graph;

		// Token: 0x0400033B RID: 827
		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x28")]
		private bool[] dirtyTiles;

		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x30")]
		private bool anyDirtyTiles;

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x34")]
		private float earliestDirty;

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x38")]
		public float maxThrottlingDelay;
	}
}
