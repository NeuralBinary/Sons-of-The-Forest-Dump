using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.RVO
{
	// Token: 0x0200015A RID: 346
	[Token(Token = "0x200015A")]
	[AddComponentMenu("Pathfinding/Local Avoidance/RVO Navmesh")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_r_v_o_1_1_r_v_o_navmesh.php")]
	public class RVONavmesh : GraphModifier
	{
		// Token: 0x06000AD7 RID: 2775 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x724740", Offset = "0x722D40", VA = "0x180724740", Slot = "16")]
		public override void OnPostCacheLoad()
		{
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x724740", Offset = "0x722D40", VA = "0x180724740", Slot = "18")]
		public override void OnGraphsPostUpdate()
		{
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x724760", Offset = "0x722D60", VA = "0x180724760", Slot = "15")]
		public override void OnLatePostScan()
		{
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x724B70", Offset = "0x723170", VA = "0x180724B70", Slot = "11")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x724B90", Offset = "0x723190", VA = "0x180724B90")]
		public void RemoveObstacles()
		{
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x724E40", Offset = "0x723440", VA = "0x180724E40")]
		private void AddGraphObstacles(Simulator sim, GridGraph grid)
		{
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x725140", Offset = "0x723740", VA = "0x180725140")]
		private void AddGraphObstacles(Simulator simulator, INavmesh navmesh)
		{
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x7252A0", Offset = "0x7238A0", VA = "0x1807252A0")]
		public RVONavmesh()
		{
		}

		// Token: 0x04000786 RID: 1926
		[Token(Token = "0x4000786")]
		[FieldOffset(Offset = "0x40")]
		public float wallHeight;

		// Token: 0x04000787 RID: 1927
		[Token(Token = "0x4000787")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<ObstacleVertex> obstacles;

		// Token: 0x04000788 RID: 1928
		[Token(Token = "0x4000788")]
		[FieldOffset(Offset = "0x50")]
		private Simulator lastSim;
	}
}
