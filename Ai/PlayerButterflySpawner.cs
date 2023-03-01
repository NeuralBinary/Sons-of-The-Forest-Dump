using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x020008EB RID: 2283
	[Token(Token = "0x20008EB")]
	public class PlayerButterflySpawner : ButterflySpawner
	{
		// Token: 0x06003E0A RID: 15882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E0A")]
		[Address(RVA = "0x2F213D0", Offset = "0x2F203D0", VA = "0x182F213D0")]
		public static void SetDebugEnabled(bool value)
		{
		}

		// Token: 0x06003E0B RID: 15883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E0B")]
		[Address(RVA = "0x2F20EB0", Offset = "0x2F1FEB0", VA = "0x182F20EB0")]
		private void CalculateNextSpawnTimer()
		{
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E0C")]
		[Address(RVA = "0x2F21920", Offset = "0x2F20920", VA = "0x182F21920")]
		private void Update()
		{
		}

		// Token: 0x06003E0D RID: 15885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E0D")]
		[Address(RVA = "0x2F216A0", Offset = "0x2F206A0", VA = "0x182F216A0")]
		private void UpdateDebug()
		{
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E0E")]
		[Address(RVA = "0x2F210F0", Offset = "0x2F200F0", VA = "0x182F210F0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E0F")]
		[Address(RVA = "0x2F21280", Offset = "0x2F20280", VA = "0x182F21280")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06003E10 RID: 15888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E10")]
		[Address(RVA = "0x2F21410", Offset = "0x2F20410", VA = "0x182F21410")]
		private void Trigger()
		{
		}

		// Token: 0x06003E11 RID: 15889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E11")]
		[Address(RVA = "0x2F21020", Offset = "0x2F20020", VA = "0x182F21020")]
		private void OnDisable()
		{
		}

		// Token: 0x06003E12 RID: 15890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E12")]
		[Address(RVA = "0x2F20EA0", Offset = "0x2F1FEA0", VA = "0x182F20EA0")]
		private void ButterflyFinished(ButterflyController controller, Transform target)
		{
		}

		// Token: 0x06003E13 RID: 15891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E13")]
		[Address(RVA = "0x2F20EF0", Offset = "0x2F1FEF0", VA = "0x182F20EF0")]
		private void CreateInstance()
		{
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E14")]
		[Address(RVA = "0x2F21300", Offset = "0x2F20300", VA = "0x182F21300")]
		public void RegisterLocation(ButterflyLandLocation butterflyLandLocation)
		{
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E15")]
		[Address(RVA = "0x2F21630", Offset = "0x2F20630", VA = "0x182F21630")]
		public void UnregisterLocation(ButterflyLandLocation butterflyLandLocation)
		{
		}

		// Token: 0x06003E16 RID: 15894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E16")]
		[Address(RVA = "0x2F21AE0", Offset = "0x2F20AE0", VA = "0x182F21AE0")]
		public PlayerButterflySpawner()
		{
		}

		// Token: 0x040041E9 RID: 16873
		[Token(Token = "0x40041E9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<ButterflyLandLocation> _locations;

		// Token: 0x040041EA RID: 16874
		[Token(Token = "0x40041EA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _minSpawnTime;

		// Token: 0x040041EB RID: 16875
		[Token(Token = "0x40041EB")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _maxSpawnTime;

		// Token: 0x040041EC RID: 16876
		[Token(Token = "0x40041EC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _debugEnabled;

		// Token: 0x040041ED RID: 16877
		[Token(Token = "0x40041ED")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _debugGroup;

		// Token: 0x040041EE RID: 16878
		[Token(Token = "0x40041EE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TMP_Text _debugReadout;

		// Token: 0x040041EF RID: 16879
		[Token(Token = "0x40041EF")]
		[FieldOffset(Offset = "0x78")]
		private List<Collider> _trackedColliders;

		// Token: 0x040041F0 RID: 16880
		[Token(Token = "0x40041F0")]
		[FieldOffset(Offset = "0x80")]
		private float _nextSpawn;

		// Token: 0x040041F1 RID: 16881
		[Token(Token = "0x40041F1")]
		[FieldOffset(Offset = "0x0")]
		private static bool _staticDebugEnabled;

		// Token: 0x040041F2 RID: 16882
		[Token(Token = "0x40041F2")]
		[FieldOffset(Offset = "0x84")]
		private float _spawnTimer;
	}
}
