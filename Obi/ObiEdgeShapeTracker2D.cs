using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000148 RID: 328
	[Token(Token = "0x2000148")]
	public class ObiEdgeShapeTracker2D : ObiShapeTracker
	{
		// Token: 0x0600067D RID: 1661 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x992FC0", Offset = "0x9915C0", VA = "0x180992FC0")]
		public ObiEdgeShapeTracker2D(ObiCollider2D source, EdgeCollider2D collider)
		{
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x27C3FD0", Offset = "0x27C25D0", VA = "0x1827C3FD0")]
		public void UpdateEdgeData()
		{
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0000428C File Offset: 0x0000248C
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x27C4010", Offset = "0x27C2610", VA = "0x1827C4010", Slot = "5")]
		public override bool UpdateIfNeeded()
		{
			return default(bool);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x27C4770", Offset = "0x27C2D70", VA = "0x1827C4770", Slot = "4")]
		public override void Destroy()
		{
		}

		// Token: 0x040005A4 RID: 1444
		[Token(Token = "0x40005A4")]
		[FieldOffset(Offset = "0x20")]
		private ObiEdgeMeshHandle handle;
	}
}
