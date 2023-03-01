using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000688 RID: 1672
	[Token(Token = "0x2000688")]
	public class ToggleOnLayerTriggerCheck : MonoBehaviour
	{
		// Token: 0x06002ACD RID: 10957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ACD")]
		[Address(RVA = "0x2DE0000", Offset = "0x2DDF000", VA = "0x182DE0000")]
		public void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ACE")]
		[Address(RVA = "0x2DE0010", Offset = "0x2DDF010", VA = "0x182DE0010")]
		private void ToggleObjects(Collider other)
		{
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ACF")]
		[Address(RVA = "0x2DE0180", Offset = "0x2DDF180", VA = "0x182DE0180")]
		public ToggleOnLayerTriggerCheck()
		{
		}

		// Token: 0x04002643 RID: 9795
		[Token(Token = "0x4002643")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayerMask _layerMask;

		// Token: 0x04002644 RID: 9796
		[Token(Token = "0x4002644")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> _gameObjectsToToggle;
	}
}
