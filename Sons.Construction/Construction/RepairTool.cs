using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000082")]
	public class RepairTool : MonoBehaviour
	{
		// Token: 0x06000367 RID: 871 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
		private void Update()
		{
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x2DC35B0", Offset = "0x2DC1BB0", VA = "0x182DC35B0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public RepairTool()
		{
		}

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClipProfile _repairedSfx;

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClipProfile _repairComplete;
	}
}
