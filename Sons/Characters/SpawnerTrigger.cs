using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x0200070D RID: 1805
	[Token(Token = "0x200070D")]
	public class SpawnerTrigger : MonoBehaviour
	{
		// Token: 0x06002FF5 RID: 12277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF5")]
		[Address(RVA = "0x346A700", Offset = "0x3468D00", VA = "0x18346A700")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF6")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SpawnerTrigger()
		{
		}

		// Token: 0x0400298C RID: 10636
		[Token(Token = "0x400298C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VailBossSpawner _bossSpawner;

		// Token: 0x0400298D RID: 10637
		[Token(Token = "0x400298D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _isPufftonBossFight;
	}
}
