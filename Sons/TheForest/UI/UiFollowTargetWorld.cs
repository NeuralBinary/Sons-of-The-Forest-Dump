using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x02000402 RID: 1026
	[Token(Token = "0x2000402")]
	public class UiFollowTargetWorld : MonoBehaviour
	{
		// Token: 0x06001B71 RID: 7025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B71")]
		[Address(RVA = "0x32B8020", Offset = "0x32B6620", VA = "0x1832B8020")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B72")]
		[Address(RVA = "0x6C2910", Offset = "0x6C0F10", VA = "0x1806C2910")]
		public UiFollowTargetWorld()
		{
		}

		// Token: 0x04001AA3 RID: 6819
		[Token(Token = "0x4001AA3")]
		[FieldOffset(Offset = "0x20")]
		public UiFollowTarget _uiFollow;

		// Token: 0x04001AA4 RID: 6820
		[Token(Token = "0x4001AA4")]
		[FieldOffset(Offset = "0x28")]
		public GameObject _visibilityFilter;

		// Token: 0x04001AA5 RID: 6821
		[Token(Token = "0x4001AA5")]
		[FieldOffset(Offset = "0x30")]
		public bool _alignWithUpAxis;
	}
}
