using System;
using Il2CppDummyDll;
using Pathfinding.RVO;
using UnityEngine;

namespace Pathfinding.Legacy
{
	// Token: 0x0200010C RID: 268
	[Token(Token = "0x200010C")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_legacy_1_1_legacy_r_v_o_controller.php")]
	[AddComponentMenu("Pathfinding/Legacy/Local Avoidance/Legacy RVO Controller")]
	public class LegacyRVOController : RVOController
	{
		// Token: 0x060008CD RID: 2253 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x6EB420", Offset = "0x6E9A20", VA = "0x1806EB420")]
		public void Update()
		{
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x6EBB10", Offset = "0x6EA110", VA = "0x1806EBB10")]
		public LegacyRVOController()
		{
		}

		// Token: 0x040005F9 RID: 1529
		[Token(Token = "0x40005F9")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("Layer mask for the ground. The RVOController will raycast down to check for the ground to figure out where to place the agent")]
		public new LayerMask mask;

		// Token: 0x040005FA RID: 1530
		[Token(Token = "0x40005FA")]
		[FieldOffset(Offset = "0x84")]
		public new bool enableRotation;

		// Token: 0x040005FB RID: 1531
		[Token(Token = "0x40005FB")]
		[FieldOffset(Offset = "0x88")]
		public new float rotationSpeed;
	}
}
