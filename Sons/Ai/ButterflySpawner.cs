using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x0200096B RID: 2411
	[Token(Token = "0x200096B")]
	public class ButterflySpawner : MonoBehaviour
	{
		// Token: 0x060045D7 RID: 17879 RVA: 0x00015588 File Offset: 0x00013788
		[Token(Token = "0x60045D7")]
		[Address(RVA = "0x366C160", Offset = "0x366A760", VA = "0x18366C160", Slot = "4")]
		public virtual bool CanSpawn()
		{
			return default(bool);
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x060045D8 RID: 17880 RVA: 0x000155A0 File Offset: 0x000137A0
		[Token(Token = "0x17000918")]
		public bool HasActiveInstance
		{
			[Token(Token = "0x60045D8")]
			[Address(RVA = "0x366C230", Offset = "0x366A830", VA = "0x18366C230")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045D9")]
		[Address(RVA = "0x366C2F0", Offset = "0x366A8F0", VA = "0x18366C2F0")]
		public ButterflyController CreateInstance(Transform parent, Vector3 targetPositionOffset, Quaternion targetRotationOffset)
		{
			return null;
		}

		// Token: 0x060045DA RID: 17882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045DA")]
		[Address(RVA = "0x366CC50", Offset = "0x366B250", VA = "0x18366CC50")]
		internal void RemoveActiveInstance()
		{
		}

		// Token: 0x060045DB RID: 17883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045DB")]
		[Address(RVA = "0x366CD30", Offset = "0x366B330", VA = "0x18366CD30")]
		private void OnDisable()
		{
		}

		// Token: 0x060045DC RID: 17884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045DC")]
		[Address(RVA = "0xA98840", Offset = "0xA96E40", VA = "0x180A98840")]
		private void ButterflyFinished(ButterflyController controller, Transform target)
		{
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045DD")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ButterflySpawner()
		{
		}

		// Token: 0x0400486B RID: 18539
		[Token(Token = "0x400486B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ButterflyController _prefabSource;

		// Token: 0x0400486C RID: 18540
		[Token(Token = "0x400486C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 _instanceStartMin;

		// Token: 0x0400486D RID: 18541
		[Token(Token = "0x400486D")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector3 _instanceStartMax;

		// Token: 0x0400486E RID: 18542
		[Token(Token = "0x400486E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _velocityRoot;

		// Token: 0x0400486F RID: 18543
		[Token(Token = "0x400486F")]
		[FieldOffset(Offset = "0x48")]
		protected ButterflyController _activeInstance;
	}
}
