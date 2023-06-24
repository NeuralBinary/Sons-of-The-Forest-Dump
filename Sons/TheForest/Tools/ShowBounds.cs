using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Tools
{
	// Token: 0x0200041E RID: 1054
	[Token(Token = "0x200041E")]
	public class ShowBounds : MonoBehaviour
	{
		// Token: 0x06001BC1 RID: 7105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC1")]
		[Address(RVA = "0x32BC120", Offset = "0x32BA720", VA = "0x1832BC120")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC2")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ShowBounds()
		{
		}

		// Token: 0x04001ADD RID: 6877
		[Token(Token = "0x4001ADD")]
		[FieldOffset(Offset = "0x20")]
		public Bounds b;
	}
}
