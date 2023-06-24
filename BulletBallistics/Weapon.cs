using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Ballistics
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	public class Weapon : MonoBehaviour
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x90D610", Offset = "0x90BC10", VA = "0x18090D610")]
		private void Awake()
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x90D690", Offset = "0x90BC90", VA = "0x18090D690", Slot = "4")]
		public virtual void Shoot(Vector3 direction, float zeroAngle = 0f)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x90DD40", Offset = "0x90C340", VA = "0x18090DD40")]
		public bool cacheBulletHandler()
		{
			return default(bool);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x90DE50", Offset = "0x90C450", VA = "0x18090DE50")]
		public float calculateZeroingAngle(float distance, int iterations = 4, float deltaDist = 1f, float simulationTimeStep = 0.015f, int simulationIterations = 1000)
		{
			return 0f;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x90E000", Offset = "0x90C600", VA = "0x18090E000")]
		public Weapon()
		{
		}

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x20")]
		public Transform visualSpawnPoint;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x28")]
		public Transform physicalSpawnPoint;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x30")]
		public float lifetime;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public BulletInfo bulletInfo;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public Bullet bulletPrefab;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public UnityEvent onShoot;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x50")]
		protected BulletHandler bulletHandler_;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x58")]
		protected PoolingManager poolManager_;
	}
}
