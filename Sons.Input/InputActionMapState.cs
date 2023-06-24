using System;
using Il2CppDummyDll;
using TheForest.Utils;
using UnityEngine;

namespace Sons.Input
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[AddComponentMenu("Sons/Input/InputActionMapState")]
	public class InputActionMapState : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x3062860", Offset = "0x3060E60", VA = "0x183062860")]
		private void OnEnable()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x30628B0", Offset = "0x3060EB0", VA = "0x1830628B0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public InputActionMapState()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InputState _applyState;
	}
}
