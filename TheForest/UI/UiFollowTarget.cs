using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x0200040F RID: 1039
	[Token(Token = "0x200040F")]
	public class UiFollowTarget : MonoBehaviour
	{
		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BF")]
		public Transform Target
		{
			[Token(Token = "0x6001B2F")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B30")]
		[Address(RVA = "0x2CF36B0", Offset = "0x2CF26B0", VA = "0x182CF36B0")]
		public void SetTarget(Transform target)
		{
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B31")]
		[Address(RVA = "0x2CF3300", Offset = "0x2CF2300", VA = "0x182CF3300")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B32")]
		[Address(RVA = "0x553EB0", Offset = "0x552EB0", VA = "0x180553EB0")]
		public UiFollowTarget()
		{
		}

		// Token: 0x04001A7C RID: 6780
		[Token(Token = "0x4001A7C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _target;

		// Token: 0x04001A7D RID: 6781
		[Token(Token = "0x4001A7D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _offset;

		// Token: 0x04001A7E RID: 6782
		[Token(Token = "0x4001A7E")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 _worldOffset;
	}
}
