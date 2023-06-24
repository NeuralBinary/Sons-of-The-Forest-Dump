using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x02000401 RID: 1025
	[Token(Token = "0x2000401")]
	public class UiFollowTarget : MonoBehaviour
	{
		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C9")]
		public Transform Target
		{
			[Token(Token = "0x6001B6D")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6E")]
		[Address(RVA = "0x32B7A40", Offset = "0x32B6040", VA = "0x1832B7A40")]
		public void SetTarget(Transform target)
		{
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6F")]
		[Address(RVA = "0x32B7AA0", Offset = "0x32B60A0", VA = "0x1832B7AA0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B70")]
		[Address(RVA = "0x5C7240", Offset = "0x5C5840", VA = "0x1805C7240")]
		public UiFollowTarget()
		{
		}

		// Token: 0x04001AA0 RID: 6816
		[Token(Token = "0x4001AA0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _target;

		// Token: 0x04001AA1 RID: 6817
		[Token(Token = "0x4001AA1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _offset;

		// Token: 0x04001AA2 RID: 6818
		[Token(Token = "0x4001AA2")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 _worldOffset;
	}
}
