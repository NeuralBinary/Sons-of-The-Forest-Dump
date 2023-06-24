using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	[AddComponentMenu("Path-o-logical/PoolManager/Pre-Runtime Pool Item")]
	public class PreRuntimePoolItem : MonoBehaviour
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x28B59E0", Offset = "0x28B3FE0", VA = "0x1828B59E0")]
		private void Start()
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x28B5B90", Offset = "0x28B4190", VA = "0x1828B5B90")]
		public PreRuntimePoolItem()
		{
		}

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x20")]
		public string poolName;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x28")]
		public string prefabName;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x30")]
		public bool despawnOnStart;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x31")]
		public bool doNotReparent;
	}
}
