using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	public class SpawnPickup : MonoBehaviour
	{
		// Token: 0x0600007F RID: 127 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2F9D010", Offset = "0x2F9B610", VA = "0x182F9D010")]
		private void OnEnable()
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2F9D110", Offset = "0x2F9B710", VA = "0x182F9D110")]
		private void DoSpawn()
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2F9D210", Offset = "0x2F9B810", VA = "0x182F9D210")]
		private void Spawn(int i)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SpawnPickup()
		{
		}

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> _pickups;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<float> _chances;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _onEnable;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _matchTransform;
	}
}
