using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public class CustomGizmoTransform : MonoBehaviour
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000052")]
		[Address(RVA = "0xA636C0", Offset = "0xA61CC0", VA = "0x180A636C0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000053")]
		[Address(RVA = "0xA636D0", Offset = "0xA61CD0", VA = "0x180A636D0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000054")]
		[Address(RVA = "0xA636E0", Offset = "0xA61CE0", VA = "0x180A636E0")]
		private void DrawGizmos()
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000055")]
		[Address(RVA = "0xA63DE0", Offset = "0xA623E0", VA = "0x180A63DE0")]
		public CustomGizmoTransform()
		{
		}

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _onSelectedOnly;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _scale;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _length;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _thickness;
	}
}
