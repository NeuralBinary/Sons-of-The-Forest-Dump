using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	[ExecuteInEditMode]
	[Serializable]
	public class CreativeStars : MonoBehaviour
	{
		// Token: 0x06000258 RID: 600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000258")]
		[Address(RVA = "0xAC18A0", Offset = "0xABFEA0", VA = "0x180AC18A0")]
		private void Update()
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000259")]
		[Address(RVA = "0xAC18F0", Offset = "0xABFEF0", VA = "0x180AC18F0")]
		public CreativeStars()
		{
		}

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x20")]
		public ProceduralStarsBlock m_starsBlock;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x28")]
		[Min(0f)]
		public float m_brightness;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float m_density;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float m_size;
	}
}
