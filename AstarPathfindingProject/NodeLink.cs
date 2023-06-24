using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	[AddComponentMenu("Pathfinding/Link")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_node_link.php")]
	public class NodeLink : GraphModifier
	{
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AC")]
		public Transform Start
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AD")]
		public Transform End
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x660320", Offset = "0x65E920", VA = "0x180660320", Slot = "13")]
		public override void OnPostScan()
		{
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x660460", Offset = "0x65EA60", VA = "0x180660460")]
		public void InternalOnPostScan()
		{
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x660480", Offset = "0x65EA80", VA = "0x180660480", Slot = "18")]
		public override void OnGraphsPostUpdate()
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x6605B0", Offset = "0x65EBB0", VA = "0x1806605B0", Slot = "19")]
		public virtual void Apply()
		{
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x660BE0", Offset = "0x65F1E0", VA = "0x180660BE0")]
		public void OnDrawGizmos()
		{
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x660F40", Offset = "0x65F540", VA = "0x180660F40")]
		public NodeLink()
		{
		}

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x40")]
		public Transform end;

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x48")]
		public float costFactor;

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x4C")]
		public bool oneWay;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x4D")]
		public bool deleteConnection;
	}
}
