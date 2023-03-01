using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x020008EA RID: 2282
	[Token(Token = "0x20008EA")]
	public class ButterflySpawner : MonoBehaviour
	{
		// Token: 0x06003E03 RID: 15875 RVA: 0x000123A8 File Offset: 0x000105A8
		[Token(Token = "0x6003E03")]
		[Address(RVA = "0x2F11040", Offset = "0x2F10040", VA = "0x182F11040", Slot = "4")]
		public virtual bool CanSpawn()
		{
			return default(bool);
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06003E04 RID: 15876 RVA: 0x000123C0 File Offset: 0x000105C0
		[Token(Token = "0x170007D5")]
		public bool HasActiveInstance
		{
			[Token(Token = "0x6003E04")]
			[Address(RVA = "0x2F11780", Offset = "0x2F10780", VA = "0x182F11780")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003E05 RID: 15877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E05")]
		[Address(RVA = "0x2F110C0", Offset = "0x2F100C0", VA = "0x182F110C0")]
		public ButterflyController CreateInstance(Transform parent, Vector3 targetPositionOffset, Quaternion targetRotationOffset)
		{
			return null;
		}

		// Token: 0x06003E06 RID: 15878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E06")]
		[Address(RVA = "0x2F11700", Offset = "0x2F10700", VA = "0x182F11700")]
		internal void RemoveActiveInstance()
		{
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E07")]
		[Address(RVA = "0x2F11630", Offset = "0x2F10630", VA = "0x182F11630")]
		private void OnDisable()
		{
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E08")]
		[Address(RVA = "0x924B30", Offset = "0x923B30", VA = "0x180924B30")]
		private void ButterflyFinished(ButterflyController controller, Transform target)
		{
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E09")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ButterflySpawner()
		{
		}

		// Token: 0x040041E4 RID: 16868
		[Token(Token = "0x40041E4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ButterflyController _prefabSource;

		// Token: 0x040041E5 RID: 16869
		[Token(Token = "0x40041E5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 _instanceStartMin;

		// Token: 0x040041E6 RID: 16870
		[Token(Token = "0x40041E6")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector3 _instanceStartMax;

		// Token: 0x040041E7 RID: 16871
		[Token(Token = "0x40041E7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _velocityRoot;

		// Token: 0x040041E8 RID: 16872
		[Token(Token = "0x40041E8")]
		[FieldOffset(Offset = "0x48")]
		protected ButterflyController _activeInstance;
	}
}
