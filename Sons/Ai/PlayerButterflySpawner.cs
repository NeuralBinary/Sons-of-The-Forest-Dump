using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x0200096C RID: 2412
	[Token(Token = "0x200096C")]
	public class PlayerButterflySpawner : ButterflySpawner
	{
		// Token: 0x060045DE RID: 17886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045DE")]
		[Address(RVA = "0x366CE50", Offset = "0x366B450", VA = "0x18366CE50")]
		public static void SetDebugEnabled(bool value)
		{
		}

		// Token: 0x060045DF RID: 17887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045DF")]
		[Address(RVA = "0x366CE90", Offset = "0x366B490", VA = "0x18366CE90")]
		private void CalculateNextSpawnTimer()
		{
		}

		// Token: 0x060045E0 RID: 17888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E0")]
		[Address(RVA = "0x366CED0", Offset = "0x366B4D0", VA = "0x18366CED0")]
		private void Update()
		{
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E1")]
		[Address(RVA = "0x366D2A0", Offset = "0x366B8A0", VA = "0x18366D2A0")]
		private void UpdateDebug()
		{
		}

		// Token: 0x060045E2 RID: 17890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E2")]
		[Address(RVA = "0x366D4C0", Offset = "0x366BAC0", VA = "0x18366D4C0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060045E3 RID: 17891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E3")]
		[Address(RVA = "0x366D690", Offset = "0x366BC90", VA = "0x18366D690")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E4")]
		[Address(RVA = "0x366D730", Offset = "0x366BD30", VA = "0x18366D730")]
		private void Trigger()
		{
		}

		// Token: 0x060045E5 RID: 17893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E5")]
		[Address(RVA = "0x366D8B0", Offset = "0x366BEB0", VA = "0x18366D8B0")]
		private void OnDisable()
		{
		}

		// Token: 0x060045E6 RID: 17894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E6")]
		[Address(RVA = "0x366D9D0", Offset = "0x366BFD0", VA = "0x18366D9D0")]
		private void ButterflyFinished(ButterflyController controller, Transform target)
		{
		}

		// Token: 0x060045E7 RID: 17895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E7")]
		[Address(RVA = "0x366D9E0", Offset = "0x366BFE0", VA = "0x18366D9E0")]
		private void CreateInstance()
		{
		}

		// Token: 0x060045E8 RID: 17896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E8")]
		[Address(RVA = "0x366DBB0", Offset = "0x366C1B0", VA = "0x18366DBB0")]
		public void RegisterLocation(ButterflyLandLocation butterflyLandLocation)
		{
		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E9")]
		[Address(RVA = "0x366DCB0", Offset = "0x366C2B0", VA = "0x18366DCB0")]
		public void UnregisterLocation(ButterflyLandLocation butterflyLandLocation)
		{
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045EA")]
		[Address(RVA = "0x366DD20", Offset = "0x366C320", VA = "0x18366DD20")]
		public PlayerButterflySpawner()
		{
		}

		// Token: 0x04004870 RID: 18544
		[Token(Token = "0x4004870")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<ButterflyLandLocation> _locations;

		// Token: 0x04004871 RID: 18545
		[Token(Token = "0x4004871")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _minSpawnTime;

		// Token: 0x04004872 RID: 18546
		[Token(Token = "0x4004872")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _maxSpawnTime;

		// Token: 0x04004873 RID: 18547
		[Token(Token = "0x4004873")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _debugEnabled;

		// Token: 0x04004874 RID: 18548
		[Token(Token = "0x4004874")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _debugGroup;

		// Token: 0x04004875 RID: 18549
		[Token(Token = "0x4004875")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TMP_Text _debugReadout;

		// Token: 0x04004876 RID: 18550
		[Token(Token = "0x4004876")]
		[FieldOffset(Offset = "0x78")]
		private List<Collider> _trackedColliders;

		// Token: 0x04004877 RID: 18551
		[Token(Token = "0x4004877")]
		[FieldOffset(Offset = "0x80")]
		private float _nextSpawn;

		// Token: 0x04004878 RID: 18552
		[Token(Token = "0x4004878")]
		[FieldOffset(Offset = "0x0")]
		private static bool _staticDebugEnabled;

		// Token: 0x04004879 RID: 18553
		[Token(Token = "0x4004879")]
		[FieldOffset(Offset = "0x84")]
		private float _spawnTimer;
	}
}
