using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	public class SphereGizmoTransform : MonoBehaviour
	{
		// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000071")]
		[Address(RVA = "0xA66760", Offset = "0xA64D60", VA = "0x180A66760")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000072")]
		[Address(RVA = "0xA66770", Offset = "0xA64D70", VA = "0x180A66770")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000073")]
		[Address(RVA = "0xA66780", Offset = "0xA64D80", VA = "0x180A66780")]
		private void DrawGizmos()
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000074")]
		[Address(RVA = "0xA66CA0", Offset = "0xA652A0", VA = "0x180A66CA0")]
		public SphereGizmoTransform()
		{
		}

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _onSelectedOnly;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _radius;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _solid;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _wireFrame;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Color _solidColor;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Color _wireFrameColor;
	}
}
