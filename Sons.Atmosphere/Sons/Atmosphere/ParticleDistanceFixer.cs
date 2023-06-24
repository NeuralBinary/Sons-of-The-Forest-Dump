using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	public class ParticleDistanceFixer : MonoBehaviour
	{
		// Token: 0x0600017A RID: 378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2D42A70", Offset = "0x2D41070", VA = "0x182D42A70")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2D42CF0", Offset = "0x2D412F0", VA = "0x182D42CF0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2D42E20", Offset = "0x2D41420", VA = "0x182D42E20")]
		public ParticleDistanceFixer()
		{
		}

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ParticleSystem _target;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _distanceTrigger;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _timer;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x30")]
		private float _lastUpdate;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 _lastPosition;
	}
}
