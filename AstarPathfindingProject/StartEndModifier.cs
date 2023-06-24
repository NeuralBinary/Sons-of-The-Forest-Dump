using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000DC RID: 220
	[Token(Token = "0x20000DC")]
	[Serializable]
	public class StartEndModifier : PathModifier
	{
		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00005A14 File Offset: 0x00003C14
		[Token(Token = "0x17000134")]
		public override int Order
		{
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x6C9C30", Offset = "0x6C8230", VA = "0x1806C9C30", Slot = "9")]
		public override void Apply(Path _p)
		{
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00005A2C File Offset: 0x00003C2C
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x6C9F20", Offset = "0x6C8520", VA = "0x1806C9F20")]
		private Vector3 Snap(ABPath path, StartEndModifier.Exactness mode, bool start, out bool forceAddPoint, out int closestConnectionIndex)
		{
			return default(Vector3);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00005A44 File Offset: 0x00003C44
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x6CA730", Offset = "0x6C8D30", VA = "0x1806CA730")]
		protected Vector3 GetClampedPoint(Vector3 from, Vector3 to, GraphNode hint)
		{
			return default(Vector3);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x6CA990", Offset = "0x6C8F90", VA = "0x1806CA990")]
		public StartEndModifier()
		{
		}

		// Token: 0x04000534 RID: 1332
		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x18")]
		public bool addPoints;

		// Token: 0x04000535 RID: 1333
		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x1C")]
		public StartEndModifier.Exactness exactStartPoint;

		// Token: 0x04000536 RID: 1334
		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x20")]
		public StartEndModifier.Exactness exactEndPoint;

		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x28")]
		public Func<Vector3> adjustStartPoint;

		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x30")]
		public bool useRaycasting;

		// Token: 0x04000539 RID: 1337
		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x34")]
		public LayerMask mask;

		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x38")]
		public bool useGraphRaycasting;

		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x40")]
		private List<GraphNode> connectionBuffer;

		// Token: 0x0400053C RID: 1340
		[Token(Token = "0x400053C")]
		[FieldOffset(Offset = "0x48")]
		private Action<GraphNode> connectionBufferAddDelegate;

		// Token: 0x020000DD RID: 221
		[Token(Token = "0x20000DD")]
		public enum Exactness
		{
			// Token: 0x0400053E RID: 1342
			[Token(Token = "0x400053E")]
			SnapToNode,
			// Token: 0x0400053F RID: 1343
			[Token(Token = "0x400053F")]
			Original,
			// Token: 0x04000540 RID: 1344
			[Token(Token = "0x4000540")]
			Interpolate,
			// Token: 0x04000541 RID: 1345
			[Token(Token = "0x4000541")]
			ClosestOnNode,
			// Token: 0x04000542 RID: 1346
			[Token(Token = "0x4000542")]
			NodeConnection
		}
	}
}
