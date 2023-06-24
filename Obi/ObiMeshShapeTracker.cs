using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200014D RID: 333
	[Token(Token = "0x200014D")]
	public class ObiMeshShapeTracker : ObiShapeTracker
	{
		// Token: 0x0600068D RID: 1677 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x992FC0", Offset = "0x9915C0", VA = "0x180992FC0")]
		public ObiMeshShapeTracker(ObiCollider source, MeshCollider collider)
		{
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x27C6C60", Offset = "0x27C5260", VA = "0x1827C6C60")]
		public void UpdateMeshData()
		{
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00004334 File Offset: 0x00002534
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x27C6CA0", Offset = "0x27C52A0", VA = "0x1827C6CA0", Slot = "5")]
		public override bool UpdateIfNeeded()
		{
			return default(bool);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x27C7500", Offset = "0x27C5B00", VA = "0x1827C7500", Slot = "4")]
		public override void Destroy()
		{
		}

		// Token: 0x040005A7 RID: 1447
		[Token(Token = "0x40005A7")]
		[FieldOffset(Offset = "0x20")]
		private ObiTriangleMeshHandle handle;
	}
}
