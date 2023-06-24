using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000E5 RID: 229
	[Token(Token = "0x20000E5")]
	[AddComponentMenu("Pathfinding/Navmesh/RelevantGraphSurface")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_relevant_graph_surface.php")]
	public class RelevantGraphSurface : VersionedMonoBehaviour
	{
		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x00005AEC File Offset: 0x00003CEC
		[Token(Token = "0x17000137")]
		public Vector3 Position
		{
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x6D15B0", Offset = "0x6CFBB0", VA = "0x1806D15B0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000138")]
		public RelevantGraphSurface Next
		{
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000139")]
		public RelevantGraphSurface Prev
		{
			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013A")]
		public static RelevantGraphSurface Root
		{
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x6D15D0", Offset = "0x6CFBD0", VA = "0x1806D15D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x6D1610", Offset = "0x6CFC10", VA = "0x1806D1610")]
		public void UpdatePosition()
		{
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x6D16E0", Offset = "0x6CFCE0", VA = "0x1806D16E0")]
		private void OnEnable()
		{
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x6D19A0", Offset = "0x6CFFA0", VA = "0x1806D19A0")]
		private void OnDisable()
		{
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x6D1F10", Offset = "0x6D0510", VA = "0x1806D1F10")]
		public static void UpdateAllPositions()
		{
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x6D1FF0", Offset = "0x6D05F0", VA = "0x1806D1FF0")]
		public static void FindAllGraphSurfaces()
		{
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x6D2140", Offset = "0x6D0740", VA = "0x1806D2140")]
		public void OnDrawGizmos()
		{
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x6D2470", Offset = "0x6D0A70", VA = "0x1806D2470")]
		public void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x5C7240", Offset = "0x5C5840", VA = "0x1805C7240")]
		public RelevantGraphSurface()
		{
		}

		// Token: 0x04000577 RID: 1399
		[Token(Token = "0x4000577")]
		[FieldOffset(Offset = "0x0")]
		private static RelevantGraphSurface root;

		// Token: 0x04000578 RID: 1400
		[Token(Token = "0x4000578")]
		[FieldOffset(Offset = "0x28")]
		public float maxRange;

		// Token: 0x04000579 RID: 1401
		[Token(Token = "0x4000579")]
		[FieldOffset(Offset = "0x30")]
		private RelevantGraphSurface prev;

		// Token: 0x0400057A RID: 1402
		[Token(Token = "0x400057A")]
		[FieldOffset(Offset = "0x38")]
		private RelevantGraphSurface next;

		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 position;
	}
}
