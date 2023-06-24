using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200077F RID: 1919
	[Token(Token = "0x200077F")]
	public class BirdHouseFeatherSpawner : MonoBehaviour
	{
		// Token: 0x060033BD RID: 13245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033BD")]
		[Address(RVA = "0x34BDED0", Offset = "0x34BC4D0", VA = "0x1834BDED0")]
		private void OnEnable()
		{
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033BE")]
		[Address(RVA = "0x34BE020", Offset = "0x34BC620", VA = "0x1834BE020")]
		private void InvokeSpawn()
		{
		}

		// Token: 0x060033BF RID: 13247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033BF")]
		[Address(RVA = "0x34BE0C0", Offset = "0x34BC6C0", VA = "0x1834BE0C0")]
		private void SpawnFeather()
		{
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C0")]
		[Address(RVA = "0x34BE160", Offset = "0x34BC760", VA = "0x1834BE160")]
		private void Update()
		{
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C1")]
		[Address(RVA = "0x34BE3B0", Offset = "0x34BC9B0", VA = "0x1834BE3B0")]
		public BirdHouseFeatherSpawner()
		{
		}

		// Token: 0x04002CC1 RID: 11457
		[Token(Token = "0x4002CC1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InWorldLayoutItemGroup _inWorldLayoutItemGroup;

		// Token: 0x04002CC2 RID: 11458
		[Token(Token = "0x4002CC2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 _timeToSpawnRangeSeconds;

		// Token: 0x04002CC3 RID: 11459
		[Token(Token = "0x4002CC3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<LandingSpotStimuli> _landingStimuli;

		// Token: 0x04002CC4 RID: 11460
		[Token(Token = "0x4002CC4")]
		[FieldOffset(Offset = "0x38")]
		private System.Random _random;

		// Token: 0x04002CC5 RID: 11461
		[Token(Token = "0x4002CC5")]
		[FieldOffset(Offset = "0x40")]
		private bool _birdhouseIsOccupied;
	}
}
