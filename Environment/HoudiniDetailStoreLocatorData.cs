using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x02000744 RID: 1860
	[Token(Token = "0x2000744")]
	public class HoudiniDetailStoreLocatorData : MonoBehaviour
	{
		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600305F RID: 12383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700060D")]
		public string WorldGroupId
		{
			[Token(Token = "0x600305F")]
			[Address(RVA = "0x2E34FC0", Offset = "0x2E33FC0", VA = "0x182E34FC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06003060 RID: 12384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700060E")]
		public string HLodId
		{
			[Token(Token = "0x6003060")]
			[Address(RVA = "0x2E34FB0", Offset = "0x2E33FB0", VA = "0x182E34FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003061")]
		[Address(RVA = "0x2E34EB0", Offset = "0x2E33EB0", VA = "0x182E34EB0")]
		public void PopulateLocatorData(ref string worldGroupId, ref string hLodId)
		{
		}

		// Token: 0x06003062 RID: 12386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003062")]
		[Address(RVA = "0x2E34F00", Offset = "0x2E33F00", VA = "0x182E34F00")]
		public void SetHLodId(string hLodId)
		{
		}

		// Token: 0x06003063 RID: 12387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003063")]
		[Address(RVA = "0x2E34F40", Offset = "0x2E33F40", VA = "0x182E34F40")]
		public HoudiniDetailStoreLocatorData()
		{
		}

		// Token: 0x04002A65 RID: 10853
		[Token(Token = "0x4002A65")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _overrideWorldGroupId;

		// Token: 0x04002A66 RID: 10854
		[Token(Token = "0x4002A66")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _worldGroupId;

		// Token: 0x04002A67 RID: 10855
		[Token(Token = "0x4002A67")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _overrideHLodId;

		// Token: 0x04002A68 RID: 10856
		[Token(Token = "0x4002A68")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _hLodId;
	}
}
