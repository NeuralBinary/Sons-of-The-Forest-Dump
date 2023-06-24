using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200014C RID: 332
	[Token(Token = "0x200014C")]
	public class ObiDistanceFieldShapeTracker : ObiShapeTracker
	{
		// Token: 0x06000689 RID: 1673 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x612090", Offset = "0x610690", VA = "0x180612090")]
		public ObiDistanceFieldShapeTracker(ObiCollider source, Component collider, ObiDistanceField distanceField)
		{
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x27C61F0", Offset = "0x27C47F0", VA = "0x1827C61F0")]
		public void UpdateDistanceFieldData()
		{
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0000431C File Offset: 0x0000251C
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x27C6230", Offset = "0x27C4830", VA = "0x1827C6230", Slot = "5")]
		public override bool UpdateIfNeeded()
		{
			return default(bool);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x27C6BF0", Offset = "0x27C51F0", VA = "0x1827C6BF0", Slot = "4")]
		public override void Destroy()
		{
		}

		// Token: 0x040005A5 RID: 1445
		[Token(Token = "0x40005A5")]
		[FieldOffset(Offset = "0x20")]
		public ObiDistanceField distanceField;

		// Token: 0x040005A6 RID: 1446
		[Token(Token = "0x40005A6")]
		[FieldOffset(Offset = "0x28")]
		private ObiDistanceFieldHandle handle;
	}
}
