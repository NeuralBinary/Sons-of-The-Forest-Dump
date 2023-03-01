using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Tools
{
	// Token: 0x0200042C RID: 1068
	[Token(Token = "0x200042C")]
	public class ShowBounds : MonoBehaviour
	{
		// Token: 0x06001B83 RID: 7043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B83")]
		[Address(RVA = "0x2CED010", Offset = "0x2CEC010", VA = "0x182CED010")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B84")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ShowBounds()
		{
		}

		// Token: 0x04001AB9 RID: 6841
		[Token(Token = "0x4001AB9")]
		[FieldOffset(Offset = "0x20")]
		public Bounds b;
	}
}
