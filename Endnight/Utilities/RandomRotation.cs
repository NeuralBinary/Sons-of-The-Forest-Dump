using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public class RandomRotation : MonoBehaviour
	{
		// Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xA8AE20", Offset = "0xA89420", VA = "0x180A8AE20")]
		private void Awake()
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xA8AE30", Offset = "0xA89430", VA = "0x180A8AE30")]
		private void Apply()
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public RandomRotation()
		{
		}

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _rotationMin;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 _rotationMax;
	}
}
