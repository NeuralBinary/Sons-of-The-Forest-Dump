using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Assemblies.Sons.VFX
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public class TreeDetailDistribution : MonoBehaviour
	{
		// Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x317DD90", Offset = "0x317C390", VA = "0x18317DD90")]
		private void OnValidate()
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x317DE40", Offset = "0x317C440", VA = "0x18317DE40")]
		public void AddDistribution(GameObject target, MapDistributionData distribution)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x317E2E0", Offset = "0x317C8E0", VA = "0x18317E2E0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TreeDetailDistribution()
		{
		}

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObjectDistributionPair> _distributions;
	}
}
