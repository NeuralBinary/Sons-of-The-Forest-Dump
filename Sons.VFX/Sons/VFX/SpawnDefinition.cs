using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.VFX
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	[Serializable]
	internal class SpawnDefinition
	{
		// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x316FF90", Offset = "0x316E590", VA = "0x18316FF90")]
		public void Spawn()
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SpawnDefinition()
		{
		}

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject _source;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _location;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _parent;
	}
}
