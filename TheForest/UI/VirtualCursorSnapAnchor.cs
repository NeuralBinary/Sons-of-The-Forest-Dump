using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x02000414 RID: 1044
	[Token(Token = "0x2000414")]
	[AddComponentMenu("TheForest/UI/VirtualCursorSnapAnchor")]
	public class VirtualCursorSnapAnchor : MonoBehaviour
	{
		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C0")]
		public Object TrackedObject
		{
			[Token(Token = "0x6001B3E")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001B3F RID: 6975 RVA: 0x00008040 File Offset: 0x00006240
		[Token(Token = "0x170003C1")]
		public float GizmoRadius
		{
			[Token(Token = "0x6001B3F")]
			[Address(RVA = "0x567960", Offset = "0x566960", VA = "0x180567960")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B40")]
		[Address(RVA = "0x541270", Offset = "0x540270", VA = "0x180541270")]
		public void SetTrackedObject(Object trackedObject)
		{
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B41")]
		[Address(RVA = "0x2CF3D70", Offset = "0x2CF2D70", VA = "0x182CF3D70")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B42")]
		[Address(RVA = "0x2CF3DE0", Offset = "0x2CF2DE0", VA = "0x182CF3DE0")]
		public VirtualCursorSnapAnchor()
		{
		}

		// Token: 0x04001A86 RID: 6790
		[Token(Token = "0x4001A86")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _gizmoRadius;

		// Token: 0x04001A87 RID: 6791
		[Token(Token = "0x4001A87")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Object _trackedObject;
	}
}
