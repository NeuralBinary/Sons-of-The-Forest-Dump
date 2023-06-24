using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	public class KeepOnCamera : MonoBehaviour
	{
		// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x3007630", Offset = "0x3005C30", VA = "0x183007630")]
		private void OnValidate()
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x30078E0", Offset = "0x3005EE0", VA = "0x1830078E0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x3007C10", Offset = "0x3006210", VA = "0x183007C10")]
		public KeepOnCamera()
		{
		}

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera _sourceCamera;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 _viewBasePosition;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector3 _basePosition;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2 _relativeRes;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x48")]
		private int[] _lastRes;
	}
}
