using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.VFX
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	public class SpawnAsRigidsInCluster : MonoBehaviour
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x3174150", Offset = "0x3172750", VA = "0x183174150")]
		private void SpawnRigids()
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x3174950", Offset = "0x3172F50", VA = "0x183174950")]
		private void DestroySpawned()
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x3174AE0", Offset = "0x31730E0", VA = "0x183174AE0")]
		private IEnumerator Countdown(int seconds)
		{
			return null;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x3174BA0", Offset = "0x31731A0", VA = "0x183174BA0")]
		private IEnumerator DestroyAfterTime()
		{
			return null;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void Start()
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x3174BE0", Offset = "0x31731E0", VA = "0x183174BE0")]
		private void OnEnable()
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x3174DA0", Offset = "0x31733A0", VA = "0x183174DA0")]
		public SpawnAsRigidsInCluster()
		{
		}

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x20")]
		public GameObject[] ObjectsToSpawn;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x28")]
		public int ObjectCountMin;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x2C")]
		public int ObjectCountMax;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x30")]
		public float SpawnAreaRadius;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x34")]
		public float ObjectSizeMult;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x38")]
		public float ObjectLifetime;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x40")]
		public GameObject FX;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x48")]
		private List<float> ObjectAge;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x50")]
		private List<GameObject> SpawnedObjects;
	}
}
