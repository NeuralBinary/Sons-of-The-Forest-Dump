using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Legacy
{
	// Token: 0x0200010B RID: 267
	[Token(Token = "0x200010B")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_legacy_1_1_legacy_rich_a_i.php")]
	[AddComponentMenu("Pathfinding/Legacy/AI/Legacy RichAI (3D, for navmesh)")]
	[RequireComponent(typeof(Seeker))]
	public class LegacyRichAI : RichAI
	{
		// Token: 0x060008C8 RID: 2248 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x6E9260", Offset = "0x6E7860", VA = "0x1806E9260", Slot = "7")]
		protected override void Awake()
		{
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x6E93F0", Offset = "0x6E79F0", VA = "0x1806E93F0", Slot = "27")]
		protected override void Update()
		{
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00005EC4 File Offset: 0x000040C4
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x6EADE0", Offset = "0x6E93E0", VA = "0x1806EADE0")]
		private new Vector3 RaycastPosition(Vector3 position, float lasty)
		{
			return default(Vector3);
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00005EDC File Offset: 0x000040DC
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x6EB040", Offset = "0x6E9640", VA = "0x1806EB040")]
		private bool RotateTowards(Vector3 trotdir)
		{
			return default(bool);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x6EB3D0", Offset = "0x6E99D0", VA = "0x1806EB3D0")]
		public LegacyRichAI()
		{
		}

		// Token: 0x040005F3 RID: 1523
		[Token(Token = "0x40005F3")]
		[FieldOffset(Offset = "0x190")]
		public bool preciseSlowdown;

		// Token: 0x040005F4 RID: 1524
		[Token(Token = "0x40005F4")]
		[FieldOffset(Offset = "0x191")]
		public bool raycastingForGroundPlacement;

		// Token: 0x040005F5 RID: 1525
		[Token(Token = "0x40005F5")]
		[FieldOffset(Offset = "0x194")]
		private new Vector3 velocity;

		// Token: 0x040005F6 RID: 1526
		[Token(Token = "0x40005F6")]
		[FieldOffset(Offset = "0x1A0")]
		private Vector3 lastTargetPoint;

		// Token: 0x040005F7 RID: 1527
		[Token(Token = "0x40005F7")]
		[FieldOffset(Offset = "0x1AC")]
		private Vector3 currentTargetDirection;

		// Token: 0x040005F8 RID: 1528
		[Token(Token = "0x40005F8")]
		[FieldOffset(Offset = "0x0")]
		private static float deltaTime;
	}
}
