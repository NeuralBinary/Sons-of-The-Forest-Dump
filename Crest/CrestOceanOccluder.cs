using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	public class CrestOceanOccluder : MonoBehaviour
	{
		// Token: 0x06000059 RID: 89 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x9CDF50", Offset = "0x9CC550", VA = "0x1809CDF50")]
		public Bounds GetBounds()
		{
			return default(Bounds);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x9CDF70", Offset = "0x9CC570", VA = "0x1809CDF70")]
		public void SetBounds(Bounds bounds)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public CrestOceanOccluder()
		{
		}

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Bounds _bounds;
	}
}
