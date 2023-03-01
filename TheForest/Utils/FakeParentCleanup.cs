using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Utils
{
	// Token: 0x020003BC RID: 956
	[Token(Token = "0x20003BC")]
	public class FakeParentCleanup : MonoBehaviour
	{
		// Token: 0x06001911 RID: 6417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001911")]
		[Address(RVA = "0x2CC4140", Offset = "0x2CC3140", VA = "0x182CC4140")]
		public void AddFakeParentComponent(FakeParent component)
		{
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001912")]
		[Address(RVA = "0x2CC4270", Offset = "0x2CC3270", VA = "0x182CC4270")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001913")]
		[Address(RVA = "0x2CC43E0", Offset = "0x2CC33E0", VA = "0x182CC43E0")]
		public FakeParentCleanup()
		{
		}

		// Token: 0x040018AD RID: 6317
		[Token(Token = "0x40018AD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<FakeParent> _fakeParents;
	}
}
