using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007AA RID: 1962
	[Token(Token = "0x20007AA")]
	public class ToggleOnLayerTriggerCheck : MonoBehaviour
	{
		// Token: 0x060034E3 RID: 13539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E3")]
		[Address(RVA = "0x34D4650", Offset = "0x34D2C50", VA = "0x1834D4650")]
		public void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E4")]
		[Address(RVA = "0x34D4660", Offset = "0x34D2C60", VA = "0x1834D4660")]
		private void ToggleObjects(Collider other)
		{
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E5")]
		[Address(RVA = "0x34D4900", Offset = "0x34D2F00", VA = "0x1834D4900")]
		public ToggleOnLayerTriggerCheck()
		{
		}

		// Token: 0x04002DAA RID: 11690
		[Token(Token = "0x4002DAA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayerMask _layerMask;

		// Token: 0x04002DAB RID: 11691
		[Token(Token = "0x4002DAB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> _gameObjectsToToggle;
	}
}
