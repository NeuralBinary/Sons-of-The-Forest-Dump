using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Physics
{
	// Token: 0x0200008A RID: 138
	[Token(Token = "0x200008A")]
	[AddComponentMenu("Endnight/Physics/KillBox")]
	public class KillBox : MonoBehaviour
	{
		// Token: 0x06000306 RID: 774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000306")]
		[Address(RVA = "0xA988A0", Offset = "0xA96EA0", VA = "0x180A988A0")]
		private void Update()
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000307")]
		[Address(RVA = "0xA98C10", Offset = "0xA97210", VA = "0x180A98C10")]
		private void OnValidate()
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000308")]
		[Address(RVA = "0xA98CC0", Offset = "0xA972C0", VA = "0x180A98CC0")]
		private void Generate()
		{
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000309")]
		[Address(RVA = "0xA98CF0", Offset = "0xA972F0", VA = "0x180A98CF0")]
		private void Clear()
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030A")]
		[Address(RVA = "0xA98D20", Offset = "0xA97320", VA = "0x180A98D20")]
		public static void EnableColliderMode(bool enable)
		{
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030B")]
		[Address(RVA = "0xA98D50", Offset = "0xA97350", VA = "0x180A98D50")]
		private void EnableColliderModeInternal(bool enable)
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030C")]
		[Address(RVA = "0xA99660", Offset = "0xA97C60", VA = "0x180A99660")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600030D")]
		[Address(RVA = "0xA99810", Offset = "0xA97E10", VA = "0x180A99810")]
		private static KillBox Instance()
		{
			return null;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030E")]
		[Address(RVA = "0xA99A10", Offset = "0xA98010", VA = "0x180A99A10")]
		private void PurgeList()
		{
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030F")]
		[Address(RVA = "0xA99BF0", Offset = "0xA981F0", VA = "0x180A99BF0")]
		public static void Register(Transform t)
		{
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000310")]
		[Address(RVA = "0xA99C50", Offset = "0xA98250", VA = "0x180A99C50")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000311")]
		[Address(RVA = "0xA99D70", Offset = "0xA98370", VA = "0x180A99D70")]
		public KillBox()
		{
		}

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x0")]
		private static KillBox _instance;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x8")]
		private static bool _isInitialized;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _killDepth;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _worldSize;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 _colliderSize;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<Transform> _transforms;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<BoxCollider> _colliders;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x48")]
		private Rigidbody _rigidbody;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x50")]
		private int _lastIndexDone;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		private const int CountPerUpdate = 100;
	}
}
