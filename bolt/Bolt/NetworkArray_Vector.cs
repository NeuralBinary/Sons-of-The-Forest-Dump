using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Bolt
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	[Documentation]
	public class NetworkArray_Vector : NetworkArray_Values<Vector3>
	{
		// Token: 0x06000521 RID: 1313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x8EBB10", Offset = "0x8EA110", VA = "0x1808EBB10")]
		internal NetworkArray_Vector(int length, int stride)
		{
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x000039C0 File Offset: 0x00001BC0
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x8EBBF0", Offset = "0x8EA1F0", VA = "0x1808EBBF0", Slot = "7")]
		protected override Vector3 GetValue(int index)
		{
			return default(Vector3);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x000039D8 File Offset: 0x00001BD8
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x8EBC60", Offset = "0x8EA260", VA = "0x1808EBC60", Slot = "8")]
		protected override bool SetValue(int index, Vector3 value)
		{
			return default(bool);
		}
	}
}
