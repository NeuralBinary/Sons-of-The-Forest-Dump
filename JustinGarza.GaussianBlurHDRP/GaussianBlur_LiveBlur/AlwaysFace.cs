using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GaussianBlur_LiveBlur
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public class AlwaysFace : MonoBehaviour
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2079720", Offset = "0x2077D20", VA = "0x182079720")]
		private void Start()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2079A50", Offset = "0x2078050", VA = "0x182079A50")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public AlwaysFace()
		{
		}

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Target;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x28")]
		public float Speed;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x2C")]
		public bool JustOnStart;
	}
}
