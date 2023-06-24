using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Areas
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public class DeepCaveActivator : MonoBehaviour
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2D2CF80", Offset = "0x2D2B580", VA = "0x182D2CF80")]
		private void OnEnable()
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2D2D030", Offset = "0x2D2B630", VA = "0x182D2D030")]
		private void OnDisable()
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2D2D0A0", Offset = "0x2D2B6A0", VA = "0x182D2D0A0")]
		private void OnDeepCavesChanged(bool value)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2D2D110", Offset = "0x2D2B710", VA = "0x182D2D110")]
		private void OnDeepCavesEntered()
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2D2D160", Offset = "0x2D2B760", VA = "0x182D2D160")]
		private void OnDeepCavesExited()
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2D2D1B0", Offset = "0x2D2B7B0", VA = "0x182D2D1B0")]
		private void ActivateList(bool value, List<GameObject> targets)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DeepCaveActivator()
		{
		}

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> _objectsToActivateEnterDeepCaves;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> _objectsToDeactivateEnterDeepCaves;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent _onEnterDeepCaves;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _objectsToActivateExitDeepCaves;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<GameObject> _objectsToDeactivateExitDeepCaves;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UnityEvent _onExitDeepCaves;
	}
}
