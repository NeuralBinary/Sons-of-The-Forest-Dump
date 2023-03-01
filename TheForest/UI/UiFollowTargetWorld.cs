using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x02000410 RID: 1040
	[Token(Token = "0x2000410")]
	public class UiFollowTargetWorld : MonoBehaviour
	{
		// Token: 0x06001B33 RID: 6963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B33")]
		[Address(RVA = "0x2CF2F40", Offset = "0x2CF1F40", VA = "0x182CF2F40")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B34")]
		[Address(RVA = "0x62C050", Offset = "0x62B050", VA = "0x18062C050")]
		public UiFollowTargetWorld()
		{
		}

		// Token: 0x04001A7F RID: 6783
		[Token(Token = "0x4001A7F")]
		[FieldOffset(Offset = "0x20")]
		public UiFollowTarget _uiFollow;

		// Token: 0x04001A80 RID: 6784
		[Token(Token = "0x4001A80")]
		[FieldOffset(Offset = "0x28")]
		public GameObject _visibilityFilter;

		// Token: 0x04001A81 RID: 6785
		[Token(Token = "0x4001A81")]
		[FieldOffset(Offset = "0x30")]
		public bool _alignWithUpAxis;
	}
}
