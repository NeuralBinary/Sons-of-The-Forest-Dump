using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000661 RID: 1633
	[Token(Token = "0x2000661")]
	public class BirdHouseFeatherSpawner : MonoBehaviour
	{
		// Token: 0x060029CC RID: 10700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CC")]
		[Address(RVA = "0x2DC6300", Offset = "0x2DC5300", VA = "0x182DC6300")]
		private void OnEnable()
		{
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CD")]
		[Address(RVA = "0x2DC62A0", Offset = "0x2DC52A0", VA = "0x182DC62A0")]
		private void InvokeSpawn()
		{
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CE")]
		[Address(RVA = "0x2DC6420", Offset = "0x2DC5420", VA = "0x182DC6420")]
		private void SpawnFeather()
		{
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CF")]
		[Address(RVA = "0x2DC64F0", Offset = "0x2DC54F0", VA = "0x182DC64F0")]
		private void Update()
		{
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D0")]
		[Address(RVA = "0x2DC6770", Offset = "0x2DC5770", VA = "0x182DC6770")]
		public BirdHouseFeatherSpawner()
		{
		}

		// Token: 0x0400256E RID: 9582
		[Token(Token = "0x400256E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InWorldLayoutItemGroup _inWorldLayoutItemGroup;

		// Token: 0x0400256F RID: 9583
		[Token(Token = "0x400256F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 _timeToSpawnRangeSeconds;

		// Token: 0x04002570 RID: 9584
		[Token(Token = "0x4002570")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<LandingSpotStimuli> _landingStimuli;

		// Token: 0x04002571 RID: 9585
		[Token(Token = "0x4002571")]
		[FieldOffset(Offset = "0x38")]
		private Random _random;

		// Token: 0x04002572 RID: 9586
		[Token(Token = "0x4002572")]
		[FieldOffset(Offset = "0x40")]
		private bool _birdhouseIsOccupied;
	}
}
