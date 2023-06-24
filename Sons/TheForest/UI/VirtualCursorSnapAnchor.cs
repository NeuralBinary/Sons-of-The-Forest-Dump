using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x02000406 RID: 1030
	[Token(Token = "0x2000406")]
	[AddComponentMenu("TheForest/UI/VirtualCursorSnapAnchor")]
	public class VirtualCursorSnapAnchor : MonoBehaviour
	{
		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CA")]
		public UnityEngine.Object TrackedObject
		{
			[Token(Token = "0x6001B7C")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x000082C8 File Offset: 0x000064C8
		[Token(Token = "0x170003CB")]
		public float GizmoRadius
		{
			[Token(Token = "0x6001B7D")]
			[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B7E")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		public void SetTrackedObject(UnityEngine.Object trackedObject)
		{
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B7F")]
		[Address(RVA = "0x32B8E30", Offset = "0x32B7430", VA = "0x1832B8E30")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B80")]
		[Address(RVA = "0x32B8F60", Offset = "0x32B7560", VA = "0x1832B8F60")]
		public VirtualCursorSnapAnchor()
		{
		}

		// Token: 0x04001AAA RID: 6826
		[Token(Token = "0x4001AAA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _gizmoRadius;

		// Token: 0x04001AAB RID: 6827
		[Token(Token = "0x4001AAB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEngine.Object _trackedObject;
	}
}
