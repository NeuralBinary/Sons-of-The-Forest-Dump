using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.RVO
{
	// Token: 0x02000160 RID: 352
	[Token(Token = "0x2000160")]
	[AddComponentMenu("Pathfinding/Local Avoidance/Square Obstacle")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_r_v_o_1_1_r_v_o_square_obstacle.php")]
	public class RVOSquareObstacle : RVOObstacle
	{
		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x00006A04 File Offset: 0x00004C04
		[Token(Token = "0x17000180")]
		protected override bool StaticObstacle
		{
			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x00006A1C File Offset: 0x00004C1C
		[Token(Token = "0x17000181")]
		protected override bool ExecuteInEditor
		{
			[Token(Token = "0x6000AFF")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x00006A34 File Offset: 0x00004C34
		[Token(Token = "0x17000182")]
		protected override bool LocalCoordinates
		{
			[Token(Token = "0x6000B00")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x00006A4C File Offset: 0x00004C4C
		[Token(Token = "0x17000183")]
		protected override float Height
		{
			[Token(Token = "0x6000B01")]
			[Address(RVA = "0x727F30", Offset = "0x726530", VA = "0x180727F30", Slot = "14")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00006A64 File Offset: 0x00004C64
		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "15")]
		protected override bool AreGizmosDirty()
		{
			return default(bool);
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x727F40", Offset = "0x726540", VA = "0x180727F40", Slot = "10")]
		protected override void CreateObstacles()
		{
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x728170", Offset = "0x726770", VA = "0x180728170")]
		public RVOSquareObstacle()
		{
		}

		// Token: 0x040007A2 RID: 1954
		[Token(Token = "0x40007A2")]
		[FieldOffset(Offset = "0xA0")]
		public float height;

		// Token: 0x040007A3 RID: 1955
		[Token(Token = "0x40007A3")]
		[FieldOffset(Offset = "0xA4")]
		public Vector2 size;

		// Token: 0x040007A4 RID: 1956
		[Token(Token = "0x40007A4")]
		[FieldOffset(Offset = "0xAC")]
		public Vector2 center;
	}
}
