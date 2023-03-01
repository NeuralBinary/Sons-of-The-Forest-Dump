using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005FB RID: 1531
	[Token(Token = "0x20005FB")]
	public class InWorldAutoStorage : MonoBehaviour
	{
		// Token: 0x0600272C RID: 10028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272C")]
		[Address(RVA = "0x2DB79F0", Offset = "0x2DB69F0", VA = "0x182DB79F0")]
		private void Start()
		{
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272D")]
		[Address(RVA = "0x2DB7620", Offset = "0x2DB6620", VA = "0x182DB7620")]
		private void OnTriggerEnter(Collider c)
		{
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272E")]
		[Address(RVA = "0x2DB7A70", Offset = "0x2DB6A70", VA = "0x182DB7A70")]
		private IEnumerator TweenInPosition(Transform fromTr, GameObject layoutGo)
		{
			return null;
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272F")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public InWorldAutoStorage()
		{
		}

		// Token: 0x0400236F RID: 9071
		[Token(Token = "0x400236F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InWorldLayoutItemGroup _storage;
	}
}
