using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Testing
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class ScreenshotTester : MonoBehaviour
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x3147F10", Offset = "0x3146510", VA = "0x183147F10")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x3148210", Offset = "0x3146810", VA = "0x183148210")]
		public ScreenshotTester()
		{
		}

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Min(1f)]
		private int _superSize;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _exifComment;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _path;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Camera _camera;
	}
}
