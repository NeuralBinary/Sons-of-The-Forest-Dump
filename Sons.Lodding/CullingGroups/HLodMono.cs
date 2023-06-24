using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Lodding.CullingGroups
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public class HLodMono : MonoBehaviour
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x30CC2B0", Offset = "0x30CA8B0", VA = "0x1830CC2B0")]
		private void OnEnable()
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x30CC480", Offset = "0x30CAA80", VA = "0x1830CC480")]
		private void OnRefreshLod(int previous, int current)
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x30CC570", Offset = "0x30CAB70", VA = "0x1830CC570")]
		private void OnDisable()
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public ObjectBoundingSphere GetObjectBoundingSphere()
		{
			return null;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x30CC6E0", Offset = "0x30CACE0", VA = "0x1830CC6E0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x30CC840", Offset = "0x30CAE40", VA = "0x1830CC840")]
		public HLodMono()
		{
		}

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ObjectBoundingSphere _boundingSphere;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<HLodStage> _stages;
	}
}
