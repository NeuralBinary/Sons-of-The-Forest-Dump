using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	[Serializable]
	public struct CameraInfo
	{
		// Token: 0x0600014B RID: 331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x23B3690", Offset = "0x23B1C90", VA = "0x1823B3690")]
		public CameraInfo(Transform cameraTransform)
		{
		}

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int Stride;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x0")]
		public Vector4 Position;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x10")]
		public Vector4 Direction;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x20")]
		public Vector4 Up;
	}
}
