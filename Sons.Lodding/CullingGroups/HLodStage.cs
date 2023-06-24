using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Lodding.CullingGroups
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	[Serializable]
	public class HLodStage
	{
		// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x30CE1B0", Offset = "0x30CC7B0", VA = "0x1830CE1B0")]
		public void SetActive(bool value)
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x30CE330", Offset = "0x30CC930", VA = "0x1830CE330")]
		public HLodStage()
		{
		}

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<Vector4> _boundingSpheres;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<GameObject> _objects;
	}
}
