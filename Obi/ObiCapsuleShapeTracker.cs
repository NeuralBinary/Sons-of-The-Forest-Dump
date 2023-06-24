using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200014A RID: 330
	[Token(Token = "0x200014A")]
	public class ObiCapsuleShapeTracker : ObiShapeTracker
	{
		// Token: 0x06000683 RID: 1667 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x27C4E80", Offset = "0x27C3480", VA = "0x1827C4E80")]
		public ObiCapsuleShapeTracker(ObiCollider source, CapsuleCollider collider)
		{
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x000042BC File Offset: 0x000024BC
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x27C4F40", Offset = "0x27C3540", VA = "0x1827C4F40", Slot = "5")]
		public override bool UpdateIfNeeded()
		{
			return default(bool);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x000042D4 File Offset: 0x000024D4
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x27C57E0", Offset = "0x27C3DE0", VA = "0x1827C57E0")]
		private int GetMaterialIndex(ObiColliderBase colliderBase)
		{
			return 0;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x000042EC File Offset: 0x000024EC
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x27C5980", Offset = "0x27C3F80", VA = "0x1827C5980")]
		private int GetRigidbodyIndex(ObiColliderBase colliderBase)
		{
			return 0;
		}
	}
}
