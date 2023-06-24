using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.WaterObjects
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[RequireComponent(typeof(Rigidbody))]
	public class MassFromChildren : MonoBehaviour
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x26FDB70", Offset = "0x26FC170", VA = "0x1826FDB70")]
		public void Calculate()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public MassFromChildren()
		{
		}

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x20")]
		private Rigidbody _rb;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x28")]
		private string _result;
	}
}
