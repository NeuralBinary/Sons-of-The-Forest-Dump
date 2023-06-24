using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Physics
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	[AddComponentMenu("Sons/Physics/OnCollisionProxy")]
	public class OnCollisionProxy : MonoBehaviour
	{
		// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000091")]
		[Address(RVA = "0xFC63A0", Offset = "0xFC49A0", VA = "0x180FC63A0")]
		public void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x3104960", Offset = "0x3102F60", VA = "0x183104960")]
		public void OnCollisionStay(Collision collision)
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x3104980", Offset = "0x3102F80", VA = "0x183104980")]
		public void OnCollisionExit(Collision collision)
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public OnCollisionProxy()
		{
		}

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x20")]
		public Action<Collision> OnCollisionEnterProxy;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x28")]
		public Action<Collision> OnCollisionStayProxy;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x30")]
		public Action<Collision> OnCollisionExitProxy;
	}
}
