using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000150 RID: 336
	[Token(Token = "0x2000150")]
	public class ObiTerrainShapeTracker : ObiShapeTracker
	{
		// Token: 0x06000696 RID: 1686 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x992FC0", Offset = "0x9915C0", VA = "0x180992FC0")]
		public ObiTerrainShapeTracker(ObiCollider source, TerrainCollider collider)
		{
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x27C7C50", Offset = "0x27C6250", VA = "0x1827C7C50")]
		public void UpdateHeightData()
		{
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00004364 File Offset: 0x00002564
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x27C7C90", Offset = "0x27C6290", VA = "0x1827C7C90", Slot = "5")]
		public override bool UpdateIfNeeded()
		{
			return default(bool);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x27C84E0", Offset = "0x27C6AE0", VA = "0x1827C84E0", Slot = "4")]
		public override void Destroy()
		{
		}

		// Token: 0x040005AA RID: 1450
		[Token(Token = "0x40005AA")]
		[FieldOffset(Offset = "0x20")]
		private bool heightmapDataHasChanged;

		// Token: 0x040005AB RID: 1451
		[Token(Token = "0x40005AB")]
		[FieldOffset(Offset = "0x28")]
		private ObiHeightFieldHandle handle;
	}
}
