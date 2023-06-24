using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ballistics
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public class PoolingObject : MonoBehaviour
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x90AAE0", Offset = "0x9090E0", VA = "0x18090AAE0")]
		public void SetID(GameObject parent)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
		public int GetID()
		{
			return 0;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x90AB10", Offset = "0x909110", VA = "0x18090AB10")]
		public void Deactivate()
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public virtual void ReAwake()
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PoolingObject()
		{
		}

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x20")]
		private int parentID;
	}
}
