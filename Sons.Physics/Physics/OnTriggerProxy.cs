using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Physics
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[AddComponentMenu("Sons/Physics/OnTriggerProxy")]
	public class OnTriggerProxy : MonoBehaviour
	{
		// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x31049A0", Offset = "0x3102FA0", VA = "0x1831049A0")]
		public void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x31049C0", Offset = "0x3102FC0", VA = "0x1831049C0")]
		public void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x31049E0", Offset = "0x3102FE0", VA = "0x1831049E0")]
		public void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x21BE6D0", Offset = "0x21BCCD0", VA = "0x1821BE6D0")]
		public void SetBlock(bool value)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public OnTriggerProxy()
		{
		}

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x20")]
		public Action<Collider> OnTriggerEnterProxy;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x28")]
		public Action<Collider> OnTriggerStayProxy;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x30")]
		public Action<Collider> OnTriggerExitProxy;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x38")]
		private bool _block;
	}
}
