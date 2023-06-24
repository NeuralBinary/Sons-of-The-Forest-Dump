using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	[AddComponentMenu("Sons/Vail/VailThrownObject")]
	public class VailThrownObject : VailCoopObject
	{
		// Token: 0x06000485 RID: 1157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x2B181C0", Offset = "0x2B167C0", VA = "0x182B181C0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x2B18300", Offset = "0x2B16900", VA = "0x182B18300")]
		public VailThrownObject()
		{
		}

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Rigidbody _rigidbody;
	}
}
