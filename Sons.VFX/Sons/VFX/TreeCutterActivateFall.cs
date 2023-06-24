using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.VFX
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	public class TreeCutterActivateFall : MonoBehaviour
	{
		// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x3175460", Offset = "0x3173A60", VA = "0x183175460")]
		private void Start()
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x31758D0", Offset = "0x3173ED0", VA = "0x1831758D0")]
		private void Update()
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x31760A0", Offset = "0x31746A0", VA = "0x1831760A0")]
		public TreeCutterActivateFall()
		{
		}

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x20")]
		public int CutPercentageRequired;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x28")]
		private List<GameObject> chunks;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x30")]
		private List<Rigidbody> chunkRBDs;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x38")]
		private int chunkCount;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x3C")]
		private int chunkActiveCount;
	}
}
