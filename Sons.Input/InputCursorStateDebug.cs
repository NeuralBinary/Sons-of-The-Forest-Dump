using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Sons.Input
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[AddComponentMenu("Sons/Input/InputCursorStateDebug")]
	public class InputCursorStateDebug : MonoBehaviour
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x3064270", Offset = "0x3062870", VA = "0x183064270")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x3064290", Offset = "0x3062890", VA = "0x183064290")]
		private void UpdateStateReadout()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x30645F0", Offset = "0x3062BF0", VA = "0x1830645F0")]
		private void UpdateInstanceReadout()
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public InputCursorStateDebug()
		{
		}

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TMP_Text _instanceReadout;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TMP_Text _stateReadout;
	}
}
