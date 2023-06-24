using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Internal
{
	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	[ExecuteInEditMode]
	[AddComponentMenu("NGUI/Internal/Snapshot Point")]
	public class UISnapshotPoint : MonoBehaviour
	{
		// Token: 0x0600057A RID: 1402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x26A0230", Offset = "0x269E830", VA = "0x1826A0230")]
		private void Start()
		{
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x26A02C0", Offset = "0x269E8C0", VA = "0x1826A02C0")]
		public UISnapshotPoint()
		{
		}

		// Token: 0x040003B2 RID: 946
		[Token(Token = "0x40003B2")]
		[FieldOffset(Offset = "0x20")]
		public bool isOrthographic;

		// Token: 0x040003B3 RID: 947
		[Token(Token = "0x40003B3")]
		[FieldOffset(Offset = "0x24")]
		public float nearClip;

		// Token: 0x040003B4 RID: 948
		[Token(Token = "0x40003B4")]
		[FieldOffset(Offset = "0x28")]
		public float farClip;

		// Token: 0x040003B5 RID: 949
		[Token(Token = "0x40003B5")]
		[FieldOffset(Offset = "0x2C")]
		[Range(10f, 80f)]
		public int fieldOfView;

		// Token: 0x040003B6 RID: 950
		[Token(Token = "0x40003B6")]
		[FieldOffset(Offset = "0x30")]
		public float orthoSize;

		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x40003B7")]
		[FieldOffset(Offset = "0x38")]
		public Texture2D thumbnail;
	}
}
