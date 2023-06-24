using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Utils
{
	// Token: 0x020003AE RID: 942
	[Token(Token = "0x20003AE")]
	public class FakeParentCleanup : MonoBehaviour
	{
		// Token: 0x0600194C RID: 6476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600194C")]
		[Address(RVA = "0x3292400", Offset = "0x3290A00", VA = "0x183292400")]
		public void AddFakeParentComponent(FakeParent component)
		{
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600194D")]
		[Address(RVA = "0x32925A0", Offset = "0x3290BA0", VA = "0x1832925A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600194E")]
		[Address(RVA = "0x3292810", Offset = "0x3290E10", VA = "0x183292810")]
		public FakeParentCleanup()
		{
		}

		// Token: 0x040018CC RID: 6348
		[Token(Token = "0x40018CC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<FakeParent> _fakeParents;
	}
}
