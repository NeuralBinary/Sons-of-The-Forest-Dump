using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_target_mover.php")]
	public class TargetMover : MonoBehaviour
	{
		// Token: 0x060004D6 RID: 1238 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x679B50", Offset = "0x678150", VA = "0x180679B50")]
		public void Start()
		{
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x679DA0", Offset = "0x6783A0", VA = "0x180679DA0")]
		public void OnGUI()
		{
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x679F40", Offset = "0x678540", VA = "0x180679F40")]
		private void Update()
		{
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x67A010", Offset = "0x678610", VA = "0x18067A010")]
		public void UpdateTargetPosition()
		{
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TargetMover()
		{
		}

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x20")]
		public LayerMask mask;

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x28")]
		public Transform target;

		// Token: 0x04000341 RID: 833
		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0x30")]
		private IAstarAI[] ais;

		// Token: 0x04000342 RID: 834
		[Token(Token = "0x4000342")]
		[FieldOffset(Offset = "0x38")]
		public bool onlyOnDoubleClick;

		// Token: 0x04000343 RID: 835
		[Token(Token = "0x4000343")]
		[FieldOffset(Offset = "0x39")]
		public bool use2D;

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000344")]
		[FieldOffset(Offset = "0x40")]
		private Camera cam;
	}
}
