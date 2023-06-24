using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000BB RID: 187
	[Token(Token = "0x20000BB")]
	[AddComponentMenu("Sons/Ai/PushCollision")]
	public class PushCollision : MonoBehaviour
	{
		// Token: 0x06000745 RID: 1861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x2B4E220", Offset = "0x2B4C820", VA = "0x182B4E220")]
		public void SetEnabled(bool value)
		{
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x2B4E410", Offset = "0x2B4CA10", VA = "0x182B4E410")]
		public void IgnoreCollider(Collider ignoreCollider)
		{
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PushCollision()
		{
		}

		// Token: 0x040005CB RID: 1483
		[Token(Token = "0x40005CB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> _colliders;

		// Token: 0x040005CC RID: 1484
		[Token(Token = "0x40005CC")]
		[FieldOffset(Offset = "0x28")]
		private bool _active;
	}
}
