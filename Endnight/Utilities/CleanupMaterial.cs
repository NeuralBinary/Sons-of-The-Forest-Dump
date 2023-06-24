using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public class CleanupMaterial : MonoBehaviour
	{
		// Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x7AAFD0", Offset = "0x7A95D0", VA = "0x1807AAFD0")]
		public void ShouldDestroy(bool value)
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		public void SetMaterial(Material material)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xA6C9E0", Offset = "0xA6AFE0", VA = "0x180A6C9E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x7951A0", Offset = "0x7937A0", VA = "0x1807951A0")]
		public CleanupMaterial()
		{
		}

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _onDestroy;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Material _material;
	}
}
