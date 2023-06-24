using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	public class CloudPresetMapper : MonoBehaviour
	{
		// Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025C")]
		[Address(RVA = "0xAC1BF0", Offset = "0xAC01F0", VA = "0x180AC1BF0")]
		public void Map(string filepath)
		{
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void LoadSourcePreset(string filepath)
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		public void LoadTargetPreset(string filepath)
		{
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025F")]
		[Address(RVA = "0xAC1F80", Offset = "0xAC0580", VA = "0x180AC1F80")]
		public CloudPresetMapper()
		{
		}

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x20")]
		public string m_sourcePreset;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x28")]
		public string m_targetPreset;
	}
}
